<%@ Page Language="C#" MasterPageFile="~/Admin/AdminMasterPage.master" AutoEventWireup="true" CodeFile="frmAddOffers.aspx.cs" Inherits="Admin_frmAddOffers" Title="Untitled Page" %>

<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
<center>
<br />
<br />
<h3>
<b style="color:Green">ADD NEW OFFERS </b>
</h3>
<br />
<fieldset style="width: 395px">
<br />
<table>
<tr>
<td align="right"><b style="color:Blue">Vendor Name :</b></td>
<td align="left"><asp:DropDownList ID="DplVendorName" runat="server" 
        AutoPostBack="True" 
        onselectedindexchanged="DplVendorName_SelectedIndexChanged"></asp:DropDownList>
<asp:RequiredFieldValidator ID="RfvVendorName" ControlToValidate="DplVendorName" 
        Text="*" runat="server" InitialValue="Select"></asp:RequiredFieldValidator>
</td>
</tr>
<tr>
<td align="right"><b style="color:Blue">Service Location :</b></td>
<td align="left"><asp:DropDownList ID="DplServiceLocation" runat="server"></asp:DropDownList>
<asp:RequiredFieldValidator ID="RfvServiceLocation" 
        ControlToValidate="DplServiceLocation" Text="*" runat="server" 
        InitialValue="Select"></asp:RequiredFieldValidator>
</td>
</tr>
<tr>
<td align="right"><b style="color:Blue">Recharge Card :</b></td>
<td align="left"><asp:TextBox ID="TxtRechargeCard" runat="server"></asp:TextBox>
<asp:RequiredFieldValidator ID="RfvRechargeCard" ControlToValidate="TxtRechargeCard" Text="*" runat="server"></asp:RequiredFieldValidator>
</td>
</tr>
<tr>
<td align="right"><b style="color:Blue"> Price :</b></td>
<td align="left"><asp:TextBox ID="TxtPrice" runat="server"></asp:TextBox>
<asp:RequiredFieldValidator ID="RfvPrice" ControlToValidate="TxtPrice" Text="*" runat="server"></asp:RequiredFieldValidator>
</td>
</tr>
<tr>
<td align="right"><b style="color:Blue"> TalkTime :</b></td>
<td align="left"><asp:TextBox ID="TxtTalkTime" runat="server"></asp:TextBox>
<asp:RequiredFieldValidator ID="RfvTalkTime" ControlToValidate="TxtTalkTime" Text="*" runat="server"></asp:RequiredFieldValidator>
</td>
</tr>
<tr>
<td align="right"><b style="color:Blue"> Validity :</b></td>
<td align="left"><asp:TextBox ID="TxtValidity" runat="server"></asp:TextBox>
<asp:RequiredFieldValidator ID="RfvValidity" ControlToValidate="TxtValidity" Text="*" runat="server"></asp:RequiredFieldValidator>
</td>
</tr>
</table>
<br />
<asp:Button ID="BtnAdd" Text="ADD" runat="server" onclick="BtnAdd_Click" />
<asp:Button ID="BtnClear" Text="CLEAR" runat="server" onclick="BtnClear_Click" />
<br />
<br />
</fieldset>
<br />
<asp:Label ID="LblMsg" Visible="false" runat="server"></asp:Label>
</center>
</asp:Content>

