<%@ Page Title="" Language="C#" MasterPageFile="~/Site1.Master" AutoEventWireup="true" CodeBehind="Hakkimizda.aspx.cs" Inherits="ders_14012022.WebForm1" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <h1>Hakkımızda</h1>
    
    <asp:ListBox ID="ListBox1" runat="server">
        <asp:ListItem Text="Sayılar"></asp:ListItem>
    </asp:ListBox>
    <br />

    <asp:ListBox ID="ListBox2" runat="server">
        <asp:ListItem Text="While"></asp:ListItem>
    </asp:ListBox>
    <br />
    <asp:ListBox ID="ListBox3" runat="server">
        <asp:ListItem Text="DoWhile"></asp:ListItem>
    </asp:ListBox>

    <br />

    <asp:Button ID="Button2" runat="server" Text="Sırala" OnClick="Button2_Click" />
</asp:Content>
