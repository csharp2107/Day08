using System;
using System.Collections.Generic;

namespace EFCoreMariaDbExample
{
    class Program
    {
        static void Main(string[] args)
        {
            using (var ctx = new MyDbContext())
            {
                // initial list of depts
                List<Department> depts = new List<Department>();                
                depts.Add(new Department() { Name = "Finance" });
                depts.Add(new Department() { Name = "IT" });
                depts.Add(new Department() { Name = "Marketing" });

                ctx.AddRange(depts);
                ctx.SaveChanges();

                Employee emp = new Employee();
                emp.Name = "John Smith II";
                emp.Department = ctx.Departments.Find(2);
                ctx.Add(emp);
                ctx.SaveChanges();
                
            }
            Console.ReadKey();
        }
    }
}
