using BusinessLayer.Abstract;
using BusinessLayer.Repository;
using DataAccesLayer.Abstract;
using DataAccesLayer.Repositories;
using FinalExam.SignalR.Hubs;
using Microsoft.AspNetCore.Authentication.Cookies;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.HttpsPolicy;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using NToastNotify;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FinalExam
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
            services.AddScoped<IUserService, IUserMan>();
            services.AddScoped<IUser, UserRepo>();
            services.AddScoped<IGorevService, GorevMan>();
            services.AddScoped<IGorev, GorevRepo>();
            services.AddScoped<IYorumService, YorumMan>();
            services.AddScoped<IYorum, YorumRepo>();

            services.AddControllersWithViews().AddRazorRuntimeCompilation().AddNToastNotifyToastr(new ToastrOptions()
            {
                Title = "Bilgilendirme"

            });
            services.AddAuthentication(CookieAuthenticationDefaults.AuthenticationScheme).
              AddCookie(x =>
              {
                  x.LoginPath = "/Admin/Login";
              }
          );
            services.AddAuthenticationCore();
            services.AddHttpContextAccessor();
             
            services.AddSignalR();
            services.AddAuthorization(options =>
            {
                options.AddPolicy("Admin",
                     policy => policy.RequireRole("Admin"));
            });
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
                // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
                app.UseHsts();
            }
            app.UseHttpsRedirection();
            app.UseStaticFiles();

            app.UseRouting();
            app.UseAuthentication();
            app.UseAuthorization();
            
            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllerRoute(
                    name: "default",
                    pattern: "{controller=U�}/{action=Index}/{id?}");
                    endpoints.MapHub<ChatHub>("/chatHub");
            });
        }
    }
}
