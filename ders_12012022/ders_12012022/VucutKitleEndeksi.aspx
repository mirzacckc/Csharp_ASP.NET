<%@ Page Title="" Language="C#" MasterPageFile="~/Masterpage.Master" AutoEventWireup="true" CodeBehind="VucutKitleEndeksi.aspx.cs" Inherits="ders_12012022.WebForm3" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    
    <div>
        <asp:RadioButton ID="RadioButton1" runat="server" Text="Kadın" />

        <br />

        <asp:RadioButton ID="RadioButton2" runat="server" Text="Erkek" />

        <br />

        <asp:Label ID="Label1" runat="server" Text="Vücut Ağırlığı(kg): " Width="150px"></asp:Label>
        <asp:TextBox ID="TextBox1" runat="server" placeholder="Örnek 50" TextMode="Number"></asp:TextBox>
        <%--<asp:Label ID="Label5" runat="server" Text="Örnek 50"></asp:Label>--%>
        <br />

        <asp:Label ID="Label2" runat="server" Text="Boy Uzunluğu(cm): " Width="150px"></asp:Label>
        <asp:TextBox ID="TextBox2" runat="server" placeholder="Örnek 170" TextMode="Number"></asp:TextBox>
       <%-- <asp:Label ID="Label4" runat="server" Text="Örnek 170"></asp:Label>--%>

        <br /><br />

        <asp:Button ID="Button1" runat="server" Text="Hesapla" OnClick="Button1_Click" />

        <br /><br />

        <asp:Label ID="lbl_sonucBaslik" runat="server" Text="Label" Visible="false"></asp:Label>
        <br />
        <asp:Label ID="lbl_sonucIcerik" runat="server" Text="Label" Visible="false"></asp:Label>
       
               
    </div>


</asp:Content>
