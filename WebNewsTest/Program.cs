var builder = WebApplication.CreateBuilder(args);

// Добавление сервисов в контейнер.
builder.Services.AddControllersWithViews();

var app = builder.Build();

// Настройка конвейера обработки HTTP-запросов.
app.UseStaticFiles();

app.UseRouting();

app.UseAuthorization();

app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{id?}");  // Изменение маршрута по умолчанию

app.Run();

