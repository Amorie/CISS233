<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="FrmEducation.aspx.cs" Inherits="Project09.FrmEducation" %>

<!DOCTYPE html>
<link href="styles/styles.css" rel="stylesheet" />
<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    
    <form id="FrmEducation" runat="server">
    <div id="main" runat="server" >
        <h2>Education Survey</h2>
        <asp:Label ID="LblFirstName" runat="server" Text="Enter your first name:"></asp:Label>
        <asp:TextBox ID="TBFirstName" runat="server"></asp:TextBox>
        <asp:Label ID="LblFirstNameError" runat="server" Text="Please enter a first name!!!" ForeColor="#CC3300" Visible="False"></asp:Label>
        <br/><br/>
        <asp:Label ID="LblLastName" runat="server" Text="Enter your last name:"></asp:Label>
        <asp:TextBox ID="TBLastName" runat="server"></asp:TextBox>
        <asp:Label ID="LblLastNameError" runat="server" Text="Please enter a last name!!!" ForeColor="#CC3300" Visible="False"></asp:Label>
        <br/><br/>
        <asp:Label ID="LblEducation" runat="server" Text="Select your highest level of education"></asp:Label>

        <asp:DropDownList ID="DDEducation" runat="server">
            <asp:ListItem>Please make a selection....</asp:ListItem>
            <asp:ListItem>High School</asp:ListItem>
            <asp:ListItem>Some College</asp:ListItem>
            <asp:ListItem>Associate's Degree</asp:ListItem>
            <asp:ListItem>Bachelor's</asp:ListItem>
            <asp:ListItem>Master's</asp:ListItem>
            <asp:ListItem>PHD</asp:ListItem>
        </asp:DropDownList>

        <asp:Label ID="LblEducationError" runat="server" Text="Please select your level of education" ForeColor="#CC3300" Visible="False"></asp:Label>
        <br/><br/>
        <asp:Button ID="BtnSubmit" runat="server" Text="Submit" OnClick="BtnSubmit_Click"/>
        <input id="BtnReset" type="reset" value="Reset"/>

    </div>
    <div id="result" runat="server">
        <h2>Survey Results:</h2>
        <asp:Label ID="LblNameResult" runat="server" Text=""></asp:Label>
        <br/><br/>
        <asp:Label ID="LblEducationResult" runat="server" Text=""></asp:Label>
        <br/><br/>
    </div>
</form>
</body>
</html>
