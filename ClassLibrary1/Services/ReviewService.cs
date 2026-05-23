using AutoMapper;
using Laptops.BLL.Interfaces;
using Laptops.DAL.Interfaces;
using Laptops.Domain.Entites;
using Laptops.Shared.DTOs.Reviews;

namespace Laptops.BLL.Services;

public class ReviewService : IReviewService
{
    private readonly IGenericRepository<Review> _repository;
    private readonly IMapper _mapper;

    public ReviewService(
        IGenericRepository<Review> repository,
        IMapper mapper)
    {
        _repository = repository;
        _mapper = mapper;
    }

    public async Task<ReviewForResultDto> CreateAsync(
        ReviewForCreateDto dto)
    {
        var review = _mapper.Map<Review>(dto);

        await _repository.CreateAsync(review);

        await _repository.SaveAsync();

        return _mapper.Map<ReviewForResultDto>(review);
    }

    public async Task<bool> DeleteAsync(long id)
    {
        var review = await _repository.SelectByIdAsync(id);

        if (review is null)
            return false;

        review.IsDeleted = true;

        _repository.Update(review);

        return await _repository.SaveAsync();
    }

    public async Task<IEnumerable<ReviewForResultDto>> GetAllAsync()
    {
        var reviews = _repository
            .SelectAll(x => !x.IsDeleted);

        return _mapper.Map<IEnumerable<ReviewForResultDto>>(reviews);
    }

    public async Task<ReviewForResultDto> GetByIdAsync(long id)
    {
        var review = await _repository.SelectByIdAsync(id);

        if (review is null || review.IsDeleted)
            return null!;

        return _mapper.Map<ReviewForResultDto>(review);
    }

    public async Task<ReviewForResultDto> UpdateAsync(
        long id,
        ReviewForUpdateDto dto)
    {
        var review = await _repository.SelectByIdAsync(id);

        if (review is null || review.IsDeleted)
            return null!;

        _mapper.Map(dto, review);

        review.UpdatedAt = DateTime.UtcNow;

        _repository.Update(review);

        await _repository.SaveAsync();

        return _mapper.Map<ReviewForResultDto>(review);
    }
}