<%@ Page Title="" Language="vb" AutoEventWireup="false" MasterPageFile="~/Site.Master" CodeBehind="WebFormRegistrasiBuku.aspx.vb" Inherits="RENTAL_BUKU.WebFormRegistrasiBuku" %>
<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <p>
        <strong>NO REGISTRASI&nbsp;</strong>&nbsp;&nbsp;&nbsp;&nbsp;
    <asp:TextBox ID="txtNoRegistrasi" runat="server"></asp:TextBox>
&nbsp;&nbsp;&nbsp;
    <asp:TextBox ID="txtState" runat="server"></asp:TextBox>
</p>
<p>
    &nbsp;</p>
<p>
    <strong>ID BUKU</strong>&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
    <asp:DropDownList ID="txtIdBuku" runat="server">
    </asp:DropDownList>
</p>
<p>
    &nbsp;</p>
<p>
    <strong>STATUS</strong>&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; &nbsp;
    <asp:TextBox ID="txtStatus" runat="server"></asp:TextBox>
</p>
<p>
    &nbsp;</p>
<p>
&nbsp;&nbsp;
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
&nbsp;&nbsp;&nbsp;&nbsp;
    <asp:GridView ID="GridView1" runat="server" AllowPaging="True" 
        AutoGenerateColumns="False" Height="149px" PageSize="5" Width="630px" 
        BackColor="#DEBA84" CellPadding="3" CellSpacing="2" Font-Bold="True">
        <Columns>
            <asp:BoundField DataField="no_reg" HeaderText="NOREGISTRASI" />
            <asp:BoundField DataField="id_buku" HeaderText="IDBUKU" />
            <asp:BoundField DataField="status" HeaderText="STATUS" />
            <asp:CommandField SelectText="&gt;&gt;" ShowSelectButton="True" />
        </Columns>
        <HeaderStyle BackColor="#B5712A" Font-Bold="True" ForeColor="White" />
    </asp:GridView>
</p>
<p>
    &nbsp;</p>
<p>
    &nbsp;</p>
<p>
    &nbsp;</p>
<p>
    &nbsp;</p>
<p>
    &nbsp;</p>
<p>
    &nbsp;</p>
<p>
    &nbsp;</p>
<p>
    &nbsp;</p>
<p>
    &nbsp;</p>
<p>
    &nbsp;</p>
<p>
    &nbsp;</p>
</asp:Content>
