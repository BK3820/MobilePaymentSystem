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

public partial class frmOffers : System.Web.UI.Page
{
    ClsCustomer objViewOffers;
    protected void Page_Load(object sender, EventArgs e)
    {
        if (!IsPostBack)
        {
            ViewProviders();
        }
    }
    public void ViewProviders()
    {
        objViewOffers = new ClsCustomer();
        DataSet ds=objViewOffers.GetVendors();
        if (ds.Tables[0].Rows.Count > 0)
        {
            RbtnLstOffers.DataValueField = "VendorName";
            RbtnLstOffers.DataTextField = "VendorName";
            RbtnLstOffers.DataSource = ds.Tables[0];
            RbtnLstOffers.DataBind();
        }
    }
    public void ViewOffers()
    {
        objViewOffers = new ClsCustomer();
        objViewOffers.VendorName = RbtnLstOffers.SelectedItem.Text;
        DataSet ds = objViewOffers.GetAllOffers();
        if (ds.Tables[0].Rows.Count > 0)
        {
            FldStOffers.Visible = true;
            GdvOffers.DataSource = ds.Tables[0];
            GdvOffers.DataBind();
            LblMsg.Visible = false;
        }
        else
        {
            FldStOffers.Visible = false;
            LblMsg.Visible = true;
            LblMsg.Text = "No Records were found";           
        }
    }
    protected void RbtnLstOffers_SelectedIndexChanged(object sender, EventArgs e)
    {
        ViewOffers();
    }
}
