using AdvancedRepository.Models;
using AdvancedRepository.Models.ViewModels;
using AdvancedRepository.Repository.Classes;
using AdvancedRepository.Repository.Interfaces;
using AdvancedRepository.UnitOfWork;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AdvancedRepository
{
    public class Startup
    {
        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        public IConfiguration Configuration { get; }

        // This method gets called by the runtime. Use this method to add services to the container.
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddControllersWithViews();
            services.AddDbContext<CompanyContext>(options => options.UseSqlServer("Server=DESKTOP-8RSTMJA\\SQLEXPRESS;Database=DBCompanyCore;Trusted_Connection=True;"));
            //services.AddScoped<ICategoryRepository, CategoryRepository>();
            //services.AddScoped<ICityRepository, CityRepository>();
            //services.AddScoped<ICountyRepository, CountyRepository>();
            //services.AddScoped<ICustomerRepository, CustomerRepository>();
            //services.AddScoped<IProductRepository, ProductRepository>();
            //services.AddScoped<IEmployeeRepository, EmployeeRepository>();
            //services.AddScoped<ISupplierRepository, SupplierRepository>();
            //services.AddScoped<IUnitRepository, UnitRepository>();
            services.AddScoped<IUnity, Unity>();
            services.AddScoped<CategoryModel>();
            services.AddScoped<CityModel>();
            services.AddScoped<CountyModel>();
            services.AddScoped<CustomerModel>();
            services.AddScoped<EmployeeModel>();
            services.AddScoped<ProductModel>();
            services.AddScoped<SupplierModel>();
            services.AddScoped<UnitModel>();
            services.AddScoped<FatMasterModel>();
            services.AddScoped<FatDetailModel>();
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }
            else
            {
                app.UseExceptionHandler("/Home/Error");
            }
            app.UseStaticFiles();

            app.UseRouting();

            app.UseAuthorization();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllerRoute(
                    name: "default",
                    pattern: "{controller=Home}/{action=Index}/{id?}");
            });
        }
    }
}
