using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using SampleDemoMVC.Data;
using Microsoft.Extensions.Logging;
using System.IO;
using Bold.Licensing;

namespace SampleDemoMVC
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
            services.AddRazorPages();
            services.AddServerSideBlazor();

            services.AddDbContext<SampleDemoMVCContext>(options =>
                    options.UseSqlServer(Configuration.GetConnectionString("SampleDemoMVCContext")));
            services.AddControllersWithViews();
            services.AddMvc();
            services.AddCors(o => o.AddPolicy("AllowAllOrigins", builder =>
            {
                builder.AllowAnyOrigin()
                        .AllowAnyMethod()
                        .AllowAnyHeader();
            }));
            services.AddLogging(loggingBuilder =>
            {
                loggingBuilder.AddConfiguration(Configuration.GetSection("Logging"));
                loggingBuilder.AddConsole();
                loggingBuilder.AddDebug();
            });
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env, ILoggerFactory loggerFactory)
        {
            //Register Bold license Online
            //Bold.Licensing.BoldLicenseProvider.RegisterLicense("NDEyMTkzQDMxMzgyZTM0MmUzMENrazB4bzZTQXo4aHdBQm9qdnNCMzFQbzEzQlVDR0l4eS82Wkl5dHFGcFk9;NDEyMTk0QDMxMzgyZTM0MmUzMGxGb2lZczB3Y1N1S0V0bWUyUGpDK1dtaWo0M1hOWHp2UzUrbTNiUnVsY0U9;NDEyMTk1QDMxMzgyZTM0MmUzMEFpTjVNcjZpc2tRYXl6SFpRVXhwVG9HcHBpb0YwaDYyR2pnVDQyZDFMR1k9;NDEyMTk2QDMxMzgyZTM0MmUzMG1qKzFhaGJmbHo5VFUvNERYV1lXKzJMNi9tZTRnSGRaS3BQMHRpTENCK2c9;NDEyMTk3QDMxMzgyZTM0MmUzME9ZckcybVh1eXg3VnZzYXZQMGhLaHJQdXFMRDhxOTFHamU5V0g5QzBQT0U9;NDEyMTk4QDMxMzgyZTM0MmUzMFNFSThkb2RuOUR2bjhPYU9xZWI1NldJeDE0RExDcjYvK3U1Ky9UcFJPRGc9;NDEyMTk5QDMxMzgyZTM0MmUzMGZzRzRPSGcxSys4WEpWeG5aZmwxKzltV3k1Y1RPLzFqNDNqRG9iUGdkU2s9;NDEyMjAwQDMxMzgyZTM0MmUzMGU5MDdweS96ZE5teUsydlFiaS9EOUE5bWoyc05wazBQblQvZHI5RzFNNUU9;NDEyMjAxQDMxMzgyZTM0MmUzMEdSRmhGanozK1FhMXUrSCtkMFJWbkM2V1lueHkvRDhaMTR1OVpTcHhYdm89;NDEyMjAyQDMxMzgyZTM0MmUzMGpibmkwa2VVcjFTYm5hZkIvcm9OMEtleHpla3pGT1NPMC9VSGRVV2loY1k9");
            //loggerFactory.AddConsole(Configuration.GetSection("Logging"));
            //loggerFactory.AddDebug();

            //Register Bold licenseKey Offline
           // string licenseKey = File.ReadAllText(@"boldreports_licensekey.lic"); // Replace it with actual license key file path
           // BoldLicenseProvider.RegisterLicense(licenseKey, isOfflineValidation: true);
            //loggerFactory.AddConsole(Configuration.GetSection("Logging"));
            //loggerFactory.AddDebug();

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
