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

public partial class Admin_frmViewComplaints : System.Web.UI.Page
{
    ClsAdmin objViewComplaints;
    protected void Page_Load(object sender, EventArgs e)
    {
        if (!IsPostBack)
        {
            ViewComplaints();
        }
    }
    public void ViewComplaints()
    {
        objViewComplaints=new ClsAdmin();
        DataSet ds = objViewComplaints.ViewComplaints();
        if (ds.Tables[0].Rows.Count > 0)
        {
            GdvViewcomplaints.DataSource = ds.Tables[0];
            GdvViewcomplaints.DataBind();
        }
        else
        {
            LblMsg.Visible = true;
            LblMsg.Text = "No records found";
        }
    }
    protected void GdvViewcomplaints_SelectedIndexChanged(object sender, EventArgs e)
    {
        objViewComplaints = new ClsAdmin();
        objViewComplaints.UserName=GdvViewcomplaints.SelectedRow.Cells[1].Text;
        objViewComplaints.Issue = GdvViewcomplaints.SelectedRow.Cells[2].Text;
        objViewComplaints.Complaint = GdvViewcomplaints.SelectedRow.Cells[3].Text;
        int i=objViewComplaints.ChangeComplaintStatus();
        if (i > 0)
        {
            LblMsg.Visible = true;
            LblMsg.Text = "Status Changed Successfully";
        }
        else
        {
            LblMsg.Visible = true;
            LblMsg.Text = "Status Not Changed Successfully...Try Again";
        }
        ViewComplaints();
    }
}
