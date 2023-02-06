using IgmaAPI.Models;
using Microsoft.AspNetCore.Mvc;

namespace IgmaAPI.Controllers;

[ApiController]
[Route("[controller]")]
public class ClientsController : ControllerBase
{
    [HttpPost(Name = "PostClient")]
    public ActionResult<string> Post(Client client)
    {
        
        return StatusCode(100);
    }
}