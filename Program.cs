using Microsoft.EntityFrameworkCore;
using Amazing_Barley_By_CjYan.Models; // adjust namespace if needed

var builder = WebApplication.CreateBuilder(args);

// ✅ Get connection string from appsettings.Development.json
var connectionString = builder.Configuration.GetConnectionString("DefaultConnection");

// ✅ Register DbContext (you need this class or I can create it)
builder.Services.AddDbContext<ApplicationDbContext>(options =>
    options.UseSqlServer(connectionString));

// Add MVC services
builder.Services.AddControllersWithViews();

var app = builder.Build();

// Configure pipeline
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Home/Error");
    app.UseHsts();
}

app.UseHttpsRedirection();
app.UseRouting();
app.UseAuthorization();
app.UseStaticFiles();
app.MapStaticAssets();

app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{id?}"
).WithStaticAssets();

app.Run();
