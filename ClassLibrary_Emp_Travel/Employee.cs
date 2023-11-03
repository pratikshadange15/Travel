using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary_Emp_Travel
{
    public class Employee
    {
        public int Emp_ID { get; set; }
        public string Emp_Name { get; set; }
       // public int Emp_salary { get; set; }
        public DateTime Emp_DOB {  get; set; }
       
        public string Emp_Address { get; set; }
        public string Emp_Contact { get; set; }

        //public Employee(int id, string name, int emp_salary, DateTime emp_Dob)
        //{
        //    Emp_ID = id; 
        //    Emp_Name = name;
        //    Emp_salary = emp_salary; 
        //    Emp_Dob = emp_Dob;
        //}
        public override string ToString()
        {
            //return string.Format("Id : {0}   , Name :{1}        , Contact :{2}     , DOB :{3}    , Address :{4}      ",
            //    Emp_Id, Emp_Name, Emp_Contact, Emp_Dob, Emp_Address);      
            return string.Format("{0,-13} |{1,-20}| {2,-20}| {3,-29}| {4,10}| ",
                Emp_ID, Emp_Name, Emp_Contact, Emp_DOB, Emp_Address);

        }
    }
}
