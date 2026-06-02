using Laptops.Shared.DTOs.Laptops;
namespace Laptops.BLL.Interfaces;  

public interface ILaptopService
{
    Task<IEnumerable<LaptopForResultDto>> GetAllAsync();

    Task<LaptopForResultDto> GetByIdAsync(long id);

    Task<LaptopForResultDto> CreateAsync(LaptopForCreateDto dto);

    Task<LaptopForResultDto> UpdateAsync(long id, LaptopForUpdateDto dto);

    Task<bool> DeleteAsync(long id);
}