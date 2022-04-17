<%@ Page Title="" Language="C#" MasterPageFile="~/Site1.Master" AutoEventWireup="true" CodeBehind="Giris.aspx.cs" Inherits="ders_26012022.WebForm2" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <br />
    <br />
    <div class="container">

        <div class="row justify-content-center">

            <div class="col-4">
                <div>
                    <asp:TextBox ID="TextBox1" runat="server" CssClass="form-control"></asp:TextBox>
                    <!-- html de textbox karşılığı input ,textbox asp nesnesi -->
                    <br />

                    <asp:DropDownList ID="DropDownList1" runat="server" CssClass="form-control">
                        <asp:ListItem>Kadın</asp:ListItem>
                        <asp:ListItem>Erkek</asp:ListItem>
                    </asp:DropDownList>
                    <br />
                    <asp:Button ID="Button1" runat="server" Text="Giriş Yap" OnClick="Button1_Click" CssClass="btn btn-success" />
                    <%-- <button type="button" class="btn btn-success">Success</button>--%>
                    <!-- Buton için css classlı html buton -->
                    <br />
                    <br />
                    <asp:Label ID="lbl_sonuc" runat="server" Text=""></asp:Label>
                </div>
            </div>
        </div>
    </div>
</asp:Content>
