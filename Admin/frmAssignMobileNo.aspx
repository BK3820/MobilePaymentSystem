<%@ Page Language="C#" MasterPageFile="~/Admin/AdminMasterPage.master" AutoEventWireup="true" CodeFile="frmAssignMobileNo.aspx.cs" Inherits="Admin_frmUpdateMobileNo" Title="Untitled Page" %>

<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    <center style="height: 389px">
<br />
<br />
<h2><b style="color:Green">Assign the Mobile Numbers from Vendors</b></h2>
<br />
<fieldset style="width: 314px; height: 187px">
<legend style="color:Gray"> *Enter the Mobile number Details</legend>
<br />
<table>
<tr>
<td align="right"><b style="color:Red">Vendor Name : </b></td>
<td align="left"><asp:DropDownList id="DplVendorName" runat="server" 
        AutoPostBack="True" onselectedindexchanged="DplVendorName_SelectedIndexChanged"></asp:DropDownList></td>
</tr>
<tr>
<td align="right"><b style="color:Red">Service Location :</b></td>
<td align="left"><asp:DropDownList id="DplServiceLocation" runat="server"></asp:DropDownList></td>
</tr>
<tr>
<td align="right"><b style="color:Red">Mobile No :</b></td>
<td align="left"><asp:TextBox id="TxtMobileNo" runat="server"></asp:TextBox>
<asp:RequiredFieldValidator id="RfvMobileNo" controltovalidate="TxtMobileNo" text="*" runat="server"></asp:RequiredFieldValidator>
</td>
</tr>
</table>
<br />
<asp:Button ID="BtnUpdate" Text="UPDATE" runat="server" onclick="BtnUpdate_Click" />
<asp:Button ID="BtnClear" Text="CLEAR" runat="server" onclick="BtnClear_Click" />
</fieldset>
<br />
<asp:Label ID="LblMsg" Visible="false" runat="server"></asp:Label>
</center>
</asp:Content>

