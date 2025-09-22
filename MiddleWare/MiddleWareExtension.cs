namespace APIEmployee3.MiddleWare
{
    public static class MiddleWareExtension
    {
        public static IApplicationBuilder UseLogging(this IApplicationBuilder app)
        {
            return app.UseMiddleware<LoggingMiddleWare>();
        }
        public static IApplicationBuilder UseAfterLogging(this IApplicationBuilder app)
        {
            return app.UseMiddleware<AfterLoggingMiddleWare>();
        }
    }
}
