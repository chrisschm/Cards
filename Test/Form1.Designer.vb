<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Das Formular überschreibt den Löschvorgang, um die Komponentenliste zu bereinigen.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.PlayingCard = New CS.Gaming.PlayingCard()
        Me.cboTyp = New System.Windows.Forms.ComboBox()
        Me.cboFaces = New System.Windows.Forms.ComboBox()
        Me.cboSuit = New System.Windows.Forms.ComboBox()
        Me.cboBack = New System.Windows.Forms.ComboBox()
        Me.SuspendLayout()
        '
        'PlayingCard
        '
        Me.PlayingCard.CardBack = CS.Gaming.PlayingCard.ECB.StriatedFish
        Me.PlayingCard.CardFace = CS.Gaming.PlayingCard.ECF.Queen
        Me.PlayingCard.CardSuit = CS.Gaming.PlayingCard.ECS.Hearts
        Me.PlayingCard.CardType = CS.Gaming.PlayingCard.ECT.Faces
        Me.PlayingCard.Location = New System.Drawing.Point(32, 32)
        Me.PlayingCard.Name = "PlayingCard"
        Me.PlayingCard.Size = New System.Drawing.Size(71, 96)
        Me.PlayingCard.TabIndex = 0
        '
        'cboTyp
        '
        Me.cboTyp.FormattingEnabled = True
        Me.cboTyp.Location = New System.Drawing.Point(153, 32)
        Me.cboTyp.Name = "cboTyp"
        Me.cboTyp.Size = New System.Drawing.Size(160, 24)
        Me.cboTyp.TabIndex = 1
        '
        'cboFaces
        '
        Me.cboFaces.FormattingEnabled = True
        Me.cboFaces.Location = New System.Drawing.Point(153, 62)
        Me.cboFaces.Name = "cboFaces"
        Me.cboFaces.Size = New System.Drawing.Size(160, 24)
        Me.cboFaces.TabIndex = 2
        '
        'cboSuit
        '
        Me.cboSuit.FormattingEnabled = True
        Me.cboSuit.Location = New System.Drawing.Point(153, 92)
        Me.cboSuit.Name = "cboSuit"
        Me.cboSuit.Size = New System.Drawing.Size(160, 24)
        Me.cboSuit.TabIndex = 3
        '
        'cboBack
        '
        Me.cboBack.FormattingEnabled = True
        Me.cboBack.Location = New System.Drawing.Point(153, 122)
        Me.cboBack.Name = "cboBack"
        Me.cboBack.Size = New System.Drawing.Size(160, 24)
        Me.cboBack.TabIndex = 4
        '
        'Form1
        '
        Me.ClientSize = New System.Drawing.Size(362, 182)
        Me.Controls.Add(Me.cboBack)
        Me.Controls.Add(Me.cboSuit)
        Me.Controls.Add(Me.cboFaces)
        Me.Controls.Add(Me.cboTyp)
        Me.Controls.Add(Me.PlayingCard)
        Me.Name = "Form1"
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents PlayingCard1 As CS.Gaming.PlayingCard
    Friend WithEvents ECBBindingSource As BindingSource
    Friend WithEvents PlayingCard As CS.Gaming.PlayingCard
    Friend WithEvents cboTyp As ComboBox
    Friend WithEvents cboFaces As ComboBox
    Friend WithEvents cboSuit As ComboBox
    Friend WithEvents cboBack As ComboBox
End Class
