Public Class WebFormBuku
    Inherits System.Web.UI.Page

    Sub load_gridview()
        If sql_conn(Session("currCon")) = True Then
            Dim tbl_grid As New DataTable
            tbl_grid = sql_datatable(Session("currCon"), "select * from buku")
            GridView1.DataSource = tbl_grid
            GridView1.DataBind()
            sql_conn_close(Session("currCon"))
        End If
    End Sub
    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        If Not Page.IsPostBack Then
            load_gridview()
        End If
    End Sub

    Sub object_clear()
        txtId.Text = ""
        txtJudul.Text = ""
        txtTahun.Text = ""
        txtPengarang.Text = ""
        txtPenerbit.Text = ""
        'txtIdTipeBuku.Text = ""
    End Sub

    Sub object_fill(ByVal row As GridViewRow)
        txtId.Text = row.Cells(0).Text
        txtJudul.Text = row.Cells(1).Text
        txtTahun.Text = row.Cells(2).Text
        txtPengarang.Text = row.Cells(3).Text
        txtPenerbit.Text = row.Cells(4).Text
        txtIdTipeBuku.Text = row.Cells(5).Text
    End Sub

    Protected Sub btnSave_Click(ByVal sender As Object, ByVal e As EventArgs) Handles btnSave.Click
        Try
            If sql_conn(Session("currCon")) = True Then

                Dim sql As String = ""
                If txtstate.Text = "new" Then
                    sql = "insert into buku values ('{0}','{1}','{2}','{3}','{4}','{5}')"
                    MsgBox("Data berhasil ditambahkan", MsgBoxStyle.Information)
                    sql = String.Format(sql, txtId.Text, txtJudul.Text, txtTahun.Text, txtPengarang.Text, txtPenerbit.Text, txtIdTipeBuku.SelectedValue)
                    sql_execute(Session("currCon"), sql)

                ElseIf txtstate.Text = "edit" Then

                    sql = "update buku set judul='{0}',tahun='{1}',pengarang='{2}',penerbit='{3}',id_tipe_buku='{4}' where id='{5}'"
                    sql = String.Format(sql, txtJudul.Text, txtTahun.Text, txtPengarang.Text, txtPenerbit.Text, txtIdTipeBuku.SelectedValue, txtId.Text)
                    sql_execute(Session("currCon"), sql)


                End If
                sql_conn_close(Session("currCon"))
                load_gridview()
                object_clear()
            End If

        Catch ex As Exception
            MsgBox(Err.Description, vbOKOnly, "Error")
        End Try
    End Sub

    Protected Sub btnNew_Click(ByVal sender As Object, ByVal e As EventArgs) Handles btnNew.Click
        txtstate.Text = "new"
        txtstate.Visible = True
        tampil_ddl()
        object_clear()
    End Sub

    Private Sub GridView1_PageIndexChanging(ByVal sender As Object, ByVal e As System.Web.UI.WebControls.GridViewPageEventArgs) Handles GridView1.PageIndexChanging
        load_gridview()
        GridView1.PageIndex = e.NewPageIndex
        GridView1.DataBind()
    End Sub
    Private Sub GridView1_SelectedIndexChanging(ByVal sender As Object, ByVal e As System.Web.UI.WebControls.GridViewSelectEventArgs) Handles GridView1.SelectedIndexChanging
        Dim row_edit As GridViewRow = GridView1.Rows(e.NewSelectedIndex)
        object_clear()
        object_fill(row_edit)
        txtstate.Text = "edit"
        tampil_ddl()
    End Sub

    Protected Sub btnDelete_Click(ByVal sender As Object, ByVal e As EventArgs) Handles btnDelete.Click
        If sql_conn(Session("currCon")) = True Then
            sql_execute(Session("currCon"), "delete from buku where id='" & txtId.Text & "'")
            sql_conn_close(Session("currCon"))
            load_gridview()
            object_clear()
        End If
    End Sub
    Sub tampil_ddl()
        Try
            If sql_conn(Session("currCon")) = True Then
                Dim sql As String = "SELECT id from tipe_buku"
                Dim RS As OleDb.OleDbDataReader
                RS = sql_datareader(Session("currCon"), sql)
                If RS.HasRows Then
                    While RS.Read
                        txtIdTipeBuku.Items.Add(RS("id"))
                    End While
                End If
            End If
        Catch ex As Exception

        End Try
    End Sub

    Protected Sub btnCancel_Click(ByVal sender As Object, ByVal e As EventArgs) Handles btnCancel.Click
        object_clear()
    End Sub
End Class