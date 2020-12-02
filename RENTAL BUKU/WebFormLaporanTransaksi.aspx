<%@ Page Title="" Language="vb" AutoEventWireup="false" MasterPageFile="~/Site.Master" CodeBehind="WebFormLaporanTransaksi.aspx.vb" Inherits="RENTAL_BUKU.WebFormLaporanTransaksi" %>
<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <p>
        <strong>Daftar Transaksi</strong></p>
    <p>
        <strong>Cari Berdasarkan ID Peminjaman</strong></p>
    <p>
        <asp:TextBox ID="txtCari" runat="server"></asp:TextBox>
&nbsp;&nbsp;
        <asp:Button ID="btnCari" runat="server" Text="Cari" BackColor="#B5712A" 
            BorderColor="#B5712A" Font-Bold="True" ForeColor="White" Width="45px" />
    </p>
    <p>
        <asp:GridView ID="GridView1" runat="server" BackColor="#DEBA84" CellPadding="3" 
            CellSpacing="2" Font-Bold="True" Height="149px" Width="440px">
            <HeaderStyle BackColor="#B5712A" Font-Bold="True" ForeColor="White" />
        </asp:GridView>
    </p>
</asp:Content>
