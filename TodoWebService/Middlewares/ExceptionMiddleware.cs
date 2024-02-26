namespace TodoWebService.Middlewares
{
    public class ExceptionMiddleware
    {
        private readonly RequestDelegate _next;

        public ExceptionMiddleware(RequestDelegate next)
        {
            _next = next;
        }

        public async Task Invoke(HttpContext context)
        {
            try
            {
                await _next(context);
            }
            catch (Exception ex)
            {
                // Handle the exception
                await HandleExceptionAsync(context, ex);
            }
        }

        private Task HandleExceptionAsync(HttpContext context, Exception ex)
        {
            // Log the exception or perform any other necessary action
            // For example:
            // logger.LogError(ex, "An unexpected error occurred.");

            // Set response status code
            context.Response.StatusCode = StatusCodes.Status500InternalServerError;

            // Write the error message to the response
            return context.Response.WriteAsync("An unexpected error occurred. Please try again later.");
        }
    }

}
