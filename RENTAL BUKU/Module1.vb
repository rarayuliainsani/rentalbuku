Imports System.Data.OleDb
Imports System.Web.UI.Page
Imports System.IO
Imports System.Web.HttpRequest
Module Module1
    Public username
    Public Sub sql_conn_close(ByRef con As OleDbConnection)
        con.Close()
        con.Dispose()
    End Sub
    Public Function sql_conn(ByRef sessionCon As OleDbConnection, Optional ByRef sessionError As String = "") As Boolean
        Try
            If sessionCon Is Nothing Then
            Else
                If sessionCon.State = ConnectionState.Open Or sessionCon.State = ConnectionState.Broken Then sql_conn_close(sessionCon)

            End If
            Dim conSTR As String = "provider=microsoft.ACE.oledb.12.0;data source=" + HttpContext.Current.Request.PhysicalApplicationPath + "db_rentalbuku.accdb"
            sessionCon = New OleDbConnection(conSTR)
            sessionCon.Open()
            Return True
        Catch ex As Exception
            sessionError = Err.Number.ToString + ":" + Err.Description
            sessionCon = Nothing
            Return False
        End Try
    End Function
    Public Sub sql_gridview(ByVal sessionCon As OleDbConnection, ByRef gridviewASP As GridView, ByVal sql As String)
        Dim tbl As New DataTable
        Using adp As New OleDbDataAdapter(sql, sessionCon)
            adp.Fill(tbl)
        End Using
        gridviewASP.Datasource = Nothing
        gridviewASP.Datasource = tbl
        gridviewASP.DataBind()
    End Sub
    Public Function sql_datareader(ByVal sessionCon As OleDbConnection, ByVal sql As String)
        Dim rdr As OleDbDataReader
        Using cmd_rdr As New OleDbCommand(sql, sessionCon)
            rdr = cmd_rdr.ExecuteReader
        End Using
        Return rdr
    End Function
    Public Function sql_datatable(ByVal sessionCon As OleDbConnection, ByVal sql As String)
        Dim tbl As New DataTable
        Using adp As New OleDbDataAdapter(sql, sessionCon)
            adp.Fill(tbl)
        End Using
        Return tbl
    End Function
    Public Function sql_execute(ByVal sessionCon As OleDbConnection, ByVal sql As String) As Integer
        Try
            Using cmd As New OleDbCommand(sql, sessionCon)
                Return cmd.ExecuteNonQuery
            End Using
        Catch ex As Exception
            Return -1
        End Try
    End Function
End Module

