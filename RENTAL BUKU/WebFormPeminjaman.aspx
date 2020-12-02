<%@ Page Title="" Language="vb" AutoEventWireup="false" MasterPageFile="~/Site.Master" CodeBehind="WebFormPeminjaman.aspx.vb" Inherits="RENTAL_BUKU.WebFormPeminjaman" %>
<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <p>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        <asp:TextBox ID="txtstate" runat="server"></asp:TextBox>
    </p>
    <p>
        <strong>ID&nbsp; </strong>&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        <asp:TextBox ID="txtId" runat="server"></asp:TextBox>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
    </p>
    <p>
        <strong>ID PETUGAS</strong>&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        <asp:DropDownList ID="txtIdPetugas" runat="server">
        </asp:DropDownList>
        &nbsp;&nbsp;</p>
    <p>
        <strong>ID PELANGGAN</strong>&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        <asp:DropDownList ID="txtIdPelanggan" runat="server">
        </asp:DropDownList>
&nbsp;
    </p>
    <p>
        <strong>NO REGISTRASI</strong>&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;<asp:DropDownList ID="txtNoRegistrasi" runat="server">
        </asp:DropDownList>
        &nbsp;&nbsp;&nbsp;</p>
    <p>
        <strong>TANGGAL PINJAM</strong>&nbsp;&nbsp;&nbsp;&nbsp;
        <asp:TextBox ID="txtTanggalPinjam" runat="server" Enabled="False" 
            style="width: 128px"></asp:TextBox>
    </p>
    <p>
        &nbsp;<asp:Calendar ID="Calendar1" runat="server" BackColor="#CC3300" 
            style="margin-left: 126px">
            <DayStyle BackColor="#FFCC66" />
            <TitleStyle BackColor="#3366FF" />
        </asp:Calendar>
    </p>
    <p>
        &nbsp;</p>
    <p>
&nbsp;&nbsp;&nbsp;
        <asp:Button ID="btnNew" runat="server" BackColor="#B5712A" 
            BorderColor="#B5712A" Font-Bold="True" ForeColor="White" Height="26px" 
            Text="NEW" Width="77px" />
&nbsp;&nbsp;&nbsp;
        <asp:Button ID="btnPinjam" runat="server" BackColor="#B5712A" 
            BorderColor="#B5712A" Font-Bold="True" ForeColor="White" style="height: 26px" 
            Text="PINJAM" Width="77px" />
&nbsp;&nbsp;&nbsp;
        <asp:Button ID="btnCancel" runat="server" BackColor="#B5712A" 
            BorderColor="#B5712A" Font-Bold="True" ForeColor="White" Text="CANCEL" 
            Width="77px" />
&nbsp;&nbsp;&nbsp;
    </p>
    <p>
        &nbsp;</p>
    <p>
        <asp:GridView ID="GridView3" runat="server" AllowPaging="True" 
            AutoGenerateColumns="False" BackColor="#DEBA84" CellPadding="3" CellSpacing="2" 
            Font-Bold="True" Height="149px" PageSize="5" Width="630px">
            <Columns>
                <asp:BoundField DataField="id" HeaderText="ID" />
                <asp:BoundField DataField="id_petugas" HeaderText="ID PETUGAS" />
                <asp:BoundField DataField="id_pelanggan" HeaderText="ID PELANGGAN" />
                <asp:BoundField DataField="no_reg" HeaderText="NO REGISTRASI" />
                <asp:BoundField DataField="tgl_pinjam" HeaderText="TANGGAL PINJAM" />
                <asp:CommandField SelectText="&gt;&gt;" ShowSelectButton="True" />
            </Columns>
            <HeaderStyle BackColor="#B5712A" Font-Bold="True" ForeColor="White" />
        </asp:GridView>
    </p>
</asp:Content>
