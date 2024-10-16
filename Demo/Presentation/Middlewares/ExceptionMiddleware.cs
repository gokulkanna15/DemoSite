namespace Demo.Presentation.Middlewares
{
    public class ExceptionMiddleware
    {
        private readonly RequestDelegate _next;

        public ExceptionMiddleware(RequestDelegate next)
        {
            _next = next;
        }
        public async Task InvokeAsync(HttpContext httpcontent)
        {
            try
            {
                await _next(httpcontent);

            }
            catch (Exception e)
            {

            }

        }
    }
}
