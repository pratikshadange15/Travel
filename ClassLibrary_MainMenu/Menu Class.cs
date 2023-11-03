using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using ClassLibrary_BAL;
using ClassLibrary_Emp_Travel;



namespace ClassLibrary_MainMenu
{
    public class Travel_Management
    {
        
        private static readonly Employee_BAL _empBAL = new Employee_BAL();
        private static readonly Travel_BAL _emptravel = new Travel_BAL();
       
        //Show Menu
        public static void Show_Menu()
        {
            int  choice;
            Console.WriteLine("*************------------------------------------  Welcome to the Travel Booking System ------------------------------------************\n");
           
                do
                {
                   
                    Console.WriteLine("-----------------------------------");
                    Console.WriteLine("           Main Menu");
                    Console.WriteLine("-----------------------------------");

                    Console.WriteLine(" 1. Manage Employee\n 2. Manage Travel Request\n 3. Exit");
                    Console.WriteLine("Select Choice 1 to 3\n");

                    choice = int.Parse(Console.ReadLine());

                    switch (choice)
                    {
                        case 1:
                            Console.WriteLine("Manage Employee - Selected");
                            Employee_Management();
                            break;

                        case 2:
                            Console.WriteLine("Travel Requests - Selected");
                            ShowTravelMgmt();
                            break;

                        case 3:
                            Console.WriteLine("Exit");
                            break;

                    }
                } while (choice != 3);
            

            //catch(Exception ex)
            //{
            //    Console.WriteLine("Please Select Correct Choice!!");
            //    Console.WriteLine(ex.Message);
            //}
        }

        //Show Manage Employee
        public static void Employee_Management()
        {
            Console.WriteLine("-----------------------------------");
            Console.WriteLine("   Welcome to Manage Employee");
            Console.WriteLine("-----------------------------------");

            try
            {
                Console.WriteLine(" 1. Add Employee\n 2. View Employee\n 3. Edit Employee\n 4. Delete Employee\n 5. Go Back\n 6. Exit");
                Console.WriteLine("Select any option from 1 to 6:");
                int choice1 = int.Parse(Console.ReadLine());
                switch (choice1)
                {
                    case 1:
                        Console.WriteLine("Add Employee");
                        Add_Employee();
                        break;

                    case 2:
                        Console.WriteLine("View Employee");
                        View_Employee();
                        break;

                    case 3:
                        Console.WriteLine("Edit Employee");
                        Edit_Employee();
                        break;
                    case 4:
                        Console.WriteLine("Delete Employee");
                        Delete_Employee();
                        break;
                    case 5:
                        Console.WriteLine("Go Back");
                        Show_Menu();
                        break;
                    case 6:
                        Console.WriteLine("Exit");
                        Environment.Exit(0);
                        break;
                }
            }
            catch(Exception ex)
            {
                Console.WriteLine("Please Select Correct Choice!!");
                Console.WriteLine(ex.Message);
            }
        }

        //Show Add Employee
        public static void Add_Employee()
        {
          
            
            int Emp_ID;
            string Emp_Name, Emp_Address, Emp_Contact;
            DateTime Emp_DOB;

           // int choice;
           
                Console.WriteLine("------------------------------");
                Console.WriteLine("        Add Employee");
                Console.WriteLine("------------------------------");

            Console.WriteLine("Enter Employee ID: \n");
            Emp_ID = int.Parse(Console.ReadLine());

            Console.WriteLine("Enter Name: \n");
            Emp_Name = Console.ReadLine();         

            Console.WriteLine("Enter Contact: \n");
            Emp_Contact = Console.ReadLine();

            Console.WriteLine("Enter DOB: \n");
            Emp_DOB = DateTime.Parse(Console.ReadLine());

            Console.WriteLine("Enter Address: \n");
            Emp_Address = Console.ReadLine();


            // Employee_BAL employeeBAL = new Employee_BAL();
            _empBAL.AddEmployee_BAL( Emp_ID, Emp_Name, Emp_Contact, Emp_DOB, Emp_Address);

            Console.WriteLine("You entered {0}, {1}, {2}, {3}, {4}", Emp_ID, Emp_Name, Emp_Contact, Emp_DOB, Emp_Address);

            _empBAL.ViewAllEmployees_BAL();

        }

        //Show Edit Employee
        public static void Edit_Employee()
        {           

            //int Emp_ID;
            string Emp_Name, Emp_Address, Emp_Contact;            
            DateTime Emp_DOB;
            
            int choice;
            Employee emp_to_Change = new Employee();         

            // _empBAL.ViewAllEmployees_BAL();                  
            
            do
            {
                _empBAL.ViewAllEmployees_BAL();

                Console.WriteLine("------------------------------");
                Console.WriteLine("       Edit Employee");
                Console.WriteLine("------------------------------");

                Console.WriteLine("Enter the Employee Id to Edit or 0 to Go Back\n");
                int Edit_Emp_ID = int.Parse(Console.ReadLine());

                if (Edit_Emp_ID == 0)
                {
                    //Environment.Exit(0);
                    Employee_Management();
                }
                 TravelRequest travelRequest=new TravelRequest();
                emp_to_Change = _empBAL.GetEmployeeById_BAL(Edit_Emp_ID);

                Console.WriteLine(" 1.Edit Name\n 2.Edit Contact\n 3.Edit DOB\n 4.Edit Address\n 5. Go Back");
                Console.WriteLine("Select Choice 1 to 5\n");

                //string input = Console.ReadLine();
                //emp_to_Change = view.GetEmployeeByID_BAL(e_Id);

                choice = int.Parse(Console.ReadLine());
                switch (choice)
                {
                    case 1:
                        Console.WriteLine("Enter New Employee Name: \n");
                        Emp_Name = Console.ReadLine();
                        emp_to_Change.Emp_Name = Emp_Name;
                        break;

                    case 2:
                        Console.WriteLine("Enter New Employee Contact : \n");
                        Emp_Contact = Console.ReadLine();
                        emp_to_Change.Emp_Contact = Emp_Contact;
                        break;
                        
                    case 3:
                        Console.WriteLine("Enter New Employee DOB: \n");
                        Emp_DOB = DateTime.Parse(Console.ReadLine());
                        emp_to_Change.Emp_DOB = Emp_DOB;
                        break;

                    case 4:
                        Console.WriteLine("Enter New Employee Address: \n");
                        Emp_Address = Console.ReadLine();
                        emp_to_Change.Emp_Address = Emp_Address;
                        break;

                    case 5:
                        Console.WriteLine("Go back");
                        Environment.Exit(0);
                        //EmployeeManagement();
                        break;

                    default:
                        Console.WriteLine("Wrong Choice");
                        break;
                }
            } while (choice != 5);
             _empBAL.EditEmployee_BAL(emp_to_Change);            
            //_empBAL.ViewAllEmployees_BAL();
        }

        //Show Delete Employee 
        public static void Delete_Employee()
        {
            Console.WriteLine("------------------------------");
            Console.WriteLine("       Delete Employee        ");
            Console.WriteLine("------------------------------");

            // int e_Id;
            Console.WriteLine("View All Employees\n");
            _empBAL.ViewAllEmployees_BAL();

            Console.WriteLine("Select Employee to Delete\n");
            Console.WriteLine("Enter Emp Id :");
            int delEmp_ID = int.Parse(Console.ReadLine());

            _empBAL.DeleteEmployee_BAL(delEmp_ID);
            Console.WriteLine("The Employee with Id {0} has been deleted!!", delEmp_ID);

            
            //_empBAL.ViewAllEmployees_BAL();
        }

        //Show View Employee
        public static void View_Employee()
        {
            //Console.WriteLine("------------------------------");
            //Console.WriteLine("     View All Employee");
            //Console.WriteLine("------------------------------");

            _empBAL.ViewAllEmployees_BAL();
        }

        //*************** Manage Travel Request*****************
        public static void ShowTravelMgmt()
        {


            Console.WriteLine("-------------------------------------");
            Console.WriteLine(" Welcome to Manage Travel Booking");
            Console.WriteLine("-------------------------------------");
            try
            {
                Console.WriteLine(" 1. Raise Travel Request\n 2. View Travel Request\n 3. Edit Travel Request\n 4. Delete Travel Request\n 5.Approve Status\n 6.Confirm Status\n 7.Go Back\n 8. Exit");
                Console.WriteLine("Select any option from 1 to 6:");

            int choice = int.Parse(Console.ReadLine());
            //choice = int.Parse(input);
            switch (choice)
            {
                case 1:
                    Console.WriteLine("Raise Travel Request");
                    RaiseTravelRequest();
                    break;

                case 2:
                    Console.WriteLine("View Travel Request");
                    ViewTravelRequest();
                    break;

                case 3:
                    Console.WriteLine("Edit Travel Request");
                    EditTravelRequest();
                    break;

                case 4:
                    Console.WriteLine("Delete Travel Request");
                    DeleteTravelRequest();
                    break;

                case 5:
                    Console.WriteLine("Approve Travel Request");
                    ApproveTravelRequest();
                    break;
                case 6:
                    Console.WriteLine("Confirm Travel Request");
                    ConfirmTravelRequest();
                    break;

                case 7:
                    Console.WriteLine("Go Back");
                    Show_Menu();
                    break;

                case 8:
                    Console.WriteLine("Exit");
                    break;
            }
        }
            
            
            catch (Exception ex)
            {
                Console.WriteLine("Please Select Correct Choice!!");
                Console.WriteLine(ex.Message);
            }

        }

        public static void RaiseTravelRequest()
        {
            int Emp_ID, Req_ID;
            String From_Loc, To_Loc;
            DateTime Req_Date;

            Console.WriteLine("------------------------------");
            Console.WriteLine("    Raise Travel Request");
            Console.WriteLine("------------------------------");

            //Console.WriteLine("View All Employee\n");
            //_empBAL.ViewAllEmployees_BAL();
            //_emptravel.ViewTravelRequest_BAL();
            

            Console.WriteLine("Enter The Employee Id to Raise Travel Request");
            Emp_ID = int.Parse(Console.ReadLine());

            //Console.WriteLine("Enter Empolyee ID: \n");
            //EmpID = int.Parse(Console.ReadLine());

            Console.WriteLine("Enter Request ID: \n");
            Req_ID = int.Parse(Console.ReadLine());

            Console.WriteLine("Enter From Location: \n");
            From_Loc = Console.ReadLine();

            Console.WriteLine("Enter To Location: \n");
            To_Loc = Console.ReadLine();

            Console.WriteLine("Enter Request Date: \n");
            Req_Date = DateTime.Parse(Console.ReadLine());

           //_emptravel.RaiseTravelRequest_BAL(Emp_ID,Req_ID,From_Loc,To_Loc,Req_Date);
            Console.WriteLine("You entered {0}, {1}, {2}, {3}, {4}",Emp_ID,Req_ID, Req_Date, From_Loc, To_Loc);


            _emptravel.RaiseTravelRequest_BAL(new TravelRequest {Emp_ID = Emp_ID, Req_ID = Req_ID,
                Req_Date = Req_Date, From_Loc =From_Loc, To_Loc =To_Loc });
            _emptravel.ViewTravelRequest_BAL();

        }
        public static void EditTravelRequest()
        {
            //int Emp_ID, Req_ID;
            string From_Loc, To_Loc;
            DateTime Req_Date;

            TravelRequest req_to_Change = new TravelRequest();
            int choice2;
            //_emptravel.ViewTravelRequest_BAL();

            do
            {
                _emptravel.ViewTravelRequest_BAL();

                Console.WriteLine("------------------------------");
                Console.WriteLine("   Edit Travel Request");
                Console.WriteLine("------------------------------");

                //Console.WriteLine("View All Travel Request");

                Console.WriteLine("Enter the Request Id to Edit  Travel Request or 0 to Go Back\n");
                int Edit_ReqID = int.Parse(Console.ReadLine());

                if (Edit_ReqID == 0)
                {
                    //Environment.Exit(0);
                    ShowTravelMgmt();

                }

               req_to_Change = _emptravel.GetReqByID_BAL(Edit_ReqID);

                Console.WriteLine(" 1.Edit Travel Date\n 2.Edit From Location\n 3.Edit To Location\n 4. Go Back");
                Console.WriteLine("Select Choice 1 to 7\n");

                choice2 = int.Parse(Console.ReadLine());

                switch (choice2)
                {

                    case 1:
                        Console.WriteLine("Enter New Travel Date: \n");
                        Req_Date = DateTime.Parse(Console.ReadLine());
                        req_to_Change.Req_Date = Req_Date;
                        break;


                    case 2:
                        Console.WriteLine("Enter New From Location: \n");
                        From_Loc = Console.ReadLine();
                        req_to_Change.From_Loc = From_Loc;
                        break;


                    case 3:
                        Console.WriteLine("Enter New To Location: \n");
                        To_Loc = Console.ReadLine();
                        req_to_Change.To_Loc = To_Loc;
                        break;


                    case 4:
                        Console.WriteLine("Go back");
                        break;

                }
            } while (choice2 != 4);

            _emptravel.EditTravelRequest_BAL(req_to_Change);
        }

        public static void ViewTravelRequest()
        {
            //Console.WriteLine("------------------------------");
            //Console.WriteLine("    View Travel Request");
            //Console.WriteLine("------------------------------");
           // _emptravel.ViewTravelRequest_BAL();
            _emptravel.ViewJoinReqTable_BAL();
        }

        public static void DeleteTravelRequest()
        {
            //Console.WriteLine("View All Travel Request\n");
            _emptravel.ViewTravelRequest_BAL();

            Console.WriteLine("------------------------------");
            Console.WriteLine("   Delete Travel Request");
            Console.WriteLine("------------------------------");

            Console.WriteLine("Enter Travel Request Id to delete\n");
            int TravelReq_ID = int.Parse(Console.ReadLine());
            _emptravel.DeleteTravelRequest_BAL(TravelReq_ID);
        }

        public static void ApproveTravelRequest()
        {
            int choice2;
            _emptravel.ViewAllPendingRequest_BAL();
            do 
            { 
            Console.WriteLine("------------------------------");
            Console.WriteLine("  Approved Travel Requests");
            Console.WriteLine("------------------------------");

            //Console.WriteLine("Display all not approved travel requests");
            Console.WriteLine("\n Enter the Travel Request Id to Approve Booking or 0 to Go Back");
            int Req_ID = int.Parse(Console.ReadLine());

            if(Req_ID == 0)
            {
                ShowTravelMgmt();
            }

            //Console.WriteLine("\n Change the Approve Booking Status");
            //string ApproveStatus = Console.ReadLine();
            //Enum ApproveStatus = Enum.Parse(Console.ReadLine());

            Console.WriteLine(" 1. Approve\n 2. Not Approved\n 3. Go Back\n 4. Exit");
            Console.WriteLine("Select any option from 1 to 4:");

            choice2 = int.Parse(Console.ReadLine());
            switch (choice2)
            {
                case 1:
                    Console.WriteLine("Raise Travel Status changed to Approved");
                    _emptravel.ApproveTravelRequest_BAL(Req_ID, ApprovedStatus.Approved);
                    break;

                case 2:
                    Console.WriteLine("Raise Travel Request changed to Not Approved");
                    _emptravel.ApproveTravelRequest_BAL(Req_ID, ApprovedStatus.Not_Approved);
                    break;

                case 3:
                    Console.WriteLine("Go Back");
                    ShowTravelMgmt();
                    break;

                case 4:
                    Console.WriteLine("Exit");
                    Environment.Exit(0);
                    break;
            }
            _emptravel.ViewJoinReqTable_BAL();
            } while (choice2 != 4);

        }

        public static void ConfirmTravelRequest()
        {
            int choice2;
            do
            {
                Console.WriteLine("--------------------------------------");
                Console.WriteLine("Confirm Booking of Travel Requests");
                Console.WriteLine("--------------------------------------");

                _emptravel.ViewJoinReqTable_BAL();
                _emptravel.ViewAllApprovedRequest_BAL();
                

                //Console.WriteLine("Display all approved travel requests");
                Console.WriteLine("\n Enter the Travel Request Id to Confirm Booking or 0 to Go Back");
                int Req_ID = int.Parse(Console.ReadLine());

                if (Req_ID == 0)
                {
                    ShowTravelMgmt();
                }

                // Console.WriteLine("\n Change the Confirm Booking Status");
                Console.WriteLine("Select any option from 1 to 4:");

                Console.WriteLine(" 1. Confirmed\n 2. Not Confirmed\n 3. Go Back\n 4. Exit");
            
                choice2 = int.Parse(Console.ReadLine());
            switch (choice2)
            {
                case 1:
                    Console.WriteLine("Raise Travel Status changed to Booked");
                      _emptravel.ConfirmTravelRequest_BAL(Req_ID, BookingStatus.Confirmed);
                    break;

                case 2:
                    Console.WriteLine("Raise Travel Request changed to Not Available");
                     _emptravel.ConfirmTravelRequest_BAL(Req_ID, BookingStatus.Not_Confirmed);
                    break;

                case 3:
                    Console.WriteLine("Go Back");
                    ShowTravelMgmt();
                    break;

                case 4:
                    Console.WriteLine("Exit");
                    Environment.Exit(0);
                    break;
            }
            } while (choice2 != 4);
        }
    }
    //public static void ShowAllTravelRequests()
    //{
    //    Console.WriteLine("------------------------------");
    //    Console.WriteLine("   All Travel Requests");
    //    Console.WriteLine("------------------------------");
    //}
    //public static void ShowOpenRequest()
    //{
    //    Console.WriteLine("------------------------------");
    //    Console.WriteLine("    Open Travel Requests");
    //    Console.WriteLine("------------------------------");

    //}
    //public static void ShowClosedRequest()
    //{
    //    Console.WriteLine("------------------------------");
    //    Console.WriteLine("   Closed Travel Requests");
    //    Console.WriteLine("------------------------------");

    //}




}

