Imports Autodesk.AutoCAD.ApplicationServices

Public Class SQL_Creator

    Public Shared Sub Creation(nazwa)
        Dim cmd As SqlClient.SqlCommand
        Dim conn As SqlClient.SqlConnection = New SqlClient.SqlConnection("Data Source=cadcenter.database.windows.net;Initial Catalog=acam;Persist Security Info=True;User ID=cadcenter;Password=@brahadabra.13")
        Try
            conn.Open()
            Dim strQ As String = String.Empty
            Dim user As String = Application.GetSystemVariable("OnlineUserName")
            strQ = "CREATE TABLE " + user + "_" + nazwa + " ([Name] [nvarchar](50) NOT NULL UNIQUE,[Number] [nvarchar](10) NOT NULL,[Diameter] [nvarchar](20) NULL,[Type] [nvarchar](20) NULL,[Vendor] [nvarchar](30) NULL,[Spindle Speed] [nvarchar](10) NOT NULL,[Cutting Feed] [nvarchar](10) NULL)"
            cmd = New SqlClient.SqlCommand(strQ, conn)
            cmd.ExecuteNonQuery()
            conn.Close()
        Catch ex As Exception
            MsgBox("Nie utworzono Tabeli")
        End Try
    End Sub

    Public Shared Sub Delete(nazwa)
        Dim cmd As SqlClient.SqlCommand
        Dim user As String = Application.GetSystemVariable("OnlineUserName")
        Dim conn As SqlClient.SqlConnection = New SqlClient.SqlConnection("Data Source=cadcenter.database.windows.net;Initial Catalog=acam;Persist Security Info=True;User ID=cadcenter;Password=@brahadabra.13")
        Try
            conn.Open()
            Dim strQ As String = String.Empty
            strQ = "DROP TABLE " + nazwa
            cmd = New SqlClient.SqlCommand(strQ, conn)
            cmd.ExecuteNonQuery()
            conn.Close()
        Catch ex As Exception
            MsgBox("Nie skasowano Tabeli " + nazwa)
        End Try
    End Sub
    Public Shared Sub CopyItems(tool, destlib, sLib)
        Dim cmd As SqlClient.SqlCommand
        Dim user As String = Application.GetSystemVariable("OnlineUserName")
        Dim conn As SqlClient.SqlConnection = New SqlClient.SqlConnection("Data Source=cadcenter.database.windows.net;Initial Catalog=acam;Persist Security Info=True;User ID=cadcenter;Password=@brahadabra.13")
        Try
            conn.Open()
            Dim strQ As String = String.Empty
            strQ = "Insert Into " + destlib + " Select *" + " From " + sLib + " WHERE NAME Like '" + tool + "'"
            cmd = New SqlClient.SqlCommand(strQ, conn)
            cmd.ExecuteNonQuery()
            conn.Close()
        Catch ex As Exception
            MsgBox("Nie skopiowano narzedzia " + tool)
        End Try
    End Sub
    Public Shared Sub DeleteItems(tool, Library)
        Dim cmd As SqlClient.SqlCommand
        Dim user As String = Application.GetSystemVariable("OnlineUserName")
        Dim conn As SqlClient.SqlConnection = New SqlClient.SqlConnection("Data Source=cadcenter.database.windows.net;Initial Catalog=acam;Persist Security Info=True;User ID=cadcenter;Password=@brahadabra.13")
        Try
            conn.Open()
            Dim strQ As String = String.Empty
            strQ = "Delete FROM " + Library + " WHERE NAME Like '" + tool + "'"
            cmd = New SqlClient.SqlCommand(strQ, conn)
            cmd.ExecuteNonQuery()
            conn.Close()
        Catch ex As Exception
            MsgBox("Nie skasowano z " + Library + " narzedzia " + tool)
        End Try
    End Sub
End Class
