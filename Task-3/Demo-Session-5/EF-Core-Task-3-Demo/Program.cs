using EF_Core_Task_3_Demo.Data;
using EF_Core_Task_3_Demo.Data.Models;

namespace EF_Core_Task_3_Demo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            using ITI_DbContext context = new ITI_DbContext();

            #region Add-data
            Fulltime_Employee f1 = new Fulltime_Employee()
            {
                Name = "Ahmed",
                age = 30,
                address = "Cairo",
                Salary = 5000,
                Bonus = 500
            };
            Part_time_Employee p1 = new Part_time_Employee()
            {
                Name = "Mohamed",
                age = 25,
                address = "Giza",
                Countofhours = 100,
                Hourly_Rate = 50
            };

            //context.Add(f1);
            //context.Add(p1);
            //context.SaveChanges();

            //var r=context.Employee.ToList();
            //if (r is not null)
            //{
            //    foreach (var item in r.OfType<Fulltime_Employee>())
            //    {
            //        Console.WriteLine($"Fulltime Emp Name = {item.Name} , his Salary = {item.Salary}");
            //    }
            //    Console.WriteLine("================================");
            //    foreach (var item in r.OfType<Part_time_Employee>())
            //    {
            //        Console.WriteLine($"Part time Emp Name = {item.Name} , Hourly_Rate = {item.Hourly_Rate }");

            //    }
            //}



            #endregion

        }
    }
}
