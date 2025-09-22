
namespace APIEmployee3.MiddleWare
{
    public class LoggingMiddleWare : IMiddleware
    {
        public async Task InvokeAsync(HttpContext context, RequestDelegate next)
        {
            Console.WriteLine($"[LoggingMiddleware] Request Method: {context.Request.Method}");
            await next(context);
            Console.WriteLine($"[LoggingMiddleware] Response Code: {context.Response.StatusCode}");
        }
    }
}
