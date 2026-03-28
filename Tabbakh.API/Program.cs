namespace Tabbakh.API
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);

            // ✅ Add services to the container
            builder.Services.AddControllers();

            // ✅ Swagger Services
            builder.Services.AddEndpointsApiExplorer();
            builder.Services.AddSwaggerGen();

            // (اختياري)
            builder.Services.AddOpenApi();

            var app = builder.Build();

            // ✅ خلي Swagger شغال دايمًا (مش بس Development)
            app.UseSwagger();
            app.UseSwaggerUI();

            // Configure the HTTP request pipeline
            app.UseHttpsRedirection();

            app.UseAuthorization();

            app.MapControllers();

            app.Run();
        }
    }
}