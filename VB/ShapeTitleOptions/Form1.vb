Imports System.Drawing
Imports System.Windows.Forms
Imports DevExpress.XtraMap

Namespace ShapeTitleOptions
    Partial Public Class Form1
        Inherits Form

        Private dot As MapDot

        Public Sub New()
            InitializeComponent()
        End Sub

        #Region "#TitleOptions"
        Private Sub Form1_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles MyBase.Load
            Dim storage As New MapItemStorage()
            Dim layer As New VectorItemsLayer() With {.Data = storage}

            dot = New MapDot() With {.Size = 100}
            dot.TitleOptions.TextColor = Color.Orange
            dot.TitleOptions.TextGlowColor = Color.Black
            dot.TitleOptions.Pattern = "{Title}"

            dot.Attributes.Add(New MapItemAttribute() With {.Name = "Title", .Value = "Hello," & ControlChars.Lf & "I am Dot."})
            storage.Items.Add(dot)

            mapControl1.Layers.Add(layer)
        End Sub
        #End Region ' #TitleOptions

        #Region "#TitleVisibility"
        Private Sub cbTitleVisibility_CheckedChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles cbTitleVisibility.CheckedChanged
            If cbTitleVisibility.Checked Then
                dot.TitleOptions.Visibility = VisibilityMode.Visible
            Else
                dot.TitleOptions.Visibility = VisibilityMode.Hidden
            End If
        End Sub
        #End Region ' #TitleVisibility
    End Class
End Namespace
