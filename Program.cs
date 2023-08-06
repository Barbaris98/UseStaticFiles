WebApplicationBuilder builder = WebApplication.CreateBuilder(args);
WebApplication app = builder.Build();

app.UseStaticFiles(); 

app.Run(async (context) => await context.Response.WriteAsync("Hello World!"));

app.Run();
