using BetweenSides1.Context;
using BetweenSides1.Models;

namespace BetweenSides1
{
    internal class Program
    {
        static void Main(string[] args)
        {
        
            using var context = new ApplicationDbContext();

       
            context.Database.EnsureCreated();


            var lawyer = new Lawyer
            {
                Name = "Mr. Salem Al-Harthy",
                LicenseNumber = "LAW12345",
                Specialization = "Criminal"
            };

            context.Lawyers.Add(lawyer);
            context.SaveChanges();

            var defendant = new Defendant
            {
                Name = "Ali Al-Mansoori",
                NationalID = "987654321",
                CaseId = "C001",
                Status = "Pending",
                LawyerId = lawyer.LawyerId  
            };

            context.Defendants.Add(defendant);
            context.SaveChanges();

            Console.WriteLine("=== Lawyer Information ===");
            Console.WriteLine($"ID: {lawyer.LawyerId}");
            Console.WriteLine($"Name: {lawyer.Name}");
            Console.WriteLine($"License Number: {lawyer.LicenseNumber}");
            Console.WriteLine($"Specialization: {lawyer.Specialization}");
            Console.WriteLine();

            Console.WriteLine("=== Defendant Information ===");
            Console.WriteLine($"ID: {defendant.Id}");
            Console.WriteLine($"Name: {defendant.Name}");
            Console.WriteLine($"National ID: {defendant.NationalID}");
            Console.WriteLine($"Case ID: {defendant.CaseId}");
            Console.WriteLine($"Status: {defendant.Status}");
            Console.WriteLine($"Lawyer: {lawyer.Name}");

            Console.WriteLine("\n✅ Data saved successfully to the database!");
            Console.ReadKey();
        }
    }
}
