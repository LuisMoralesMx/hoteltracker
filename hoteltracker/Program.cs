using Autofac;
using Autofac.Integration.Mvc;
using Microsoft.AspNetCore;
using Microsoft.AspNetCore.Hosting;
using System.Web.Mvc;

namespace hoteltracker
{
    public class Program
    {
        public static void Main(string[] args)
        {
            ConfigureAutofac();
            CreateWebHostBuilder(args).Build().Run();
        }

        public static IWebHostBuilder CreateWebHostBuilder(string[] args) =>
            WebHost.CreateDefaultBuilder(args)
                .UseStartup<Startup>();

        // Autofac Binding
        static void ConfigureAutofac()
        {
            var builder = new ContainerBuilder();
            builder.RegisterType<Models.Reservations>().As<Models.IReservations>();

            var container = builder.Build();
            DependencyResolver.SetResolver(new AutofacDependencyResolver(container));
        }
    }
}
