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

public partial class frmRegister : System.Web.UI.Page
{
    ClsCustomer objRegisterUser;
    protected void Page_Load(object sender, EventArgs e)
    {
        if (!IsPostBack)
        {
            GetVendors();
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

    protected void BtnRegister_Click(object sender, EventArgs e)
    {
        try
        {
            registerUser();
        }
        catch (Exception ex)
        {
            LblMsg.Visible = true;
            LblMsg.Text = ex.Message;
        }
    }
    public void registerUser()
    {
        objRegisterUser = new ClsCustomer();
        objRegisterUser.FName = TxtFName.Text;
        objRegisterUser.LName = TxtLName.Text;
        objRegisterUser.DOB = TxtDOB.Text;
        objRegisterUser.EmailId = TxtEmailId.Text;
        objRegisterUser.Address = TxtAddress.Text;
        objRegisterUser.State = TxtState.Text;
        objRegisterUser.Country = TxtCountry.Text;
        objRegisterUser.UserName = TxtUserName.Text;
        objRegisterUser.Password = TxtPassword.Text;
        objRegisterUser.HintQuestion = DplHintQ.SelectedItem.Text;
        objRegisterUser.Answer = TxtAnswer.Text;
        objRegisterUser.VendorName = DplVendorName.SelectedItem.Text;
        objRegisterUser.ServiceLocation = DplServiceLocation.SelectedItem.Text;
        objRegisterUser.Mode = RbtnMode.SelectedItem.Text;
        objRegisterUser.MobileNo = TxtMobileNo.Text;
        int i = objRegisterUser.RegisterUser();
        if (i > 0)
        {
            LblMsg.Visible = true;
            LblMsg.Text = "You Have Been registered Successfully";
        }
        else
        {
            LblMsg.Visible = true;
            LblMsg.Text = "Sorry....Try Again";
        }
        clear();
    }
    public void GetVendors()
    {
        objRegisterUser = new ClsCustomer();
        DataSet ds = objRegisterUser.GetVendors();
        if (ds.Tables[0].Rows.Count > 0)
        {
            DplVendorName.DataValueField = "VendorName";
            DplVendorName.DataTextField = "VendorName";
            DplVendorName.DataSource = ds.Tables[0];
            DplVendorName.DataBind();
            DplVendorName.Items.Insert(0, "Select");
        }
    }
    public void GetServiceLocationByVendor()
    {
        objRegisterUser = new ClsCustomer();
        objRegisterUser.VendorName = DplVendorName.SelectedItem.Text;
        DataSet ds = objRegisterUser.GetServiceLocationsByVendor();
        if (ds.Tables[0].Rows.Count > 0)
        {
            DplServiceLocation.DataValueField = "ServiceLocation";
            DplServiceLocation.DataTextField = "ServiceLocation";
            DplServiceLocation.DataSource = ds.Tables[0];
            DplServiceLocation.DataBind();
            DplServiceLocation.Items.Insert(0, "Select");
        }
    }
    public void clear()
    {
        objRegisterUser = new ClsCustomer();
        TxtFName.Text="";
        TxtLName.Text = "";
        TxtDOB.Text = "";
        TxtEmailId.Text = "";
        TxtAddress.Text = "";
        TxtState.Text = "";
        TxtCountry.Text = "";
        TxtUserName.Text = "";
        TxtPassword.Text = "";
        TxtAnswer.Text = "";
        DplHintQ.SelectedIndex = 0;
        DplVendorName.SelectedIndex = 0;
        DplServiceLocation.Items.Clear();
        RbtnMode.ClearSelection();
        TxtMobileNo.Text = "";
    }
}