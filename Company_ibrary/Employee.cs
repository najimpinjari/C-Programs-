using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Company_ibrary
{
    public class employee   
    {
        public int Employeeid { get; set; }
        public string Name { get; set; }
        public string city { get; set; }
        public int experience { get; set; }

        public Company com { get; set; }
        public Company Company { get; set; }

        public void Details()
        {
            Console.WriteLine($"Employeeid : {Employeeid}  name : {Name} city : {city} experience : {experience}"); 
        }
    }
}
