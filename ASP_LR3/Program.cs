using ASP_LR3.Calc;
using ASP_LR3.Time;

var builder = WebApplication.CreateBuilder(args);
builder.Services.AddTransient<ICalcService, CalcService>();
builder.Services.AddTransient<ITimeService, TimeService>();
var app = builder.Build();

app.Use(async (context, next) => {
    context.Response.ContentType = "text/plain; charset=utf-8";
    await next();
});

app.MapGet("/", async context => {
    var calcService = app.Services.GetService<ICalcService>();
    var timeService = app.Services.GetService<ITimeService>();
    DateTime dateTime = DateTime.Now;
    await context.Response.WriteAsync($"\n�������� ���: {timeService?.GetTimeDay(dateTime)}\n");
    await context.Response.WriteAsync($"\n��������� ���������: {calcService?.Addition(1, 2, 3, 4, 5)}\n" +
$"\n��������� ���������: {calcService?.Subtraction(1, 2, 3, 4, 5)}\n" +
$"\n��������� ��������: {calcService?.Multiplication(1f, 2f, 3f, 4f, 5f)}\n" +
$"\n��������� ������: {calcService?.Division(1.0, 2.0, 3.0, 4.0, 5.0)}\n");
});

app.Run();

