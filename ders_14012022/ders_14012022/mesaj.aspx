<%@ Page Title="" Language="C#" MasterPageFile="~/Site1.Master" AutoEventWireup="true" CodeBehind="mesaj.aspx.cs" Inherits="ders_14012022.WebForm3" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <title>Mesaj</title>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">

    <div>

        <h1>Başvuru Oluştur</h1>
        <br />

        <asp:Label ID="Label1" runat="server" Text="Kimlik No"></asp:Label>
        <br />
        <asp:TextBox ID="txt_kimlikno" runat="server"></asp:TextBox>
        <br />
        <asp:Label ID="Label2" runat="server" Text="Ad:"></asp:Label>
        <br />
        <asp:TextBox ID="txt_ad" runat="server"></asp:TextBox>
        <br />
        <asp:Label ID="Label3" runat="server" Text="Soyad:"></asp:Label>
        <br />
        <asp:TextBox ID="txt_soyad" runat="server"></asp:TextBox>
        <br />
        <asp:Label ID="Label4" runat="server" Text="Cep Telefonu"></asp:Label>
        <br />
        <asp:TextBox ID="txt_telefon" runat="server" TextMode="Phone"></asp:TextBox>
        <br />
        <asp:Label ID="Label5" runat="server" Text="Email:"></asp:Label>
        <br />
        <asp:TextBox ID="txt_email" runat="server" TextMode="Email"></asp:TextBox>
        <br />

        <asp:Label ID="Label6" runat="server" Text="İl Seçiniz: "></asp:Label>
        <br />
        <asp:DropDownList ID="DropDownList1" runat="server" AutoPostBack="true" OnSelectedIndexChanged="DropDownList1_SelectedIndexChanged">
            <asp:ListItem Text="SEÇİNİZ" Value="seciniz" ></asp:ListItem>
            <asp:ListItem Text="ANKARA" Value="ankara"></asp:ListItem> 
            <asp:ListItem Text="İSTANBUL" Value="istanbul"></asp:ListItem>
            <asp:ListItem Text="İZMİR" Value="izmir" ></asp:ListItem>            
        </asp:DropDownList>

        <br />        

        <asp:Label ID="Label7" runat="server" Text="İlçe Seçiniz"></asp:Label>
        <br />
        <asp:DropDownList ID="DropDownList2" runat="server"></asp:DropDownList>
        <br />
        <br />
        <asp:Button ID="Button1" runat="server" Text="Gönder" />

    </div>

</asp:Content>
