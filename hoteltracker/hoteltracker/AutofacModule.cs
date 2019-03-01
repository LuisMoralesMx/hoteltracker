using Autofac;
using hoteltracker.Services;
using hoteltracker.Services.Impl;

namespace hoteltracker
{
    public class AutofacModule: Module
    {
        protected override void Load(ContainerBuilder builder)
        {
            builder.RegisterType<ReservationsService>().As<IReservationsService>().InstancePerLifetimeScope();
            builder.RegisterType<UserService>().As<IUserService>().InstancePerLifetimeScope();
            builder.RegisterType<MembershipService>().As<IMembershipService>().InstancePerLifetimeScope();
            builder.RegisterType<DiscountsService>().As<IDiscountsService>().InstancePerLifetimeScope();
        }
    }
}
