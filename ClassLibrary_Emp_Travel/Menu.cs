using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;



namespace ClassLibrary_Emp_Travel
{
    public class Travel_Management
    {
        //Show Menu
        public static void Show_Menu()
        {
            string choice;
            do
            {
                Console.WriteLine("------------------------");
                Console.WriteLine("Main Menu:");
                Console.WriteLine("------------------------");
                Console.WriteLine("1. Manage Employee");
                Console.WriteLine("2. Travel Requests");
                Console.WriteLine("Select the option by entering the sr. No (1 or 2), (or '0' to exit):");

                choice = Console.ReadLine();

                switch (choice)
                {
                    case "1":
                        Console.WriteLine("Manage Employee - Selected");
                        Employee_Management();

                        break;

                    case "2":
                        Console.WriteLine("Travel Requests - Selected");
                        TravelRequestsMenu();
                        break;

                    case "0":
                        Console.WriteLine("EXIT");
                        break;

                    default:
                        Console.WriteLine("Invalid choice. Please enter 1, 2, or 0 to exit.");
                        break;
                }
            } while (choice != "0");
        }

        //Show Manage Employee
        public static void Employee_Management()
        {
            int choice;
            do
            {
                Console.WriteLine("------------------------");
                Console.WriteLine("Manage Employee:");
                Console.WriteLine("------------------------");
                Console.WriteLine("1:Add Employee");
                Console.WriteLine("2:Edit Employee");
                Console.WriteLine("3:Delete Employee");
                Console.WriteLine("4:View Employee");
                Console.WriteLine("5:Exit");
                Console.WriteLine("______________________");

                Console.WriteLine("Enter choice (1,2,3,4,5)");

                String input = Console.ReadLine();

                choice = int.Parse(input);
                switch (choice)
                {
                    case 1:
                        Console.WriteLine("Add Employee-Selected");
                        break;

                    case 2:
                        Console.WriteLine("Edit Employee-Selected");
                        break;

                    case 3:
                        Console.WriteLine("Delete Employee-Selected");
                        break;

                    case 4:
                        Console.WriteLine("View Employee-Selected");
                        break;

                    case 5:
                        Console.WriteLine("Exit-Selected");
                        break;

                    default:
                        Console.WriteLine("Invalid choice. Please enter 1, 2, or 0 to exit.");
                        break;
                }
            } while (choice != 5);
        }

        //Show Add Employee
        public static void Add_employee()
        {
            int choice;
            do
            {
                Console.WriteLine("Add Employee:");
                Console.WriteLine("0:Enter Employee ID:");
                Console.WriteLine("1:Enter First Name:");
                Console.WriteLine("2:Enter Last Name:");
                Console.WriteLine("3:Enter DOB:");
                Console.WriteLine("4:Enter address");
                Console.WriteLine("5:Enter contact details");
                Console.WriteLine("6:Exist");

                string input = Console.ReadLine();

                choice = int.Parse(input);
                switch (choice)
                {
                    case 0:
                        Console.WriteLine("Enter the Employee ID : Selected");
                        break;
                    case 1:
                        Console.WriteLine("Enter First Name : Selected");
                        break;
                    case 2:
                        Console.WriteLine("Enter Last Name : Selected");
                        break;
                    case 3:
                        Console.WriteLine("Enter DOB : Selected");
                        break;
                    case 4:
                        Console.WriteLine("Enter address : Selected");
                        break;
                    case 5:
                        Console.WriteLine("Enter contact details : Selected");
                        break;
                    case 6:
                        Console.WriteLine("Exit : Selected");
                        break;
                }
                Console.WriteLine("                                               ");
            } while (choice != 6);
        }

        //Show EDit Employee
        public static void Edit_employee()
        {
            Console.WriteLine("List of Employee\r\nEnter Emp ID\r\n1.Emp ID  2.First Name\r\n3.Last Name 4.Emp DOB" +
                "\r\n5.Address 6.Contact\r\nEnter Choice :\r\n");
            int choice;

            Console.WriteLine("1.List of all employee");

            do
            {
                Console.WriteLine("2.Enter Emp ID which you want to edit");
                Console.WriteLine("3.Edit Emp ID");
                Console.WriteLine("4.Edit first name");
                Console.WriteLine("5.Edit last Name");
                Console.WriteLine("6.Edit Emp DOB");
                Console.WriteLine("7.Edit Emp Address");
                Console.WriteLine("Edit Address");
                Console.WriteLine("Edit Contact details");



                string input = Console.ReadLine();

                choice = int.Parse(input);
                switch (choice)
                {
                    default:
                        Console.WriteLine("View all the employees");
                        break;

                    case 1:
                        Console.WriteLine("Enter the Employee ID:Selected");
                        break;
                    case 2:
                        Console.WriteLine("Enter First Name:Selected");
                        break;
                    case 3:
                        Console.WriteLine("Enter Last Name:Selected");
                        break;
                    case 4:
                        Console.WriteLine("Enter DOB : Selected");
                        break;
                    case 5:
                        Console.WriteLine("Enter address : Selected");
                        break;
                    case 6:
                        Console.WriteLine("Enter contact Details : Selected");
                        break;
                    case 7:
                        Console.WriteLine("Exit : Selected");
                        break;
                }
            } while (choice != 7);
        }

        //Show Delete Employee 
        public static void DeleteEmployee()
        {
            Console.WriteLine("View Employee");
            int choice;
            do
            {
                Console.WriteLine("Press 1 to Delete Employee or Press 0 to Exit");
                string input = Console.ReadLine();
                choice = int.Parse(input);
                Console.WriteLine("1.Enter ID of Employee You Want to Delete: ");

                switch (choice)
                {
                    default:
                        Console.WriteLine("View employee - Selected");
                        break;
                    case 1:
                        Console.WriteLine("Delete Employee-Selected");
                        break;
                    case 0:
                        Console.WriteLine("Exit - Selected");
                        break;
                }
            } while (choice != 0);
        }

        //Show View Employee
        public static void ViewEmployee()
        {
            Console.WriteLine("View The Employee - Selected");

            
        }
        public static void Go_back()
        {
            string choice;
            Console.WriteLine("press 0 to go back");
            choice = Console.ReadLine();

            switch (choice)
            {
                case "1":
                    Console.WriteLine("Exit");
                    break;
            }
        }


        // Manage Travel Request
        public static void TravelRequestsMenu()
        {
            int choice;
            do
            {
                Console.WriteLine("------------------------");
                Console.WriteLine("Travel Requests:");
                Console.WriteLine("------------------------");
                Console.WriteLine("1: Raise Travel Request");
                Console.WriteLine("2: View Travel Request");
                Console.WriteLine("3: Delete Travel Request");
                Console.WriteLine("4: Approve Travel Requests");
                Console.WriteLine("5: Confirm Booking");
                Console.WriteLine("6: Go Back");
                Console.WriteLine("Enter choice (1, 2, 3, 4, 5, 6)");

                String input = Console.ReadLine();

                choice = int.Parse(input);
                switch (choice)
                {
                    case 1:
                        Console.WriteLine("Raise Travel Request - Selected");                   
                        break;

                    case 2:
                        Console.WriteLine("View Travel Request - Selected");                     
                        break;

                    case 3:
                        Console.WriteLine("Delete Travel Request - Selected");                     
                        break;

                    case 4:
                        Console.WriteLine("Approve Travel Requests - Selected");                    
                        break;

                    case 5:
                        Console.WriteLine("Confirm Booking - Selected");                      
                        break;

                    case 6:
                        Console.WriteLine("Go Back - Selected");
                        break;

                    default:
                        Console.WriteLine("Invalid choice. Please enter 1, 2, 3, 4, 5, or 6.");
                        break;
                }
            } while (choice != 6);
        }

        public static void RaiseTravelRequests()
        {
            Console.WriteLine("Raise Travel Requests - Selected");
            int choice;

            do
            {
                Console.WriteLine("1. Request ID");
                Console.WriteLine("2. Employee ID");
                Console.WriteLine("3. Location From");
                Console.WriteLine("4. Location To");
                Console.WriteLine("5. Go Back");
                Console.WriteLine("Enter Choice:");

                string input = Console.ReadLine();
                choice = int.Parse(input);

                switch (choice)
                {
                    case 1:
                        Console.WriteLine("Request ID - Selected");
                        // Capture and store request ID.
                        break;
                    case 2:
                        Console.WriteLine("Employee ID - Selected");
                        // Capture and store employee ID.
                        break;
                    case 3:
                        Console.WriteLine("Location From - Selected");
                        // Capture and store location from.
                        break;
                    case 4:
                        Console.WriteLine("Location To - Selected");
                        // Capture and store location to.
                        break;
                    case 5:
                        Console.WriteLine("Go Back - Selected");
                        break;
                    default:
                        Console.WriteLine("Invalid choice. Please enter 1, 2, 3, 4, or 5.");
                        break;
                }
            } while (choice != 5);
        }

        public static void ViewTravelRequests()
        {
            Console.WriteLine("View Travel Requests - Selected");
            int choice;

            do
            {
                Console.WriteLine("1. View All Travel Request");
                Console.WriteLine("2. View Request By Emp ID");
                Console.WriteLine("3. View Pending Request");
                Console.WriteLine("4. View Approved Request");
                Console.WriteLine("5. Go Back");
                Console.WriteLine("Enter Choice:");

                string input = Console.ReadLine();
                choice = int.Parse(input);

                switch (choice)
                {
                    case 1:
                        Console.WriteLine("View All Travel Request - Selected");
                        // Implement logic to view all travel requests.
                        break;
                    case 2:
                        Console.WriteLine("View Request By Emp ID - Selected");
                        // Implement logic to view requests by employee ID.
                        break;
                    case 3:
                        Console.WriteLine("View Pending Request - Selected");
                        // Implement logic to view pending requests.
                        break;
                    case 4:
                        Console.WriteLine("View Approved Request - Selected");
                        // Implement logic to view approved requests.
                        break;
                    case 5:
                        Console.WriteLine("Go Back - Selected");
                        break;
                    default:
                        Console.WriteLine("Invalid choice. Please enter 1, 2, 3, 4, or 5.");
                        break;
                }
            } while (choice != 5);
        }

        public static void DeleteTravelRequests()
        {
            Console.WriteLine("Delete Travel Requests - Selected");
            int choice;

            do
            {
                Console.WriteLine("1. Select Request ID to Delete");
                Console.WriteLine("2. Go Back");
                Console.WriteLine("Enter Choice:");

                string input = Console.ReadLine();
                choice = int.Parse(input);

                switch (choice)
                {
                    case 1:
                        Console.WriteLine("Select Request ID to Delete - Selected");
                        // Implement logic to delete a travel request by ID.
                        break;
                    case 2:
                        Console.WriteLine("Go Back - Selected");
                        break;
                    default:
                        Console.WriteLine("Invalid choice. Please enter 1 or 2.");
                        break;
                }
            } while (choice != 2);
        }

        public static void ApproveTravelRequests()
        {
            Console.WriteLine("Approve Travel Requests - Selected");
            int choice;

            do
            {
                Console.WriteLine("1. Select Request ID");
                Console.WriteLine("2. Approve");
                Console.WriteLine("3. Deny");
                Console.WriteLine("4. Go Back");
                Console.WriteLine("Enter Choice:");

                string input = Console.ReadLine();
                choice = int.Parse(input);

                switch (choice)
                {
                    case 1:
                        Console.WriteLine("Select Request ID - Selected");
                        // Implement logic to select a request by ID.
                        break;
                    case 2:
                        Console.WriteLine("Approve - Selected");
                        // Implement logic to approve the selected request.
                        break;
                    case 3:
                        Console.WriteLine("Deny - Selected");
                        // Implement logic to deny the selected request.
                        break;
                    case 4:
                        Console.WriteLine("Go Back - Selected");
                        break;
                    default:
                        Console.WriteLine("Invalid choice. Please enter 1, 2, 3, or 4.");
                        break;
                }
            } while (choice != 4);
        }

        public static void ConfirmTravelRequest()
        {
            Console.WriteLine("Confirm Travel Request - Selected");
            int choice;

            do
            {
                Console.WriteLine("1. Confirm Booking");
                Console.WriteLine("2. Go Back");
                Console.WriteLine("Enter Choice:");

                string input = Console.ReadLine();
                choice = int.Parse(input);

                switch (choice)
                {
                    case 1:
                        Console.WriteLine("Confirm Booking - Selected");
                        // Implement confirmation logic for the selected request.
                        break;
                    case 2:
                        Console.WriteLine("Go Back - Selected");
                        break;
                    default:
                        Console.WriteLine("Invalid choice. Please enter 1 or 2.");
                        break;
                }
            } while (choice != 2);
        }
    }





}
