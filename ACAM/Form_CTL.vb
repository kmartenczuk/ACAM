Imports System.Windows.Forms

Public Class Form_CTL

    Dim conn As SqlClient.SqlConnection
    Dim cmd As SqlClient.SqlCommand
    Dim da As SqlClient.SqlDataAdapter
    Dim ds As DataSet
    Dim itemcoll(200) As String
    Dim aView As String = "All Samples"

    Friend Sub LibList_init()
        Me.ListView2.ShowGroups = True
    End Sub

    Private Sub ListView2_Click(sender As Object, e As EventArgs) Handles ListView2.Click
        Dim lvwitem As ListViewItem
        lvwitem = ListView2.SelectedItems.Item(0)
        aView = lvwitem.Text
        If aView = "" Then aView = "All Samples"
        Call SQLConnect_default()
    End Sub

    Friend Sub SQLConnect_default()
        Me.ListView1.Clear()
        Me.ListView1.GridLines = True
        conn = New SqlClient.SqlConnection("Data Source=cadcenter.database.windows.net;Initial Catalog=acam;Persist Security Info=True;User ID=cadcenter;Password=@brahadabra.13")
        conn.Open()
        If aView = "MyLibrary" Then
            ListView1.Clear()
        Else
            Dim strQ As String = String.Empty
            strQ = "SELECT * FROM [acam].[dbo].[" + aView + "] ORDER BY [Number] "
            cmd = New SqlClient.SqlCommand(strQ, conn)
            da = New SqlClient.SqlDataAdapter(cmd)
            ds = New DataSet
            da.Fill(ds, "Table")
            Dim i As Integer = 0
            Dim j As Integer = 0
            For i = 0 To ds.Tables(0).Columns.Count - 1
                Me.ListView1.Columns.Add(ds.Tables(0).Columns(i).ColumnName.ToString())
            Next
            Try
                For i = 0 To ds.Tables(0).Rows.Count - 1

                    For j = 0 To ds.Tables(0).Columns.Count - 1

                        itemcoll(j) = ds.Tables(0).Rows(i)(j).ToString()
                    Next

                    Dim lvi As New ListViewItem(itemcoll)
                    Me.ListView1.Items.Add(lvi)
                    Me.ListView1.AutoResizeColumns(ColumnHeaderAutoResizeStyle.HeaderSize)
                    Me.ListView1.CanSelect.ToString()

                Next
            Catch ex As Exception
                MsgBox("...")
            End Try
        End If
    End Sub
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Me.Close()
        Call ACAM.TabBuilder.Activ()
    End Sub

End Class