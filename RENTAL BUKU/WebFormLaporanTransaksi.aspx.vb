Public Class WebFormLaporanTransaksi
    Inherits System.Web.UI.Page

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load

    End Sub

    Protected Sub btnCari_Click(ByVal sender As Object, ByVal e As EventArgs) Handles btnCari.Click
        If sql_conn(Session("currCon")) = True Then
            Dim tbl_grid As New DataTable
            tbl_grid = sql_datatable(Session("currCon"), "select D.ID, C.nama, B.judul, C.no_telp, A.nama from tipe_buku A, buku B, pelanggan C, peminjaman D, reg_buku E where B.id_tipe_buku=A.id AND B.id = E.id_buku AND C.id = D.id_pelanggan AND D.ID ='" & txtCari.Text & "'")
            GridView1.DataSource = tbl_grid
            GridView1.DataBind()
            Call sql_conn_close(Session("currCon"))
        End If
    End Sub
End Class