using Microsoft.Net.Http.Headers;

namespace WebAPI.Extensions
{
    public static class AppUseExtensions
    {
        public static IApplicationBuilder UseApplication(this IApplicationBuilder app)
        {
            app.UseCors(policy =>
            policy
                .AllowAnyOrigin()
                .AllowAnyMethod()
                .AllowAnyHeader()
                .WithHeaders(HeaderNames.ContentType)
            );

            app.UseSwagger();
            app.UseSwaggerUI();
            app.UseHttpsRedirection();
            app.UseAuthorization();

            return app;
        }
    }
}
