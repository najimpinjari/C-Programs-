using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Company_ibrary
{
    public  class Company
    {
        public int companyId { get; set; }
        public string name { get; set; }

        public Employe[] Employees { get; set; }


        public Company(Employee[] emps)
        {
            Employees = emps;
        }
        public void details()
        {
            Console.WriteLine($" companyid : {companyId} name : {name}");
        }

        public void AllEmployee()
        { 
            if (Employe != null && Employees.Length  > 0  )    
            {
                for(int i = 0; i < Employe.Length; i++)
                {
                    Console.WriteLine($"Employeeid  ; {Employe[i].Employeeid} name : {employees[i].Name} city: {employees[i].city} experience : {employees[i].experience}");    
                }
            }
            else
            {
                Console.WriteLine("no employee in company ");
            }
        
        }
    }
}
