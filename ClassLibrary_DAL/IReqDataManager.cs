using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ClassLibrary_Emp_Travel;

namespace ClassLibrary_DAL
{
     public  interface IReqDataManager 
      {
        // int RaiseTravelRequest_DAL(int Emp_ID, int Req_ID, string Emp_Name, string From_Loc, string To_Loc, DateTime Req_Date);
        int RaiseTravelRequest_DAL(TravelRequest travelRequest);
        int EditTravelRequest_DAL(TravelRequest travelRequest);
        int  ViewTravelRequest_DAL();
        int DeleteTravelRequest_DAL(int Req_ID);
        int ApproveTravelRequest_DAL(int Travel_ID, ApprovedStatus appstatus);
        int ConfirmTravelRequest_DAL(int Travel_ID, BookingStatus bookstatus);
        }

    }

