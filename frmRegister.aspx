<%@ Page Language="C#" MasterPageFile="~/HomeMasterPage.master" AutoEventWireup="true" CodeFile="frmRegister.aspx.cs" Inherits="frmRegister" Title="Untitled Page" %>

<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    <center style="height:auto; width: 774px">
<br />
<h2><b style="color:Green">Registration Form</b></h2>
<br />
<fieldset style="width: 307px"><legend style="color:Gray"> *Enter your Personal Details</legend>
<table>
<tr>
<td align="right"><b style="color:Red">First Name :</b></td>
<td align="left"><asp:TextBox ID="TxtFName" runat="server" MaxLength="20"></asp:TextBox>
<asp:RequiredFieldValidator ID="RfvFName" ControlToValidate="TxtFName" 
        runat="server" ErrorMessage="*"></asp:RequiredFieldValidator></td>
</tr>
<tr>
<td align="right"><b style="color:Red">Last Name :</b></td>
<td align="left"><asp:TextBox ID="TxtLName" runat="server" MaxLength="20"></asp:TextBox>
    <asp:RequiredFieldValidator ID="RfvLName" ControlToValidate="TxtLName" 
        runat="server" ErrorMessage="*"></asp:RequiredFieldValidator></td>
</tr>
<tr>
<td align="right"><b style="color:Red">Date Of Birth :</b></td>
<td align="left"><asp:TextBox ID="TxtDOB" runat="server"></asp:TextBox>
    <asp:RequiredFieldValidator ID="RfvDOB" ControlToValidate="TxtDOB" 
        runat="server" ErrorMessage="*"></asp:RequiredFieldValidator>
    <asp:CompareValidator ID="CompareValidator1" runat="server" 
        ControlToValidate="TxtDOB" ErrorMessage="*" Operator="DataTypeCheck" 
        Type="Date"></asp:CompareValidator>
                                                </td>
</tr>
<tr>
<td align="right"><b style="color:Red">Email Id :</b></td>
<td align="left"><asp:TextBox ID="TxtEmailId" runat="server"></asp:TextBox>
    <asp:RequiredFieldValidator ID="RfvEmailId" ControlToValidate="TxtEmailId" 
        runat="server" ErrorMessage="*"></asp:RequiredFieldValidator>
    <asp:RegularExpressionValidator ID="RegularExpressionValidator1" runat="server" 
        ControlToValidate="TxtEmailId" ErrorMessage="*" 
        ValidationExpression="\w+([-+.']\w+)*@\w+([-.]\w+)*\.\w+([-.]\w+)*"></asp:RegularExpressionValidator>
                                                </td>
</tr>
<tr>
<td align="right"><b style="color:Red">Address :</b></td>
<td align="left"><asp:TextBox ID="TxtAddress" TextMode="MultiLine" runat="server"></asp:TextBox>
    <asp:RequiredFieldValidator ID="RfvAddress" ControlToValidate="TxtAddress" 
        runat="server" ErrorMessage="*"></asp:RequiredFieldValidator></td>
</tr>
<tr>
<td align="right"><b style="color:Red">State :</b></td>
<td align="left"><asp:TextBox ID="TxtState" runat="server"></asp:TextBox>
    <asp:RequiredFieldValidator ID="RfvState" ControlToValidate="TxtState" 
        runat="server" ErrorMessage="*"></asp:RequiredFieldValidator></td>
</tr>
<tr>
<td align="right"><b style="color:Red">Country :</b></td>
<td align="left"><asp:TextBox ID="TxtCountry" runat="server"></asp:TextBox>
    <asp:RequiredFieldValidator ID="RfvCountry" ControlToValidate="TxtCountry" 
        runat="server" ErrorMessage="*"></asp:RequiredFieldValidator></td>
</tr>
</table>
</fieldset>
<br />
<br />
<fieldset style="width: 307px"><legend style="color:Gray"> *Enter Your Login Details</legend>
<table>
<tr>
<td align="right"><b style="color:Red">User Name :</b></td>
<td align="left"><asp:TextBox ID="TxtUserName" runat="server"></asp:TextBox><asp:RequiredFieldValidator ID="RfvUserName" ControlToValidate="TxtUserName" Text="*" runat="server"></asp:RequiredFieldValidator></td>
</tr>
<tr>
<td align="right"><b style="color:Red">Password :</b></td>
<td align="left"><asp:TextBox ID="TxtPassword" runat="server"></asp:TextBox><asp:RequiredFieldValidator ID="RfvPassword" ControlToValidate="TxtPassword" Text="*" runat="server"></asp:RequiredFieldValidator></td>
</tr>
<tr>
<td align="right"><b style="color:Red">Hint Question :</b></td>
<td align="left"><asp:DropDownList ID="DplHintQ" runat="server">
    <asp:ListItem>Select</asp:ListItem>
    <asp:ListItem>What is your Favorite pass time?</asp:ListItem>
    <asp:ListItem>What is your PetName?</asp:ListItem>
    <asp:ListItem>What is your first school name ?</asp:ListItem>
    </asp:DropDownList><asp:RequiredFieldValidator ID="RfvHintQ" 
        ControlToValidate="DplHintQ" Text="*" runat="server" InitialValue="Select"></asp:RequiredFieldValidator></td>
</tr>
<tr>
<td align="right"><b style="color:Red">Answer :</b></td>
<td align="left"><asp:TextBox ID="TxtAnswer" runat="server"></asp:TextBox><asp:RequiredFieldValidator ID="RfvAnswer" ControlToValidate="TxtAnswer" Text="*" runat="server"></asp:RequiredFieldValidator></td>
</tr>
</table>
</fieldset>
<br />
<br />
<fieldset style="width: 307px"><legend style="color:Gray"> *Enter Your Mobile Details</legend>
<table>
<tr>
<td align="right"><b style="color:Red">Vendor Name :</b></td>
<td align="left"><asp:DropDownList ID="DplVendorName" runat="server" 
        AutoPostBack="True" onselectedindexchanged="DplVendorName_SelectedIndexChanged"></asp:DropDownList></td>
</tr>
<tr>
<td align="right"><b style="color:Red">Service Location :</b></td>
<td align="left"><asp:DropDownList ID="DplServiceLocation" runat="server"></asp:DropDownList></td>
</tr>
<tr>
<td align="right"><b style="color:Red">Mode :</b></td>
<td align="left"><asp:RadioButtonList ID="RbtnMode" runat="server" 
        RepeatDirection="Horizontal">
    <asp:ListItem>PrePaid</asp:ListItem>
    <asp:ListItem>PostPaid</asp:ListItem>
    </asp:RadioButtonList></td>
</tr>
<tr>
<td align="right"><b style="color:Red">Mobile No :</b></td>
<td align="left"><asp:TextBox ID="TxtMobileNo" runat="server"></asp:TextBox><asp:RequiredFieldValidator ID="RfvMobileNo" ControlToValidate="TxtMobileNo" Text="*" runat="server"></asp:RequiredFieldValidator>
<asp:RegularExpressionValidator ID="RexpMobileNo" ControlToValidate="TxtMobileNo" 
        Text="*" runat="server" ValidationExpression="\d{10}"></asp:RegularExpressionValidator>
</td>
</tr>
</table>
</fieldset>
<br />
<br />
<asp:Button ID="BtnRegister" Text="REGISTER" runat="server" 
            onclick="BtnRegister_Click" />
<br />
<br />
<asp:Label ID="LblMsg" runat="server"></asp:Label>
</center>
</asp:Content>

