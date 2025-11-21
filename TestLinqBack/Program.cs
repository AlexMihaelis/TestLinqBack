using TestLinqBack.Contracts;
using TestLinqBack.Data;
using TestLinqBack.Services;

// Создаем билдер приложения
var builder = WebApplication.CreateBuilder(args);

// Добавляем MVC Контроллеры
builder.Services.AddControllers();

// Swagger
// Настройка Сваггера для API
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

// Регистрация сервисов
builder.Services.AddScoped<IHelloWorldService, HelloWorldService>();
builder.Services.AddScoped<IUserService, UserService>();
builder.Services.AddScoped<IProjectService, ProjectService>();
builder.Services.AddScoped<IDepartmentService, DepartmentService>();
builder.Services.AddScoped<IDocumentService, DocumentService>();

// Сборка приложения
var app = builder.Build();

// Подключения Сваггера middleware
app.UseSwagger();
app.UseSwaggerUI();

// Маппинг контроллеров
app.MapControllers();

// Бывший Hello World при запуске :]
//app.MapGet("/", () => "Hello World!");

// Запуск нашего приложения
app.Run();
