<%@ Page Language="C#" MasterPageFile="~/Customer/CustomerMasterPage.master" AutoEventWireup="true" CodeFile="frmComplaints.aspx.cs" Inherits="Customer_frmComplaints" Title="Untitled Page" %>

<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
<center>
<br />
<br />
<h3>
<b style="color:Green"> REGISTER   A   COMPLAINT   AGAINST   THE   ISSUES</b>
</h3>
<br />
<br />
<fieldset style="height: 115px; width: 342px"><legend style="color:Gray"> *Enter your Complaint</legend>
<br />
<table>
<tr>
<td align="right"><b style="color:Blue"> Issue : </b></td>
<td align="left"><asp:RadioButtonList ID="RbtnIssue" runat="server" 
        RepeatDirection="Horizontal">
    <asp:ListItem>Recharge</asp:ListItem>
    <asp:ListItem>Online Bill Payment</asp:ListItem>
    </asp:RadioButtonList></td>
</tr>
<tr>
<td align="right"><b style="color:Blue">Complaint :</b></td>
<td><asp:TextBox ID="TxtComplaint" TextMode="MultiLine" runat="server"></asp:TextBox>
<asp:RequiredFieldValidator ID="RfvComplaint" ControlToValidate="TxtComplaint" Text="*" runat="server"></asp:RequiredFieldValidator>
</td>
</tr>
</table>
<br />
<asp:Button ID="BtnComplain" Text="COMPLAIN" runat="server" 
        onclick="BtnComplain_Click" />
<asp:Button ID="BtnClear" Text="CLEAR" runat="server" onclick="BtnClear_Click" />
<br />
<br />
</fieldset>
<br />
<asp:Label ID="LblMsg" Visible="false" runat="server"></asp:Label>
<br />
</center>
</asp:Content>

