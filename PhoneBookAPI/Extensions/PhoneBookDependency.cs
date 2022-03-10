using Microsoft.Extensions.DependencyInjection;
using PhoneBookAPI.BLL.Interfaces;
using PhoneBookAPI.BLL.Services;

namespace PhoneBookAPI.Extensions
{
    public static class PhoneBookDependency
    {
        public static void AddPhoneBookDependancy(this IServiceCollection services)
        {
            services.AddScoped(typeof(IUserService), typeof(UserService));
            //services.AddScoped(typeof(IEmailRepository), typeof(EmailRepository));
            //services.AddScoped(typeof(IPhoneRepository), typeof(PhoneRepository));

            //services.AddScoped(typeof(IUserBLL), typeof(UserBLL));
        }
    }
}
