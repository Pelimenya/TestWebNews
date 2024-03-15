var builder = WebApplication.CreateBuilder(args);

// ���������� �������� � ���������.
builder.Services.AddControllersWithViews();

var app = builder.Build();

// ��������� ��������� ��������� HTTP-��������.
app.UseStaticFiles();

app.UseRouting();

app.UseAuthorization();

app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{id?}");  // ��������� �������� �� ���������

app.Run();

