<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Kaydol.aspx.cs" Inherits="ders_16032022.Kaydol" %>

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
            height: 1200px;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server" style="padding: 50px">
        <div class="container" >
            <div class="row justify-content-center">
                <div class="col-5" id="div1" >
                    <img src="resimler/dragon.png" class="rounded mx-auto d-block" width="100" height="100" />
                    <br />
                    <h2 style="text-align: center">Dragon Araç Kiralamaya Hoşgeldiniz</h2>
                    <br />
                    <h5 style="text-align: center">Lütfen Kayıt İçin Aşağıdaki Bilgileri Doldurunuz</h5>
                    <br />
                    <asp:Label ID="lbl_tc" runat="server" Text="T.C."></asp:Label>
                    <br />
                    <asp:TextBox ID="txt_tc" runat="server" CssClass="form-control"></asp:TextBox>
                    <br />
                    <asp:Label ID="lbl_ad" runat="server" Text="Ad:"></asp:Label>
                    <br />
                    <asp:TextBox ID="txt_ad" runat="server" CssClass="form-control"></asp:TextBox>
                    <br />
                    <asp:Label ID="lbl_soyad" runat="server" Text="Soyad:"></asp:Label>
                    <br />
                    <asp:TextBox ID="txt_soyad" runat="server" CssClass="form-control"></asp:TextBox>
                    <br />
                    <asp:Label ID="lbl_eposta" runat="server" Text="Eposta:"></asp:Label>
                    <br />
                    <asp:TextBox ID="txt_eposta" runat="server" CssClass="form-control" TextMode="Email" placeholder="name@example.com"></asp:TextBox>
                    <br />
                    <asp:Label ID="lbl_tel" runat="server" Text="Telefon:"></asp:Label>
                    <br />
                    <asp:TextBox ID="txt_tel" runat="server" CssClass="form-control" TextMode="Phone"></asp:TextBox>
                    <br />                    
                    <asp:Label ID="lbl_dogum" runat="server" Text="Doğum Tarihi:"></asp:Label>
                    <br />
                    <asp:TextBox ID="txt_dogum" runat="server" CssClass="form-control" TextMode="Date"></asp:TextBox>
                    <br />
                    <asp:Label ID="lbl_surucu" runat="server" Text="Sürücü Belge Tarihi:"></asp:Label>
                    <br />
                    <asp:TextBox ID="txt_surucu" runat="server" CssClass="form-control" TextMode="Date"></asp:TextBox>
                    <br />
                    <asp:Label ID="lbl_sifre" runat="server" Text="Şifreniz:"></asp:Label>
                    <br />
                    <asp:TextBox ID="txt_sifre" runat="server" CssClass="form-control" TextMode="Password"></asp:TextBox>
                    <br />
                    <asp:Label ID="lbl_sifretekrar" runat="server" Text="Şifrenizi Tekrar Giriniz:"></asp:Label>
                    <br />
                    <asp:TextBox ID="txt_sifretekrar" runat="server" CssClass="form-control" TextMode="Password"></asp:TextBox>           
                    <br />                   
                    <asp:Button ID="Button1" runat="server" Text="Kayıt Ol" CssClass="w-50 btn btn-dark" OnClick="Button1_Click" />
                    <asp:CompareValidator ID="CompareValidator2" runat="server" ErrorMessage="Şifreler uyuşmuyor!!!" CssClass="alert alert-danger" 
                        ControlToValidate="txt_sifre" ControlToCompare="txt_sifretekrar"></asp:CompareValidator>
                    <br />
                    <br />
                    <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" 
                        ErrorMessage="TC Kimlik No Zorunlu!!!" ControlToValidate="txt_tc" CssClass="alert alert-warning"></asp:RequiredFieldValidator>
                </div>
            </div>
        </div>
    </form>
    <script src="js/bootstrap.bundle.min.js"></script>
</body>
</html>
