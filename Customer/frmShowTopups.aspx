<%@ Page Language="C#" MasterPageFile="~/Customer/CustomerMasterPage.master" AutoEventWireup="true" CodeFile="frmShowTopups.aspx.cs" Inherits="Customer_frmRecharge" Title="Untitled Page" %>

<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
<center>
<br />
<br />
<h3><b style="color:Green"> Recharge Your Mobile </b></h3>
<br />
<fieldset style="width: 302px"><legend style="color:Fuchsia"> *Select Your Service Provider and Location</legend>
<br />
<table>
<tr>
<td align="right"><b style="color:Blue">Service Provider:</b></td>
<td align="left"><asp:DropDownList ID="DplProvider" runat="server" 
        AutoPostBack="True" 
        onselectedindexchanged="DplProvider_SelectedIndexChanged"></asp:DropDownList></td>
</tr>
<tr>
<td align="right"><b style="color:Blue">Location :</b></td>
<td align="left"><asp:DropDownList ID="DplLocation" runat="server" 
        onselectedindexchanged="DplLocation_SelectedIndexChanged" 
        AutoPostBack="True"></asp:DropDownList></td>
</tr>
</table>
<br />
</fieldset>
<br />
<br />
<fieldset id="FstTopups" visible="false" runat="server" style="width: 300px">
<asp:GridView ID="GdvTopups" runat="server" AutoGenerateColumns="False" 
        CellPadding="4" ForeColor="#333333" GridLines="None" 
        onrowcommand="GdvTopups_RowCommand" 
        onselectedindexchanging="GdvTopups_SelectedIndexChanging" >
    <FooterStyle BackColor="#507CD1" Font-Bold="True" ForeColor="White" />
    <RowStyle BackColor="#EFF3FB" />
    <Columns>
    <asp:BoundField DataField="RechargeCardId" HeaderText="Recharge CardId" />
        <asp:BoundField DataField="RechargeCard" HeaderText="Recharge Card" />
        <asp:BoundField DataField="Price" HeaderText="Price" />
        <asp:BoundField DataField="TalkTime" HeaderText="Talk Time" />
        <asp:BoundField DataField="Validity" HeaderText="Validity" />
        <asp:TemplateField HeaderText="Buy" >
        <ItemTemplate>
        <asp:Button ID="btnBuy" style="color:Blue" CommandArgument='<%#Eval("RechargeCardId") %>'  runat="server" Text="Buy Now" Visible='<%#show1(Eval("Status"))%>'/>
        <asp:Label ID="lblStatus" runat="server" Text="Out Of Stock" Visible='<%#show2(Eval("Status"))%>'> </asp:Label>
        </ItemTemplate>
        </asp:TemplateField>
    </Columns>
    <PagerStyle BackColor="#2461BF" ForeColor="White" HorizontalAlign="Center" />
    <SelectedRowStyle BackColor="#D1DDF1" Font-Bold="True" ForeColor="#333333" />
    <HeaderStyle BackColor="#507CD1" Font-Bold="True" ForeColor="White" />
    <EditRowStyle BackColor="#2461BF" />
    <AlternatingRowStyle BackColor="White" />
    </asp:GridView>
</fieldset><br />
<asp:Label ID="LblMsg" Visible="false" runat="server"></asp:Label>
</center>
</asp:Content>

