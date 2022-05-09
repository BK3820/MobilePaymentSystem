<%@ Page Language="C#" MasterPageFile="~/Admin/AdminMasterPage.master" AutoEventWireup="true" CodeFile="frmViewComplaints.aspx.cs" Inherits="Admin_frmViewComplaints" Title="Untitled Page" %>

<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
<center>
<br />
<h3><b style="color:Green"> VIEW THE COMPLAINTS FROM CUSTOMERS </b></h3>
<br />
<fieldset style="width: 300px">
<asp:GridView ID="GdvViewcomplaints" runat="server" AutoGenerateColumns="False" 
        CellPadding="4" ForeColor="#333333" GridLines="None" Width="300px" 
        onselectedindexchanged="GdvViewcomplaints_SelectedIndexChanged" >
    <FooterStyle BackColor="#507CD1" Font-Bold="True" ForeColor="White" />
    <RowStyle BackColor="#EFF3FB" />
    <Columns>
        <asp:CommandField SelectText="VIEW" ShowSelectButton="True" />
        <asp:BoundField DataField="UserName" HeaderText="User Name" />
        <asp:BoundField DataField="Issue" HeaderText="Issue" />
        <asp:BoundField DataField="Complaint" HeaderText="Complaint" />
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
<br />
<br />
</center>
</asp:Content>

