
using Donacare.Data;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

// Mengambil connection string dari User Secrets
var connectionString = builder.Configuration
    .GetConnectionString("DefaultConnection");

// Menghubungkan aplikasi ke database MySQL
builder.Services.AddDbContext<DonacareContext>(options =>
    options.UseMySql(
        connectionString,
        ServerVersion.AutoDetect(connectionString)
    )
);

// Menambahkan layanan MVC
builder.Services.AddControllersWithViews();

var app = builder.Build();

// Konfigurasi HTTP Request Pipeline
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Home/Error");
    app.UseHsts();
}

app.UseHttpsRedirection();
app.UseStaticFiles();

app.UseRouting();

app.UseAuthorization();

// Konfigurasi routing MVC
app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{id?}");

app.Run();
