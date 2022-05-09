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

public partial class Customer_frmRecharge : System.Web.UI.Page
{
    ClsCustomer objRecharge;
    protected void Page_Load(object sender, EventArgs e)
    {
        if (!IsPostBack)
            GetVendors();
    }
    public void GetVendors()
    {
        objRecharge = new ClsCustomer();
        DataSet ds = objRecharge.GetVendors();
        if (ds.Tables[0].Rows.Count > 0)
        {
            DplProvider.DataValueField = "VendorName";
            DplProvider.DataTextField = "VendorName";
            DplProvider.DataSource = ds.Tables[0];
            DplProvider.DataBind();
            DplProvider.Items.Insert(0, "Select");
        }
     }
    public bool show1(object Status)
    {
        if (Status.ToString() == "Buy Now")
            return true;
        return false;
    }
    public bool show2(object Status)
    {
        if (Status.ToString() == "Out Of Stock")
            return true;
        return false;
    }
       protected void DplProvider_SelectedIndexChanged(object sender, EventArgs e)
    {
        objRecharge = new ClsCustomer();
        if (DplProvider.SelectedIndex > 0)
        {
            objRecharge.VendorName = DplProvider.SelectedItem.Text;
            DataSet ds=objRecharge.GetServiceLocationsByVendor();
            if (ds.Tables[0].Rows.Count > 0)
            {
                DplLocation.DataValueField = "ServiceLocation";
                DplLocation.DataTextField = "ServiceLocation";
                DplLocation.DataSource = ds.Tables[0];
                DplLocation.DataBind();
                DplLocation.Items.Insert(0, "Select");
            }
            else
            {
                LblMsg.Visible = true;
                LblMsg.Text = "Please select an item from the list";
            }
        }
        else
            DplLocation.Items.Clear();
    }
       protected void DplLocation_SelectedIndexChanged(object sender, EventArgs e)
       {
           objRecharge = new ClsCustomer();
           objRecharge.VendorName = DplProvider.SelectedItem.Text;
           objRecharge.ServiceLocation = DplLocation.SelectedItem.Text;
           Session["SelectedProvider"] = DplProvider.SelectedItem.Text;
           Session["SelectedLocation"] = DplLocation.SelectedItem.Text;
           DataSet ds = objRecharge.getTopups();
           if (ds.Tables[0].Rows.Count > 0)
           {
               FstTopups.Visible = true;
               GdvTopups.DataSource = ds.Tables[0];
               GdvTopups.DataBind();
               //GdvTopups.Columns[0].Visible = false;
           }
       }
       protected void GdvTopups_RowCommand(object sender, GridViewCommandEventArgs e)
       {
           Session["RechargeCardId"] = e.CommandArgument.ToString();
           Response.Redirect("~/Customer/frmRecharge.aspx");
       }
       protected void GdvTopups_SelectedIndexChanging(object sender, GridViewSelectEventArgs e)
       {
           Session["TopUpcard"] = GdvTopups.SelectedRow.Cells[0].Text;
            Session["TopupPrice"] =Convert.ToInt32(GdvTopups.SelectedRow.Cells[1].Text);
               Response.Redirect("~/Customer/frmRecharge.aspx");
           
       }
}

