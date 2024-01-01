namespace App.Application.Shared
{
    public static class ApplicationServiceRegistration
    {
        public static void ConfigureApplicationService(this IServiceCollection services)
        {
            //Configure Automapper
            services.AddAutoMapper(typeof(CategoryMappingProfile));
        }
    }
}
