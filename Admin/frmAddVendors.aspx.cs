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

public partial class Admin_AddVendors : System.Web.UI.Page
{
    ClsAdmin objAddvendors = new ClsAdmin();
    protected void Page_Load(object sender, EventArgs e)
    {

    }
    protected void BtnAdd_Click(object sender, EventArgs e)
    {
        objAddvendors.Vendorname = TxtVendorName.Text;
        objAddvendors.ServiceLocation = TxtServiceLocation.Text;
        int i = objAddvendors.AddVendors();
        if (i > 0)
        {
            LblMsg.Visible = true;
            LblMsg.Text = "Vendor Added Successfully";
        }
        else
        {
            LblMsg.Visible = true;
            LblMsg.Text = "Sorry...Insertion Failed..Try Again";
        }
    }
    protected void BtnClear_Click(object sender, EventArgs e)
    {
        TxtVendorName.Text = "";
        TxtServiceLocation.Text = "";
        LblMsg.Text = "";
        LblMsg.Visible = false;
    }
}
