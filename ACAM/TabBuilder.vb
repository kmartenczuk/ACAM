'https://www.cadcenter.pl/
'Kamil Martenczuk Autodesk Authorized Developer DEPL2710
'info@cadcenter.pl
'Date: 10/30/2020
'AutoCAD CAM plugin
'**********************************************************
Imports System.IO
Imports System.Drawing
Imports System.Drawing.Imaging
Imports System.Windows.Media.Imaging
Imports Autodesk.Windows
Imports Autodesk.AutoCAD.ApplicationServices

Public Class TabBuilder

    Public Shared Sub CAM_Tab()
        Dim ribbonControl As Autodesk.Windows.RibbonControl = Autodesk.Windows.ComponentManager.Ribbon
        Dim Tab As RibbonTab = New RibbonTab()
        Tab.Title = "CAM"
        Tab.Id = "CAM"
        ribbonControl.Tabs.Add(Tab)
        '////////////////////////////////// P A N E L 1 /////////////////////////////////////
        Dim panel1Panel As Autodesk.Windows.RibbonPanelSource = New RibbonPanelSource()
        panel1Panel.Title = "Toolpath"
        Dim Panel1 As RibbonPanel = New RibbonPanel()
        Panel1.Source = panel1Panel
        Tab.Panels.Add(Panel1)
        Dim panbutton0 As RibbonButton = New RibbonButton()
        panbutton0.ShowText = True
        panbutton0.ShowImage = True
        panbutton0.Orientation = System.Windows.Controls.Orientation.Vertical
        panbutton0.Size = RibbonItemSize.Large
        panbutton0.CommandHandler = New RibbonCommandHandler()
        Dim pan1button01 As RibbonButton = New RibbonButton()
        pan1button01 = panbutton0.Clone
        pan1button01.LargeImage = Images.getBitmap(My.Resources.large1)
        pan1button01.Text = "Simulate"
        pan1button01.Name = "Simulate"
        pan1button01.Tag = "_CAMSimulate"
        Dim pan1button As RibbonButton = New RibbonButton()
        pan1button.ShowText = True
        pan1button.ShowImage = True
        pan1button.CommandHandler = New RibbonCommandHandler()
        Dim pan1button1 As RibbonButton = New RibbonButton()
        pan1button1 = pan1button.Clone
        pan1button1.Image = Images.getBitmap(My.Resources.small1)
        pan1button1.Text = "Post Process"
        pan1button1.Tag = "_CAMPost"
        Dim pan1button2 As RibbonButton = New RibbonButton()
        pan1button2 = pan1button.Clone
        pan1button2.Image = Images.getBitmap(My.Resources.small2)
        pan1button2.Text = "Setup Sheet"
        pan1button2.Tag = "_CAMSetSheet"
        Dim pan1button3 As RibbonButton = New RibbonButton()
        pan1button3 = pan1button.Clone
        pan1button3.Image = Images.getBitmap(My.Resources.small3)
        pan1button3.Text = "Generate"
        pan1button3.Tag = "_CAMGenerate"
        Dim pan1row1 As RibbonRowPanel = New RibbonRowPanel()
        pan1row1.Items.Add(pan1button1)
        pan1row1.Items.Add(New RibbonRowBreak())
        pan1row1.Items.Add(pan1button2)
        pan1row1.Items.Add(New RibbonRowBreak())
        pan1row1.Items.Add(pan1button3)
        panel1Panel.Items.Add(pan1button01)
        panel1Panel.Items.Add(pan1row1)
        '////////////////////////////////// P A N E L 2 /////////////////////////////////////
        Dim panel2Panel As Autodesk.Windows.RibbonPanelSource = New RibbonPanelSource()
        panel2Panel.Title = "Job"
        Dim Panel2 As RibbonPanel = New RibbonPanel()
        Panel2.Source = panel2Panel
        Tab.Panels.Add(Panel2)
        Dim pan2button01 As RibbonButton = New RibbonButton()
        pan2button01 = panbutton0.Clone
        pan2button01.LargeImage = Images.getBitmap(My.Resources.large2)
        pan2button01.Text = "Setup"
        pan2button01.Name = "Setup"
        pan2button01.Tag = "_CAMSetup"
        Dim pan2button02 As RibbonButton = New RibbonButton()
        pan2button02 = panbutton0.Clone
        pan2button02.LargeImage = Images.getBitmap(My.Resources.large3)
        pan2button02.Text = "Tool Library"
        pan2button02.Name = "Tool Library"
        pan2button02.Tag = "_CAMToolLib"
        panel2Panel.Items.Add(pan2button01)
        panel2Panel.Items.Add(pan2button02)

        '////////////////////////////////// P A N E L 3 /////////////////////////////////////
        Dim panel3Panel As Autodesk.Windows.RibbonPanelSource = New RibbonPanelSource()
        panel3Panel.Title = "Drilling"
        Dim Panel3 As RibbonPanel = New RibbonPanel()
        Panel3.Source = panel3Panel
        Tab.Panels.Add(Panel3)
        Dim pan3button01 As RibbonButton = New RibbonButton()
        pan3button01 = panbutton0.Clone
        pan3button01.LargeImage = Images.getBitmap(My.Resources.large4)
        pan3button01.Text = "Drill"
        pan3button01.Name = "Drill"
        pan3button01.Tag = "_CAMDrill"
        Dim pan3row1 As RibbonRowPanel = New RibbonRowPanel()
        panel3Panel.Items.Add(pan3button01)
        panel3Panel.Items.Add(pan3row1)
        '////////////////////////////////// P A N E L 4 /////////////////////////////////////
        Dim panel4Panel As Autodesk.Windows.RibbonPanelSource = New RibbonPanelSource()
        panel4Panel.Title = "2D Milling"
        Dim Panel4 As RibbonPanel = New RibbonPanel()
        Panel4.Source = panel4Panel
        Tab.Panels.Add(Panel4)
        Dim pan4button01 As RibbonButton = New RibbonButton()
        pan4button01 = panbutton0.Clone
        pan4button01.LargeImage = Images.getBitmap(My.Resources.large5)
        pan4button01.Text = "Face"
        pan4button01.Name = "Face"
        pan4button01.Tag = "_CAMFace"
        Dim pan4button1 As RibbonButton = New RibbonButton()
        pan4button1 = pan1button.Clone
        pan4button1.LargeImage = Images.getBitmap(My.Resources.small7)
        pan4button1.Text = "2D Adaptive"
        pan4button1.Tag = "_CAM2DAdaptive"
        Dim pan4button2 As RibbonButton = New RibbonButton()
        pan4button2 = pan1button.Clone
        pan4button2.LargeImage = Images.getBitmap(My.Resources.small8)
        pan4button2.Text = "2D Pocket"
        pan4button2.Tag = "_CAM2DPocket"
        Dim pan4button3 As RibbonButton = New RibbonButton()
        pan4button3 = pan1button.Clone
        pan4button3.LargeImage = Images.getBitmap(My.Resources.small9)
        pan4button3.Text = "2D Contour"
        pan4button3.Tag = "_CAM2DContour"
        Dim pan4button4 As RibbonButton = New RibbonButton()
        pan4button4 = pan1button.Clone
        pan4button4.LargeImage = Images.getBitmap(My.Resources.small10)
        pan4button4.Text = "Slot"
        pan4button4.Tag = "_CAM2DSlot"
        Dim pan4button5 As RibbonButton = New RibbonButton()
        pan4button5 = pan1button.Clone
        pan4button5.LargeImage = Images.getBitmap(My.Resources.small11)
        pan4button5.Text = "Trace"
        pan4button5.Tag = "_CAM2DTrace"
        Dim pan4button6 As RibbonButton = New RibbonButton()
        pan4button6 = pan1button.Clone
        pan4button6.LargeImage = Images.getBitmap(My.Resources.small12)
        pan4button6.Text = "Thread"
        pan4button6.Tag = "_CAM2DThread"
        Dim pan4button7 As RibbonButton = New RibbonButton()
        pan4button7 = pan1button.Clone
        pan4button7.LargeImage = Images.getBitmap(My.Resources.small13)
        pan4button7.Text = "Circular"
        pan4button7.Tag = "_CAM2DCircular"
        Dim pan4button8 As RibbonButton = New RibbonButton()
        pan4button8 = pan1button.Clone
        pan4button8.LargeImage = Images.getBitmap(My.Resources.small4)
        pan4button8.Text = "Bore"
        pan4button8.Tag = "_CAM2DBore"
        Dim pan4button9 As RibbonButton = New RibbonButton()
        pan4button9 = pan1button.Clone
        pan4button9.LargeImage = Images.getBitmap(My.Resources.small15)
        pan4button9.Text = "2D Chamfer"
        pan4button9.Tag = "_CAM2DChamfer"
        Dim pan4row1 As RibbonRowPanel = New RibbonRowPanel()
        pan4row1.Items.Add(pan4button1)
        pan4row1.Items.Add(New RibbonRowBreak())
        pan4row1.Items.Add(pan4button2)
        pan4row1.Items.Add(New RibbonRowBreak())
        pan4row1.Items.Add(pan4button3)
        Dim pan4row2 As RibbonRowPanel = New RibbonRowPanel()
        pan4row2.Items.Add(pan4button4)
        pan4row2.Items.Add(New RibbonRowBreak())
        pan4row2.Items.Add(pan4button5)
        pan4row2.Items.Add(New RibbonRowBreak())
        pan4row2.Items.Add(pan4button6)
        Dim pan4row3 As RibbonRowPanel = New RibbonRowPanel()
        pan4row3.Items.Add(pan4button7)
        pan4row3.Items.Add(New RibbonRowBreak())
        pan4row3.Items.Add(pan4button8)
        pan4row3.Items.Add(New RibbonRowBreak())
        pan4row3.Items.Add(pan4button9)
        panel4Panel.Items.Add(pan4button01)
        panel4Panel.Items.Add(pan4row1)
        panel4Panel.Items.Add(pan4row2)
        panel4Panel.Items.Add(pan4row3)
        '////////////////////////////////// P A N E L 5 /////////////////////////////////////
        Dim panel5Panel As Autodesk.Windows.RibbonPanelSource = New RibbonPanelSource()
        panel5Panel.Title = "3D Milling"
        Dim Panel5 As RibbonPanel = New RibbonPanel()
        Panel5.Source = panel5Panel
        Tab.Panels.Add(Panel5)
        Dim pan5button01 As RibbonButton = New RibbonButton()
        pan5button01 = panbutton0.Clone
        pan5button01.LargeImage = Images.getBitmap(My.Resources.large6)
        pan5button01.Text = "Adaptive"
        pan5button01.Name = "Adaptive"
        pan5button01.Tag = "_CAM3DAdaptive"
        Dim pan5button1 As RibbonButton = New RibbonButton()
        pan5button1 = pan1button.Clone
        pan5button1.LargeImage = Images.getBitmap(My.Resources.small16)
        pan5button1.Text = "Horizontal"
        pan5button1.Tag = "_CAM3DHorizontal"
        Dim pan5button2 As RibbonButton = New RibbonButton()
        pan5button2 = pan1button.Clone
        pan5button2.Image = Images.getBitmap(My.Resources.small17)
        pan5button2.Text = "Contour"
        pan5button2.Tag = "_CAM3DContour"
        Dim pan5button3 As RibbonButton = New RibbonButton()
        pan5button3 = pan1button.Clone
        pan5button3.LargeImage = Images.getBitmap(My.Resources.small18)
        pan5button3.Text = "Parallel"
        pan5button3.Tag = "_CAM3DParallel"
        Dim pan5button4 As RibbonButton = New RibbonButton()
        pan5button4 = pan1button.Clone
        pan5button4.LargeImage = Images.getBitmap(My.Resources.small19)
        pan5button4.Text = "Pocket"
        pan5button4.Tag = "_CAM3DPocket"
        Dim pan5button5 As RibbonButton = New RibbonButton()
        pan5button5 = pan1button.Clone
        pan5button5.LargeImage = Images.getBitmap(My.Resources.small20)
        pan5button5.Text = "Radial"
        pan5button5.Tag = "_CAM3DRadial"
        Dim pan5button6 As RibbonButton = New RibbonButton()
        pan5button6 = pan1button.Clone
        pan5button6.LargeImage = Images.getBitmap(My.Resources.small21)
        pan5button6.Text = "Flow"
        pan5button6.Tag = "_CAM3DFlow"
        Dim pan5row1 As RibbonRowPanel = New RibbonRowPanel()
        pan5row1.Items.Add(pan5button1)
        pan5row1.Items.Add(New RibbonRowBreak())
        pan5row1.Items.Add(pan5button2)
        pan5row1.Items.Add(New RibbonRowBreak())
        pan5row1.Items.Add(pan5button3)
        Dim pan5row2 As RibbonRowPanel = New RibbonRowPanel()
        pan5row2.Items.Add(pan5button4)
        pan5row2.Items.Add(New RibbonRowBreak())
        pan5row2.Items.Add(pan5button5)
        pan5row2.Items.Add(New RibbonRowBreak())
        pan5row2.Items.Add(pan5button6)
        panel5Panel.Items.Add(pan5button01)
        panel5Panel.Items.Add(pan5row1)
        panel5Panel.Items.Add(pan5row2)
        '////////////////////////////////// P A N E L 6 /////////////////////////////////////

        '////////////////////////////////// P A N E L 7 /////////////////////////////////////
        Dim panel7Panel As Autodesk.Windows.RibbonPanelSource = New RibbonPanelSource()
        panel7Panel.Title = "About"
        Dim Panel7 As RibbonPanel = New RibbonPanel()
        Panel7.Source = panel7Panel
        Tab.Panels.Add(Panel7)
        Dim pan7button01 As RibbonButton = New RibbonButton()
        pan7button01 = panbutton0.Clone
        pan7button01.LargeImage = Images.getBitmap(My.Resources.large8)
        pan7button01.Text = "Help / Tutorials"
        pan7button01.Name = "Help"
        pan7button01.Tag = "_CAMHelp"
        Dim pan7button02 As RibbonButton = New RibbonButton()
        pan7button02 = panbutton0.Clone
        pan7button02.LargeImage = Images.getBitmap(My.Resources.large9)
        pan7button02.Text = "About"
        pan7button02.Name = "About"
        pan7button02.Tag = "_CAMAbout"
        Dim pan7row1 As RibbonRowPanel = New RibbonRowPanel()
        panel7Panel.Items.Add(pan7button01)
        panel7Panel.Items.Add(New RibbonSeparator())
        panel7Panel.Items.Add(pan7button02)
        panel7Panel.Items.Add(pan7row1)
        Tab.IsActive = True
        Tab.IsVisible = True
    End Sub
    Public Shared Sub Deactiv()
        Dim ribbonControl As Autodesk.Windows.RibbonControl = Autodesk.Windows.ComponentManager.Ribbon
        Dim InstallCHK As RibbonTab = ribbonControl.FindTab("CAM")
        InstallCHK.IsEnabled = False
        InstallCHK.IsPanelEnabled = False
    End Sub

    Public Shared Sub Activ()
        Dim ribbonControl As Autodesk.Windows.RibbonControl = Autodesk.Windows.ComponentManager.Ribbon
        Dim InstallCHK As RibbonTab = ribbonControl.FindTab("CAM")
        InstallCHK.IsEnabled = True
        InstallCHK.IsPanelEnabled = True
    End Sub


    Public Class RibbonCommandHandler

        Implements System.Windows.Input.ICommand

        Public Function CanExecute(ByVal parameter As Object) As Boolean Implements System.Windows.Input.ICommand.CanExecute
            Return True
        End Function

        Public Event CanExecuteChanged(ByVal sender As Object, ByVal e As System.EventArgs) Implements System.Windows.Input.ICommand.CanExecuteChanged

        Public Sub Execute(ByVal parameter As Object) Implements System.Windows.Input.ICommand.Execute

            Dim doc As Document = Application.DocumentManager.MdiActiveDocument

            If TypeOf parameter Is RibbonButton Then
                Dim button As RibbonButton = TryCast(parameter, RibbonButton)
                doc.SendStringToExecute(button.Tag + " ", True, False, True)
            End If
        End Sub
    End Class

    Public Class Images

        Public Shared Function getBitmap(ByVal image As Bitmap) As BitmapImage
            Dim stream As New MemoryStream()
            image.Save(stream, ImageFormat.Png)
            Dim bmp As New BitmapImage()
            bmp.BeginInit()
            bmp.StreamSource = stream
            bmp.EndInit()
            Return bmp
        End Function
    End Class
End Class
