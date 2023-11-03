using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary_Emp_Travel
{
    public enum ApprovedStatus {Pending, Approved, Not_Approved };
    public enum BookingStatus { Pending, Confirmed, Not_Confirmed };
    public enum RequestStatus { Open, Close};

    public class TravelRequest
    {
       
        public int Emp_ID { get; set; }
        public int Req_ID { get; set; }
        public string Emp_Name { get; set; }

        public string From_Loc { get; set; }
        public string To_Loc { get; set;}
        public DateTime Req_Date { get; set; }

        public ApprovedStatus Approved_Status { get; set; }
        public BookingStatus Booking_Status { get; set; }

        public RequestStatus Request_Status { get; set; }


        public override string ToString()
        {
            //return string.Format("Id : {0}   , Name :{1}        , Contact :{2}     , DOB :{3}    , Address :{4}      ",
            //    Emp_Id, Emp_Name, Emp_Contact, Emp_Dob, Emp_Address);      
            return string.Format("{0,-12}| {1,-10}| {2,-15}| {3,-20}| {4,-15}| {5,-17}| {6,-20}| {7,-20}| {8,-19} ",
              Emp_ID, Req_ID, Emp_Name, Req_Date, From_Loc, To_Loc, Approved_Status, Booking_Status, Request_Status);
            //appst restat
        }
    }
}
