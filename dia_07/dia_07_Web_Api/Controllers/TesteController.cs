using Microsoft.AspNetCore.Mvc;

namespace dia_07_Web_Api.Controllers;

[ApiController]
[Route("[controller]")]
public class HelloWorldController : Controller
{
    [HttpGet]
    public string Get() => "Hello world!";
}