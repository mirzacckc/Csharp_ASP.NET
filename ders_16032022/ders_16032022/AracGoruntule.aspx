<%@ Page Title="" Language="C#" MasterPageFile="~/Admin.Master" AutoEventWireup="true" CodeBehind="AracGoruntule.aspx.cs" Inherits="ders_16032022.WebForm1" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div class="container">
        <div class="row justify-content-center">
            <div class="col-11">
                <asp:GridView ID="GridView1" runat="server" OnRowCommand="GridView1_RowCommand">
                    <Columns>
                        <asp:ButtonField ButtonType="Button" CommandName="Guncelle" Text="Güncelle" ControlStyle-CssClass="btn btn-primary" />
                        <asp:ButtonField ButtonType="Button" CommandName="Sil" Text="Sil" ControlStyle-CssClass="btn btn-danger" />
                    </Columns>
                </asp:GridView>

            </div>
        </div>

        <div class="row justify-content-center">
            <div class="col-8">
                <asp:Label ID="Label1" runat="server" Text="Araç Model Bilgisi"></asp:Label>
                <asp:TextBox ID="txt_model" runat="server" CssClass="form-control"></asp:TextBox>
                <br />
                <asp:Label ID="Label2" runat="server" Text="Araç Resmi Yükleyiniz"></asp:Label>
                <asp:FileUpload ID="FileUpload1" runat="server" CssClass="form-control" />
                <br />

                <asp:Label ID="Label3" runat="server" Text="Araç Açıklaması"></asp:Label>
                <asp:TextBox ID="txt_aciklama" runat="server" CssClass="form-control"></asp:TextBox>
                <br />

                <asp:CheckBox ID="chck_kilima" runat="server" Text="Klima Var" />
                <br />
                <br />

                <asp:Label ID="Label4" runat="server" Text="Vites Türünü Seçiniz"></asp:Label>
                <asp:DropDownList ID="DropDownList1" runat="server" CssClass="form-control">
                    <asp:ListItem>Vites Türünü Seçiniz</asp:ListItem>
                    <asp:ListItem>Otomatik</asp:ListItem>
                    <asp:ListItem>Manuel</asp:ListItem>
                </asp:DropDownList>
                <br />

                <asp:Label ID="Label5" runat="server" Text="Yakıt Türünü Seçiniz"></asp:Label>
                <asp:DropDownList ID="DropDownList2" runat="server" CssClass="form-control">
                    <asp:ListItem>Yakıt Türünü Seçiniz</asp:ListItem>
                    <asp:ListItem>Benzin</asp:ListItem>
                    <asp:ListItem>LPG</asp:ListItem>
                    <asp:ListItem>Dizel</asp:ListItem>
                    <asp:ListItem>Hybrid</asp:ListItem>
                </asp:DropDownList>

                <br />

                <asp:Label ID="Label6" runat="server" Text="Yolcu Kapasitesi"></asp:Label>
                <asp:TextBox ID="txt_kapasite" runat="server" Text="5" CssClass="form-control"></asp:TextBox>
                <br />

                <asp:Label ID="Label7" runat="server" Text="Araç Kapı Sayısı"></asp:Label>
                <asp:TextBox ID="txt_kapi" runat="server" Text="5" CssClass="form-control"></asp:TextBox>
                <br />

                <asp:Label ID="Label8" runat="server" Text="Araç Kiralama Yaş Sınırı"></asp:Label>
                <asp:TextBox ID="txt_yas" runat="server" Text="21" CssClass="form-control"></asp:TextBox>
                <br />

                <asp:Label ID="Label9" runat="server" Text="Araç Kiralama Ehliyet Süre Sınırı"></asp:Label>
                <asp:TextBox ID="txt_ehliyetSinir" runat="server" Text="1" CssClass="form-control"></asp:TextBox>
                <br />

                <asp:CheckBox ID="chck_abs" runat="server" Text="ABS Var" />
                <br />
                <br />

                <asp:CheckBox ID="chck_airbag" runat="server" Text="Airbag Var" />
                <br />
                <br />

                <asp:Button ID="Button1" runat="server" Text="Kaydet" CssClass="btn btn-warning" OnClick="Button1_Click" />
                <br />

            </div>
        </div>

        <div class="row justify-content-center">
            <div class="col-11">
                <asp:GridView ID="GridView2" runat="server" OnRowCommand="GridView2_RowCommand">
                    <Columns>
                        <asp:ButtonField ButtonType="Button" CommandName="Aktif" Text="Aktifleştir" ControlStyle-CssClass="btn btn-success" />
                    </Columns>
                </asp:GridView>

            </div>
        </div>
    </div>
</asp:Content>
