<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Card
    Inherits System.Windows.Forms.UserControl

    'UserControl1 überschreibt den Löschvorgang, um die Komponentenliste zu bereinigen.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Wird vom Windows Form-Designer benötigt.
    Private components As System.ComponentModel.IContainer

    'Hinweis: Die folgende Prozedur ist für den Windows Form-Designer erforderlich.
    'Das Bearbeiten ist mit dem Windows Form-Designer möglich.  
    'Das Bearbeiten mit dem Code-Editor ist nicht möglich.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.picMain = New System.Windows.Forms.PictureBox()
        CType(Me.picMain, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'picMain
        '
        Me.picMain.Dock = System.Windows.Forms.DockStyle.Fill
        Me.picMain.Image = Global.FCards.My.Resources.Resources.cards32_53
        Me.picMain.InitialImage = Nothing
        Me.picMain.Location = New System.Drawing.Point(0, 0)
        Me.picMain.Margin = New System.Windows.Forms.Padding(0)
        Me.picMain.Name = "picMain"
        Me.picMain.Size = New System.Drawing.Size(71, 96)
        Me.picMain.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.picMain.TabIndex = 0
        Me.picMain.TabStop = False
        '
        'Card
        '
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None
        Me.BackColor = System.Drawing.SystemColors.Control
        Me.Controls.Add(Me.picMain)
        Me.Name = "Card"
        Me.Size = New System.Drawing.Size(71, 96)
        CType(Me.picMain, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents picMain As PictureBox
End Class
