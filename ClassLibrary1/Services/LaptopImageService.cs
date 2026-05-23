using AutoMapper;
using Laptops.BLL.Interfaces;
using Laptops.DAL.Interfaces;
using Laptops.Domain.Entites;
using Laptops.Shared.DTOs.LaptopImage;

namespace Laptops.BLL.Services;

public class LaptopImageService : ILaptopImageService
{
    private readonly IGenericRepository<LaptopImage> _repository;
    private readonly IMapper _mapper;

    public LaptopImageService(
        IGenericRepository<LaptopImage> repository,
        IMapper mapper)
    {
        _repository = repository;
        _mapper = mapper;
    }

    public async Task<LaptopImageForResultDto> CreateAsync(
        LaptopImageForCreateDto dto)
    {
        var image = _mapper.Map<LaptopImage>(dto);

        await _repository.CreateAsync(image);

        await _repository.SaveAsync();

        return _mapper.Map<LaptopImageForResultDto>(image);
    }

    public async Task<bool> DeleteAsync(long id)
    {
        var image = await _repository.SelectByIdAsync(id);

        if (image is null)
            return false;

        image.IsDeleted = true;

        _repository.Update(image);

        return await _repository.SaveAsync();
    }

    public async Task<IEnumerable<LaptopImageForResultDto>> GetAllAsync()
    {
        var images = _repository
            .SelectAll(x => !x.IsDeleted);

        return _mapper.Map<IEnumerable<LaptopImageForResultDto>>(images);
    }

    public async Task<LaptopImageForResultDto> GetByIdAsync(long id)
    {
        var image = await _repository.SelectByIdAsync(id);

        if (image is null || image.IsDeleted)
            return null!;

        return _mapper.Map<LaptopImageForResultDto>(image);
    }

    public async Task<LaptopImageForResultDto> UpdateAsync(
        long id,
        LaptopImageForUpdateDto dto)
    {
        var image = await _repository.SelectByIdAsync(id);

        if (image is null || image.IsDeleted)
            return null!;

        _mapper.Map(dto, image);

        image.UpdatedAt = DateTime.UtcNow;

        _repository.Update(image);

        await _repository.SaveAsync();

        return _mapper.Map<LaptopImageForResultDto>(image);
    }
}