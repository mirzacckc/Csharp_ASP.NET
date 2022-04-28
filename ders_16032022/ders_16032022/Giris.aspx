<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Giris.aspx.cs" Inherits="ders_16032022.Giris" %>

<!DOCTYPE html>

<html lang="tr">
<head runat="server">
    <meta charset="utf-8" />
    <meta name="viewport" content="width=device-width, initial-scale=1" />

    <link href="css/bootstrap.min.css" rel="stylesheet" />   

    <title></title>

    <style>
        #div1 {
            border-radius: 25px;
            background: #BBBBBB;
            padding: 20px;
            width: 500px;
            height: 550px;
        }
    </style>

</head>
<body>
    <form id="form1" runat="server" style="padding: 150px">
        <div class="container"  >
            <div class="row justify-content-center" >
                <div class="col-8" id="div1">
                    <img src="resimler/dragon.png" class="rounded mx-auto d-block" width="100" height="100" />
                    <br />
                    <h1 style="text-align: center">Dragon Araç Kiralamaya Hoşgeldiniz</h1>
                    <br />
                    <asp:TextBox ID="txt_kullaniciAdi" runat="server" CssClass="form-control" placeholder="Kullanıcı adı, telefon veya email"></asp:TextBox>
                    <br />
                    <asp:TextBox ID="txt_sifre" runat="server" CssClass="form-control" placeholder="Sifre" TextMode="Password"></asp:TextBox>
                    <br />
                    <asp:CheckBox ID="chck_benihatirla" runat="server" Text="Beni Hatırla" style="background:#BBBBBB" />
                    <br />
                    <br />
                    <asp:Button ID="Button1" runat="server" Text="Giriş" CssClass="w-100 btn btn-dark" OnClick="Button1_Click" />
                    <br /><br />
                    <asp:Label ID="lbl_sonuc" runat="server" Text=""></asp:Label>
                </div>
            </div>
        </div>
    </form>
    <script src="js/bootstrap.bundle.min.js"></script>
</body>
</html>
