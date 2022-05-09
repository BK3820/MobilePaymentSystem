using System;
using System.Collections;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.Security;
using System.Web.UI;
using System.Web.UI.HtmlControls;
using System.Web.UI.WebControls;
using System.Web.UI.WebControls.WebParts;
using System.Xml.Linq;

public partial class Customer_frmFindProviderLocation : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }
    protected void BtnFind_Click(object sender, EventArgs e)
    {
        try
        {
            ClsCustomer objFindProvider = new ClsCustomer();
            objFindProvider.MobileNo = TxtMobileNo.Text;
            DataSet ds = objFindProvider.FindProviderLocation();
            if (ds.Tables[0].Rows.Count > 0)
            {
                FstDetails.Visible = true;
                TxtProvider.Text = ds.Tables[0].Rows[0]["VendorName"].ToString();
                TxtLocation.Text = ds.Tables[0].Rows[0]["ServiceLocation"].ToString();
            }
            else
            {
                LblMsg.Visible = true;
                LblMsg.Text = "Not a valid Mobile Number";
            }
        }
        catch (Exception ex)
        {
            LblMsg.Visible = true;
            LblMsg.Text = ex.Message;
        }
    }
}
