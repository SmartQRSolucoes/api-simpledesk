using Infrastructure.Phaynell;
using Microsoft.OpenApi.Models;

namespace WebAPI.Extensions
{
    public static class BuilderExtensions
    {
        public static WebApplicationBuilder AddArchitectures(this WebApplicationBuilder builder)
        {
            builder.Services.AddControllers();
            builder.Services.AddEndpointsApiExplorer();
            builder.Services.AddSwaggerGen(c =>
            {
                c.SwaggerDoc("v1", new OpenApiInfo
                {
                    Title = "Phaynell.API",
                    Version = "v1",
                    Contact = new OpenApiContact
                    {
                        Name = "Smart QR",
                        Email = "smartqr@smartqr.tec.br",
                        Url = new Uri("https://www.smartqr.tec.br/")
                    }
                });
            });
            builder.Services.AddCors();
            builder.Services.AddScopedServices();

            return builder;
        }
    }
}
