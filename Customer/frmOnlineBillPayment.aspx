<%@ Page Language="C#" MasterPageFile="~/Customer/CustomerMasterPage.master" AutoEventWireup="true" CodeFile="frmOnlineBillPayment.aspx.cs" Inherits="Customer_frmOnlineBillPayment" Title="Untitled Page" %>

<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
<center>
<br />
<br />
<h3>
<b style="color:Green">PAY YOUR MOBILE BILL ONLINE </b>
</h3>
<br />
<br />
<fieldset style="width: 300px"><legend style="color:Fuchsia"> *Enter your Mobile No </legend>
<br />
<table>
<tr>
<td align="right"><b style="color:Blue"> Provider :</b></td>
<td align="left"><asp:DropDownList ID="DplProvider" runat="server" 
        AutoPostBack="True" onselectedindexchanged="DplProvider_SelectedIndexChanged"></asp:DropDownList></td>
</tr>
<tr>
<td align="right"><b style="color:Blue"> Location :</b></td>
<td align="left"><asp:DropDownList ID="DplLocation" runat="server" 
        AutoPostBack="True"></asp:DropDownList></td>
</tr>
<tr>
<td align="right"><b style="color:Blue"> Mobile No :</b></td>
<td align="left"><asp:TextBox ID="TxtMobileNo" runat="server"></asp:TextBox>
<asp:RequiredFieldValidator ID="RfvMobileNo" ControlToValidate="TxtMobileNo" runat="server" Text="*"></asp:RequiredFieldValidator>
<asp:RegularExpressionValidator ID="RexpMobileNo" ControlToValidate="TxtMobileNo" 
        Text="*" runat="server" ValidationExpression="\d{10}"></asp:RegularExpressionValidator>
</td>
</tr>
</table>
<br />
<asp:Button ID="BtnPay" Text="Pay Bill" runat="server" onclick="BtnPay_Click" />
<br />
<br />
</fieldset>
<br />
<br />
<fieldset style="width:300px" id="FstBankDetails" visible="false" runat="server"><legend style="color:Fuchsia"> *Enter your Card Details</legend>
<br />
<table>
<tr>
<td align="right"><b style="color:Blue"> Card No :</b></td>
<td align="left"><asp:TextBox ID="TxtCardno" runat="server"></asp:TextBox>
<asp:RequiredFieldValidator ID="RfvCardno" ControlToValidate="TxtCardno" Text="*" runat="server"></asp:RequiredFieldValidator>
</td>
</tr>
<tr>
<td align="right"><b style="color:Blue"> Pin No :</b></td>
<td align="left"><asp:TextBox ID="TxtPinNo" runat="server"></asp:TextBox>
<asp:RequiredFieldValidator ID="RfvPinNo" ControlToValidate="TxtpinNo" Text="*" runat="server"></asp:RequiredFieldValidator>
</td>
</tr>
</table>
<br />
<asp:Button ID="BtnCheck" Text="CHECK" runat="server" onclick="BtnCheck_Click" />
<br />
<br />
</fieldset>
<br />
<br />
<asp:Label ID="LblMsg" Visible="false" runat="server"></asp:Label>
<br />
<br />
</center>
</asp:Content>

