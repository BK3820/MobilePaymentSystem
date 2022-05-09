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

public partial class Admin_frmReports : System.Web.UI.Page
{
    ClsCustomer objReports;
    protected void Page_Load(object sender, EventArgs e)
    {
        if (!IsPostBack)
            ViewProviders();
    }
    public void ViewProviders()
    {
        objReports= new ClsCustomer();
        DataSet ds =objReports.GetVendors();
        if (ds.Tables[0].Rows.Count > 0)
        {
            RbtnLstOffers.DataValueField = "VendorName";
            RbtnLstOffers.DataTextField = "VendorName";
            RbtnLstOffers.DataSource = ds.Tables[0];
            RbtnLstOffers.DataBind();
         }
    }
    public void ViewReport()
    {
        objReports = new ClsCustomer();
        objReports.VendorName = RbtnLstOffers.SelectedItem.Text;
        DataSet ds = objReports.GetReports();
        if (ds.Tables[0].Rows.Count > 0)
        {
            FldStTransactions.Visible = true;
            GdvTransactions.DataSource = ds.Tables[0];
            GdvTransactions.DataBind();
            LblMsg.Visible = false;
        }
        else
        {
            FldStTransactions.Visible = false;
            LblMsg.Text = "No Transactions were made";
            LblMsg.Visible = true;
        }
    }
    protected void RbtnLstOffers_SelectedIndexChanged(object sender, EventArgs e)
    {
        ViewReport();
    }
}
