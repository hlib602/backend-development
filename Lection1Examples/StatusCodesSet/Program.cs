var builder = WebApplication.CreateBuilder();
var app = builder.Build();

app.Run(async (context) =>
{
    context.Response.StatusCode = 404;
    await context.Response.WriteAsync("Page Not Found");
});

app.Run();


