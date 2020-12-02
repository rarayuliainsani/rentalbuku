Public Class WebFormPetugas
    Inherits System.Web.UI.Page
    Sub load_gridview()
        If sql_conn(Session("currCon")) = True Then
            Dim tbl_grid As New DataTable
            tbl_grid = sql_datatable(Session("currCon"), "select * from petugas")
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
        txtNama.Text = ""
        txtAlamat.Text = ""
        txtNotelepon.Text = ""
        txtNamaPengguna.Text = ""
        txtKataSandi.Text = ""
    End Sub
    Sub object_fill(ByVal row As GridViewRow)
        txtId.Text = row.Cells(0).Text
        txtNama.Text = row.Cells(1).Text
        txtAlamat.Text = row.Cells(2).Text
        txtNotelepon.Text = row.Cells(3).Text
        txtNamaPengguna.Text = row.Cells(4).Text
        txtKataSandi.Text = row.Cells(5).Text
    End Sub
    Protected Sub btnSave_Click(ByVal sender As Object, ByVal e As EventArgs) Handles btnSave.Click
        Try
            If sql_conn(Session("currCon")) = True Then

                Dim sql As String = ""
                If txtstate.Text = "new" Then
                    sql = "insert into petugas values ('{0}','{1}','{2}','{3}','{4}','{5}')"
                    MsgBox("Data berhasil ditambahkan", MsgBoxStyle.Information)
                    sql = String.Format(sql, txtId.Text, txtNama.Text, txtAlamat.Text, txtNotelepon.Text, txtNamaPengguna.Text, txtKataSandi.Text)
                    sql_execute(Session("currCon"), sql)

                ElseIf txtstate.Text = "edit" Then

                    sql = "update petugas set nama='{0}',alamat='{1}',No_telp='{2}',nama_pengguna='{3}',katasandi='{4}' where Id='{5}'"
                    sql = String.Format(sql, txtNama.Text, txtAlamat.Text, txtNotelepon.Text, txtNamaPengguna.Text, txtKataSandi.Text, txtId.Text)
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
        txtState.Text = "edit"
    End Sub

    Protected Sub btnDelete_Click(ByVal sender As Object, ByVal e As EventArgs) Handles btnDelete.Click
        If sql_conn(Session("currCon")) = True Then
            sql_execute(Session("currCon"), "delete from petugas where Id='" & txtId.Text & "'")
            sql_conn_close(Session("currCon"))
            load_gridview()
            object_clear()
        End If
    End Sub


    Protected Sub btnCancel_Click(ByVal sender As Object, ByVal e As EventArgs) Handles btnCancel.Click
        object_clear()
    End Sub

End Class