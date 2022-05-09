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

public partial class Customer_frmOnlineBillPayment : System.Web.UI.Page
{
    ClsCustomer objbillpayment;
    protected void Page_Load(object sender, EventArgs e)
    {
        objbillpayment=new ClsCustomer();
        if (!IsPostBack)
        {
            DataSet ds = objbillpayment.GetVendors();
            if (ds.Tables[0].Rows.Count > 0)
            {
                DplProvider.DataValueField = "VendorName";
                DplProvider.DataTextField = "VendorName";
                DplProvider.DataSource = ds.Tables[0];
                DplProvider.DataBind();
                DplProvider.Items.Insert(0,"Select");
            }
        }

    }
    protected void BtnPay_Click(object sender, EventArgs e)
    {
        try
        {
            objbillpayment = new ClsCustomer();
            objbillpayment.VendorName = DplProvider.SelectedItem.Text;
            objbillpayment.ServiceLocation = DplLocation.SelectedItem.Text;
            objbillpayment.MobileNo = TxtMobileNo.Text;
            int i = objbillpayment.CheckMobileNo();
            if (i == 1)
            {
                if (Session["Mode"].ToString() == "PostPaid")
                    FstBankDetails.Visible = true;
                else
                {
                    LblMsg.Visible = true;
                    LblMsg.Text = "You are not a PostPaid customer";
                    TxtMobileNo.Text = "";
                    DplLocation.Items.Clear();
                    DplProvider.SelectedIndex = 0;
                }
            }
            else
            {
                LblMsg.Visible = true;
                LblMsg.Text = "Your Mobile No is not Valid for the selected provider and Service Location";
            }

        }
        catch (Exception ex)
        {
            LblMsg.Visible = true;
            LblMsg.Text = ex.Message;
        }
    }
    protected void DplProvider_SelectedIndexChanged(object sender, EventArgs e)
    {
        objbillpayment=new ClsCustomer();
        if (DplProvider.SelectedIndex > 0)
        {
            objbillpayment.VendorName = DplProvider.SelectedItem.Text;
            DataSet ds = objbillpayment.GetServiceLocationsByVendor();
            if (ds.Tables[0].Rows.Count > 0)
            {
                DplLocation.DataValueField = "ServiceLocation";
                DplLocation.DataTextField = "ServiceLocation";
                DplLocation.DataSource = ds.Tables[0];
                DplLocation.DataBind();
                DplLocation.Items.Insert(0, "Select");
            }
        }
        else
            DplLocation.Items.Clear();
    }
    protected void BtnCheck_Click(object sender, EventArgs e)
    {
        objbillpayment = new ClsCustomer();
        objbillpayment.CardNo = TxtCardno.Text;
        objbillpayment.PinNo = TxtPinNo.Text;
        int j = objbillpayment.CheckBankDetails();
        if (j==1)
        {
            Response.Redirect("~/Customer/frmBillPaymentFinish.aspx");
        }
        else
        {
            LblMsg.Text = "Your card details doesn't match.......Try again";
            LblMsg.Visible = true;
        }
    }
}
