<%@ Page Language="C#" MasterPageFile="~/Customer/CustomerMasterPage.master" AutoEventWireup="true" CodeFile="frmRecharge.aspx.cs" Inherits="Customer_frmRecharge" Title="Untitled Page" %>

<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
<center>
<br />
<h3>
<br />
<b style="color:Green"> Recharge Your Mobile</b>
</h3>
<br />
<br />
<fieldset style="width: 300px"><legend style="color:Fuchsia"> *Enter your Mobile No </legend>
<br />
<table>
<tr>
<td align="right"><b style="color:Blue"> Mobile No :</b></td>
<td align="left"><asp:TextBox ID="TxtMobileNo" runat="Server"></asp:TextBox>
<asp:RequiredFieldValidator ID="RfvMobileNo" ControlToValidate="TxtMobileNo" Text="*" runat="server"></asp:RequiredFieldValidator>
<asp:RegularExpressionValidator ID="RexpMobileNo" ControlToValidate="TxtMobileNo" 
        Text="*" runat="server" ValidationExpression="\d{10}"></asp:RegularExpressionValidator>
</td>
</tr>
</table>
<br />
<asp:Button ID="BtnCheck" Text="Check" runat="server" onclick="BtnCheck_Click" />
<br />
<br />
</fieldset>
<br />
<br />
<fieldset id="FstBankDetails" visible="false" runat="server" style="width: 300px"><legend style="color:Fuchsia"> *Enter Your Card Details</legend>
<table>
<tr>
<td align="right"><b style="color:Blue"> Card No :</b></td>
<td align="left"><asp:TextBox ID="TxtCardNo" runat="server" ValidationGroup="vg2"></asp:TextBox>
<asp:RequiredFieldValidator ID="RfvCardNo" ControlToValidate="TxtCardNo" Text="*" 
        runat="server" ValidationGroup="vg2"></asp:RequiredFieldValidator>
</td>
</tr>
<tr>
<td align="right"><b style="color:Blue"> Pin No :</b></td>
<td align="left"><asp:TextBox ID="TxtPinNo" runat="server" ValidationGroup="vg2"></asp:TextBox>
<asp:RequiredFieldValidator ID="RfvPinNo" ControlToValidate="TxtPinNo" Text="*" 
        runat="server" ValidationGroup="vg2"></asp:RequiredFieldValidator>
</td>
</tr>
</table>
<br />
<asp:Button ID="BtnPurchase" Text="Purchase" runat="server" 
        onclick="BtnPurchase_Click" ValidationGroup="vg2" />
<br />
<br />
</fieldset><br />
<asp:Label ID="LblMsg" Visible="false" runat="server"></asp:Label>
</center>
</asp:Content>

