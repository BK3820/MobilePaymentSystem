<%@ Page Language="C#" MasterPageFile="~/HomeMasterPage.master" AutoEventWireup="true" CodeFile="frmOffers.aspx.cs" Inherits="frmOffers" Title="Untitled Page" %>

<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
<center>
<br />
<br />
<h3><b style="color:Green"> VIEW THE OFFERS PROVIDED BY DIFFERENT PROVIDERS</b></h3>
<br />
<br />
<fieldset style="width: 300px"><legend style="color:Fuchsia"> *Select a Provider</legend>
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
<br />
<br />
</fieldset>
<br />
<br />
<fieldset id="FldStOffers" visible="false" style="width: 300px" runat="server">
<asp:GridView ID="GdvOffers" runat="server" AutoGenerateColumns="False" 
        CellPadding="4" ForeColor="#333333" GridLines="None">
    <FooterStyle BackColor="#507CD1" Font-Bold="True" ForeColor="White" />
    <RowStyle BackColor="#EFF3FB" />
    <Columns>
        <asp:BoundField DataField="RechargeCard" HeaderText="Recharge card" />
        <asp:BoundField DataField="ServiceLocation" HeaderText="ServiceLocation" />
        <asp:BoundField DataField="Price" HeaderText="Price" />
        <asp:BoundField DataField="TalkTime" HeaderText="TalkTime" />
        <asp:BoundField DataField="Validity" HeaderText="Validity" />
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

