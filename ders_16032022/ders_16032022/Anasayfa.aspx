<%@ Page Title="" Language="C#" MasterPageFile="~/Kullanici.Master" AutoEventWireup="true" CodeBehind="Anasayfa.aspx.cs" Inherits="ders_16032022.WebForm5" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">

    <div class="container">
        <div class="row justify-content-center">
            <div class="col-3">
                <asp:Label ID="Label4" runat="server" Text="Nereden Alacaksınız? "></asp:Label>
                <asp:DropDownList ID="DropDownList1" runat="server" CssClass="form-control"></asp:DropDownList>
            </div>
            <div class="col-3">
                <asp:Label ID="Label2" runat="server" Text="Alış Tarihi"></asp:Label>
                <asp:TextBox ID="txt_alisTarihi" runat="server" TextMode="Date" CssClass="form-control"></asp:TextBox>
            </div>
            <div class="col-3">

                <asp:Label ID="Label3" runat="server" Text="Teslim Tarihi"></asp:Label>
                <asp:TextBox ID="txt_teslimTarhi" runat="server" TextMode="Date" CssClass="form-control"></asp:TextBox>
            </div>
            <div class="col-3">
                <asp:Label ID="Label5" runat="server" Text="" Visible="false"></asp:Label>
                <br />
                <asp:Button ID="Button3" runat="server" Text="En Uygun Aracı Bul" CssClass="btn btn-dark" OnClick="Button3_Click" />
            </div>

        </div>
        <br />
        <br />
        <div class="row justify-content-center">
            <div class="col-3">
                <div class="accordion" id="accordionExample">
                    <div class="accordion-item">
                        <h2 class="accordion-header" id="headingOne">
                            <button class="accordion-button" type="button" data-bs-toggle="collapse" data-bs-target="#collapseOne" aria-expanded="true" aria-controls="collapseOne">
                                Vites Türü
                            </button>
                        </h2>
                        <div id="collapseOne" class="accordion-collapse collapse show" aria-labelledby="headingOne" data-bs-parent="#accordionExample">
                            <div class="accordion-body">
                                <asp:Repeater ID="rpter_vites" runat="server">
                                    <ItemTemplate>
                                        <asp:CheckBox ID="CheckBox1" runat="server" Text='<%#Eval("aciklama")%>' />
                                        <br />
                                    </ItemTemplate>
                                </asp:Repeater>
                            </div>
                        </div>
                    </div>
                    <div class="accordion-item">
                        <h2 class="accordion-header" id="headingTwo">
                            <button class="accordion-button collapsed" type="button" data-bs-toggle="collapse" data-bs-target="#collapseTwo" aria-expanded="false" aria-controls="collapseTwo">
                                Yakıt Türü
                            </button>
                        </h2>
                        <div id="collapseTwo" class="accordion-collapse collapse" aria-labelledby="headingTwo" data-bs-parent="#accordionExample">
                            <div class="accordion-body">
                                <asp:Repeater ID="rpter_yakit" runat="server">
                                    <ItemTemplate>
                                        <asp:CheckBox ID="CheckBox2" runat="server" Text='<%#Eval("aciklama")%>' />
                                        <br />
                                    </ItemTemplate>
                                </asp:Repeater>
                            </div>
                        </div>
                    </div>
                    <div class="accordion-item">
                        <h2 class="accordion-header" id="headingThree">
                            <button class="accordion-button collapsed" type="button" data-bs-toggle="collapse" data-bs-target="#collapseThree" aria-expanded="false" aria-controls="collapseThree">
                                Fiyat
                            </button>
                        </h2>
                        <div id="collapseThree" class="accordion-collapse collapse" aria-labelledby="headingThree" data-bs-parent="#accordionExample">
                            <div class="accordion-body">
                                <div class="row">
                                    <div class="col-4">
                                        <asp:TextBox ID="txt_min" runat="server" CssClass="form-control" placeholder="min"></asp:TextBox>
                                    </div>
                                    <div class="col-1">
                                        <asp:Label ID="Label1" runat="server" Text="_"></asp:Label>
                                    </div>
                                    <div class="col-4">
                                        <asp:TextBox ID="txt_max" runat="server" CssClass="form-control" placeholder="max"></asp:TextBox>
                                    </div>
                                    <div class="col-3">
                                        <asp:Button ID="btn_ara" runat="server" Text="Ara" CssClass="btn btn-dark" OnClick="btn_ara_Click" />
                                    </div>
                                </div>
                            </div>
                        </div>
                    </div>
                </div>

                <br />
                <asp:Button ID="btn_arama" runat="server" Text="Arama Yap" CssClass="btn btn-dark" OnClick="btn_ara_Click" />
            </div>
            <div class="col-9">
                <div class="row">
                    <asp:Label ID="lbl_uyari" runat="server" Text="Label" Visible="false" CssClass="alert alert-danger" style="text-align:center"></asp:Label>
                    <asp:Repeater ID="rpter_araclar" runat="server">
                        <ItemTemplate>
                            <div class="col-5">
                                <div class="card mb-3" style="max-width: 540px;">
                                    <div class="row g-0">
                                        <div class="col-md-4">
                                            <img src='<%#Eval("resimYolu") %>' class="img-fluid rounded-start" alt="...">
                                        </div>
                                        <div class="col-md-8">
                                            <div class="card-body">
                                                <h5 class="card-title"><%#Eval("model")%></h5>
                                                <p class="card-text"><%#Eval("aciklama")%> <%#Eval("Vites")%> <%#Eval("Yakit")%></p>
                                                <p class="card-text">
                                                    <asp:Button ID="Button1" runat="server" Text="Detay Görüntele" CssClass="btn btn-outline-dark" />
                                                </p>
                                            </div>
                                        </div>
                                    </div>
                                </div>
                            </div>
                        </ItemTemplate>
                    </asp:Repeater>
                </div>


            </div>
        </div>
    </div>






</asp:Content>
