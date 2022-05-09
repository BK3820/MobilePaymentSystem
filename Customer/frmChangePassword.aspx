<%@ Page Language="C#" MasterPageFile="~/Customer/CustomerMasterPage.master" AutoEventWireup="true" CodeFile="frmChangePassword.aspx.cs" Inherits="Customer_frmChangePassword" Title="Untitled Page" %>

<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
 <center>
<br />
<h3><b style="color:Green"> CHANGE PASSWORD </b></h3>
<br />
<fieldset style="height: 167px; width: 308px">
<br />
<table>
<tr>
<td align="right"><b style="color:Blue"> User Name :</b></td>
<td><asp:TextBox ID="TxtUserName" runat="server" ReadOnly="True"></asp:TextBox>
<asp:RequiredFieldValidator ID="RfvUserName" ControlToValidate="TxtUserName" Text="*" runat="server"></asp:RequiredFieldValidator>
</td>
</tr>
<tr>
<td align="right"><b style="color:Blue"> Old Password :</b></td>
<td><asp:TextBox ID="TxtPassword" TextMode="Password" runat="server"></asp:TextBox>
<asp:RequiredFieldValidator ID="RfvPassword" ControlToValidate="TxtPassword" Text="*" runat="server"></asp:RequiredFieldValidator></td>
</tr>
<tr>
<td align="right"><b style="color:Blue"> New Password :</b></td>
<td><asp:TextBox ID="TxtNewPassword" TextMode="Password" runat="server"></asp:TextBox>
<asp:RequiredFieldValidator ID="RfvNewPassword" ControlToValidate="TxtNewPassword" Text="*" runat="server"></asp:RequiredFieldValidator></td>
</tr>
<tr>
<td align="right"><b style="color:Blue"> Confirm Password :</b></td>
<td><asp:TextBox ID="TxtConfirmPassword" TextMode="Password" runat="server"></asp:TextBox>
<asp:RequiredFieldValidator ID="RfvConfirmPassword" ControlToValidate="TxtConfirmPassword" Text="*" runat="server"></asp:RequiredFieldValidator></td>
</tr>
</table>
<br />
<asp:Button ID="BtnChange" Text="CHANGE" runat="server" onclick="BtnChange_Click" />
<br />
<asp:Label ID="LblMsg" Visible="false" runat="server"></asp:Label>
</fieldset>
</center>
</asp:Content>

