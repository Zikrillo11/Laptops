using Laptops.Shared.DTOs.LaptopImage;

namespace Laptops.BLL.Interfaces;

public interface ILaptopImageService
{
    Task<LaptopImageForResultDto> CreateAsync(
        LaptopImageForCreateDto dto);

    Task<LaptopImageForResultDto> UpdateAsync(
        long id,
        LaptopImageForUpdateDto dto);

    Task<bool> DeleteAsync(long id);

    Task<LaptopImageForResultDto> GetByIdAsync(long id);

    Task<IEnumerable<LaptopImageForResultDto>> GetAllAsync();
}