<%@ Page Language="C#" MasterPageFile="~/Customer/CustomerMasterPage.master" AutoEventWireup="true" CodeFile="frmFindProviderLocation.aspx.cs" Inherits="Customer_frmFindProviderLocation" Title="Untitled Page" %>

<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    <center>
<br />
<br />
<h3><b style="color:Green"> FIND SERVICE PROVIDER AND LOCATION </b></h3>
<br />
<br />
<fieldset style="width: 300px"><legend style="color:Fuchsia"> *Enter The Mobile No</legend>
<br />
<table>
<tr>
<td align="right"><b style="color:Blue"> Mobile No :</b></td>
<td align="left"><asp:TextBox ID="TxtMobileNo" runat="server"></asp:TextBox>
<asp:RequiredFieldValidator ID="RfvMobileNo" ControlToValidate="TxtMobileNo" Text="*" runat="server"></asp:RequiredFieldValidator>
<asp:RegularExpressionValidator ID="RexpMobileNo" ControlToValidate="TxtMobileNo" 
        Text="*" runat="server" ValidationExpression="\d{10}"></asp:RegularExpressionValidator>
</td>
</tr>
</table>
<br />
<asp:Button ID="BtnFind" Text="FIND" runat="server" onclick="BtnFind_Click" />
<br />
<br />
</fieldset>
<br />
<br />
<fieldset style="width: 300px" id="FstDetails" visible="false" runat="server">
<legend style="color:Fuchsia"> *Provider and Location Details</legend>
<br />
<table>
<tr>
<td align="right"><b style="color:Blue">Provider Name :</b></td>
<td align="left"><asp:TextBox ID="TxtProvider" ReadOnly="true" runat="server"></asp:TextBox></td>
</tr>
<tr>
<td align="right"><b style="color:Blue">Service location :</b></td>
<td align="left"><asp:TextBox ID="TxtLocation" ReadOnly="true" runat="server"></asp:TextBox></td>
</tr>
</table>
</fieldset>
<br />
<br />
<asp:Label ID="LblMsg" Visible="false" runat="server"></asp:Label>
<br />
<br />
</center>
</asp:Content>

