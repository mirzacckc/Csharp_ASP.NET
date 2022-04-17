<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Anasayfa.aspx.cs" Inherits="ders_07012022.Anasayfa" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title>My First Project</title>
</head>
<body>
    <form id="form1" runat="server">
        <div>

            <asp:Label ID="Label1" runat="server" Text="Adınızı Giriniz: " Width="250px"></asp:Label>
                        
            <asp:TextBox ID="txt_ad" runat="server"></asp:TextBox>

            <br /><br />

            <asp:Label ID="Label2" runat="server" Text="Cinsiyet Bilgisi(Kadın: k, Erkek: e)" Width="250px"></asp:Label>

            <asp:TextBox ID="txt_cinsiyet" runat="server"></asp:TextBox>

            <br /><br />

            <asp:Button ID="Button1" runat="server" Text="Hoşgeldiniz" OnClick="Button1_Click" />
            <br /><br />

            <asp:Label ID="Label3" runat="server" Text="Yaşınızı Giriniz" Width="250px"></asp:Label>

            <asp:TextBox ID="txt_yas" runat="server"></asp:TextBox>
            <br /><br />

            <asp:Button ID="Button2" runat="server" Text="Yaş Kontrol" OnClick="Button2_Click" />
            <br /><br />

            <asp:Label ID="lbl_sonuc" runat="server" Text=""></asp:Label>

        </div>
    </form>
</body>
</html>
