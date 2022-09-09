using CustomMiddleware;

var builder = WebApplication.CreateBuilder(args);
var app = builder.Build();

app.UseToken("12345678");
app.MapGet("/", () => "Hello World!");

app.Run();
