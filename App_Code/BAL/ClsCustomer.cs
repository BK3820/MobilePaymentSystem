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
/// Summary description for ClsCustomer
/// </summary>
public class ClsCustomer
{
    public string FName { get; set; }
    public string LName { get; set; }
    public string DOB { get; set; }
    public string EmailId { get; set; }
    public string Address { get; set; }
    public string Country { get; set; }
    public string State { get; set; }
    public string UserName { get; set; }
    public string Password { get; set; }
    public string NewPassword { get; set; }
    public string HintQuestion { get; set; }
    public string Answer { get; set; }
    public string VendorName { get; set; }
    public string ServiceLocation { get; set; }
    public string Mode { get; set; }
    public string MobileNo { get; set; }
    public string Issue { get; set; }
    public string Complaint { get; set; }
    public string CardNo { get; set; }
    public string PinNo { get; set; }
    public int RechargeCardId { get; set; }
    public ClsCustomer()
	{
		
	}
    public int RegisterUser()
    {
        SqlParameter []p=new SqlParameter[15];
        p[0] = new SqlParameter("@FName",FName);
        p[1] = new SqlParameter("@LName",LName);
        p[2] = new SqlParameter("@DOB",DOB);
        p[3] = new SqlParameter("@EmailId",EmailId);
        p[4] = new SqlParameter("@Address",Address);
        p[5] = new SqlParameter("@Country",Country);
        p[6] = new SqlParameter("@State",State);
        p[7] = new SqlParameter("@UserName",UserName);
        p[8] = new SqlParameter("@Password",Password);
        p[9] = new SqlParameter("@HintQuestion",HintQuestion);
        p[10] = new SqlParameter("@Answer",Answer);
        p[11] = new SqlParameter("@VendorName",VendorName);
        p[12] = new SqlParameter("@ServiceLocation",ServiceLocation);
        p[13] = new SqlParameter("@Mode",Mode);
        p[14] = new SqlParameter("@MobileNo",MobileNo);
        return (SqlHelper.ExecuteNonQuery(ClsConnection.Connectionstring, CommandType.StoredProcedure, "sp_RegisterUser", p));
    }
    public DataSet GetVendors()
    {
        string str = "Select Distinct VendorName from Tbl_VendorInfo";
        return (SqlHelper.ExecuteDataset(ClsConnection.Connectionstring, CommandType.Text, str));
    }
    public DataSet GetServiceLocationsByVendor()
    {
        SqlParameter p = new SqlParameter("@VendorName",VendorName);
        return (SqlHelper.ExecuteDataset(ClsConnection.Connectionstring, CommandType.StoredProcedure, "sp_GetServiceLocationbyVendor", p));
    }
    public DataSet LoginChecking()
    {
        SqlParameter []p=new SqlParameter[2];
        p[0] = new SqlParameter("@UserName",UserName);
        p[1] = new SqlParameter("@Password",Password);
        return (SqlHelper.ExecuteDataset(ClsConnection.Connectionstring, CommandType.StoredProcedure, "sp_LoginChecking",p));
    }
    public int AddComplaint()
    {
        SqlParameter[] p = new SqlParameter[3];
        p[0] = new SqlParameter("@UserName",UserName);
        p[1] = new SqlParameter("@Issue", Issue);
        p[2] = new SqlParameter("@Complaint",Complaint);
        return (SqlHelper.ExecuteNonQuery(ClsConnection.Connectionstring, CommandType.StoredProcedure, "sp_AddComplaint", p)); 
    }
    public DataSet getTopups()
    {
        SqlParameter []p=new SqlParameter[2];
        p[0] = new SqlParameter("@VendorName",VendorName);
        p[1] = new SqlParameter("@ServiceLocation",ServiceLocation);
        return (SqlHelper.ExecuteDataset(ClsConnection.Connectionstring, CommandType.StoredProcedure, "sp_GetTopups", p));
    }
    public int CheckMobileNo()
    {
        SqlParameter []p=new SqlParameter[4];
        p[0] = new SqlParameter("@MobileNo",MobileNo);
        p[1] = new SqlParameter("@VendorName",VendorName);
        p[2] = new SqlParameter("@ServiceLocation",ServiceLocation);
        p[3] = new SqlParameter("@Flag",SqlDbType.Int);
        p[3].Direction = ParameterDirection.Output;
        SqlHelper.ExecuteNonQuery(ClsConnection.Connectionstring, CommandType.StoredProcedure, "sp_checkMobileNo", p);
        return Convert.ToInt32(p[3].Value);
    }
    public int CheckBankDetails()
    {
        SqlParameter []p=new SqlParameter[3];
        p[0] = new SqlParameter("@CardNo",CardNo);
        p[1] = new SqlParameter("@PinNo",PinNo);
        p[2] = new SqlParameter("@Flag",SqlDbType.Int);
        p[2].Direction = ParameterDirection.Output;
        SqlHelper.ExecuteNonQuery(ClsConnection.Connectionstring, CommandType.StoredProcedure, "sp_CheckBankDetails", p);
        return (Convert.ToInt32(p[2].Value));
    }
    public int ChangePassword()
    {
        SqlParameter []p=new SqlParameter[4];
        p[0] = new SqlParameter("@UserName",UserName);
        p[1] = new SqlParameter("@OldPassWord",Password);
        p[2] = new SqlParameter("@NewPassWord",NewPassword);
        p[3] = new SqlParameter("@Result",SqlDbType.Int);
        p[3].Direction = ParameterDirection.Output;
        SqlHelper.ExecuteNonQuery(ClsConnection.Connectionstring, CommandType.StoredProcedure, "sp_ChangePassword", p);
        return(Convert.ToInt32(p[3].Value));
    }
    public DataSet FindProviderLocation()
    {
        SqlParameter p = new SqlParameter("@MobileNo",MobileNo);
        return (SqlHelper.ExecuteDataset(ClsConnection.Connectionstring, CommandType.StoredProcedure, "sp_FindProviderAndLocation", p));
    }
    public int InsertTransaction()
    {
        SqlParameter[] p = new SqlParameter[2];
        p[0] = new SqlParameter("@RechargeCardId",RechargeCardId);
        p[1]=new SqlParameter("@UserName",UserName);
        return (SqlHelper.ExecuteNonQuery(ClsConnection.Connectionstring, CommandType.StoredProcedure, "sp_Transaction", p));
    }
    public DataSet DisplayTransactions()
    {
        SqlParameter p = new SqlParameter("@UserName",UserName);
        return (SqlHelper.ExecuteDataset(ClsConnection.Connectionstring, CommandType.StoredProcedure, "sp_DisplayTransactions", p));
    }
    public DataSet GetAllOffers()
    {
        SqlParameter p = new SqlParameter("@VendorName",VendorName);
        return (SqlHelper.ExecuteDataset(ClsConnection.Connectionstring, CommandType.StoredProcedure, "sp_GetAllOffers", p));
    }
    public DataSet GetReports()
    {
        SqlParameter p = new SqlParameter("@VendorName",VendorName);
        return (SqlHelper.ExecuteDataset(ClsConnection.Connectionstring, CommandType.StoredProcedure, "sp_Report", p));
    }
}
