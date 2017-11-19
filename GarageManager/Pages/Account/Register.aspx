﻿<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage.master" AutoEventWireup="true" CodeFile="Register.aspx.cs" Inherits="Pages_Account_Register" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    <asp:Literal ID="litStatus" runat="server"></asp:Literal>
    <br />
    <br />
    <asp:Label ID="lblUserName" runat="server" Text="UserName:"></asp:Label>
    <br />
    <asp:TextBox ID="txtUserName" runat="server" CssClass="inputs"></asp:TextBox>
    <br />
    <asp:Label ID="lblPassword" runat="server" Text="Password:"></asp:Label>
    <br />
    <asp:TextBox ID="txtPassword" runat="server" CssClass="inputs" TextMode="Password"></asp:TextBox>
    <br />
    <asp:Label ID="lblConfirmPassword" runat="server" Text="Confirm Password:"></asp:Label>
    <br />
    <asp:TextBox ID="txtConfirmPassword" runat="server" CssClass="inputs" TextMode="Password"></asp:TextBox>
    <br />
First Name:<br />
<asp:TextBox ID="txtFirstName" runat="server" CssClass="inputs"></asp:TextBox>
<br />
Last Name:<br />
<asp:TextBox ID="txtLastName" runat="server" CssClass="inputs"></asp:TextBox>
<br />
Address:<br />
<asp:TextBox ID="txtAddress" runat="server" CssClass="inputs"></asp:TextBox>
<br />
Postal Code:<br />
<asp:TextBox ID="txtPostalCode" runat="server" CssClass="inputs"></asp:TextBox>
<br />
    <br />
    <asp:Button ID="Button1" runat="server" CssClass="button" OnClick="Button1_Click" Text="Register" />
    <br />
</asp:Content>

