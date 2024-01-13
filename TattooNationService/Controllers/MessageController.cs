using Microsoft.AspNetCore.Mvc;

namespace TattooNationService.Controllers;

[ApiController]
[Route("[controller]")]
public class MessageController : ControllerBase
{
    private readonly ILogger<MessageController> _logger;

    public MessageController(ILogger<MessageController> logger)
    {
        _logger = logger;
    }

    [HttpGet(Name = "GetWelcomeMessage")]
    public string Get()
    {
        return "Welcome to Tattoo Nation";
    }
}