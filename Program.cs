using System;

WebApplicationBuilder builder = WebApplication.CreateBuilder(args);
WebApplication app = builder.Build();

//app.UseDefaultFiles();  // ��������� ������� html �� ���������
app.UseFileServer(); //���� �����

app.UseStaticFiles(); // ��� ��������� ����������� ������
//��� middleware � ������������ ������ ���� ������

app.Run(async (context) => await context.Response.WriteAsync("Hello World!"));

app.Run();
