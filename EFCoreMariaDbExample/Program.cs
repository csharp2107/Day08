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
                List<Department> depts = new List<Department>();
                Department d = new Department()
                {
                    Name = "Finance"
                };
                depts.Add(d);

                ctx.Departments.Add(d);
                ctx.SaveChanges();
                
            }
            Console.ReadKey();
        }
    }
}
