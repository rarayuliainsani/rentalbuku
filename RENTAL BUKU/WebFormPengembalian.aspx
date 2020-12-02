<%@ Page Title="" Language="vb" AutoEventWireup="false" MasterPageFile="~/Site.Master" CodeBehind="WebFormPengembalian.aspx.vb" Inherits="RENTAL_BUKU.WebFormPengembalian" %>
<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <p>
&nbsp;
    <asp:TextBox ID="txtstate" runat="server"></asp:TextBox>
</p>
<p>
    &nbsp;</p>
<p>
    <strong>&nbsp;ID&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;</strong>&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
    <asp:TextBox ID="txtId" runat="server"></asp:TextBox>
</p>
<p>
    &nbsp;</p>
<p>
    &nbsp;<strong>ID PEMINJAMAN&nbsp;</strong>&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
    <asp:DropDownList ID="txtIdPeminjaman" runat="server">
    </asp:DropDownList>
</p>
<p>
    &nbsp;</p>
<p>
    <strong>TANGGAL PINJAM</strong>&nbsp;&nbsp;&nbsp;
    <asp:TextBox ID="TextBox1" runat="server" Enabled="False"></asp:TextBox>
&nbsp;&nbsp;
    <asp:Button ID="Button6" runat="server" Text="Proses" />
</p>
<p>
    &nbsp;</p>
<p>
    <strong>&nbsp;TANGGAL KEMBALI</strong> <asp:TextBox ID="txtTanggalKembali" runat="server" 
        Enabled="False"></asp:TextBox>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
</p>
<p>
    &nbsp;</p>
<p>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
    <asp:Calendar ID="Calendar2" runat="server" BackColor="#CC3300" Height="207px" 
        Width="240px">
        <DayStyle BackColor="#FFCC66" />
        <TitleStyle BackColor="#3366FF" Font-Bold="True" />
    </asp:Calendar>
</p>
<p>
    &nbsp;</p>

<p>
&nbsp;<strong> LAMA PEMINJAMAN&nbsp;</strong>&nbsp;&nbsp;
    <asp:TextBox ID="txtLamaPeminjaman" runat="server" Enabled="False"></asp:TextBox>
</p>
<p>
    &nbsp;</p>
<p>
&nbsp; <strong>KETERLAMBATAN</strong>&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
    <asp:TextBox ID="txtKeterlambatan" runat="server" Enabled="False"></asp:TextBox>
</p>
<p>
    &nbsp;</p>
<p>
&nbsp;<strong> DENDA&nbsp;&nbsp;&nbsp;</strong>&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
    <asp:TextBox ID="txtDenda" runat="server" Enabled="False"></asp:TextBox>
</p>
<p>
    &nbsp;</p>
<p>
    <strong>&nbsp; TOTAL BAYAR&nbsp;</strong>&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
    <asp:TextBox ID="txtTotalBayar" runat="server" Enabled="False"></asp:TextBox>
</p>
<p>
    &nbsp;</p>
<p>
&nbsp;&nbsp;&nbsp;
    <asp:Button ID="btnNew" runat="server" Text="NEW" Width="77px" 
        BackColor="#B5712A" BorderColor="#B5712A" Font-Bold="True" ForeColor="White" />
&nbsp;&nbsp;
    <asp:Button ID="btnPengembalian" runat="server" Text="PENGEMBALIAN" 
        BackColor="#B5712A" BorderColor="#B5712A" Font-Bold="True" ForeColor="White" />
&nbsp;&nbsp;&nbsp;
    <asp:Button ID="btnCancel" runat="server" Text="CANCEL" Width="77px" 
        BackColor="#B5712A" BorderColor="#B5712A" Font-Bold="True" ForeColor="White" />
&nbsp;&nbsp;
</p>
<p>
&nbsp;</p>
<p>
    <asp:GridView ID="GridView1" runat="server" AutoGenerateColumns="False" 
        Height="149px" Width="630px" BackColor="#DEBA84" Font-Bold="True" 
        CellPadding="3" CellSpacing="2">
        <Columns>
            <asp:BoundField DataField="id" HeaderText="ID" />
            <asp:BoundField DataField="id_peminjaman" HeaderText="ID PEMINJAMAN" />
            <asp:BoundField DataField="tgl_kembali" HeaderText="TGL KEMBALI" />
            <asp:BoundField DataField="terlambat" HeaderText="TERLAMBAT" />
            <asp:BoundField DataField="denda" HeaderText="DENDA" />
            <asp:BoundField DataField="total_bayar" HeaderText="TOTAL BAYAR" />
            <asp:CommandField SelectText="&gt;&gt;" ShowSelectButton="True" />
        </Columns>
        <HeaderStyle BackColor="#B5712A" Font-Bold="True" ForeColor="White" />
    </asp:GridView>
</p>
<p>
    &nbsp;</p>


</asp:Content>
