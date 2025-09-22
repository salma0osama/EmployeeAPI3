
namespace APIEmployee3.MiddleWare
{
    public class AfterLoggingMiddleWare
    {
        private readonly RequestDelegate _next;
        public AfterLoggingMiddleWare(RequestDelegate next)
        {
            _next = next;
        }
        public async Task InvokeAsync(HttpContext context)
        {
            await _next(context);
            Console.WriteLine($"[AfterLoggingMiddleware] Done! ");
        }
    }
}
