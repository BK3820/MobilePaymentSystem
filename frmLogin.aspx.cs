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

public partial class frmLogin : System.Web.UI.Page
{
    ClsCustomer objLoginCheck;
    protected void Page_Load(object sender, EventArgs e)
    {

    }
    protected void LnkBtnRegister_Click(object sender, EventArgs e)
    {
        Response.Redirect("~/frmRegister.aspx");
    }
    protected void BtnLogin_Click(object sender, EventArgs e)
    {
        try
        {
            objLoginCheck = new ClsCustomer();
            objLoginCheck.UserName = TxtUserName.Text;
            objLoginCheck.Password = TxtPassword.Text;
            Session["UserName"] = TxtUserName.Text;
            DataSet ds = objLoginCheck.LoginChecking();
            if (ds.Tables[0].Rows.Count > 0)
            {
                int RoleId = Convert.ToInt32(ds.Tables[0].Rows[0]["RoleId"]);
                string Mode = ds.Tables[0].Rows[0]["Mode"].ToString();
                Session["Mode"] = Mode;
                FormsAuthentication.RedirectFromLoginPage(TxtUserName.Text, false);
                if(Request.QueryString["ReturnUrl"] ==null)
                    if (RoleId == 20)
                    {
                        Response.Redirect("~/Customer/frmCustomerHome.aspx");
                    }
                    else if (RoleId == 10)
                    {
                        Response.Redirect("~/Admin/frmAdminHome.aspx");
                    }
                    else
                    {
                        Response.Redirect("~/frmLogin.aspx");
                    }
            }
            else
            {
                LblMsg.Visible = true;
                LblMsg.Text = "Login details are not matched";
            }
        }
        catch (Exception ex)
        {
            LblMsg.Visible = true;
            LblMsg.Text = ex.Message;
        }
    }
}
