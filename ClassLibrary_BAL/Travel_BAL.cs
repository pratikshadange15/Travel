using ClassLibrary_DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;
using ClassLibrary_Emp_Travel;


namespace ClassLibrary_BAL
{
    public class Travel_BAL : ITravel_BAL
    {
        private readonly ReqDataManager _travelData = new ReqDataManager();

        /*  public int RaiseTravelRequest_BAL(int Emp_ID, int Req_ID, string Emp_Name,string From_Loc, string To_Loc, DateTime Req_Date)
          {
              // _empData.AddEmployee_DAL(Emp_ID, Name, Emp_Contact, Emp_Address, DOB);
              _travelData.RaiseTravelRequest_DAL(Emp_ID, Req_ID, Emp_Name,From_Loc, To_Loc, Req_Date);
               return 1;
          } */
        public int RaiseTravelRequest_BAL(TravelRequest travelRequest)
        {
            _travelData.RaiseTravelRequest_DAL(travelRequest);
            return 1;
        }
        public int EditTravelRequest_BAL(TravelRequest travelRequest)
        {
            _travelData.EditTravelRequest_DAL(travelRequest);
             return 1;
        }
        public void ViewTravelRequest_BAL()
        {
            // _travelData.ViewTravelRequest_DAL();
            _travelData.ViewTravelRequest_DAL();
           // return 1;
        }
        public void ViewJoinReqTable_BAL()
        {
            _travelData.ViewJoinReqTable_DAL();
            //return 1;
        }
        public int DeleteTravelRequest_BAL(int Req_ID)
        {
           // _travelData.ViewTravelRequest_DAL();
            _travelData.DeleteTravelRequest_DAL(Req_ID);
             return 1;
        }
        public int ApproveTravelRequest_BAL(int Travel_ID, ApprovedStatus appstatus)
        {
            _travelData.ApproveTravelRequest_DAL(Travel_ID, appstatus);
            return 1;
        }
        public int ConfirmTravelRequest_BAL(int Travel_ID, BookingStatus bookstatus)
        {
            _travelData.ConfirmTravelRequest_DAL(Travel_ID, bookstatus);
            return -1;
        }

        public TravelRequest GetReqByID_BAL(int ReqID)
        {
            TravelRequest TravelReq = _travelData.GetTravelRequestByID_DAL(ReqID);
            return TravelReq;

        }
        public void ViewAllApprovedRequest_BAL()
        {
            _travelData.ViewAllApprovedRequest_DAL();
           // return 1;
        }
        public void ViewAllPendingRequest_BAL()
        {
            _travelData.ViewAllPendingRequest_DAL();
           // return 1;
        }
        
    }

}//
