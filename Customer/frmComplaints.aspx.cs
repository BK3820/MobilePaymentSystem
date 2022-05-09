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

public partial class Customer_frmComplaints : System.Web.UI.Page
{
    ClsCustomer objAddComplaint;
    protected void Page_Load(object sender, EventArgs e)
    {

    }
    protected void BtnComplain_Click(object sender, EventArgs e)
    {
        objAddComplaint = new ClsCustomer();
        objAddComplaint.UserName = Session["UserName"].ToString();
        objAddComplaint.Issue = RbtnIssue.SelectedItem.Text;
        objAddComplaint.Complaint = TxtComplaint.Text;
        int i = objAddComplaint.AddComplaint();
        if (i > 0)
        {
            LblMsg.Visible = true;
            LblMsg.Text = "Complaint Added Successfully";
        }
        else
        {
            LblMsg.Visible = true;
            LblMsg.Text = "Sorry....Try Again";
        }
    }
    protected void BtnClear_Click(object sender, EventArgs e)
    {
        TxtComplaint.Text = "";
        RbtnIssue.ClearSelection();
    }
}
