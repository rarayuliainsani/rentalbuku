Public Class WebFormPeminjaman
    Inherits System.Web.UI.Page

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        If Not Page.IsPostBack Then
            load_gridview()
        End If
    End Sub

    Sub load_gridview()
        If sql_conn(Session("currCon")) = True Then
            Dim tbl_grid As New DataTable
            tbl_grid = sql_datatable(Session("currCon"), "select * from peminjaman")
            GridView3.DataSource = tbl_grid
            GridView3.DataBind()
            sql_conn_close(Session("currCon"))
        End If
    End Sub

    Sub object_fill(ByVal row As GridViewRow)
        txtId.Text = row.Cells(0).Text
        txtIdPetugas.Text = row.Cells(1).Text
        txtIdPelanggan.Text = row.Cells(2).Text
        txtNoRegistrasi.Text = row.Cells(3).Text
        Calendar1.SelectedDate = row.Cells(4).Text
    End Sub

    Sub object_clear()
        txtId.Text = ""
        txtTanggalPinjam.Text = ""
        txtIdPelanggan.Items.Add("")

    End Sub

    Protected Sub btnNew_Click(ByVal sender As Object, ByVal e As EventArgs) Handles btnNew.Click
        txtstate.Text = "new"
        tampil_ddl()
        tampil_ddl1()
        tampil_ddl2()
        object_clear()
    End Sub

    Protected Sub btnCancel_Click(ByVal sender As Object, ByVal e As EventArgs) Handles btnCancel.Click
        object_clear()
    End Sub

    Private Sub GridView3_PageIndexChanging(ByVal sender As Object, ByVal e As System.Web.UI.WebControls.GridViewPageEventArgs) Handles GridView3.PageIndexChanging
        load_gridview()
        GridView3.PageIndex = e.NewPageIndex
        GridView3.DataBind()
        tampil_ddl()
        tampil_ddl1()
        tampil_ddl2()
    End Sub


    Sub tampil_ddl()
        Try
            If sql_conn(Session("currCon")) = True Then
                Dim sql As String = "SELECT id from petugas"

                Dim RS As OleDb.OleDbDataReader
                RS = sql_datareader(Session("currCon"), sql)
                If RS.HasRows Then
                    While RS.Read
                        txtIdPetugas.Items.Add(RS("id"))

                    End While
                End If
            End If
        Catch ex As Exception

        End Try
    End Sub
    Sub tampil_ddl1()
        Try
            If sql_conn(Session("currCon")) = True Then
                Dim sql As String = "SELECT id from pelanggan"

                Dim RS As OleDb.OleDbDataReader
                RS = sql_datareader(Session("currCon"), sql)
                If RS.HasRows Then
                    While RS.Read
                        txtIdPelanggan.Items.Add(RS("id"))

                    End While
                End If
            End If
        Catch ex As Exception

        End Try
    End Sub
    Sub tampil_ddl2()
        Try
            If sql_conn(Session("currCon")) = True Then
                Dim sql As String = "SELECT no_reg from reg_buku where status = 'Tersedia'"

                Dim RS As OleDb.OleDbDataReader
                RS = sql_datareader(Session("currCon"), sql)
                If RS.HasRows Then
                    While RS.Read
                        txtNoRegistrasi.Items.Add(RS("no_reg"))

                    End While
                End If
            End If
        Catch ex As Exception

        End Try
    End Sub

    Private Sub GridView3_SelectedIndexChanging(ByVal sender As Object, ByVal e As System.Web.UI.WebControls.GridViewSelectEventArgs) Handles GridView3.SelectedIndexChanging
        Dim row_edit As GridViewRow = GridView3.Rows(e.NewSelectedIndex)
        object_clear()
        object_fill(row_edit)
        txtstate.Text = "edit"

    End Sub

    Protected Sub btnPinjam_Click(ByVal sender As Object, ByVal e As EventArgs) Handles btnPinjam.Click
        Try
            If sql_conn(Session("currCon")) = True Then

                Dim sql As String = ""
                If txtstate.Text = "new" Then

                    sql = "insert into peminjaman values ('{0}','{1}','{2}','{3}','{4}')"
                    MsgBox("Data berhasil ditambahkan", MsgBoxStyle.Information)
                    sql = String.Format(sql, txtId.Text, txtIdPetugas.SelectedValue, txtIdPelanggan.SelectedValue, txtNoRegistrasi.SelectedValue, Calendar1.SelectedDate)
                    sql_execute(Session("currCon"), sql)

                    Dim sql1 As String = ""
                    sql1 = "update reg_buku set status = 'tidak tersedia' where no_reg = '{0}'"
                    sql1 = String.Format(sql1, txtNoRegistrasi.SelectedValue)
                    sql_execute(Session("currCon"), sql1)

                    'ElseIf txtstate.Text = "edit" Then

                    'sql = "update peminjaman set id_petugas='{0}',id_pelanggan='{1}',no_reg='{2}',tgl_pinjam='{3}' where id='{6}'"
                    'sql = String.Format(sql, txtIdPetugas.SelectedValue, txtIdPelanggan.SelectedValue, txtNoRegistrasi.SelectedValue, Calendar1.SelectedDate, txtId.Text)
                    'sql_execute(Session("currCon"), sql)


                End If
                sql_conn_close(Session("currCon"))
                load_gridview()
                object_clear()
            End If

        Catch ex As Exception
            MsgBox(Err.Description, vbOKOnly, "Error")
        End Try
    End Sub

    Public Sub Calendar1_SelectionChanged(ByVal sender As Object, ByVal e As EventArgs) Handles Calendar1.SelectionChanged
        txtTanggalPinjam.Text = Calendar1.SelectedDate
    End Sub


    Protected Sub txtNoRegistrasi_SelectedIndexChanged(ByVal sender As Object, ByVal e As EventArgs) Handles txtNoRegistrasi.SelectedIndexChanged

    End Sub

    Protected Sub txtTanggalPinjam_TextChanged(ByVal sender As Object, ByVal e As EventArgs) Handles txtTanggalPinjam.TextChanged

    End Sub
End Class