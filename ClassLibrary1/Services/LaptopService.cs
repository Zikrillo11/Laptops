using AutoMapper;
using Laptops.BLL.Interfaces;
using Laptops.DAL.Interfaces;
using Laptops.Domain.Entites;
using Laptops.Shared.DTOs.Laptops;

namespace Laptops.BLL.Services;

public class LaptopService : ILaptopService
{
    private readonly IGenericRepository<Laptop> _repository;
    private readonly IMapper _mapper;

    public LaptopService(
        IGenericRepository<Laptop> repository,
        IMapper mapper)
    {
        _repository = repository;
        _mapper = mapper;
    }

    public async Task<LaptopForResultDto> CreateAsync(
        LaptopForCreateDto dto)
    {
        var laptop = _mapper.Map<Laptop>(dto);

        await _repository.CreateAsync(laptop);

        await _repository.SaveAsync();

        return _mapper.Map<LaptopForResultDto>(laptop);
    }

    public async Task<bool> DeleteAsync(long id)
    {
        var laptop = await _repository.SelectByIdAsync(id);

        if (laptop is null)
            return false;

        laptop.IsDeleted = true;

        _repository.Update(laptop);

        return await _repository.SaveAsync();
    }

    public async Task<IEnumerable<LaptopForResultDto>> GetAllAsync()
    {
        var laptops = _repository
            .SelectAll(x => !x.IsDeleted);

        return _mapper.Map<IEnumerable<LaptopForResultDto>>(laptops);
    }

    public async Task<LaptopForResultDto> GetByIdAsync(long id)
    {
        var laptop = await _repository.SelectByIdAsync(id);

        if (laptop is null || laptop.IsDeleted)
            return null!;

        return _mapper.Map<LaptopForResultDto>(laptop);
    }

    public async Task<LaptopForResultDto> UpdateAsync(
        long id,
        LaptopForUpdateDto dto)
    {
        var laptop = await _repository.SelectByIdAsync(id);

        if (laptop is null || laptop.IsDeleted)
            return null!;

        _mapper.Map(dto, laptop);

        laptop.UpdatedAt = DateTime.UtcNow;

        _repository.Update(laptop);

        await _repository.SaveAsync();

        return _mapper.Map<LaptopForResultDto>(laptop);
    }
}