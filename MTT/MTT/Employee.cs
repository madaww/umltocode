using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MTT
{
    public class Employee : Person
    {
        public Departament departament;
        private float Salary;
    }

     public enum Departament
    {
        departament_one, 
        departament_two
    }
}
