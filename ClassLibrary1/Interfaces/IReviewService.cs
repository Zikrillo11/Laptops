using Laptops.Shared.DTOs.Reviews;

namespace Laptops.BLL.Interfaces;

public interface IReviewService
{
    Task<ReviewForResultDto> CreateAsync(ReviewForCreateDto dto);

    Task<ReviewForResultDto> UpdateAsync(long id, ReviewForUpdateDto dto);

    Task<bool> DeleteAsync(long id);

    Task<ReviewForResultDto> GetByIdAsync(long id);

    Task<IEnumerable<ReviewForResultDto>> GetAllAsync();
}