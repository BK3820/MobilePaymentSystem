<%@ Page Language="C#" MasterPageFile="~/Admin/AdminMasterPage.master" AutoEventWireup="true" CodeFile="frmReports.aspx.cs" Inherits="Admin_frmReports" Title="Untitled Page" %>

<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    <center>
<br />
<br />
<h3><b style="color:Green">VIEW THE CUSTOMER TRANSACTIONS </b></h3>
<br />
<br />
<fieldset style="width:300px">
<table>
<tr>
<td align="right"><b style="color:Blue">Providers :</b></td>
<td align="left">
<asp:RadioButtonList ID="RbtnLstOffers" runat="server" AutoPostBack="True" 
        RepeatColumns="2" RepeatDirection="Horizontal" 
        onselectedindexchanged="RbtnLstOffers_SelectedIndexChanged"></asp:RadioButtonList>
</td>
</tr>
</table>
</fieldset>
<br />
<br />
<fieldset id="FldStTransactions" visible="false" style="width: 300px" runat="server">
<asp:GridView ID="GdvTransactions" runat="server" AutoGenerateColumns="False" 
        CellPadding="4" ForeColor="#333333" GridLines="None">
    <FooterStyle BackColor="#507CD1" Font-Bold="True" ForeColor="White" />
    <RowStyle BackColor="#EFF3FB" />
    <Columns>
        <asp:BoundField DataField="UserName" HeaderText="User Name" />
        <asp:BoundField DataField="RechargeCard" HeaderText="Recharge Card" />
        <asp:BoundField DataField="ServiceLocation" HeaderText="Location" />
        <asp:BoundField DataField="Price" HeaderText="Price" />
        <asp:BoundField DataField="DateOfRecharge" HeaderText="Date Of Recharge" />
    </Columns>
    <PagerStyle BackColor="#2461BF" ForeColor="White" HorizontalAlign="Center" />
    <SelectedRowStyle BackColor="#D1DDF1" Font-Bold="True" ForeColor="#333333" />
    <HeaderStyle BackColor="#507CD1" Font-Bold="True" ForeColor="White" />
    <EditRowStyle BackColor="#2461BF" />
    <AlternatingRowStyle BackColor="White" />
    </asp:GridView>
</fieldset>
<br />
<br />
<asp:Label ID="LblMsg" Visible="false" runat="server"></asp:Label>
</center>
</asp:Content>

