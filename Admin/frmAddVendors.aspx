<%@ Page Language="C#" MasterPageFile="~/Admin/AdminMasterPage.master" AutoEventWireup="true" CodeFile="frmAddVendors.aspx.cs" Inherits="Admin_AddVendors" Title="Untitled Page" %>

<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    <center style="height: 355px">
<br />
<br />
<h3><b style="color:Green">ADD NEW VENDORS</b></h3>
<br />
<fieldset style="width: 315px; height: 161px"><legend style="color:Gray"> *Enter the new Vendor Details</legend>
<br />
<table>
<tr>
<td align="right"><b style="color:Red">Vendor Name :</b></td>
<td align="left">
<asp:TextBox id="TxtVendorName" runat="Server"></asp:TextBox>
<asp:RequiredFieldValidator id="RfvVendorName" text="*" ControlToValidate="TxtVendorName" runat="server"></asp:RequiredFieldValidator>
</td>
</tr>
<tr>
<td align="right"><b style="color:Red">Service Location :</b></td>
<td>
<asp:TextBox id="TxtServiceLocation" runat="server"></asp:TextBox>
<asp:RequiredFieldValidator id="RfvServiceLocation" ControlToValidate="TxtServiceLocation" Text="*" runat="server"></asp:RequiredFieldValidator>
</td>
</tr>
</table>
<br />
<asp:Button id="BtnAdd" text="ADD" runat="server" onclick="BtnAdd_Click" />
<asp:Button id="BtnClear" text="CLEAR" runat="server" onclick="BtnClear_Click" />
</fieldset>
<br />
<asp:Label ID="LblMsg" Visible="false" runat="server"></asp:Label>
</center>
</asp:Content>

