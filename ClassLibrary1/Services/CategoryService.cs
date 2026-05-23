using AutoMapper;
using Laptops.BLL.Interfaces;
using Laptops.DAL.Interfaces;
using Laptops.Domain.Entites;
using Laptops.Shared.DTOs.Categories;

namespace Laptops.BLL.Services;

public class CategoryService : ICategoryService
{
    private readonly IGenericRepository<Category> _repository;
    private readonly IMapper _mapper;

    public CategoryService(
        IGenericRepository<Category> repository,
        IMapper mapper)
    {
        _repository = repository;
        _mapper = mapper;
    }

    public async Task<CategoryForResultDto> CreateAsync(
        CategoryForCreateDto dto)
    {
        var mappedCategory = _mapper.Map<Category>(dto);

        await _repository.CreateAsync(mappedCategory);

        await _repository.SaveAsync();

        return _mapper.Map<CategoryForResultDto>(mappedCategory);
    }

    public async Task<bool> DeleteAsync(long id)
    {
        var category = await _repository.SelectByIdAsync(id);

        if (category is null)
            return false;

        category.IsDeleted = true;
        category.DeletedBy = 1;

        _repository.Update(category);

        return await _repository.SaveAsync();
    }

    public async Task<IEnumerable<CategoryForResultDto>> GetAllAsync()
    {
        var categories = _repository
            .SelectAll(x => !x.IsDeleted);

        return _mapper.Map<IEnumerable<CategoryForResultDto>>(categories);
    }

    public async Task<CategoryForResultDto> GetByIdAsync(long id)
    {
        var category = await _repository.SelectByIdAsync(id);

        if (category is null || category.IsDeleted)
            return null!;

        return _mapper.Map<CategoryForResultDto>(category);
    }

    public async Task<CategoryForResultDto> UpdateAsync(
        long id,
        CategoryForUpdateDto dto)
    {
        var category = await _repository.SelectByIdAsync(id);

        if (category is null || category.IsDeleted)
            return null!;

        _mapper.Map(dto, category);

        category.UpdatedAt = DateTime.UtcNow;
        category.UpdatedBy = 1;

        _repository.Update(category);

        await _repository.SaveAsync();

        return _mapper.Map<CategoryForResultDto>(category);
    }
}