using Microsoft.AspNetCore.Antiforgery;

namespace WebApiSample.Middleware
{
  public class AntiforgeryMiddleware : IMiddleware
  {
    private readonly IAntiforgery _antiforgery;

    public AntiforgeryMiddleware(IAntiforgery antiforgery)
    {
      _antiforgery = antiforgery;
    }

    public async Task InvokeAsync(HttpContext context, RequestDelegate next)
    {
      var isGetRequest = string.Equals("GET", context.Request.Method, StringComparison.OrdinalIgnoreCase);
      if (!isGetRequest)
      {
        await _antiforgery.ValidateRequestAsync(context);
      }

      await next(context);
    }
  }
}
