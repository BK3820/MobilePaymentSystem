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

public partial class Admin_frmUpdateOffers : System.Web.UI.Page
{
    ClsAdmin objUpdateOffers;
    protected void Page_Load(object sender, EventArgs e)
    {
        if (!IsPostBack)
        {
            UpdateOffers();
        }
    }
    protected void GdvUpdateOffers_RowEditing(object sender, GridViewEditEventArgs e)
    {
        try
        {
            LblMsg.Visible = false;
            LblMsg.Text = "";
            FldstUpdate.Visible = true;
            Session["EditVendorName"] = GdvUpdateOffers.Rows[e.NewEditIndex].Cells[1].Text;
            Session["EditServiceLocation"] = GdvUpdateOffers.Rows[e.NewEditIndex].Cells[2].Text;
            Session["EditRechargeCard"] = GdvUpdateOffers.Rows[e.NewEditIndex].Cells[3].Text;
            TxtTalktime.Text=GdvUpdateOffers.Rows[e.NewEditIndex].Cells[5].Text;
            TxtValidity.Text = GdvUpdateOffers.Rows[e.NewEditIndex].Cells[6].Text;
            RbtnStatus.ClearSelection();
        }
        catch (Exception ex)
        {
            LblMsg.Visible = true;
            LblMsg.Text = ex.Message;
        }
    }
    protected void GdvUpdateOffers_RowDeleting(object sender, GridViewDeleteEventArgs e)
    {
        try
        {
            objUpdateOffers = new ClsAdmin();
            objUpdateOffers.Vendorname = GdvUpdateOffers.Rows[e.RowIndex].Cells[1].Text;
            objUpdateOffers.ServiceLocation = GdvUpdateOffers.Rows[e.RowIndex].Cells[2].Text;
            objUpdateOffers.RechargeCard = GdvUpdateOffers.Rows[e.RowIndex].Cells[3].Text;
            int i = objUpdateOffers.DeleteOffer();
            if (i > 0)
            {
                LblMsg.Visible = true;
                LblMsg.Text = "Offer Deleted Successfully";
            }
            else
            {
                LblMsg.Visible = true;
                LblMsg.Text = "Offer Deletion Failed...Try Again";
            }
            UpdateOffers();
        }
        catch (Exception ex)
        {
            LblMsg.Visible = true;
            LblMsg.Text = ex.Message;
        }
    }
    protected void BtnUpdate_Click(object sender, EventArgs e)
    {
        try
        {
            EditOffer();
            FldstUpdate.Visible = false;
        }
        catch(Exception ex)
        {
            LblMsg.Visible = true;
            LblMsg.Text = ex.Message;
        }

    }
    public void UpdateOffers()
    {
        objUpdateOffers = new ClsAdmin();
        DataSet ds = objUpdateOffers.UpdateOffers();
        if (ds.Tables[0].Rows.Count > 0)
        {
            GdvUpdateOffers.DataSource = ds.Tables[0];
            GdvUpdateOffers.DataBind();
        }
        else
        {
            LblMsg.Visible = true;
            LblMsg.Text = "No Records Found";
        }
    }
    public void EditOffer()
    {
        objUpdateOffers = new ClsAdmin();
        objUpdateOffers.Vendorname=Session["EditVendorName"].ToString();
        objUpdateOffers.ServiceLocation=Session["EditServiceLocation"].ToString();
        objUpdateOffers.RechargeCard=Session["EditRechargeCard"].ToString();
        objUpdateOffers.TalkTime =float.Parse(TxtTalktime.Text);
        objUpdateOffers.Validity =Convert.ToInt32(TxtValidity.Text);
        objUpdateOffers.Status = RbtnStatus.SelectedItem.Text;
        int i = objUpdateOffers.EditOffer();
        if (i > 0)
        {
            LblMsg.Visible = true;
            LblMsg.Text = "Offer Edited Successfully";
        }
        else
        {
            LblMsg.Visible = true;
            LblMsg.Text = "Offer Editing failed.....Try Again";
        
        }
    }

   
}
