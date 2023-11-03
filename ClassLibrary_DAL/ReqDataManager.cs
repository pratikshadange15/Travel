using ClassLibrary_Emp_Travel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary_DAL
{
    public class ReqDataManager : IReqDataManager
    {
        EmpDataManager empDataManager = new EmpDataManager();

        List<TravelRequest> TravelRequests = new List<TravelRequest>()
        {
           new TravelRequest()
           {
            Req_ID = 1,
            Emp_ID   = 11,
            Emp_Name = "Pratiksha",
            Req_Date = DateTime.Parse("2023-10-24"),
            From_Loc = "Pune",
            To_Loc   = "Hyderabad",
            Approved_Status =ApprovedStatus.Pending,
            Booking_Status = BookingStatus.Pending,
            Request_Status = RequestStatus.Open
           },
           new TravelRequest()
           {
               Req_ID = 2,
               Emp_ID   = 22,
               Emp_Name = "Sneha",
               Req_Date = DateTime.Parse("2023-10-25"),
               From_Loc = "Noida",
               To_Loc   = "Pune",              
               Approved_Status = ApprovedStatus.Pending,
               Booking_Status  = BookingStatus.Pending,
               Request_Status  = RequestStatus.Open
           },
           new TravelRequest()
           {
               Req_ID = 3,
               Emp_ID   = 33,
               Emp_Name = "Sakshi",
               Req_Date = DateTime.Parse("2023-10-26"),
               From_Loc = "Mumbai",
               To_Loc   = "Bangalore",     
               Approved_Status = ApprovedStatus.Pending,
               Booking_Status = BookingStatus.Pending,
               Request_Status  = RequestStatus.Open
           }
        };
        public int RaiseTravelRequest_DAL(TravelRequest travelRequest)     
        {
            TravelRequests.Add(new TravelRequest() { Emp_ID = travelRequest.Emp_ID, Req_ID = travelRequest.Req_ID,
                Emp_Name= travelRequest.Emp_Name, From_Loc = travelRequest.From_Loc, To_Loc = travelRequest.To_Loc, 
                Req_Date = travelRequest.Req_Date });
            Console.WriteLine("Emp Id : {0}, Travel Id {1}", travelRequest.Emp_ID, travelRequest.Req_ID);
            //TravelRequests.Add(travelRequest);

            return 1;
        }

        public int EditTravelRequest_DAL(TravelRequest travelRequest)// check tr
        {
            Console.WriteLine("In Edit - DAL");

            TravelRequest travelreq_Main = TravelRequests.FirstOrDefault(X => X.Req_ID == travelRequest.Req_ID);

            int index = TravelRequests.IndexOf(travelreq_Main);

            TravelRequests[index].Req_Date = travelRequest.Req_Date;
            TravelRequests[index].To_Loc = travelRequest.To_Loc;
            TravelRequests[index].From_Loc = travelRequest.From_Loc;
            TravelRequests[index].Approved_Status = travelRequest.Approved_Status;
            TravelRequests[index].Request_Status = travelRequest.Request_Status;



            return 1;
        }//check travel_req
        public int ViewTravelRequest_DAL()
        {
            Console.WriteLine("\n-------------------------------------------------------------------------------------------");
            Console.WriteLine("                                    View All Travel Requests                                 ");
            Console.WriteLine("\n-------------------------------------------------------------------------------------------");
            Console.WriteLine("{0,-10}| {1,-10}| {2,-15}| {3,-20}| {4,-15}| {5,-17}| {6,-22}| {7,-18}| {8,-20}|", "Emp_ID","Req_ID", "Emp_Name", "      Req_Date      ", "    From_Loc   ", "      To_Loc      "," Approved_Status"," Booking_Status","   Request_Status");
            Console.WriteLine("--------------------------------------------------------------------------------------------------------------------------");


            foreach (TravelRequest travel in TravelRequests)
            {
                Console.WriteLine(travel.ToString());
            }
            return 1; 
        }
        public int ViewJoinReqTable_DAL()
        {
            Console.WriteLine("\n---------------------------------------------------------");
            Console.WriteLine("                 View All Travel Requests                  ");
            Console.WriteLine("\n---------------------------------------------------------");
            Console.WriteLine("{0,-10}| {1,-10}| {2,-15}| {3,-20}| {4,-15}| {5,-17}| {6,-22}| {7,-20}| {8,-19}|", "Emp_ID", "Req_ID", "Emp_Name" ,"Req_Date ", 
               "From_Loc", "To_Loc", "  Approved_Status  ", "  Booking_Status  ", "  Request Status  ");
            Console.WriteLine("--------------------------------------------------------------------------------------------------------------------------");


            var querymethodview = from emp in empDataManager.Employee
                                   join req in TravelRequests
                                   on emp.Emp_ID equals req.Emp_ID
                                   select new
                                   {
                                       E_ID = emp.Emp_ID,
                                       ReqID = req.Req_ID,
                                       E_Name = emp.Emp_Name,
                                       
                                       E_Address = emp.Emp_Address,
                                       EContact = emp.Emp_Contact,
                                       ReqDate = req.Req_Date,
                                       From_Location = req.From_Loc,
                                       To_Location = req.To_Loc,
                                       ApprovedStatus = req.Approved_Status,
                                       RequestStatus = req.Request_Status,
                                       BookingStatus = req.Booking_Status,
                                   };

            foreach (var request in querymethodview)
            {
                Console.WriteLine("{0,-10}| {1,-10}| {2,-15}| {3,-20}| {4,-15}| {5,-17}| {6,20}| {7,-20}| {8,-19}|",
                    request.E_ID, request.ReqID, request.E_Name, request.ReqDate, request.From_Location,
                    request.To_Location, request.ApprovedStatus, request.BookingStatus, request.RequestStatus);
                // Console.WriteLine(request.E_ID + " " + request.E_Name);
            }

            return 1;
        }
        public int DeleteTravelRequest_DAL(int Req_ID)
        {
            Console.WriteLine("In Delete - DAL");

            var querymethoddelete = TravelRequests.Remove(TravelRequests.FirstOrDefault(travelReq => travelReq.Req_ID == Req_ID));
            Console.WriteLine("Travel Request with Request ID {0} is deleted !!!", Req_ID);

            ViewTravelRequest_DAL();
            return 1;
        }
        public int ApproveTravelRequest_DAL(int Travel_ID , ApprovedStatus appstatus)
        {
            Console.WriteLine("In Approve Request - DAL");

            var querymethodapprove = TravelRequests.FirstOrDefault(travelreq => travelreq.Req_ID == Travel_ID);
            // var query = from travelreq in TravelRequests where travelreq.Req_ID == Travel_ID;

            var query = querymethodapprove.Approved_Status = appstatus;

            if(querymethodapprove.Booking_Status == BookingStatus.Not_Confirmed && querymethodapprove.Approved_Status ==appstatus)
            {
                querymethodapprove.Request_Status = RequestStatus.Close;

            }
            if (querymethodapprove.Approved_Status == ApprovedStatus.Not_Approved)

            {

                querymethodapprove.Request_Status = RequestStatus.Close;

            }
            //var query =querymethodapprove

            //ViewJoinReqTable_DAL();
            return 1;
        }
        public int ConfirmTravelRequest_DAL(int Travel_ID, BookingStatus bookstatus)
        {
            Console.WriteLine("In Confirm Request - DAL");
            var querymethodconfirm = TravelRequests.FirstOrDefault(travelreq => travelreq.Req_ID == Travel_ID);

            bool result = querymethodconfirm.Approved_Status == ApprovedStatus.Approved;

            if(result == true)
            {
                var query = querymethodconfirm.Booking_Status = bookstatus;
                //ViewJoinReqTable_DAL();
            }
            else
            {
                Console.WriteLine("Travel Request Not Approved Yet!!");
            }

            //RequestStatus requestStatus = RequestStatus.Open;
            if(querymethodconfirm.Booking_Status == BookingStatus.Confirmed || querymethodconfirm.Booking_Status == BookingStatus.Not_Confirmed)
            {
                querymethodconfirm.Request_Status = RequestStatus.Close;
            }
            return 1;
        }
        
        public TravelRequest GetTravelRequestByID_DAL(int ID)
        {
            TravelRequest TravelReq = TravelRequests.FirstOrDefault(req => req.Req_ID == ID);
            if(TravelReq != null)
            {
                return TravelReq;

            }
            return null;
        }
        public int ViewAllApprovedRequest_DAL()
        {
            Console.WriteLine("\n--------------------------------------------------------------------------------------------------------------------------");
            Console.WriteLine("                                         View All Travel Requests");
            Console.WriteLine("--------------------------------------------------------------------------------------------------------------------------");
            Console.WriteLine("{0,-12} {1,-10} {2,-10} {3,-10} {4,-20} {5,-20} {6,15} {7,10} {8,10}", "Emp_ID","Req_ID", "Emp_Name","Req_Date" , "From_Loc", "To_Loc", "ApprovedStatus", "BookingStatus", "   Request Status");
            Console.WriteLine("--------------------------------------------------------------------------------------------------------------------------");
            foreach (TravelRequest travelreq in TravelRequests)
            {
                if (travelreq.Approved_Status == ApprovedStatus.Approved && travelreq.Request_Status == RequestStatus.Open)
                {
                    Console.WriteLine(travelreq.ToString());
                }
            }
            return 1;
        }
        public int ViewAllPendingRequest_DAL()
        {

            Console.WriteLine("\n--------------------------------------------------------------------------------------------------------------------------");
            Console.WriteLine("                                         View All Travel Requests");
            Console.WriteLine("--------------------------------------------------------------------------------------------------------------------------");
            Console.WriteLine("{0,-12} {1,-10} {2,-10} {3,-10} {4,-20} {5,-20} {6,10} {7,10} {8,10}", "Emp_ID", "Req_ID", "Emp_Name","Req_Date", "From_Loc", "To_Loc", "ApprovedStatus", "BookingStatus", "   Request Status");
            Console.WriteLine("--------------------------------------------------------------------------------------------------------------------------");
            foreach (TravelRequest travelreq in TravelRequests)
            {
                if (travelreq.Approved_Status == ApprovedStatus.Pending && travelreq.Request_Status == RequestStatus.Open)
                {
                    Console.WriteLine(travelreq.ToString());
                }
            }
            return 1;
        }
    }
}
