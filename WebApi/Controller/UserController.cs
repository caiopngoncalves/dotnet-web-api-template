using Application.InputModels;
using Application.Interfaces;
using Microsoft.AspNetCore.Mvc;

[ApiController]
[Route("/user")]
public class UserController : ControllerBase
{
    private readonly IUserService _userService;

    public UserController(IUserService userService)
    {
        _userService = userService;
    }

    [HttpPost("/")]
    public async Task<IActionResult> Create(UserInputModel inputModel)
    {
        var viewModel = await _userService.Create(inputModel);
        return CreatedAtAction(nameof(Get), new { id = viewModel.Id }, viewModel);
    }

    [HttpGet("/{id}")]
    public async Task<IActionResult> Get(Guid id)
    {
        var viewModel = await _userService.Get(id);
        return Ok(viewModel);
    }

    [HttpPut("/{id}")]
    public async Task<IActionResult> Update(Guid id, UserInputModel inputModel)
    {
        var viewModel = await _userService.Update(inputModel);
        return Ok(viewModel);
    }

    [HttpDelete("/{id}")]
    public async Task<IActionResult> Delete(Guid id)
    {
        await _userService.Delete(id);
        return NoContent();
    }

    [HttpGet("/")]
    public async Task<IActionResult> GetAll()
    {
        var viewModels = await _userService.GetAll();
        return Ok(viewModels);
    }
}