using FileSorterUI;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using NameSorterDomain.Interfaces;
using NameSorterDomain.Services;

using IHost host = CreateHostBuilder(args).Build();
using var scope = host.Services.CreateScope();

var services = scope.ServiceProvider;

try
{
    services.GetRequiredService<App>().Run(args);

}
catch (Exception ex)
{

    Console.WriteLine(ex.Message);
}


static IHostBuilder CreateHostBuilder(string[] args)
{
    return Host.CreateDefaultBuilder(args)
        .ConfigureServices((_, services) =>
        {
            //Todo : need to revise new changes and add fluent assertions to Unittests
            services.AddSingleton<IWriter,WriteName>();
            services.AddSingleton<INameSorter,NameSorter>();
            services.AddSingleton<INameSorter, ReverseSortNames>();
            services.AddSingleton<INameSorter,SortNameByFirstNames>();
            services.AddSingleton<ITextReader, ReadTextFile>();
            services.AddSingleton<App>();
        });
}
  