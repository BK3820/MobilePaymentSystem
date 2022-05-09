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

public partial class Customer_frmChangePassword : System.Web.UI.Page
{
    ClsCustomer objChangePassword;
    protected void Page_Load(object sender, EventArgs e)
    {
        TxtUserName.Text = Session["UserName"].ToString();
    }
    protected void BtnChange_Click(object sender, EventArgs e)
    {
        objChangePassword = new ClsCustomer();
        try
        {
            objChangePassword.UserName = Session["UserName"].ToString();
            objChangePassword.Password = TxtPassword.Text;
            objChangePassword.NewPassword = TxtNewPassword.Text;
            int i = objChangePassword.ChangePassword();
            if (i == 1)
            {
                LblMsg.Visible = true;
                LblMsg.Text = "Your Password has been changed Successfully... ";
            }
            else if (i == 2)
            {
                LblMsg.Visible = true;
                LblMsg.Text = "Your Old Password and New Password are the same.. ";
            }
            else if (i == 3)
            {
                LblMsg.Visible = true;
                LblMsg.Text = "Password doesn't match your Login Details ";
            }
        }
        catch (Exception ex)
        {
            LblMsg.Visible = true;
            LblMsg.Text = ex.Message;
        }
    }
}
