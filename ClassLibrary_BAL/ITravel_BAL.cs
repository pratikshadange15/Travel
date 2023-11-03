using ClassLibrary_Emp_Travel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ClassLibrary_DAL;


namespace ClassLibrary_BAL
{
    public  interface ITravel_BAL
    {
        int RaiseTravelRequest_BAL(TravelRequest travelRequest);

        int EditTravelRequest_BAL(TravelRequest travelRequest);

        void ViewTravelRequest_BAL();
        
        int DeleteTravelRequest_BAL(int Req_ID);

        int ApproveTravelRequest_BAL(int Travel_ID, ApprovedStatus appstatus);
        int ConfirmTravelRequest_BAL(int Travel_ID, BookingStatus bookstatus);
       // int ViewAllRequest_BAL();

        void ViewJoinReqTable_BAL();
        void ViewAllApprovedRequest_BAL();
        void ViewAllPendingRequest_BAL();
    }
}
