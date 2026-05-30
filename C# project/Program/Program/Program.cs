using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Program
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // 1. Your database connection string (Targeting CHSMSDB)
            string connectionString = @"Server=(localdb)\MSSQLLocalDB;Database=CHSMSDB;Trusted_Connection=True;";

            // 2. This activates the repository and hooks it up to your database pipeline
            ArtifactRepository repo = new ArtifactRepository(connectionString);

            // 3. Keep the user informed and the window open
            Console.WriteLine("All systems initialized! Project classes, Connection, and Core CRUD are fully setup.");
            Console.ReadLine();
        }
    }
}