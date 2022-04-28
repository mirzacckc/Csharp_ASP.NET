<%@ Page Title="" Language="C#" MasterPageFile="~/Kullanici.Master" AutoEventWireup="true" CodeBehind="EkHizmetler.aspx.cs" Inherits="ders_16032022.WebForm6" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div class="container">
        <h2 style="text-align: center">Ek Sigorta Hizmetleri</h2>
        <br />
        <div class="row justify-content-center">
            <div class="col-12">
                <asp:Image ID="Image1" runat="server" src="resimler/sigorta.png" Style="height: 350px; width: 1295px" />
            </div>
        </div>
        <div class="row justify-content-center">
            <div class="col-3">
                <div class="container" style="background-color: black; color: white; border-radius: 10px; text-align: center; font-size: x-large">
                    <asp:Label ID="Label4" runat="server" Text="İndirimli Fiyat"></asp:Label>
                </div>
            </div>
            <div class="col-3">
                <div class="container" style="background-color: black; color: white; border-radius: 10px; text-align: center; font-size: x-large">
                    <asp:Label ID="Label5" runat="server" Text="89,00 TL/Gün"></asp:Label>
                </div>
                <br />
                <asp:Button ID="Button1" runat="server" Text=" + Ekle" CssClass="w-100 btn btn-outline-dark" Style="text-align: center" />
            </div>
            <div class="col-3">
                <div class="container" style="background-color: black; color: white; border-radius: 10px; text-align: center; font-size: x-large">
                    <asp:Label ID="Label6" runat="server" Text="139.00 TL/Gün"></asp:Label>
                </div>
                <br />
                <asp:Button ID="Button2" runat="server" Text=" + Ekle" CssClass="w-100 btn btn-outline-dark" Style="text-align: center" />
            </div>
            <div class="col-3">
                <div class="container" style="background-color: black; color: white; border-radius: 10px; text-align: center; font-size: x-large">
                    <asp:Label ID="Label7" runat="server" Text="159.00 TL/Gün"></asp:Label>
                </div>
                <br />
                <asp:Button ID="Button3" runat="server" Text=" + Ekle" CssClass="w-100 btn btn-outline-dark" Style="text-align: center" />
            </div>
        </div>

        <br />
        <br />
        <div class="row justify-content-center">
            <div class="col-12">
                <h2 style="text-align: center">Ek Hizmetler</h2>
                <br />
                <asp:Repeater ID="rpt_ekHizmet" runat="server">
                    <ItemTemplate>
                        <div class="card">
                            <div class="card-header">
                                <%#Eval("ad") %>
                            </div>
                            <div class="card-body">
                                <h5 class="card-title"> <%#Eval("tutar") %> TL / <%#Eval("odeme") %></h5>
                                <p class="card-text"> <%#Eval("aciklama") %></p>
                                <asp:Button ID="Button4" runat="server" Text="Seç" CssClass="btn btn-dark" />
                            </div>
                        </div>
                        <br />
                    </ItemTemplate>
                </asp:Repeater>
            </div>
        </div>
    </div>
</asp:Content>
