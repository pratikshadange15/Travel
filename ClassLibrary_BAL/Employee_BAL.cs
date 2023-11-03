using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ClassLibrary_DAL;
using ClassLibrary_Emp_Travel;


namespace ClassLibrary_BAL
{
    public class Employee_BAL : IEmp_BAL
    {
        private readonly EmpDataManager _empData = new EmpDataManager();
      

        //List<Employee> Employee = new List<Employee>()
        //{
        //    new Employee() {Emp_ID =22 , Emp_Name = "Pratiksha", Emp_Contact = "7875", Emp_Dob= DateTime.Parse("15-09-2001"),  Emp_Address = " Pune"},
        //    new Employee() {Emp_ID=22,  Emp_Name = "Sneha"   , Emp_Contact = "2800", Emp_Dob = DateTime.Parse("12-03-2002"), Emp_Address = " Mumbai"},
        //    new Employee() {Emp_ID =22 , Emp_Name = "Sakshi"   , Emp_Contact = "7070", Emp_Dob = DateTime.Parse("09-09-2003"), Emp_Address = " Delhi"}
        //};
        public int AddEmployee_BAL(int Emp_ID, string Emp_Name, string Emp_Contact,
            DateTime Emp_DOB, string Emp_Address)
        {
            
            
             _empData.AddEmployee_DAL(Emp_ID, Emp_Name,Emp_Contact,Emp_DOB, Emp_Address);
           // _travelreqManager.AddEmployee_DAL(Emp_ID, Name, Emp_Contact, Emp_Address, DOB);

            return 1;
        }
    
        public int EditEmployee_BAL(Employee emp_to_Change)
        {
            
            _empData.EditEmployee_DAL(emp_to_Change);
            return 1;
        }
        public int DeleteEmployee_BAL(int Emp_ID)
        {
          
            
           // _empData.ViewAllEmployees();
            _empData.DeleteEmployee_DAL(Emp_ID);
            return 1;
        }
        public void ViewAllEmployees_BAL()
        {
              _empData.ViewAllEmployees();
            
        }
        public Employee GetEmployeeById_BAL(int ID)
        {
            Employee emp = _empData.GetEmployeeById_DAL(ID);
            return emp;
        }








    }
}
