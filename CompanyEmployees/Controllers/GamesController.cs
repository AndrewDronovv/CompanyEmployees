using CompanyEmployees.Models;
using CompanyEmployees.Services;
using Microsoft.AspNetCore.Mvc;

namespace CompanyEmployees.Controllers;

[Route("api/[controller]")]
[ApiController]
public class GamesController : ControllerBase
{
    private readonly IPlayerGenerator _playerGenerator;

    public GamesController([FromKeyedServices("betterPlayer")] IPlayerGenerator playerGenerator)
    {
        _playerGenerator = playerGenerator;
    }

    [HttpGet]
    public Player Get()
    {
        var newPlayer = _playerGenerator.CreateNewPlayer();

        return newPlayer;
    }
}
