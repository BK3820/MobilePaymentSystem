<%@ Page Language="C#" MasterPageFile="~/HomeMasterPage.master" AutoEventWireup="true" CodeFile="frmSignOut.aspx.cs" Inherits="frmSignOut" Title="Untitled Page" %>

<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
<center style="height: 393px; width: 750px">
<br />
<br />
<h3><b style="color:Red"> YOU HAVE BEEN SIGNED OUT SUCCESSFULLY </b></h3>
<br />
<asp:LinkButton ID="LnkBtnRelogin" Text="Do you want to Relogin ?" 
        style="color:Green" runat="server" Font-Bold="True" Font-Size="Medium" 
         onclick="LnkBtnRelogin_Click"></asp:LinkButton>
         <br />
       <asp:Label ID="LblMsg" runat="server" ></asp:Label>
       <br />
       <br />
       <br />
</center>
</asp:Content>

