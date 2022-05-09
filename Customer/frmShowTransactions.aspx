<%@ Page Language="C#" MasterPageFile="~/Customer/CustomerMasterPage.master" AutoEventWireup="true" CodeFile="frmShowTransactions.aspx.cs" Inherits="Customer_frmShowTransactions" Title="Untitled Page" %>

<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    <center>
<br />
<br />
<h3><b style="color:Green"> TRANSACTIONS </b></h3>
<br />
<br />
<asp:GridView ID="GdvTransactions" runat="server" AutoGenerateColumns="False" 
        CellPadding="4" ForeColor="#333333" GridLines="None">
    <FooterStyle BackColor="#507CD1" Font-Bold="True" ForeColor="White" />
    <RowStyle BackColor="#EFF3FB" />
    <Columns>
        <asp:BoundField DataField="VendorName" HeaderText="Vendor Name" />
        <asp:BoundField DataField="RechargeCard" HeaderText="Recharge Card" />
        <asp:BoundField DataField="Price" HeaderText="Price" />
        <asp:BoundField DataField="DateOfRecharge" HeaderText="Date Of Recharge" />
    </Columns>
    <PagerStyle BackColor="#2461BF" ForeColor="White" HorizontalAlign="Center" />
    <SelectedRowStyle BackColor="#D1DDF1" Font-Bold="True" ForeColor="#333333" />
    <HeaderStyle BackColor="#507CD1" Font-Bold="True" ForeColor="White" />
    <EditRowStyle BackColor="#2461BF" />
    <AlternatingRowStyle BackColor="White" />
    </asp:GridView>
    <br />
    <br />
    <asp:Label ID="LblMsg" Visible="false" runat="server"></asp:Label>
<br />
<br />
</center>
</asp:Content>

