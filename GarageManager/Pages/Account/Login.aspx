<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage.master" AutoEventWireup="true" CodeFile="Login.aspx.cs" Inherits="Pages_Account_Login" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    <asp:Literal ID="litStatus" runat="server"></asp:Literal>
    <br />
    <br />
    UserName:<br />
    <asp:TextBox ID="txtUserName" runat="server" CssClass="inputs"></asp:TextBox>
    <br />
    <br />
    Password:<br />
    <asp:TextBox ID="txtPassword" runat="server" CssClass="inputs" TextMode="Password"></asp:TextBox>
    <br />
    <br />
    <asp:Button ID="btnLogIn" runat="server" CssClass="button" OnClick="btnLogIn_Click" Text="Log In" />
    <br />
</asp:Content>

