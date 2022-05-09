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

public partial class Admin_frmAddOffers : System.Web.UI.Page
{
    ClsAdmin objAddOffers;
    protected void Page_Load(object sender, EventArgs e)
    {
        if (!IsPostBack)
        {
            GetVendors();
        }
    }
    protected void DplVendorName_SelectedIndexChanged(object sender, EventArgs e)
    {
        try
        {
            if (DplVendorName.SelectedIndex > 0)
                GetServiceLocationsByVendor();
            else
            {
                LblMsg.Visible = true;
                LblMsg.Text = "Please select an Item";
            }
        }
        catch (Exception ex)
        {
            LblMsg.Visible = true;
            LblMsg.Text = ex.Message;
        }
    }
    public void GetVendors()
    {
        objAddOffers = new ClsAdmin();
        DataSet ds = objAddOffers.GetVendors();
        if (ds.Tables[0].Rows.Count > 0)
        {
            DplVendorName.DataValueField = "VendorName";
            DplVendorName.DataTextField = "VendorName";
            DplVendorName.DataSource = ds.Tables[0];
            DplVendorName.DataBind();
            DplVendorName.Items.Insert(0, "Select");
        }
        else
        {
            LblMsg.Visible = true;
            LblMsg.Text = "There are no records found";
        }
    }
    public void GetServiceLocationsByVendor()
    {
        objAddOffers = new ClsAdmin();
        objAddOffers.Vendorname = DplVendorName.SelectedItem.Text;
        DataSet ds = objAddOffers.GetServiceLocationsByVendor();
        if (ds.Tables[0].Rows.Count > 0)
        {
            DplServiceLocation.DataValueField = "ServiceLocation";
            DplServiceLocation.DataTextField = "ServiceLocation";
            DplServiceLocation.DataSource = ds.Tables[0];
            DplServiceLocation.DataBind();
            DplServiceLocation.Items.Insert(0,"Select");
        }
        else
        {
            LblMsg.Visible = true;
            LblMsg.Text = "There are no records found";
        }
    }
    public void AddOffers()
    {
        objAddOffers = new ClsAdmin();
        objAddOffers.Vendorname = DplVendorName.SelectedItem.Text;
        objAddOffers.ServiceLocation = DplServiceLocation.SelectedItem.Text;
        objAddOffers.RechargeCard = TxtRechargeCard.Text;
        objAddOffers.Price =Convert.ToInt32(TxtPrice.Text);
        objAddOffers.TalkTime = float.Parse(TxtTalkTime.Text);
        objAddOffers.Validity = Convert.ToInt32(TxtValidity.Text);
        int i = objAddOffers.AddOffers();
        if (i > 0)
        {
            LblMsg.Visible = true;
            LblMsg.Text = "Offer Inserted Successfully";
        }
        else
        {
            LblMsg.Visible = true;
            LblMsg.Text = "Insertion Failed....Try Again";
        }
    }

    protected void BtnAdd_Click(object sender, EventArgs e)
    {
        try
        {
            AddOffers();
        }
        catch(Exception ex)
        {
            LblMsg.Visible = true;
            LblMsg.Text = ex.Message;
        }
    }
    protected void BtnClear_Click(object sender, EventArgs e)
    {
        TxtRechargeCard.Text = "";
        TxtTalkTime.Text = "";
        TxtPrice.Text = "";
        TxtValidity.Text = "";
        DplVendorName.ClearSelection();
        DplServiceLocation.Items.Clear();
        LblMsg.Visible = false;
        LblMsg.Text = "";
    }
}
