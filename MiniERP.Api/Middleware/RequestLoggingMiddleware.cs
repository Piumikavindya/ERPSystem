namespace MiniERP.Api.Middleware
{
    public class RequestLoggingMiddleware
    {
        private readonly RequestDelegate _next;

        public RequestLoggingMiddleware(RequestDelegate next)
        {
            _next = next;
        }

        public async Task InvokeAsync(HttpContext context)
        {
            Console.WriteLine(
            $"Request started: {context.Request.Method} {context.Request.Path}");

            await _next(context);

            Console.WriteLine(
                $"Request completed: {context.Response.StatusCode}");
        }
    }
}
