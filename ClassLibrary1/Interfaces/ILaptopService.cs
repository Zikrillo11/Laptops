using Laptops.Shared.DTOs.Laptops;


namespace Laptops.BLL.Interfaces;

public interface ILaptopService
{
    Task<LaptopForResultDto> CreateAsync(LaptopForCreateDto dto);

    Task<LaptopForResultDto> UpdateAsync(long id, LaptopForUpdateDto dto);

    Task<bool> DeleteAsync(long id);

    Task<LaptopForResultDto> GetByIdAsync(long id);

    Task<IEnumerable<LaptopForResultDto>> GetAllAsync();
}