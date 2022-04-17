<%@ Page Title="" Language="C#" MasterPageFile="~/Site1.Master" AutoEventWireup="true" CodeBehind="PizzaDetay.aspx.cs" Inherits="ders_28012022.WebForm3" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">

    <div class="container">
        <div class="row">
            <!-- justify-content-center dersek 12 den küçük olanları ortalayarak sayfaya sığdırır eğer 12 boyutunde collar olursa bu komutun gerçekleşmez.--> 
            <div class="col-8">
                <asp:Image ID="Image1" runat="server" CssClass="rounded-circle" />
                <br />

                <asp:Label ID="lbl_baslik" runat="server" Text="Label"></asp:Label>
                <br />


                <asp:Label ID="lbl_icerik" runat="server" Text="Label"></asp:Label>
                <br />

                <div class="accordion" id="accordionPanelsStayOpenExample">
                    <div class="accordion-item">
                        <h2 class="accordion-header" id="panelsStayOpen-headingOne">
                            <button class="accordion-button" type="button" data-bs-toggle="collapse" data-bs-target="#panelsStayOpen-collapseOne" aria-expanded="true" aria-controls="panelsStayOpen-collapseOne">
                                Ürün Boyutu
                            </button>
                        </h2>
                        <div id="panelsStayOpen-collapseOne" class="accordion-collapse collapse show" aria-labelledby="panelsStayOpen-headingOne">
                            <div class="accordion-body">
                                <div class="row">
                                    <div class="col">
                                        <div class="card">
                                            <img src="Pizza_resimleri/web_listeleme_partiterra_2707.jpg" class="card-img-top" alt="...">
                                            <div class="card-body">
                                                <p class="card-text">Küçük Boy</p>
                                            </div>
                                        </div>
                                    </div>
                                    <div class="col">
                                        <div class="card">
                                            <img src="Pizza_resimleri/web_listeleme_partiterra_2707.jpg" class="card-img-top" alt="...">
                                            <div class="card-body">
                                                <p class="card-text">Orta Boy</p>
                                            </div>
                                        </div>
                                    </div>
                                    <div class="col">
                                        <div class="card">
                                            <img src="Pizza_resimleri/web_listeleme_partiterra_2707.jpg" class="card-img-top" alt="...">
                                            <div class="card-body">
                                                <p class="card-text">Büyük Boy</p>
                                            </div>
                                        </div>
                                    </div>

                                </div>

                            </div>
                        </div>
                    </div>
                    <div class="accordion-item">
                        <h2 class="accordion-header" id="panelsStayOpen-headingTwo">
                            <button class="accordion-button collapsed" type="button" data-bs-toggle="collapse" data-bs-target="#panelsStayOpen-collapseTwo" aria-expanded="false" aria-controls="panelsStayOpen-collapseTwo">
                                Hamur tipi
                            </button>
                        </h2>
                        <div id="panelsStayOpen-collapseTwo" class="accordion-collapse collapse" aria-labelledby="panelsStayOpen-headingTwo">
                            <div class="accordion-body">
                                <div class="row">
                                    <!-- coll ara 6 şar atayarak 2 satıra 4 adeti yayabiliriz. Her satırda kaç tane istersek 12 yi bölüp 
                                    coll lara onu yazarak kendi kendine satır yapabiliriz. 2 row yerine col-6 yazarak 4 adeti 2 satıra yayabiliriz. -->
            <div class="col-6">
                <div class="card mb-3" style="max-width: 540px;">
                    <div class="row g-0">
                        <div class="col-md-4">

                            <img src="Pizza_resimleri/web_listeleme_margarita_2707.jpg" class="img-fluid rounded-start" alt="...">
                        </div>
                        <div class="col-md-8">
                            <div class="card-body">
                                <h5 class="card-title">Klasik Hamur</h5>

                            </div>
                        </div>
                    </div>
                </div>
            </div>
            <div class="col-6">
                <div class="card mb-3" style="max-width: 540px;">
                    <div class="row g-0">
                        <div class="col-md-4">
                            <img src="Pizza_resimleri/web_listeleme_margarita_2707.jpg" class="img-fluid rounded-start" alt="...">
                        </div>
                        <div class="col-md-8">
                            <div class="card-body">
                                <h5 class="card-title">İnce Hamur</h5>

                            </div>
                        </div>
                    </div>
                </div>
            </div>


            <div class="col-6">
                <div class="card mb-3" style="max-width: 540px;">
                    <div class="row g-0">
                        <div class="col-md-4">
                            <img src="Pizza_resimleri/web_listeleme_margarita_2707.jpg" class="img-fluid rounded-start" alt="...">
                        </div>
                        <div class="col-md-8">
                            <div class="card-body">
                                <h5 class="card-title">Klasik Hamur Simit Kenar</h5>
                                <p class="card-text">+ 5,99 TL</p>

                            </div>
                        </div>
                    </div>
                </div>
            </div>
            <div class="col-6">
                <div class="card mb-3" style="max-width: 540px;">
                    <div class="row g-0">
                        <div class="col-md-4">
                            <img src="Pizza_resimleri/web_listeleme_margarita_2707.jpg" class="img-fluid rounded-start" alt="...">
                        </div>
                        <div class="col-md-8">
                            <div class="card-body">
                                <h5 class="card-title">Klasik Hamur Peynirli Kenar</h5>
                                <p class="card-text">+ 5,99 TL</p>

                            </div>
                        </div>
                    </div>
                </div>
            </div>
        </div>
        </div>
                        </div>
                    </div>
                    <div class="accordion-item">
                        <h2 class="accordion-header" id="panelsStayOpen-headingThree">
                            <button class="accordion-button collapsed" type="button" data-bs-toggle="collapse" data-bs-target="#panelsStayOpen-collapseThree" aria-expanded="false" aria-controls="panelsStayOpen-collapseThree">
                                Malzemeler
                            </button>
                        </h2>
                        <div id="panelsStayOpen-collapseThree" class="accordion-collapse collapse" aria-labelledby="panelsStayOpen-headingThree">
                            <div class="accordion-body">

                                <div class="container">
                                    <div class="row">
                                        <div class="col-4">
                                            <asp:Button ID="Button1" runat="server" Text="Beyaz Peynir" CssClass="btn btn-outline-success" />
                                        </div>
                                        <div class="col-4">
                                            <asp:Button ID="Button2" runat="server" Text="Cheddar Peynir" CssClass="btn btn-outline-success" />
                                        </div>
                                        <div class="col-4">
                                            <asp:Button ID="Button3" runat="server" Text="Kekik" CssClass="btn btn-outline-success" />
                                        </div>
                                        <div class="col-4">
                                            <asp:Button ID="Button4" runat="server" Text="Parmesan Peynir" CssClass="btn btn-outline-success" />
                                        </div>
                                    </div>

                                </div>
                            </div>
                        </div>
                    </div>
        <div class="accordion-item">
            <h2 class="accordion-header" id="panelsStayOpen-headingFour">
                <button class="accordion-button collapsed" type="button" data-bs-toggle="collapse" data-bs-target="#panelsStayOpen-collapseFour" aria-expanded="false" aria-controls="panelsStayOpen-collapseFour">
                    Ek Malzeme
                </button>
            </h2>
            <div id="panelsStayOpen-collapseFour" class="accordion-collapse collapse" aria-labelledby="panelsStayOpen-headingFour">
                <div class="accordion-body">
                    <div class="container">
                        <div class="row">

                            <div class="col-4">
                                <asp:CheckBox ID="CheckBox1" runat="server" Text="Brokoli" />
                                <asp:Label ID="Label1" runat="server" Text="+3.00 TL" ForeColor="Red"></asp:Label>
                            </div>
                            <div class="col-4">
                                <asp:CheckBox ID="CheckBox2" runat="server" Text="Domates" />
                                <asp:Label ID="Label2" runat="server" Text="+3.00 TL" ForeColor="Red"></asp:Label>
                            </div>
                            <div class="col-4">
                                <asp:CheckBox ID="CheckBox3" runat="server" Text="Extra Mozerella" />
                                <asp:Label ID="Label3" runat="server" Text="+3.00 TL" ForeColor="Red"></asp:Label>
                            </div>
                            <div class="col-4">
                                <asp:CheckBox ID="CheckBox4" runat="server" Text="Füme Kaburga" />
                                <asp:Label ID="Label4" runat="server" Text="+3.00 TL" ForeColor="Red"></asp:Label>
                            </div>
                            <div class="col-4">
                                <asp:CheckBox ID="CheckBox5" runat="server" Text="Jalapeno Biber" />
                                <asp:Label ID="Label5" runat="server" Text="+3.00 TL" ForeColor="Red"></asp:Label>
                            </div>
                            <div class="col-4">
                                <asp:CheckBox ID="CheckBox6" runat="server" Text="Mısır" />
                                <asp:Label ID="Label6" runat="server" Text="+3.00 TL" ForeColor="Red"></asp:Label>
                            </div>
                        </div>
                    </div>
                </div>
            </div>
        </div>
        </div>
            </div>
           
            <div class="col-4">
                <div class="card">
                    <div class="card-header">
                        <asp:Label ID="lbl_baslik2" runat="server" Text="Pizza Özellikleri"></asp:Label>
                    </div>
                    <ul class="list-group list-group-flush">
                        <li class="list-group-item">
                            <asp:Label ID="Label7" runat="server" Text="Ürün Boyutu"></asp:Label>
                            <asp:Label ID="lbl_urunBoyutu" runat="server" Text="Büyük" ForeColor="Red"></asp:Label>
                        </li>
                        <li class="list-group-item">
                            <asp:Label ID="Label8" runat="server" Text="Hamur"></asp:Label>
                            <asp:Label ID="lbl_hamur" runat="server" Text="İnce Hamur" ForeColor="Red"></asp:Label>
                        </li>
                        <li class="list-group-item">
                            <asp:Label ID="Label9" runat="server" Text="Malzeme"></asp:Label>
                            <asp:Label ID="lbl_malzeme" runat="server" Text="Kavurma" ForeColor="Red"></asp:Label>
                        </li>
                        <li class="list-group-item">
                            <asp:Label ID="Label10" runat="server" Text="Ekstra Malzeme"></asp:Label>
                            <asp:Label ID="lbl_extraMalzeme" runat="server" Text="Mısır" ForeColor="Red"></asp:Label>
                        </li>
                    </ul>
                    <asp:Button ID="Button5" runat="server" Text="Sepete Ekle" CssClass="btn btn-warning" />

                </div>

            </div>
        </div>
    </div>

    <br />
    <br />




</asp:Content>
