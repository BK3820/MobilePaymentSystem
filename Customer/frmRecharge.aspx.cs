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
    ClsCustomer objcheckBank;
    protected void Page_Load(object sender, EventArgs e)
    {
    }
    protected void BtnCheck_Click(object sender, EventArgs e)
    {
        try
        {
            objcheckBank = new ClsCustomer();
            objcheckBank.MobileNo = TxtMobileNo.Text;
            objcheckBank.VendorName = Session["SelectedProvider"].ToString();
            objcheckBank.ServiceLocation = Session["SelectedLocation"].ToString();
            int i = objcheckBank.CheckMobileNo();
            if (i == 1)
            {
                if (Session["Mode"].ToString()== "PrePaid")
                {
                    FstBankDetails.Visible = true;
                    LblMsg.Visible = false;
                }
                else
                {
                    LblMsg.Visible = true;
                    LblMsg.Text = "You are not a prepaid customer";
                    TxtMobileNo.Text = "";
                }
            }
            else
            {
                LblMsg.Visible=true;
                LblMsg.Text = "Your Mobile No is not Valid for the selected provider and Service Location";
            }
        }
        catch (Exception ex)
        {
            LblMsg.Visible = true;
            LblMsg.Text = ex.Message;
        }
    }
    protected void BtnPurchase_Click(object sender, EventArgs e)
    {
        objcheckBank = new ClsCustomer();
        objcheckBank.CardNo = TxtCardNo.Text;
        objcheckBank.PinNo = TxtPinNo.Text;
        int i = objcheckBank.CheckBankDetails();
        if (i==1)
        {
            objcheckBank.RechargeCardId=Convert.ToInt32(Session["RechargeCardId"]);
            objcheckBank.UserName = Session["UserName"].ToString();
            int j = objcheckBank.InsertTransaction();
            Response.Redirect("~/Customer/frmRechargeFinish.aspx");
        }
        else
        {
            LblMsg.Text = "Your card details doesn't match.......Try again";
            LblMsg.Visible = true;
        }
    }
}
