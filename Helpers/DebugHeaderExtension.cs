namespace RequestlyWebApi.Helpers
{
    public static class DebugHeaderExtension
    {
        public static IApplicationBuilder UseDebugHeader(this IApplicationBuilder app)
        {
            return app.UseMiddleware<DebugHeaderMiddleware>();
        }
    }
}
