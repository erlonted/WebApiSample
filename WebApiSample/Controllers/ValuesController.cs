using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace WebApiSample.Controllers
{
  /// <summary>
  ///  Api para teste inicial
  /// </summary>
  [Route("api/v1/[controller]")]
  [ApiController]
  public class ValuesController : ControllerBase
  {

    [HttpPost]
    public IActionResult Post([FromBody] PostModel model)
    { 
    
      return Ok("1"); 
    
    }


  }
}
