var builder = WebApplication.CreateBuilder();
var app = builder.Build();

app.Run(async (context) =>
{
    context.Response.ContentType = "text/html; charset=utf-8";
    var stringBuilder = new System.Text.StringBuilder("<h3>��������� ����� ������</h3><table>");
    stringBuilder.Append("<tr><td>��������</td><td>��������</td></tr>");
    foreach (var param in context.Request.Query)
    {
        stringBuilder.Append($"<tr><td>{param.Key}</td><td>{param.Value}</td></tr>");
    }

    stringBuilder.Append("</table>");

    await context.Response.WriteAsync(stringBuilder.ToString());
});

app.Run();

