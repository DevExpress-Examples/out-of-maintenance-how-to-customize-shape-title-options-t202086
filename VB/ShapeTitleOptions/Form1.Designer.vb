Namespace ShapeTitleOptions
    Partial Public Class Form1
        ''' <summary>
        ''' Required designer variable.
        ''' </summary>
        Private components As System.ComponentModel.IContainer = Nothing

        ''' <summary>
        ''' Clean up any resources being used.
        ''' </summary>
        ''' <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        Protected Overrides Sub Dispose(ByVal disposing As Boolean)
            If disposing AndAlso (components IsNot Nothing) Then
                components.Dispose()
            End If
            MyBase.Dispose(disposing)
        End Sub

        #Region "Windows Form Designer generated code"

        ''' <summary>
        ''' Required method for Designer support - do not modify
        ''' the contents of this method with the code editor.
        ''' </summary>
        Private Sub InitializeComponent()
            Me.mapControl1 = New DevExpress.XtraMap.MapControl()
            Me.cbTitleVisibility = New System.Windows.Forms.CheckBox()
            DirectCast(Me.mapControl1, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.SuspendLayout()
            ' 
            ' mapControl1
            ' 
            Me.mapControl1.Dock = System.Windows.Forms.DockStyle.Fill
            Me.mapControl1.Location = New System.Drawing.Point(0, 0)
            Me.mapControl1.Name = "mapControl1"
            Me.mapControl1.NavigationPanelOptions.Visible = False
            Me.mapControl1.Size = New System.Drawing.Size(304, 201)
            Me.mapControl1.TabIndex = 0
            ' 
            ' cbTitleVisibility
            ' 
            Me.cbTitleVisibility.AutoSize = True
            Me.cbTitleVisibility.Checked = True
            Me.cbTitleVisibility.CheckState = System.Windows.Forms.CheckState.Checked
            Me.cbTitleVisibility.Location = New System.Drawing.Point(13, 13)
            Me.cbTitleVisibility.Name = "cbTitleVisibility"
            Me.cbTitleVisibility.Size = New System.Drawing.Size(110, 17)
            Me.cbTitleVisibility.TabIndex = 1
            Me.cbTitleVisibility.Text = "Show Shape Title"
            Me.cbTitleVisibility.UseVisualStyleBackColor = True
            ' 
            ' Form1
            ' 
            Me.AutoScaleDimensions = New System.Drawing.SizeF(6F, 13F)
            Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
            Me.ClientSize = New System.Drawing.Size(304, 201)
            Me.Controls.Add(Me.cbTitleVisibility)
            Me.Controls.Add(Me.mapControl1)
            Me.Name = "Form1"
            Me.Text = "Form1"
            DirectCast(Me.mapControl1, System.ComponentModel.ISupportInitialize).EndInit()
            Me.ResumeLayout(False)
            Me.PerformLayout()

        End Sub

        #End Region

        Private mapControl1 As DevExpress.XtraMap.MapControl
        Private WithEvents cbTitleVisibility As System.Windows.Forms.CheckBox


    End Class
End Namespace

