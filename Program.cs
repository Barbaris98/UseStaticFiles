using System;

WebApplicationBuilder builder = WebApplication.CreateBuilder(args);
WebApplication app = builder.Build();

//app.UseDefaultFiles();  // поддержка страниц html по умолчанию
app.UseFileServer(); //тоже самое

app.UseStaticFiles(); // доб поддержку статических файлов
//доб middleware с функционалом работы стат файлов

app.Run(async (context) => await context.Response.WriteAsync("Hello World!"));

app.Run();
