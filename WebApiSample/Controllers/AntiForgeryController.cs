using Microsoft.AspNetCore.Antiforgery;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace WebApiSample.Controllers
{
  [Route("api/v1/[controller]")]
  [ApiController]
  public class AntiForgeryController : ControllerBase
  {
    private IAntiforgery _antiforgery;

    public AntiForgeryController(IAntiforgery antiforgery)
    {
      _antiforgery = antiforgery;
    }

    [IgnoreAntiforgeryToken]
    [HttpGet]
    public IActionResult Get()
    {
      // Creates and sets the cookie token in a cookie
      // Cookie name will be like ".AspNetCore.Antiforgery.pG4SaGh5yDI"
      var tokens = _antiforgery.GetAndStoreTokens(HttpContext);

      // Take request token (which is different from a cookie token)
      var headerToken = tokens.RequestToken;
      // Set another cookie for a request token
      Response.Cookies.Append("XSRF-TOKEN", headerToken, new CookieOptions
      {
        HttpOnly = false
      });
      return NoContent();
    }
  }

}
