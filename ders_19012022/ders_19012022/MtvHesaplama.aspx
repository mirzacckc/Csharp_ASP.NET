<%@ Page Title="" Language="C#" MasterPageFile="~/Site1.Master" AutoEventWireup="true" CodeBehind="MtvHesaplama.aspx.cs" Inherits="ders_19012022.WebForm1" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">

    <asp:Label ID="lbl_aractipi" runat="server" Text="Araç Tipi"></asp:Label>
    <br />
    <asp:DropDownList ID="DropDownList1" runat="server" AutoPostBack="true" OnSelectedIndexChanged="DropDownList1_SelectedIndexChanged">
   <%--     <asp:ListItem Text="Otomobil"></asp:ListItem>
        <asp:ListItem Text="Motosiklet"></asp:ListItem>
        <asp:ListItem Text="Minibüs"></asp:ListItem>
        <asp:ListItem Text="Panel Van"></asp:ListItem>
        <asp:ListItem Text="Otobüs"></asp:ListItem>
        <asp:ListItem Text="Kamyonet"></asp:ListItem>--%>
    </asp:DropDownList>
   <br />

    <asp:Label ID="lbl_birinci" runat="server" Text="Motor Silindir Hacmi (cm³)"></asp:Label>
    <br />
    <asp:DropDownList ID="DropDownList2" runat="server"></asp:DropDownList>
    <br />

    <asp:Label ID="lbl_ikinci" runat="server" Text="Araç Yaşı"></asp:Label>
    <br />
    <asp:DropDownList ID="DropDownList3" runat="server" AutoPostBack="true" OnSelectedIndexChanged="DropDownList3_SelectedIndexChanged"></asp:DropDownList>
    <br />
    <asp:Label ID="lbl_ucuncu" runat="server" Text="Araç Tescil Yılı"></asp:Label>
    <br />

    <asp:DropDownList ID="DropDownList4" runat="server" AutoPostBack="true" OnSelectedIndexChanged="DropDownList4_SelectedIndexChanged"></asp:DropDownList>
    <br />
    <asp:Label ID="lbl_dorduncu" runat="server" Text="Label" Visible="false"></asp:Label>
    <br />
    <asp:DropDownList ID="DropDownList5" runat="server" Visible="false">
        <asp:ListItem>56.500'i aşmayanlar</asp:ListItem>
        <asp:ListItem>56.500'i aşıp 99.000'i aşmayanlar</asp:ListItem>
        <asp:ListItem>99.000 aşanlar</asp:ListItem>
    </asp:DropDownList>
    <br /><br />

    <asp:Button ID="Button1" runat="server" Text="Hesapla" OnClick="Button1_Click"/>

    <br />
    <div style="background-color:paleturquoise; font-family:Arial">

        <%--<asp:Label ID="Label1" runat="server" Text="2022 Yılı İçin Ödenmesi Gereken MTV Tutarı" Font-Size="Large"></asp:Label>--%>
        <p1 style="font-size:large; color:darkslategrey"><strong>2022</strong> Yılı İçin Ödenmesi Gereken MTV Tutarı</p1>
        <hr color="darkslategrey" />
        <br />
        <asp:Label ID="lbl_sonuc" runat="server" Text="" Font-Size="X-Large" ForeColor="DarkSlateGray"></asp:Label>
    </div>
    

</asp:Content>
