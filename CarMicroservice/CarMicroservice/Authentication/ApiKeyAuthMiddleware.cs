using CarMicroservice.Utils;

namespace CarMicroservice.Authentication
{
    public class ApiKeyAuthMiddleware
    {
        private readonly RequestDelegate _next;
        private readonly IConfiguration _configuration;

        public ApiKeyAuthMiddleware(RequestDelegate next, IConfiguration configuration)
        {
            _next = next;
            _configuration = configuration;
        }

        public async Task Invoke(HttpContext context)
        {
            if (!context.Request.Headers.TryGetValue(Utils.Constants.ApiKeyHeaderName, out var extractedApiKey)) {
                context.Response.StatusCode = 401;
                await context.Response.WriteAsync(Utils.Constants.ApiKeyMissing);
                return;
            }

            var apiKey = _configuration.GetValue<string>(Utils.Constants.ApiKeySectionName);

            if (!apiKey.Equals(extractedApiKey)) {
                context.Response.StatusCode = 401;
                await context.Response.WriteAsync(Utils.Constants.ApiKeyInvalid);
                return;
            }

            await _next(context);
        }
    }
}
