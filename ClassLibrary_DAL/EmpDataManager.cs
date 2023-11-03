using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;
using ClassLibrary_Emp_Travel;



namespace ClassLibrary_DAL
{
    public class EmpDataManager : IEmpDataManager
    {
      public List<Employee> Employee = new List<Employee>()
        {
            new Employee() {Emp_ID =11 , Emp_Name = "Pratiksha", Emp_Contact = "7875598996", Emp_DOB= DateTime.Parse("01-09-2001"),  Emp_Address = " Pune"},
            new Employee() {Emp_ID=22 ,  Emp_Name = "Sneha"    , Emp_Contact = "9800242800", Emp_DOB = DateTime.Parse("02-03-2002"), Emp_Address = " Mumbai"},
            new Employee() {Emp_ID =33 , Emp_Name = "Sakshi"   , Emp_Contact = "7011701170", Emp_DOB = DateTime.Parse("09-09-2003"), Emp_Address = " Delhi"}
        };

      


        public int AddEmployee_DAL(int Emp_ID, string Emp_Name, string Emp_Contact, DateTime Emp_DOB, string Emp_Address)
        {
            Employee.Add(new Employee()
            {
                Emp_ID = Emp_ID,
                Emp_Name = Emp_Name,
                Emp_Contact = Emp_Contact,
                Emp_Address = Emp_Address,
                Emp_DOB = Emp_DOB
              
                
            });
           // Console.WriteLine(emp.ToString());
            return 1;
        }

          public  void ViewAllEmployees()
          {
            Console.WriteLine("\n--------------------------------------------------------------------------------------------------------------------------");
            Console.WriteLine("                                             View All Employees                                                             ");
            Console.WriteLine("-----------------------------------------------+-------------+--------------+--------------------+--------------------------");
            Console.WriteLine("\t{0,-0}|{1,-20}| {2,-20}| {3,-20}| {4,-11}| ", "Emp ID", "Emp_Name", "   Emp_Contact   ", "          Emp_DOB            ","Emp_Address");
            Console.WriteLine("----------------------------------------------------------------------------------------------------------------------------");

            foreach (Employee e in Employee)
            {
               //Console.WriteLine ("{0,-12} {1,-10} {2,-25} {3,-10} {4,10} ",
               // e.Emp_ID, e.Emp_Name, e.Emp_Contact, e.Emp_Dob, e.Emp_Address);

                Console.WriteLine(e.ToString());
            }
            //return 1;
        }

        

        public int EditEmployee_DAL(Employee emp)
        {
            Console.WriteLine("In Edit - DAL");

            Employee emp_Main = Employee.FirstOrDefault(X => X.Emp_ID ==emp.Emp_ID);
               int index =Employee.IndexOf(emp_Main);

            Employee[index].Emp_ID = emp.Emp_ID;
            Employee[index].Emp_Name =  emp.Emp_Name;
            Employee[index].Emp_Contact = emp.Emp_Contact;
            Employee[index].Emp_DOB  =  emp.Emp_DOB;
            Employee[index].Emp_Address = emp.Emp_Address;
              
            ViewAllEmployees();
                return 1;
        }

        public int DeleteEmployee_DAL(int e_ID)
            {
                 Console.WriteLine("In Delete - DAL");
                 var querymethoddelete = Employee.Remove(Employee.FirstOrDefault(emp => emp.Emp_ID == e_ID));

                 Console.WriteLine("Employee with Id {0} is deleted!!!", e_ID);
                 ViewAllEmployees();
                 return 1;

            }
            //public Employee GetEmployeeById_BAL(int id)
            //{
            //  Employee emp = GetEmployeeById_DAL(id);
            //   return emp;
            //}
        public Employee GetEmployeeById_DAL(int id)
        {
            Employee employee = Employee.FirstOrDefault(e => e.Emp_ID == id);
            if(employee != null)
            {
                return employee;
            }
            return null;
        }


        
    }
    }

