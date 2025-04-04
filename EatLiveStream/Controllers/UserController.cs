using Microsoft.AspNetCore.Mvc;

namespace EatLiveStream.Controllers;

[ApiController]
[Route("[controller]")]
public class UserController : ControllerBase
{
    [HttpGet("{device}/{playerId}")]
    public User Get([FromRoute] int device, float playerId)
    {
        User user = new User()
        {
            device = device,
            playerId = playerId,
        };
        
        return user;
    }

    [HttpPost]
    public User Post(User user)
    {
        Console.WriteLine("Player has been added to the DB");
        
        return user;
    }
} 