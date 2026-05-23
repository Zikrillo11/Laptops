using Laptops.BLL.Interfaces;
using Laptops.Shared.DTOs.Laptops;
using Microsoft.AspNetCore.Mvc;

namespace Laptops.Controllers;

[ApiController]
[Route("api/[controller]")]
public class LaptopsController : ControllerBase
{
    private readonly ILaptopService _service;

    public LaptopsController(ILaptopService service)
    {
        _service = service;
    }

    [HttpGet]
    public async Task<IActionResult> GetAllAsync()
    {
        var result = await _service.GetAllAsync();

        return Ok(result);
    }

    [HttpGet("{id}")]
    public async Task<IActionResult> GetByIdAsync(long id)
    {
        var result = await _service.GetByIdAsync(id);

        return Ok(result);
    }

    [HttpPost]
    public async Task<IActionResult> CreateAsync(
        LaptopForCreateDto dto)
    {
        var result = await _service.CreateAsync(dto);

        return Ok(result);
    }

    [HttpPut("{id}")]
    public async Task<IActionResult> UpdateAsync(
        long id,
        LaptopForUpdateDto dto)
    {
        var result = await _service.UpdateAsync(id, dto);

        return Ok(result);
    }

    [HttpDelete("{id}")]
    public async Task<IActionResult> DeleteAsync(long id)
    {
        var result = await _service.DeleteAsync(id);

        return Ok(result);
    }
}