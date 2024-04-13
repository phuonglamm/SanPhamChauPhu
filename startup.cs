//using Microsoft.EntityFrameworkCore;
using SanPhamChauPhu.Helper;

namespace SanPhamChauPhu
{
    public class Startup
    {
        public IConfiguration configRoot
        {
            get;
        }
        public Startup(IConfiguration configuration)
        {
            configRoot = configuration;
        }
        void ConfigureServices(IServiceCollection services)
        {
        //    services.AddDbContext<AppDbContext>(options =>
        //        options.UseSqlServer(@"Data Source=PHUONGLAMM\SQLEXPRESS;Initial Catalog=SanPhamChauPhu;Integrated Security=True;Trust Server Certificate=True"));
        }
       
        public void Configure(WebApplication app, IWebHostEnvironment env)
        {
            if (!app.Environment.IsDevelopment())
            {
                app.UseExceptionHandler("/Error");
                // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
                app.UseHsts();
            }
            app.UseHttpsRedirection();
            app.UseStaticFiles();
            app.UseRouting();
            app.UseAuthorization();
            app.MapRazorPages();
            app.Run();
        }
    }
}
