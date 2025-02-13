var builder = WebApplication.CreateBuilder(args);
{
    // Add services to the container.
    // Learn more about configuring OpenAPI at https://aka.ms/aspnet/openapi
    builder.Services.AddOpenApi();
    builder.Services.AddControllers();
}

var app = builder.Build();
{
    if (app.Environment.IsDevelopment())
    {
        app.MapOpenApi();
        app.UseSwaggerUi(options =>
        {
            options.DocumentPath = "openapi/v1.json";
        });
    }

    app.UseAuthorization();
    app.MapControllers();
    app.UseHttpsRedirection();
    app.Run();
}