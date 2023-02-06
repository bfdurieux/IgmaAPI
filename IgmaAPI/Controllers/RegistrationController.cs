using IgmaAPI.Models;
using Microsoft.AspNetCore.Mvc;

namespace IgmaAPI.Controllers;

[ApiController]
[Route("[controller]")]
public class RegistrationController : ControllerBase
{

    [HttpPost(Name = "PostRegistration")]
    public ActionResult<string> Post(Registration registration)
    {
        
        return StatusCode(100);
    }
}
