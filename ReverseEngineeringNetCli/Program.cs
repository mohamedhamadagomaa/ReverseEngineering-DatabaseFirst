using ReverseEngineeringNetCli.Data;
using System;

namespace EF03.ReverseEngineering
{
    internal class Program
    {

        // PMC Commands for connect with exists sql database 
        // Scaffold-Dbcontext 'connection string' Provider[SQL Server]
        static void Main(string[] args)
        {
            using (var context = new AppDbContext())
            {
                foreach (var item in context.Speakers)
                    Console.WriteLine(item.FirstName);
            }
        }
    }
}
