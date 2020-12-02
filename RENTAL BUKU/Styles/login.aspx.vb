Public Class login1
    Inherits System.Web.UI.Page
    Protected Sub cmdOK_Click(ByVal sender As Object, ByVal e As EventArgs) Handles cmdOK.Click
        Dim iduser, user, pass As String
        Try
            If sql_conn(Session("currCon")) = True Then
                Dim sql1 As String = "SELECT * FROM tbl_pelanggan WHERE username='" & txtUser.Text & "'"
                Dim RS1 As OleDb.OleDbDataReader
                RS1 = sql_datareader(Session("currCon"), sql1)

                If RS1.HasRows Then
                    While RS1.Read
                        user = RS1("username")
                        pass = RS1("password")
                        iduser = RS1("id")
                    End While
                End If
            End If
        Catch ex As Exception

        End Try
        If user = txtUser.Text And pass = txtPass.Text Then
            Session("Pelanggan") = "Pelanggan"
            Response.Redirect("../Default.aspx")
        Else
            MsgBox("Username atau Password tidak valid")

        End If
        'If user = txtUser.Text And pass = txtPass.Text Then
        '    Label1.Text = "ok"

        'Else
        '    MsgBox("pok")
        'End If

    End Sub
End Class