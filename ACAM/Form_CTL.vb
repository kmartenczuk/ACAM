Imports Autodesk.AutoCAD.Runtime
Imports AdskApp = Autodesk.AutoCAD.ApplicationServices
Imports System.Windows.Forms
Public Class Form_CTL
    Dim conn As SqlClient.SqlConnection = New SqlClient.SqlConnection("Data Source=cadcenter.database.windows.net;Initial Catalog=acam;Persist Security Info=True;User ID=cadcenter;Password=@brahadabra.13")
    Dim cmd As SqlClient.SqlCommand
    Dim da As SqlClient.SqlDataAdapter
    Dim ds As DataSet
    Dim itemcoll(200) As String
    Dim aView As String = "All Samples"
    Dim dlName As String
    Dim user As String = AdskApp.Application.GetSystemVariable("OnlineUserName")

    Friend Sub FormCTL_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.ListView2.Clear()
        Me.ComboBox1.SelectedItem = "Name"
        Me.ListView2.ShowGroups = True
        Me.Button8.Enabled = False
        Me.Button9.Enabled = False
        Me.ProgressBar1.Visible = False
        Me.ListView1.Clear()
        Dim user As String = AdskApp.Application.GetSystemVariable("OnlineUserName")
        conn.Open()
        Try
            Dim strQ As String = String.Empty
            strQ = "SELECT Table_Name FROM acam.INFORMATION_SCHEMA.Tables WHERE Table_Name LIKE '" + user + "%'"
            cmd = New SqlClient.SqlCommand(strQ, conn)
            da = New SqlClient.SqlDataAdapter(cmd)
            ds = New DataSet
            da.Fill(ds, "Table")
            Me.ListView2.Groups.Add(New ListViewGroup("USER", HorizontalAlignment.Center))
            Me.ListView2.Groups.Add(New ListViewGroup("Online Samples", HorizontalAlignment.Center))
            Dim usermax As Integer = ds.Tables(0).Rows.Count - 1
            If usermax > -1 Then
                For i = 0 To usermax
                    Me.ListView2.Items.Add(ds.Tables(0).Rows(i)(0).ToString())
                    Me.ListView2.Items(i).Group = Me.ListView2.Groups(0)
                Next
            End If
            Me.ListView2.Items.Add("Face Mill")
            Me.ListView2.Items.Add("Flat Mill")
            Me.ListView2.Items.Add("Bull-Nose Mill")
            Me.ListView2.Items.Add("Ball Mill")
            Me.ListView2.Items.Add("Chamfer Mill")
            Me.ListView2.Items.Add("Other")
            Me.ListView2.Items.Add("All Samples")
            For i = usermax + 1 To usermax + 7
                Me.ListView2.Items(i).Group = Me.ListView2.Groups(1)
            Next
            conn.Close()
            Me.ListView1.AutoResizeColumns(ColumnHeaderAutoResizeStyle.HeaderSize)
        Catch ex As Exception
            MsgBox("...")
            conn.Close()
        End Try

    End Sub
    Private Sub ListView2_Click(sender As Object, e As EventArgs) Handles ListView2.Click
        Dim lvwitem As ListViewItem
        lvwitem = ListView2.SelectedItems.Item(0)
        aView = lvwitem.Text
        If aView = "" Then aView = "All Samples"
        ProgressBar1.Value = 0
        Call SQLConnect_online()
        If Me.Button12.Text = "Paste" Then
            Me.Button12.Enabled = True
        ElseIf Me.Button12.Text = "Copy" Then
            Me.Button12.Enabled = False
        End If
        If Me.Button13.Text = "Cancel" Then
            Me.Button13.Enabled = True
        ElseIf Me.Button13.Text = "Delete" Then
            Me.Button13.Enabled = False
        End If
        If aView.StartsWith(user) Then
            Me.Button9.Enabled = True
            Me.Button8.Enabled = True
            If Me.Button12.Text = "Paste" Then
                Me.Button12.Enabled = True
            Else Me.Button12.Enabled = False
            End If
        Else
            Me.Button9.Enabled = False
            Me.Button8.Enabled = False
            If Me.Button12.Text = "Paste" Then
                Me.Button12.Enabled = False
                Me.Button13.Enabled = True
            End If
        End If
    End Sub

    Private Sub ListView1_Click(sender As Object, e As EventArgs) Handles ListView1.Click
        Dim lvwitem1 As ListViewItem
        lvwitem1 = ListView1.SelectedItems.Item(0)
        Dim aView1 As String = lvwitem1.Text
        TextBox4.Text = aView1
        Button12.Enabled = True
        If aView.StartsWith(user) Then
            Me.Button13.Enabled = True
        Else
            If Me.Button13.Text = "Cancel" Then
                Me.Button13.Enabled = True
            End If
            If Me.Button12.Text = "Paste" Then
                Me.Button12.Enabled = False
            End If
        End If
    End Sub

    Friend Sub SQLConnect_online()
        Me.ListView1.Clear()
        conn.Open()
        If aView = "MyLibrary" Then
            Call MyLibrary()
        Else
            ListView1.Visible = False
            ProgressBar1.Value = 0
            ProgressBar1.Visible = True
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
            Me.ProgressBar1.Maximum = ds.Tables(0).Rows.Count
            For i = 0 To ds.Tables(0).Rows.Count - 1
                Me.ProgressBar1.Value += 1
                TextBox1.Text = i
            Next
            Try
                For i = 0 To ds.Tables(0).Rows.Count - 1

                    For j = 0 To ds.Tables(0).Columns.Count - 1

                        itemcoll(j) = ds.Tables(0).Rows(i)(j).ToString()
                        Me.ProgressBar1.Value = i + 1
                    Next
                    Dim lvi As New ListViewItem(itemcoll)
                    Me.ListView1.Items.Add(lvi)
                Next
                conn.Close()
                Me.ListView1.AutoResizeColumns(ColumnHeaderAutoResizeStyle.HeaderSize)
            Catch ex As Exception
                MsgBox("...")
            End Try
        End If
        If ProgressBar1.Value > (ds.Tables(0).Rows.Count - 1) Then
            ListView1.Visible = True
            ProgressBar1.Visible = False
        End If
        conn.Close()
    End Sub

    Public Sub MyLibrary()
        ListView1.Clear()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Me.Close()
        Call ACAM.TabBuilder.Activ()
    End Sub

    Private Sub FormCTL_FormClosed(ByVal sender As System.Object, ByVal e As System.Windows.Forms.FormClosedEventArgs) Handles MyBase.FormClosed

    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        Me.Button10.Visible = True
        Me.Button11.Visible = True
        Me.TextBox3.Visible = True
        Me.Label2.Visible = True
        Me.Button9.Enabled = False
        Me.Button8.Enabled = False

    End Sub


    Private Sub Button9_Click(sender As Object, e As EventArgs) Handles Button9.Click
        Call SQL_Creator.Delete(aView)
        Call FormCTL_Load(e, e)
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs)
        Me.Close()
    End Sub

    Private Sub Button10_Click(sender As Object, e As EventArgs) Handles Button10.Click
        Dim nazwa = TextBox3.Text
        Call SQL_Creator.Creation(nazwa)
        Me.FormCTL_Load(e, e)
        Me.Button9.Enabled = True
        Me.Button8.Enabled = True
        Me.Button10.Visible = False
        Me.Button11.Visible = False
        Me.TextBox3.Visible = False
        Me.Label2.Visible = False
        Me.TextBox3.Text = ""
    End Sub

    Private Sub Button11_Click(sender As Object, e As EventArgs) Handles Button11.Click
        Me.Button10.Visible = False
        Me.Button11.Visible = False
        Me.TextBox3.Visible = False
        Me.Label2.Visible = False
        Me.TextBox3.Text = ""
    End Sub

    Private Sub Button8_Click(sender As Object, e As EventArgs) Handles Button8.Click

    End Sub

    Private Sub Button13_Click(sender As Object, e As EventArgs) Handles Button13.Click
        If Button13.Text = "Cancel" Or Button13.Text = "OK" Then
            Me.Button12.Enabled = False
            Me.TextBox4.Text = ""
            Me.Button13.Text = "Delete"
            Me.Button12.Text = "Copy"
            Me.Button13.Enabled = False
            Me.Label3.Text = ""
        ElseIf Button13.Text = "Delete" Then
            Me.Label3.Text = aView
            Dim Library As String = Me.Label3.Text
            Dim Tool As String = Me.TextBox4.Text
            Call SQL_Creator.DeleteItems(Tool, Library)
            Call SQLConnect_online()
            Me.Button13.Enabled = False
        End If
    End Sub

    Private Sub Button12_Click(sender As Object, e As EventArgs) Handles Button12.Click
        If Me.Button12.Text = "Copy" Then
            Me.Button12.Text = "Paste"
            If aView.StartsWith(user) Then
                Me.Button12.Enabled = True
            Else Me.Button12.Enabled = False
            End If
            Me.Button13.Text = "Cancel"
            Me.Button13.Enabled = True
            Me.Label3.Text = aView
        Else
            Dim sLib As String
            If Me.Label3.Text.StartsWith(user) Then
                sLib = Me.Label3.Text
            Else
                sLib = "data1"
            End If
            Dim destLib As String = Me.aView
            Dim tool As String = Me.TextBox4.Text
            Call SQL_Creator.CopyItems(tool, destLib, sLib)
            Call SQLConnect_online()
            If Me.Button13.Text = "Cancel" Then
                Me.Button13.Text = "OK"
            End If
        End If


    End Sub
End Class