using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplinqde
{
    class Program
    {
        static void Main(string[] args)
        {
            string conn = "Data Source = LAPTOP-3K24CQ1R; Initial Catalog=ThinkQuotientdb ; Integrated Security=true; User ID=sa; Password=Pass@123";

            var newEmployee = new StudentsDataContext(conn);
            Employee emp = new Employee();

            emp.Name = "ABC";
            emp.Email = "abc@gmail.com";
            emp.ContactNo = "8456778985";
            emp.DepartmentId = 3;
            emp.Address = "Latur";

            newEmployee.Employees.InsertOnSubmit(emp);
            newEmployee.SubmitChanges();
            Console.WriteLine("Record has been inserted");

        }
    }
}
