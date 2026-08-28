namespace MiniERP.Api.Middleware
{
    public class RequestLoggingMiddleware
    {
        private readonly RequestDelegate _next;
        private readonly ILogger<RequestLoggingMiddleware> _logger;

        public RequestLoggingMiddleware(RequestDelegate next, ILogger<RequestLoggingMiddleware> logger)
        {
            _next = next;
            _logger = logger;
        }

        public async Task InvokeAsync(HttpContext context)
        {
            /*Console.WriteLine(
            $"Request started: {context.Request.Method} {context.Request.Path}");

            await _next(context);

            Console.WriteLine(
                $"Request completed: {context.Response.StatusCode}");*/

            _logger.LogInformation(
          "Request started: {Method} {Path}",
          context.Request.Method,
          context.Request.Path);

            await _next(context);

            _logger.LogInformation(
                "Request completed with status code: {StatusCode}",
                context.Response.StatusCode);
        }
    }
}
