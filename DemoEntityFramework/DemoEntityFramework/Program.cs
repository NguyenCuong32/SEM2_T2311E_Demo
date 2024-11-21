

using DemoEntityFramework.Repositories;
using DemoEntityFramework.Services;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

internal class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("Demo Entityframework");
        IConfiguration configuration = new ConfigurationBuilder().AddJsonFile("appsettings.json").Build();
        var serviceCollection = new ServiceCollection();
        ConfigurationService(serviceCollection,configuration);
        var scopeProvider = serviceCollection.BuildServiceProvider();
        using (var scope  = scopeProvider.CreateScope())
        {
            var classService = scope.ServiceProvider.GetRequiredService<IClassService>();
            var classes = classService.GetClasses();
            foreach (var c  in classes)
            {
                System.Console.WriteLine($"Class information {c.ClassName} {c.RoomName}");
            }
            System.Console.WriteLine("Start Application.");
        }
    }
    private static void ConfigurationService(ServiceCollection services,IConfiguration configuration){
        services.AddDbContext<EduDbContext>(options=>options.UseSqlServer(configuration.GetConnectionString("EduConnect")));
        services.AddScoped<IClassRepository,ClassRepository>();
        services.AddScoped<IClassService,ClassService>();
    }
}