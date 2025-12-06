using Microsoft.AspNetCore.Mvc;

namespace RequestlyWebApi.Helpers
{
    public class DebugHeaderMiddleware
    {
        private readonly RequestDelegate _next;

        public DebugHeaderMiddleware(RequestDelegate next)
        {
            _next = next;
        }

        public async Task InvokeAsync(HttpContext context)
        {
            if (context.Request.Headers.TryGetValue("X-Debug-Mode", out var value))
            {
                Console.WriteLine("Debug Mode Enabled from Requestly!");
            }

            await _next(context);
        }

        
    }
}
