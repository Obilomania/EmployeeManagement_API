using EmployeeManagement.API.IRepository;
using EmployeeManagement.API.IRepository.Repository;

namespace EmployeeManagement.API.Helpers
{
    public class DIConfiguration
    {
        public static void RegisterServices(IServiceCollection services)
        {
            services.AddScoped<IAddressRepository, AddressRepository>();
            services.AddScoped<IJobRepository, JobRepository>();
        }
    }
}
