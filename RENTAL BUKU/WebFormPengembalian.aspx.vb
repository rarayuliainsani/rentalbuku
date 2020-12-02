Public Class WebFormPengembalian
    Inherits System.Web.UI.Page

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        If Not Page.IsPostBack Then
            load_gridview()
        End If
    End Sub
    Sub load_gridview()
        If sql_conn(Session("currCon")) = True Then
            Dim tbl_grid As New DataTable
            tbl_grid = sql_datatable(Session("currCon"), "select * from pengembalian")
            GridView1.DataSource = tbl_grid
            GridView1.DataBind()
            sql_conn_close(Session("currCon"))
        End If
    End Sub

    Sub object_fill(ByVal row As GridViewRow)
        txtId.Text = row.Cells(0).Text
        txtIdPeminjaman.Text = row.Cells(1).Text
        Calendar2.SelectedDate = row.Cells(2).Text
        txtKeterlambatan.Text = row.Cells(3).Text
        txtDenda.Text = row.Cells(4).Text
        txtTotalBayar.Text = row.Cells(5).Text
    End Sub

    Sub object_clear()
        txtId.Text = ""
        txtLamaPeminjaman.Text = ""
        txtTanggalKembali.Text = ""
        txtKeterlambatan.Text = ""
        txtDenda.Text = ""
        txtTotalBayar.Text = ""
    End Sub

    Protected Sub btnNew_Click(ByVal sender As Object, ByVal e As EventArgs) Handles btnNew.Click
        txtstate.Text = "new"
        tampil_ddl()
        object_clear()
    End Sub

    Protected Sub btnCancel_Click(ByVal sender As Object, ByVal e As EventArgs) Handles btnCancel.Click
        object_clear()
    End Sub


    Protected Sub Calendar2_SelectionChanged(ByVal sender As Object, ByVal e As EventArgs) Handles Calendar2.SelectionChanged

        If sql_conn(Session("currCon")) = True Then
            txtTanggalKembali.Text = Calendar2.SelectedDate

            'Dim sql As String = "select tgl_pinjam from peminjaman where ID='{0}'"
            'sql = String.Format(sql, txtIdPeminjaman.SelectedValue)

            'Dim RS As OleDb.OleDbDataReader
            'RS = sql_datareader(Session("currCon"), sql)
            'RS.Read()

            'If RS.HasRows Then
            '    TextBox1.Text = RS.Item("tgl_pinjam")
            'End If


            'sql_execute(Session("currCon"), sql)



        End If

        sql_conn_close(Session("currCon"))
        txtLamaPeminjaman.Text = DateDiff(DateInterval.Day, CDate(TextBox1.Text), CDate(txtTanggalKembali.Text))

        If txtLamaPeminjaman.Text >= 0 And txtLamaPeminjaman.Text <= 3 Then
            txtKeterlambatan.Text = 0
        Else
            txtKeterlambatan.Text = txtLamaPeminjaman.Text - 3
        End If

        If txtKeterlambatan.Text = 1 Then
            txtDenda.Text = txtKeterlambatan.Text * 1000
        ElseIf txtKeterlambatan.Text > 1 Then

            txtDenda.Text = 1000 + ((txtKeterlambatan.Text - 1) * 500)
        End If




        If sql_conn(Session("currCon")) = True Then

            Dim sql2 As String = "select A.harga_sewa_perhari from tipe_buku A, buku B, reg_buku C, peminjaman D where B.id_tipe_buku=A.id AND B.id = C.id_buku AND C.no_reg = D.no_reg AND D.ID ='{0}'"
            sql2 = String.Format(sql2, txtIdPeminjaman.SelectedValue)

            Dim RS As OleDb.OleDbDataReader
            RS = sql_datareader(Session("currCon"), sql2)
            RS.Read()

            If RS.HasRows Then

                txtTotalBayar.Text = (RS.Item("harga_sewa_perhari") * (txtLamaPeminjaman.Text - txtKeterlambatan.Text)) + txtDenda.Text

            End If

            sql_execute(Session("currCon"), sql2)

        End If

        sql_conn_close(Session("currCon"))

    End Sub
    Sub tampil_ddl()
        Try
            If sql_conn(Session("currCon")) = True Then
                Dim sql As String = "SELECT id from peminjaman, reg_buku where reg_buku.no_reg=peminjaman.no_reg and status='tidak tersedia' "

                Dim RS As OleDb.OleDbDataReader
                RS = sql_datareader(Session("currCon"), sql)
                If RS.HasRows Then
                    While RS.Read
                        txtIdPeminjaman.Items.Add(RS("id"))
                    End While
                End If
            End If
        Catch ex As Exception

        End Try
    End Sub

    Protected Sub btnPengembalian_Click(ByVal sender As Object, ByVal e As EventArgs) Handles btnPengembalian.Click
        Try
            If sql_conn(Session("currCon")) = True Then

                Dim sql As String = ""
                If txtstate.Text = "new" Then
                    sql = "insert into pengembalian values ('{0}','{1}','{2}','{3}','{4}','{5}')"
                    MsgBox("Buku Telah dikembalikan!", MsgBoxStyle.Information)
                    sql = String.Format(sql, txtId.Text, txtIdPeminjaman.Text, Calendar2.SelectedDate, txtKeterlambatan.Text, txtDenda.Text, txtTotalBayar.Text)
                    sql_execute(Session("currCon"), sql)

                    Dim sql1 As String = ""
                    sql1 = "update reg_buku C, tipe_buku A, buku B, peminjaman D set C.status = 'Tersedia' where B.id_tipe_buku=A.id AND B.id = C.id_buku AND C.no_reg = D.no_reg AND D.ID ='{0}'"
                    sql1 = String.Format(sql1, txtIdPeminjaman.SelectedValue)
                    sql_execute(Session("currCon"), sql1)

                ElseIf txtstate.Text = "edit" Then

                    sql = "update pengembalian set id_peminjaman='{0}',tgl_kembali='{1}',terlambat='{2}',denda='{3}',total_bayar='{4}' where id='{5}'"
                    sql = String.Format(sql, txtIdPeminjaman.Text, Calendar2.SelectedDate, txtKeterlambatan.Text, txtDenda.Text, txtTotalBayar.Text, txtId.Text)
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

    Protected Sub TextBox1_TextChanged(ByVal sender As Object, ByVal e As EventArgs) Handles TextBox1.TextChanged

    End Sub

    Public Sub Button6_Click(ByVal sender As Object, ByVal e As EventArgs) Handles Button6.Click

        If sql_conn(Session("currCon")) = True Then

            Dim sql As String = "select tgl_pinjam from peminjaman where ID='{0}'"
            sql = String.Format(sql, txtIdPeminjaman.SelectedValue)

            Dim RS As OleDb.OleDbDataReader
            RS = sql_datareader(Session("currCon"), sql)
            RS.Read()

            If RS.HasRows Then
                TextBox1.Text = RS.Item("tgl_pinjam")
            End If


            sql_execute(Session("currCon"), sql)

        End If

    End Sub

    Protected Sub txtTanggalKembali_TextChanged(ByVal sender As Object, ByVal e As EventArgs) Handles txtTanggalKembali.TextChanged

    End Sub

    Private Sub txtIdPeminjaman_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtIdPeminjaman.Load

    End Sub

    Protected Sub txtIdPeminjaman_SelectedIndexChanged(ByVal sender As Object, ByVal e As EventArgs) Handles txtIdPeminjaman.SelectedIndexChanged


    End Sub
End Class