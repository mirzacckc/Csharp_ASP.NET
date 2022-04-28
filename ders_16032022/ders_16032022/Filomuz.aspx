<%@ Page Title="" Language="C#" MasterPageFile="~/Kullanici.Master" AutoEventWireup="true" CodeBehind="Filomuz.aspx.cs" Inherits="ders_16032022.WebForm3" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div class="container">
        <div class="row justify-content-center">

            <asp:Repeater ID="Repeater1" runat="server">
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
                                            <asp:Button ID="Button1" runat="server" Text="Detay Görüntele" CssClass="btn btn-primary" />
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
</asp:Content>
