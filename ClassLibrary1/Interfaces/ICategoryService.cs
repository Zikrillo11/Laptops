using Laptops.Shared.DTOs.Categories;

namespace Laptops.BLL.Interfaces;

public interface ICategoryService
{
    Task<CategoryForResultDto> CreateAsync(CategoryForCreateDto dto);

    Task<CategoryForResultDto> UpdateAsync(long id, CategoryForUpdateDto dto);

    Task<bool> DeleteAsync(long id);

    Task<CategoryForResultDto> GetByIdAsync(long id);

    Task<IEnumerable<CategoryForResultDto>> GetAllAsync();
}