using System;
using System.Data;
using System.Configuration;
using System.Linq;
using System.Web;
using System.Web.Security;
using System.Web.UI;
using System.Web.UI.HtmlControls;
using System.Web.UI.WebControls;
using System.Web.UI.WebControls.WebParts;
using System.Xml.Linq;
using MobilePaymentSystem;
using System.Data.SqlClient;

/// <summary>
/// Summary description for ClsAdmin
/// </summary>
public class ClsAdmin
{
    public string Vendorname { get; set; }
    public string ServiceLocation { get; set; }
    public string MobileNo { get; set; }
    public string RechargeCard { get; set; }
    public int Validity { get; set; }
    public int Price { get; set; }
    public float TalkTime { get; set; }
    public string Status { get; set; }
    public string UserName { get; set; }
    public string Issue { get; set; }
    public string Complaint { get; set; }
	public ClsAdmin()
	{
		
	}
    public int AddVendors()
    {
        SqlParameter[] p = new SqlParameter[2];
        p[0] = new SqlParameter("@Vendorname",Vendorname);
        p[1] = new SqlParameter("@ServiceLocation",ServiceLocation);
        return (SqlHelper.ExecuteNonQuery(ClsConnection.Connectionstring, CommandType.StoredProcedure, "sp_Addvendors",p));
    }
    public DataSet GetVendors()
    {
        string str = "Select Distinct VendorName from Tbl_VendorInfo";
        return (SqlHelper.ExecuteDataset(ClsConnection.Connectionstring,CommandType.Text,str));
    }
    public DataSet GetServiceLocationsByVendor()
    {
        SqlParameter p = new SqlParameter("@VendorName",Vendorname);
        return (SqlHelper.ExecuteDataset(ClsConnection.Connectionstring, CommandType.StoredProcedure, "sp_GetServiceLocationbyVendor", p));
    }
    public int UpdateMobileNo()
    {
        SqlParameter[] p = new SqlParameter[3];
        p[0] = new SqlParameter("@VendorName",Vendorname);
        p[1] = new SqlParameter("@ServiceLocation",ServiceLocation);
        p[2] = new SqlParameter("@MobileNo",MobileNo);
        return (SqlHelper.ExecuteNonQuery(ClsConnection.Connectionstring, CommandType.StoredProcedure, "sp_UpdateMobileNofromVendor", p));
    }
    public int AddOffers()
    {
        SqlParameter []p=new SqlParameter[6];
        p[0] = new SqlParameter("@VendorName",Vendorname);
        p[1] = new SqlParameter("@ServiceLocation",ServiceLocation);
        p[2] = new SqlParameter("@RechargeCard",RechargeCard);
        p[3] = new SqlParameter("@Price",Price);
        p[4] = new SqlParameter("@TalkTime",TalkTime);
        p[5] = new SqlParameter("@Validity",Validity);
        return (SqlHelper.ExecuteNonQuery(ClsConnection.Connectionstring, CommandType.StoredProcedure, "sp_AddTopUps", p));
    }
    public DataSet UpdateOffers()
    {
        return (SqlHelper.ExecuteDataset(ClsConnection.Connectionstring, CommandType.StoredProcedure, "sp_UpdateOffers"));
    }
    public int DeleteOffer()
    {
        SqlParameter []p=new SqlParameter[3];
        p[0] = new SqlParameter("@VendorName",Vendorname);
        p[1] = new SqlParameter("@ServiceLocation",ServiceLocation);
        p[2] = new SqlParameter("@RechargeCard",RechargeCard);
        return (SqlHelper.ExecuteNonQuery(ClsConnection.Connectionstring, CommandType.StoredProcedure, "sp_DeleteOffer", p));
    }
    public int EditOffer()
    {
        SqlParameter []p=new SqlParameter[6];
        p[0] = new SqlParameter("@VendorName",Vendorname);
        p[1] = new SqlParameter("@ServiceLocation",ServiceLocation);
        p[2] = new SqlParameter("@RechargeCard",RechargeCard);
        p[3] = new SqlParameter("@TalkTime",TalkTime);
        p[4] = new SqlParameter("@Validity",Validity);
        p[5] = new SqlParameter("@Status",Status);
        return (SqlHelper.ExecuteNonQuery(ClsConnection.Connectionstring, CommandType.StoredProcedure, "sp_EditOffer", p));
    }
    public DataSet ViewComplaints()
    {
        return (SqlHelper.ExecuteDataset(ClsConnection.Connectionstring, CommandType.StoredProcedure, "sp_ViewComplaints"));
    }
    public int ChangeComplaintStatus()
    {
        SqlParameter[] p = new SqlParameter[3];
        p[0] = new SqlParameter("@UserName",UserName);
        p[1] = new SqlParameter("@Issue",Issue);
        p[2] = new SqlParameter("@Complaint",Complaint);
        return (SqlHelper.ExecuteNonQuery(ClsConnection.Connectionstring, CommandType.StoredProcedure, "sp_ChangeComplaintStatus",p));
    }
}
