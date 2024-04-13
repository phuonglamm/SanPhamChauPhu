//using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.FileProviders;
using SanPhamChauPhu.Helper;
using System.Configuration;

var builder = WebApplication.CreateBuilder(args);
builder.Services.AddScoped<AppDbContext>();
void ConfigureServices(IServiceCollection services)
{
    //services.AddDbContext<AppDbContext>(options =>
  // options.UseSqlServer(@"Data Source=PHUONGLAMM\SQLEXPRESS;Initial Catalog=SanPhamChauPhu;Integrated Security=True;Trust Server Certificate=True"));
}
// Add services to the container.
builder.Services.AddControllersWithViews();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Home/Error");
    // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
    app.UseHsts();
}

app.UseHttpsRedirection();
app.UseStaticFiles();
app.UseStaticFiles(new StaticFileOptions {
    FileProvider = new CompositeFileProvider(
        new PhysicalFileProvider(Path.Combine(Directory.GetCurrentDirectory(), "media"))
    ), RequestPath = "/media"
});

app.UseRouting();

app.UseAuthorization();

app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{id?}");

app.Run();
