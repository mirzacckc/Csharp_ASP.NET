<%@ Page Title="" Language="C#" MasterPageFile="~/Site1.Master" AutoEventWireup="true" CodeBehind="Anasayfa.aspx.cs" Inherits="ders_28012022.WebForm2" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">

    <div class="container">

        <div class="row">

            <div class="col">
                <div class="card" style="width: 18rem;">
                    <img src="Pizza_resimleri/web_listeleme_akdenizli_2707.jpg" class="card-img-top" alt="...">
                    <div class="card-body">
                        <h5 class="card-title">AKDENİZLİ</h5>
                        <p class="card-text">Pizza Sosu, Mozarella Peyniri, Beyaz Peynir, Küp Domates, Siyah Zeytin, Kekik</p>
                        <%--<a href="#" class="btn btn-primary">Sepete Ekle</a>--%>
                        <asp:Button ID="Button1" runat="server" Text="Sepete Ekle" CssClass="btn btn-danger" OnClick="Button1_Click"/>
                    </div>
                </div>
            </div>
             <div class="col">
                <div class="card" style="width: 18rem;">
                    <img src="Pizza_resimleri/web_listeleme_dopdolu_sucuklu_2707.jpg" class="card-img-top" alt="...">
                    <div class="card-body">
                        <h5 class="card-title">DOPDOLU SUCUKLU</h5>
                        <p class="card-text">Pizza Sosu, Mozarella Peyniri, Sucuk</p>
                        <%--<a href="#" class="btn btn-primary">Sepete Ekle</a>--%>
                        <asp:Button ID="Button2" runat="server" Text="Sepete Ekle" CssClass="btn btn-danger" OnClick="Button2_Click"/>
                    </div>
                </div>
            </div>
             <div class="col">
                <div class="card" style="width: 18rem;">
                    <img src="Pizza_resimleri/web_listeleme_kaburgali_2707.jpg" class="card-img-top" alt="...">
                    <div class="card-body">
                        <h5 class="card-title">KABURGALI</h5>
                        <p class="card-text">Barbekü Sos, Mozarella Peyniri, Fırınlanmış Patlıcan, Füme Kaburga, Soğan, Mantar, Susam, Kekik</p>
                        <%--<a href="#" class="btn btn-primary">Sepete Ekle</a>--%>
                        <asp:Button ID="Button3" runat="server" Text="Sepete Ekle" CssClass="btn btn-danger" OnClick="Button3_Click"/>
                    </div>
                </div>
            </div>


        </div>

    </div>
</asp:Content>
