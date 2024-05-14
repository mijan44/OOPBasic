using Microsoft.Extensions.DependencyInjection;
using OOPBasic.Entities;
using System.Runtime.InteropServices;
using System.Security.Authentication.ExtendedProtection;

class Program
{
    static void Main(string[] args)
    {
        var serviceProvider = new ServiceCollection()
            .AddSingleton<IEmployee, Employee>()
            .BuildServiceProvider();

        var employeeService = serviceProvider.GetService<IEmployee>();
        employeeService.AddEmployee("mijan");
        Console.WriteLine();
    }
}
