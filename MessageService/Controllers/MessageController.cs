using Microsoft.AspNetCore.Mvc;

namespace MessageService.Controllers;

[ApiController]
[Route("[controller]")]
public class MessageController : ControllerBase
{
    private const string Message = "Welcome to Tattoo Nation!";

    private readonly ILogger<MessageController> _logger;

    public MessageController(ILogger<MessageController> logger)
    {
        _logger = logger;
    }

    [HttpGet(Name = "GetIntroMessage")]
    public string Get()
    {
        _logger.LogInformation("GetIntroMessage called.");
        return Message;
    }
}