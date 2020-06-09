using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebFormsDemo
{
    public class Employee
    {
        public string IDNum { get; set; }
        public string Name { get; set; }       
        public string Phone { get; set; }
        public Employee()
        {

        }
        public Employee(string idnum,
                        string name,                        
                        string phone)
        {
            IDNum = idnum;
            Name = name;            
            Phone = phone;
        }
    }
}