<%@ Page Title="" Language="vb" AutoEventWireup="false" MasterPageFile="~/Site.Master" CodeBehind="WebFormPetugas.aspx.vb" Inherits="RENTAL_BUKU.WebFormPetugas" %>
<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <p>
        <strong>ID&nbsp;&nbsp;</strong>&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
    <asp:TextBox ID="txtId" runat="server"></asp:TextBox>
    &nbsp;<asp:TextBox ID="txtstate" runat="server"></asp:TextBox>
    &nbsp;</p>
<p>
    &nbsp;</p>
<p>
    <strong>NAMA&nbsp;</strong>&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;<asp:TextBox ID="txtNama" runat="server"></asp:TextBox>
</p>
<p>
    &nbsp;</p>
<p>
    <strong>ALAMAT</strong>&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
    <asp:TextBox ID="txtAlamat" runat="server"></asp:TextBox>
</p>
<p>
    &nbsp;</p>
<p>
    <strong>NO TELEPON</strong>&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;<asp:TextBox ID="txtNotelepon" runat="server"></asp:TextBox>
</p>
<p>
    &nbsp;</p>
<p>
    <strong>NAMA PENGGUNA</strong>&nbsp;&nbsp;<asp:TextBox ID="txtNamaPengguna" runat="server"></asp:TextBox>
</p>
<p>
    &nbsp;</p>
<p>
    <strong>KATA SANDI</strong>&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;<asp:TextBox ID="txtKataSandi" runat="server"></asp:TextBox>
</p>
<p>
    &nbsp;</p>
<p>
&nbsp;&nbsp;&nbsp;
    <asp:Button ID="btnNew" runat="server" Text="NEW" Width="77px" 
        BackColor="#B5712A" BorderColor="#B5712A" Font-Bold="True" ForeColor="White" />
&nbsp;&nbsp;&nbsp;
    <asp:Button ID="btnSave" runat="server" Text="SAVE" Width="77px" 
        BackColor="#B5712A" BorderColor="#B5712A" Font-Bold="True" ForeColor="White" />
&nbsp;&nbsp;&nbsp;
    <asp:Button ID="btnCancel" runat="server" Text="CANCEL" Width="77px" 
        BackColor="#B5712A" BorderColor="#B5712A" Font-Bold="True" ForeColor="White" />
&nbsp;&nbsp;&nbsp;
    <asp:Button ID="btnDelete" runat="server" Text="DELETE" Width="77px" 
        BackColor="#B5712A" BorderColor="#B5712A" Font-Bold="True" ForeColor="White" />
</p>
<p>
    &nbsp;</p>
<p>
</p>
<p>
    <asp:GridView ID="GridView1" runat="server" AllowPaging="True" 
        AutoGenerateColumns="False" Height="149px" PageSize="5" Width="630px" 
        BackColor="#DEBA84" CellPadding="3" CellSpacing="2" Font-Bold="True">
        <Columns>
            <asp:BoundField DataField="id" HeaderText="ID" />
            <asp:BoundField DataField="nama" HeaderText="NAMA" />
            <asp:BoundField DataField="alamat" HeaderText="ALAMAT" />
            <asp:BoundField DataField="no_telp" HeaderText="NOTELEPON" />
            <asp:BoundField DataField="nama_pengguna" HeaderText="NAMA PENGGUNA" />
            <asp:BoundField DataField="katasandi" HeaderText="KATA SANDI" />
            <asp:CommandField SelectText="&gt;&gt;" ShowSelectButton="True" />
        </Columns>
        <HeaderStyle BackColor="#B5712A" Font-Bold="True" ForeColor="White" />
    </asp:GridView>
</p>
<p>
    &nbsp;</p>
</asp:Content>
