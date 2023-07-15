using Microsoft.AspNetCore.Mvc;

namespace TodoApi.Controllers;

[ApiController]
[Route("[controller]")]
public class TodoController : ControllerBase
{
    [HttpGet]
    public string getTodo() {
        return "olá";
    }
}
