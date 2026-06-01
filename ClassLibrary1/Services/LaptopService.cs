using Laptops.BLL.Interfaces;
using Laptops.DAL.Interfaces;
using Laptops.Domain.Entites;
using Laptops.Shared.DTOs.Laptops;

namespace Laptops.BLL.Services;

public class LaptopService : ILaptopService
{
    private readonly IGenericRepository<Laptop> _repository;

    public LaptopService(
        IGenericRepository<Laptop> repository)
    {
        _repository = repository;
    }

    public async Task<LaptopForResultDto> CreateAsync(
        LaptopForCreateDto dto)
    {
        var laptop = new Laptop
        {
            Name = dto.Name,
            Brand = dto.Brand,
            Price = dto.Price,
            CreatedAt = DateTime.UtcNow
        };

        await _repository.CreateAsync(laptop);

        await _repository.SaveAsync();

        return new LaptopForResultDto
        {
            Id = laptop.Id,
            Name = laptop.Name,
            Brand = laptop.Brand,
            Price = laptop.Price
        };
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
            .SelectAll(x => !x.IsDeleted)
            .ToList();

        return laptops.Select(x => new LaptopForResultDto
        {
            Id = x.Id,
            Name = x.Name,
            Brand = x.Brand,
            Price = x.Price
        });
    }

    public async Task<LaptopForResultDto> GetByIdAsync(long id)
    {
        var laptop = await _repository.SelectByIdAsync(id);

        if (laptop is null)
            return null!;

        return new LaptopForResultDto
        {
            Id = laptop.Id,
            Name = laptop.Name,
            Brand = laptop.Brand,
            Price = laptop.Price
        };
    }

    public async Task<LaptopForResultDto> UpdateAsync(
        long id,
        LaptopForUpdateDto dto)
    {
        var laptop = await _repository.SelectByIdAsync(id);

        if (laptop is null)
            return null!;

        laptop.Name = dto.Name;
        laptop.Brand = dto.Brand;
        laptop.Price = dto.Price;
        laptop.UpdatedAt = DateTime.UtcNow;

        _repository.Update(laptop);

        await _repository.SaveAsync();

        return new LaptopForResultDto
        {
            Id = laptop.Id,
            Name = laptop.Name,
            Brand = laptop.Brand,
            Price = laptop.Price
        };
    }
}