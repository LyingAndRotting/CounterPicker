using CounterPicker.Domain.Services;
namespace CounterPicker
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);
            builder.Services.AddMemoryCache();
            builder.Services.AddMvc();
            builder.Services.AddControllers();
            builder.Services.AddEndpointsApiExplorer();
            builder.Services.AddSwaggerGen();
            builder.Services.AddScoped<IHeroService, HeroService>();
            builder.Services.AddSingleton<IJsonCacheService, JsonCacheService>();
            var app = builder.Build();
           
            app.MapControllers();
            app.UseSwagger();
            app.UseRouting();
            app.UseSwaggerUI();

            app.Use(async (context, next) =>
            {
                if (context.Request.Path == "/")
                {
                    context.Response.Redirect("/swagger");
                    return;
                }
                await next();
            });
            app.Run();
        }
    }
}
