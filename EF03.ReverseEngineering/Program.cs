using EF03.ReverseEngineering.Data;
using System;

namespace EF03.ReverseEngineering
{
    internal class Program
    {

        // PMC Commands for connect with exists sql database 
        // Scaffold-Dbcontext 'connection string' Provider[SQL Server]
        static void Main(string[] args)
        {
            foreach (var item in new AppDbContext().Speakers)
                Console.WriteLine(item.FirstName);
        }

    }
}
