using Company_ibrary;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Company_library_Client
{
    class Program
    {
        static void Main(string[] args)
        {
            //Employee e = new Employee()
            //{
            //    Employeeid = 1,
            //    Name = "radhesh",
            //    city = "nasik",
            //    experience = 2
            //};
            //e.Company = new Company()
            //{
            //    companyId = 1,
            //    name = "emaerson"
            //};
            //Console.WriteLine($"company id : {e.Company.companyId} name : {e.Company.name}");
            //e.Details();

            Employe e1 = new Employe() {Employeeid = 102, Name = "prathm", city = "satara", experience = 3 };



            Employe e2 = new Employe() { Employeeid = 103, Name = "rade", city = "nasik", experience = 5};


            Employe e3 = new Employe() { Employeeid = 104, Name = "najim", city = "dhule", experience = 2 };



            Employe e4 = new Employe() { Employeeid = 105, Name = "veda", city = "parola", experience = 7 };



            Employe e5 = new Employe() { Employeeid = 106, Name = "sham", city = "jalgon", experience = 3 };

            Employe[]  employees = new Employe[]
            { e1, e2, e3, e4,e5 };

            Company c = new Company(employees) { companyId = 1, name = "tata" };
            c.details();
            c.AllEmployee();

            Console.ReadLine();
        }
    }
}
