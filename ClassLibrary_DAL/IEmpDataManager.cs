using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using ClassLibrary_Emp_Travel;


namespace ClassLibrary_DAL
{
    public  interface IEmpDataManager
    {
        int AddEmployee_DAL(int Emp_ID, string Emp_Name, 
            string Emp_Contact, DateTime Emp_DOB, string Emp_Address);

        int EditEmployee_DAL(Employee emp);
        int DeleteEmployee_DAL(int e_Id);
        void ViewAllEmployees();
        Employee GetEmployeeById_DAL(int id);
    }
}
