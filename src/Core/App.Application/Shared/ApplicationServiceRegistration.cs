namespace App.Application.Shared
{
    public static class ApplicationServiceRegistration
    {
        public static void ConfigureApplicationService(this IServiceCollection services)
        {
            //Configure Automapper and MediatR
            services.AddAutoMapper(typeof(CategoryMappingProfile));
            services.AddMediatR(AppDomain.CurrentDomain.GetAssemblies());
        }
    }
}
