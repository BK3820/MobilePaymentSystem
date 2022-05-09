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

public partial class Admin_frmUpdateMobileNo : System.Web.UI.Page
{
    ClsAdmin objUpdatemobileNo;
    protected void Page_Load(object sender, EventArgs e)
    {
        try
        {
            if (!IsPostBack)
            {
                GetVendors();
            }
        }
        catch (Exception ex)
        {
            LblMsg.Visible = true;
            LblMsg.Text = ex.Message;
        }
    }
    protected void BtnUpdate_Click(object sender, EventArgs e)
    {
        objUpdatemobileNo = new ClsAdmin();
        objUpdatemobileNo.Vendorname = DplVendorName.SelectedItem.Text;
        objUpdatemobileNo.ServiceLocation = DplServiceLocation.SelectedItem.Text;
        objUpdatemobileNo.MobileNo = TxtMobileNo.Text;
        int i = objUpdatemobileNo.UpdateMobileNo();
        if (i > 0)
        {
            LblMsg.Visible = true;
            LblMsg.Text = "Mobile No updated Successfully";
        }
        else
        {
            LblMsg.Visible = true;
            LblMsg.Text = "Mobile No updation Failed...Try Again";
        }
     }
    public void GetVendors()
    {
        objUpdatemobileNo = new ClsAdmin();
        DataSet ds = objUpdatemobileNo.GetVendors();
        if (ds.Tables[0].Rows.Count > 0)
        {
            DplVendorName.DataValueField = "VendorName";
            DplVendorName.DataTextField = "VendorName";
            DplVendorName.DataSource = ds.Tables[0];
            DplVendorName.DataBind();
            DplVendorName.Items.Insert(0,"Select");
        }
    }
    public void GetServiceLocationByVendor()
    {
        objUpdatemobileNo = new ClsAdmin();
        objUpdatemobileNo.Vendorname = DplVendorName.SelectedItem.Text;
        DataSet ds = objUpdatemobileNo.GetServiceLocationsByVendor();
        if (ds.Tables[0].Rows.Count > 0)
        {
            DplServiceLocation.DataValueField = "ServiceLocation";
            DplServiceLocation.DataTextField = "ServiceLocation";
            DplServiceLocation.DataSource = ds.Tables[0];
            DplServiceLocation.DataBind();
            DplServiceLocation.Items.Insert(0, "Select");
        }
    }
    protected void DplVendorName_SelectedIndexChanged(object sender, EventArgs e)
    {
        if (DplVendorName.SelectedIndex > 0)
        {
            GetServiceLocationByVendor();
        }
        else
            DplServiceLocation.Items.Clear();
    }
    protected void BtnClear_Click(object sender, EventArgs e)
    {
        TxtMobileNo.Text = "";
        DplServiceLocation.SelectedIndex = 0;
        DplVendorName.SelectedIndex = 0;
        LblMsg.Text = "";
        LblMsg.Visible = true;
        DplServiceLocation.Items.Clear();
    }
}
