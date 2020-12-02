<%@ Page Title="" Language="vb" AutoEventWireup="false" MasterPageFile="~/Site.Master" CodeBehind="WebFormBuku.aspx.vb" Inherits="RENTAL_BUKU.WebFormBuku" %>
<asp:Content ID="Content1" runat="server" 
    contentplaceholderid="ContentPlaceHolder1">
    <p>
    <strong>ID&nbsp; </strong>&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;<asp:TextBox ID="txtId" runat="server"></asp:TextBox>
    &nbsp;<asp:TextBox ID="txtstate" runat="server" Visible="False"></asp:TextBox>
    &nbsp;</p>
<p>
    <strong></strong>
</p>
<p>
    <strong>JUDUL&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;<asp:TextBox ID="txtJudul" runat="server"></asp:TextBox>
    </strong>
</p>
<p>
    <strong></strong>
</p>
<p>
    TAHUN&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; <strong>&nbsp;&nbsp;&nbsp;<asp:TextBox ID="txtTahun" runat="server"></asp:TextBox>
    </strong>
</p>
<p>
    &nbsp;</p>
<p>
    <strong>PENGARANG&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; <asp:TextBox ID="txtPengarang" runat="server"></asp:TextBox>
    </strong>
</p>
<p>
    <strong></strong>
</p>
<p>
    PENERBIT<strong>&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
    <asp:TextBox ID="txtPenerbit" runat="server"></asp:TextBox>
    </strong>
</p>
<p>
    <strong></strong>
</p>
<p>
    <strong>ID TIPE BUKU&nbsp;&nbsp;&nbsp;&nbsp;
    <asp:DropDownList ID="txtIdTipeBuku" runat="server" Height="16px" Width="123px">
    </asp:DropDownList>
    </strong>
</p>
<p>
    <strong></strong>
</p>
<p><b>
    <strong>&nbsp;&nbsp;&nbsp;
    <asp:Button ID="btnNew" runat="server" Text="NEW" Width="77px" 
        BackColor="#B5712A" BorderColor="#B5712A" ForeColor="White" 
        Font-Bold="True" />
&nbsp;&nbsp;&nbsp;
    <asp:Button ID="btnSave" runat="server" Text="SAVE" Width="77px" 
        BackColor="#B5712A" BorderColor="#B5712A" ForeColor="White" 
        Font-Bold="True" />
&nbsp;&nbsp;&nbsp;
    <asp:Button ID="btnCancel" runat="server" Text="CANCEL" Width="77px" 
        BackColor="#B5712A" BorderColor="#B5712A" ForeColor="White" 
        Font-Bold="True" />
&nbsp;&nbsp;&nbsp;
    <asp:Button ID="btnDelete" runat="server" Text="DELETE" Width="77px" 
        BackColor="#B5712A" BorderColor="#B5712A" ForeColor="White" 
        Font-Bold="True" />
    </strong>
</b></p>
<p>
</p>
<asp:GridView ID="GridView1" runat="server" AllowPaging="True" 
    AutoGenerateColumns="False" Height="149px" PageSize="5" Width="630px" 
        BackColor="#DEBA84" BorderColor="White" BorderStyle="None" BorderWidth="1px" 
        CellPadding="3" CellSpacing="2" Font-Bold="True">
    <Columns>
        <asp:BoundField DataField="id" HeaderText="ID" />
        <asp:BoundField DataField="judul" HeaderText="JUDUL" />
        <asp:BoundField DataField="tahun" HeaderText="TAHUN" />
        <asp:BoundField DataField="pengarang" HeaderText="PENGARANG" />
        <asp:BoundField DataField="penerbit" HeaderText="PENERBIT" />
        <asp:BoundField DataField="id_tipe_buku" HeaderText="ID TIPE BUKU" />
        <asp:CommandField SelectText="&gt;&gt;" ShowSelectButton="True" />
    </Columns>
    <HeaderStyle BackColor="#B5712A" ForeColor="White" />
</asp:GridView>
</asp:Content>

