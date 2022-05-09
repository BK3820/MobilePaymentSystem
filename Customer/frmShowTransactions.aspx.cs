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

public partial class Customer_frmShowTransactions : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        if (!IsPostBack)
        {
            DispalyTransactions();
        }
    }
    public void DispalyTransactions()
    {
        ClsCustomer objShowTransaction = new ClsCustomer();
        objShowTransaction.UserName = Session["UserName"].ToString();
        DataSet ds = objShowTransaction.DisplayTransactions();
        if (ds.Tables[0].Rows.Count > 0)
        {
            GdvTransactions.DataSource = ds.Tables[0];
            GdvTransactions.DataBind();
        }
        else
        {
            LblMsg.Visible = true;
            LblMsg.Text = "No Transactions were made by you.....";
        }
    }
}
