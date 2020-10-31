'https://www.cadcenter.pl/
'Kamil Martenczuk Autodesk Authorized Developer DEPL2710
'info@cadcenter.pl
'Date: 10/30/2020
'AutoCAD CAM plugin
'**********************************************************
Imports Autodesk.Windows
Imports Autodesk.AutoCAD.Runtime
Imports Autodesk.AutoCAD.EditorInput
Imports Autodesk.AutoCAD.ApplicationServices
Imports Autodesk.AutoCAD.DatabaseServices


Public Class Inizialisation
    <CommandMethod("ACAM")> Public Shared Sub Start()
        Dim ccpDoc As Document = Application.DocumentManager.MdiActiveDocument
        Dim ribbonControl As Autodesk.Windows.RibbonControl = Autodesk.Windows.ComponentManager.Ribbon
        Dim RibbonCHK As RibbonTab = ribbonControl.FindTab("CAM")
        If RibbonCHK Is Nothing Then
            Call Menu.TabNotLoaded()
        Else
            If RibbonCHK.IsVisible = True Then Call Menu.TabLoaded() Else Call Menu.TabHidden()
        End If

    End Sub

End Class

Public Class Menu
    Public Shared Sub TabNotLoaded()
        Dim ccpDoc As Document = Application.DocumentManager.MdiActiveDocument
        Dim ccpDialog As PromptKeywordOptions = New PromptKeywordOptions("")
        Dim ccpDialogRes As PromptResult
        ccpDialog.Message = vbCrLf + "Is not loaded. Choose an Option: "
        ccpDialog.Keywords.Add("Load")
        ccpDialog.Keywords.Add("Help")
        ccpDialog.Keywords.Add("Exit")
        ccpDialog.Keywords.Default = "Load"
        ccpDialog.AllowNone = False
        ccpDialogRes = ccpDoc.Editor.GetKeywords(ccpDialog)
        If ccpDialogRes.Status = PromptStatus.Cancel Then Exit Sub
        If ccpDialogRes.StringResult = "Load" Then Call TabBuilder.CAM_Tab()
        If ccpDialogRes.StringResult = "Help" Then Call TabBuilder.CAM_Tab()
        If ccpDialogRes.StringResult = "Exit" Then Exit Sub
    End Sub

    Public Shared Sub TabLoaded()
        Dim ccpDoc As Document = Application.DocumentManager.MdiActiveDocument
        Dim ccpDialog As PromptKeywordOptions = New PromptKeywordOptions("")
        Dim ccpDialogRes As PromptResult
        ccpDialog.Message = vbCrLf + "Choose: "
        ccpDialog.Keywords.Add("Hide")
        ccpDialog.Keywords.Add("Help")
        ccpDialog.Keywords.Add("Exit")
        ccpDialog.Keywords.Default = "Hide"
        ccpDialog.AllowNone = False
        ccpDialogRes = ccpDoc.Editor.GetKeywords(ccpDialog)
        If ccpDialogRes.Status = PromptStatus.Cancel Then Exit Sub
        If ccpDialogRes.StringResult = "Hide" Then
            Dim ribbonControl As Autodesk.Windows.RibbonControl = Autodesk.Windows.ComponentManager.Ribbon
            Dim InstallCHK As RibbonTab = ribbonControl.FindTab("CAM")
            If InstallCHK IsNot Nothing Then InstallCHK.IsVisible = False
        End If
        If ccpDialogRes.StringResult = "Help" Then Exit Sub
        If ccpDialogRes.StringResult = "Exit" Then Exit Sub
    End Sub

    Public Shared Sub TabHidden()
        Dim ccpDoc As Document = Application.DocumentManager.MdiActiveDocument
        Dim ccpDialog As PromptKeywordOptions = New PromptKeywordOptions("")
        Dim ccpDialogRes As PromptResult
        ccpDialog.Message = vbCrLf + "Choose: "
        ccpDialog.Keywords.Add("Show")
        ccpDialog.Keywords.Add("Help")
        ccpDialog.Keywords.Add("Exit")
        ccpDialog.Keywords.Default = "Show"
        ccpDialog.AllowNone = False
        ccpDialogRes = ccpDoc.Editor.GetKeywords(ccpDialog)
        If ccpDialogRes.Status = PromptStatus.Cancel Then Exit Sub
        If ccpDialogRes.StringResult = "Show" Then
            Dim ribbonControl As Autodesk.Windows.RibbonControl = Autodesk.Windows.ComponentManager.Ribbon
            Dim InstallCHK As RibbonTab = ribbonControl.FindTab("CAM")
            If InstallCHK IsNot Nothing Then
                InstallCHK.IsVisible = True
                InstallCHK.IsActive = True
            End If
        End If
        If ccpDialogRes.StringResult = "Help" Then Exit Sub
        If ccpDialogRes.StringResult = "Exit" Then Exit Sub
    End Sub
End Class
Public Class Commands

    <CommandMethod("CAMToolLib")> Public Shared Sub CamToolLibs()
        Dim ccpDoc As Document = Application.DocumentManager.MdiActiveDocument
        Dim ccpDB As Database = ccpDoc.Database
        Using ccpTrans As Transaction = ccpDB.TransactionManager.StartTransaction
            Dim Form As Form_CTL = New Form_CTL
            Form.Activate()
            Form.Show()
            Form.SQLConnect_default()
            Form.LibList_init()
            Call TabBuilder.Deactiv()
            ccpTrans.Commit()
        End Using
    End Sub
End Class
