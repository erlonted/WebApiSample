using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using WebApiSample.Models;

namespace WebApiSample.Controllers
{
  [Route("api/v1/[controller]")]
  [ApiController]
  public class LoginController : ControllerBase
  {
    [HttpPost]
    public IActionResult Post([FromBody] Usuario usuario)
    {

      return Ok("1");

    }

  }
}
