using Autofac;
using hoteltracker.Services;

namespace hoteltracker
{
    public class AutofacModule: Module
    {
        protected override void Load(ContainerBuilder builder)
        {
            builder.RegisterType<ReservationsService>().As<IReservationsService>().InstancePerLifetimeScope();
            builder.RegisterType<UserService>().As<IUserService>().InstancePerLifetimeScope();
        }
    }
}
