<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Index.aspx.cs" Inherits="ders_05012022.Index" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
    <style>
        h3{
            color:aquamarine;
            background-color:blueviolet;
            font-family:'Lucida Fax';
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
        <div>

            <asp:Label ID="Label3" runat="server" Text="Hesaplama"></asp:Label>

            <br /><br />

            <asp:Label ID="Label1" runat="server" Text="Kullanıcı Adı:" style="font-size:x-large" Width="150px"></asp:Label>

            <asp:TextBox ID="TextBox1" runat="server"></asp:TextBox>

            <br /><br />

            <asp:Label ID="Label2" runat="server" Text="Şifreniz:" style="font-size:x-large" Width="150px" ></asp:Label>

            <asp:TextBox ID="TextBox2" runat="server"></asp:TextBox>

            <!-- Yorum satırı -->
           <%-- <h1 style="color:darkorange; background-color:Highlight">Başlık</h1>
            <br />
            <h2 style="color:deeppink; font-family:'Felix Titling'; background-color:chartreuse">Bir Alt Başlık</h2>
            <h3>Üçüncü Alt Başlık</h3>
            <h4>Dördüncü</h4>
            <h5>Beşinci</h5>
            <h6>Altıncı</h6>--%>
            <br /><br />

            <asp:CheckBox ID="CheckBox1" runat="server" Text="Beni Hatırla" Checked="true" />

            <br /><br />
            
            <asp:Button ID="Button1" runat="server" Text="Giriş Yap" OnClick="Button1_Click" style="color:aqua;background-color:red" />
            <%--<p>
                Paragraf
                Paragraf
                Paragraf
            </p>--%>
            <!-- Tüm paragraf yoruma almak için ctrl+k ardından ctrl+c , geri döndürmek için ctrl+k ardından ctrl+u -->
        </div>
    </form>
</body>
</html>
