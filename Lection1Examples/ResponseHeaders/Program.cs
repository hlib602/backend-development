var builder = WebApplication.CreateBuilder();
var app = builder.Build();

app.Run(async (context) =>
{
    var response = context.Response;
    response.Headers.ContentLanguage = "ua-UA";
    response.Headers.ContentType = "text/plain; charset=utf-8";
    response.Headers.Append("secret-id", "256"); // додавання кастомного заголовка
    await response.WriteAsync("Hello world");
});

app.Run();

