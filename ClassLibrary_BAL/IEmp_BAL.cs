using ClassLibrary_Emp_Travel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ClassLibrary_DAL;


namespace ClassLibrary_BAL
{
    public  interface IEmp_BAL
    {

            int AddEmployee_BAL(int Emp_ID, string Emp_Name, string Emp_Contact,
            DateTime Emp_DOB, string Emp_Address);
            int EditEmployee_BAL(Employee employee);
            int DeleteEmployee_BAL(int Emp_ID);
            void ViewAllEmployees_BAL();
            Employee GetEmployeeById_BAL(int ID);
            //void EditEmployee_BAL(Employee emp_to_Change)
            //{

           // }
        
    }
}
