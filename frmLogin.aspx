<%@ Page Language="C#" MasterPageFile="~/HomeMasterPage.master" AutoEventWireup="true" CodeFile="frmLogin.aspx.cs" Inherits="frmLogin" Title="Untitled Page" %>

<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
<center>
<br />
<h3><b style="color:Green"> LOGIN PAGE </b></h3>
<br />
<fieldset style="width: 300px"><legend style="color:Gray"> *Login Here*</legend>
<br />
<table>
<tr>
<td align="right"><b style="color:Blue"> User Name :</b></td>
<td align="left"><asp:TextBox ID="TxtUserName" runat="server"></asp:TextBox>
<asp:RequiredFieldValidator ID="RfvUserName" ControlToValidate="TxtUserName" Text="*" runat="server"></asp:RequiredFieldValidator>
</td>
</tr>
<tr>
<td align="right"><b style="color:Blue"> Password :</b></td>
<td align="left"><asp:TextBox ID="TxtPassword" TextMode="Password" runat="server"></asp:TextBox>
<asp:RequiredFieldValidator ID="RfvPassword" ControlToValidate="TxtPassword" Text="*" runat="server"></asp:RequiredFieldValidator>
</td>
</tr>
</table>
<br />
<asp:Button ID="BtnLogin" Text="LOGIN" runat="server" onclick="BtnLogin_Click" />
<br />
<br />
<asp:LinkButton ID="LnkBtnRegister" Text="New User? Register Here" runat="server" 
        onclick="LnkBtnRegister_Click" CausesValidation="False"></asp:LinkButton>
<br />
<br />
</fieldset>
<br />
<asp:Label ID="LblMsg" Visible="false" runat="server"></asp:Label>
<br />
<br />
<br />
<br />
</center>
</asp:Content>

