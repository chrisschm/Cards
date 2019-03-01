Option Explicit On
Imports System.ComponentModel

Public Class Card

    Implements INotifyPropertyChanged

    Public Enum ECB As Long
        ecbCrossHatch = 53
        ecbClouds = 54
        ecbBlueCurtain = 55
        ecbStriatedFish = 56
        ecbFrog = 57
        ecbRedWhirl = 58
        ecbBeach = 59
        ecbBlueSquares = 60
        ecbPurple = 61
        ecbDesertMoon = 62
        ecbAstronaut = 63
        ecbOrangeStripes = 64
        ecbSportCars = 65
        ecbUnused = 66
        ecbX = 67
        ecbO = 68
    End Enum

    Public Enum ECF As Long
        ecfAce = 1
        ecfTwo = 2
        ecfThree = 3
        ecfFour = 4
        ecfFive = 5
        ecfSix = 6
        ecfSeven = 7
        ecfEight = 8
        ecfNine = 9
        ecfTen = 10
        ecfJack = 11
        ecfQueen = 12
        ecfKing = 13
    End Enum

    Public Enum ECS As Long
        ecsClubs = 0
        ecsDiamonds = 13
        ecsHearts = 26
        ecsSpades = 39
    End Enum

    Public Enum ECT As Long
        ectFaces = 0
        ectBacks = 1
    End Enum

    Private lngHeight As Integer
    Private lngWidth As Integer
    Private lngCardBack As ECB = ECB.ecbCrossHatch
    Private lngCardFace As ECF = ECF.ecfAce
    Private lngCardSuit As ECS = ECS.ecsHearts
    Private lngCardType As ECT = ECT.ectBacks

    Public Sub New()

        ' Dieser Aufruf ist für den Designer erforderlich.
        InitializeComponent()

        ' Fügen Sie Initialisierungen nach dem InitializeComponent()-Aufruf hinzu.
        lngHeight = My.Resources.cards32_1.Height
        lngWidth = My.Resources.cards32_1.Width
        Me.BorderStyle = BorderStyle.None
        Me.MaximumSize = New Size(lngWidth, lngHeight)
        Me.MinimumSize = New Size(lngWidth, lngHeight)
        My.Settings.Reload()
        lngCardBack = My.Settings.CardBack
        lngCardFace = My.Settings.CardFace
        lngCardSuit = My.Settings.CardSuit
        lngCardType = My.Settings.CardType
        NotifyPropertyChanged("")

    End Sub

    Public Event PropertyChanged As PropertyChangedEventHandler Implements INotifyPropertyChanged.PropertyChanged

    Public Shadows Event Click()
    Public Shadows Event DoubleClick()
    Public Shadows Event KeyDown(sender As Object, e As KeyEventArgs)
    Public Shadows Event KeyPress(sender As Object, e As KeyPressEventArgs)
    Public Shadows Event KeyUp(sender As Object, e As KeyEventArgs)
    Public Shadows Event MouseDown(sender As Object, e As MouseEventArgs)
    Public Shadows Event MouseMove(sender As Object, e As MouseEventArgs)
    Public Shadows Event MouseUp(sender As Object, e As MouseEventArgs)








    Private Sub Card_Click() Handles Me.Click
        RaiseEvent Click()
    End Sub

    Private Sub Card_DoubleClick() Handles Me.DoubleClick
        RaiseEvent DoubleClick()
    End Sub

    Private Sub Card_KeyDown(sender As Object, e As KeyEventArgs) Handles Me.KeyDown
        RaiseEvent KeyDown(sender, e)
    End Sub

    Private Sub Card_KeyPress(sender As Object, e As KeyPressEventArgs) Handles Me.KeyPress
        RaiseEvent KeyPress(sender, e)
    End Sub

    Private Sub Card_KeyUp(sender As Object, e As KeyEventArgs) Handles Me.KeyUp
        RaiseEvent KeyUp(sender, e)
    End Sub

    Private Sub Card_MouseDown(sender As Object, e As MouseEventArgs) Handles Me.MouseDown
        RaiseEvent MouseDown(sender, e)
    End Sub

    Private Sub Card_MouseMove(sender As Object, e As MouseEventArgs) Handles Me.MouseMove
        RaiseEvent MouseMove(sender, e)
    End Sub

    Private Sub Card_MouseUp(sender As Object, e As MouseEventArgs) Handles Me.MouseUp
        RaiseEvent MouseUp(sender, e)
    End Sub

    Private Sub NotifyPropertyChanged(Info As String)
        RaiseEvent PropertyChanged(Me, New PropertyChangedEventArgs(Info))

        Dim lngTemp As Long = 0
        Debug.Print("Card.NotifyPropertyChanged")
        If lngCardType = ECT.ectFaces Then

            lngTemp = lngCardSuit + lngCardFace
            Select Case lngTemp
                Case 1
                    Me.BackgroundImage = My.Resources.cards32_1
                Case 2
                    Me.BackgroundImage = My.Resources.cards32_2
                Case 3
                    Me.BackgroundImage = My.Resources.cards32_3
                Case 4
                    Me.BackgroundImage = My.Resources.cards32_4
                Case 5
                    Me.BackgroundImage = My.Resources.cards32_5
                Case 6
                    Me.BackgroundImage = My.Resources.cards32_6
                Case 7
                    Me.BackgroundImage = My.Resources.cards32_7
                Case 8
                    Me.BackgroundImage = My.Resources.cards32_8
                Case 9
                    Me.BackgroundImage = My.Resources.cards32_9
                Case 10
                    Me.BackgroundImage = My.Resources.cards32_10
                Case 11
                    Me.BackgroundImage = My.Resources.cards32_11
                Case 12
                    Me.BackgroundImage = My.Resources.cards32_12
                Case 13
                    Me.BackgroundImage = My.Resources.cards32_13
                Case 14
                    Me.BackgroundImage = My.Resources.cards32_14
                Case 15
                    Me.BackgroundImage = My.Resources.cards32_15
                Case 16
                    Me.BackgroundImage = My.Resources.cards32_16
                Case 17
                    Me.BackgroundImage = My.Resources.cards32_17
                Case 18
                    Me.BackgroundImage = My.Resources.cards32_18
                Case 19
                    Me.BackgroundImage = My.Resources.cards32_19
                Case 20
                    Me.BackgroundImage = My.Resources.cards32_20
                Case 21
                    Me.BackgroundImage = My.Resources.cards32_21
                Case 22
                    Me.BackgroundImage = My.Resources.cards32_22
                Case 23
                    Me.BackgroundImage = My.Resources.cards32_23
                Case 24
                    Me.BackgroundImage = My.Resources.cards32_24
                Case 25
                    Me.BackgroundImage = My.Resources.cards32_25
                Case 26
                    Me.BackgroundImage = My.Resources.cards32_26
                Case 27
                    Me.BackgroundImage = My.Resources.cards32_27
                Case 28
                    Me.BackgroundImage = My.Resources.cards32_28
                Case 29
                    Me.BackgroundImage = My.Resources.cards32_29
                Case 30
                    Me.BackgroundImage = My.Resources.cards32_30
                Case 31
                    Me.BackgroundImage = My.Resources.cards32_31
                Case 32
                    Me.BackgroundImage = My.Resources.cards32_32
                Case 33
                    Me.BackgroundImage = My.Resources.cards32_33
                Case 34
                    Me.BackgroundImage = My.Resources.cards32_34
                Case 35
                    Me.BackgroundImage = My.Resources.cards32_35
                Case 36
                    Me.BackgroundImage = My.Resources.cards32_36
                Case 37
                    Me.BackgroundImage = My.Resources.cards32_37
                Case 38
                    Me.BackgroundImage = My.Resources.cards32_38
                Case 39
                    Me.BackgroundImage = My.Resources.cards32_39
                Case 40
                    Me.BackgroundImage = My.Resources.cards32_40
                Case 41
                    Me.BackgroundImage = My.Resources.cards32_41
                Case 42
                    Me.BackgroundImage = My.Resources.cards32_42
                Case 43
                    Me.BackgroundImage = My.Resources.cards32_43
                Case 44
                    Me.BackgroundImage = My.Resources.cards32_44
                Case 45
                    Me.BackgroundImage = My.Resources.cards32_45
                Case 46
                    Me.BackgroundImage = My.Resources.cards32_46
                Case 47
                    Me.BackgroundImage = My.Resources.cards32_47
                Case 48
                    Me.BackgroundImage = My.Resources.cards32_48
                Case 49
                    Me.BackgroundImage = My.Resources.cards32_49
                Case 50
                    Me.BackgroundImage = My.Resources.cards32_50
                Case 51
                    Me.BackgroundImage = My.Resources.cards32_51
                Case 52
                    Me.BackgroundImage = My.Resources.cards32_52
                Case Else
                    Err.Raise(vbObjectError + 1000, Me.ToString, "Ressource " & lngTemp.ToString & " ist nicht vorhanden.")
            End Select

        Else

            lngTemp = lngCardBack
            Select Case lngTemp
                Case 53
                    Me.BackgroundImage = My.Resources.cards32_53
                Case 54
                    Me.BackgroundImage = My.Resources.cards32_54
                Case 55
                    Me.BackgroundImage = My.Resources.cards32_55
                Case 56
                    Me.BackgroundImage = My.Resources.cards32_56
                Case 57
                    Me.BackgroundImage = My.Resources.cards32_57
                Case 58
                    Me.BackgroundImage = My.Resources.cards32_58
                Case 59
                    Me.BackgroundImage = My.Resources.cards32_59
                Case 60
                    Me.BackgroundImage = My.Resources.cards32_60
                Case 61
                    Me.BackgroundImage = My.Resources.cards32_61
                Case 62
                    Me.BackgroundImage = My.Resources.cards32_62
                Case 63
                    Me.BackgroundImage = My.Resources.cards32_63
                Case 64
                    Me.BackgroundImage = My.Resources.cards32_64
                Case 65
                    Me.BackgroundImage = My.Resources.cards32_65
                Case 67
                    Me.BackgroundImage = My.Resources.cards32_67
                Case 68
                    Me.BackgroundImage = My.Resources.cards32_68
                Case Else
                    Err.Raise(vbObjectError + 1000, Me.ToString, "Ressource " & lngTemp.ToString & " ist nicht vorhanden.")
            End Select

        End If
        Refresh()

        ' Settings speichern !!!!!!!!!!!!!!!!!!!!!!!!!

        Select Case Info
            Case ""
            Case "CardBack"
                My.Settings.CardBack = lngCardBack
            Case "CardFace"
                My.Settings.CardFace = lngCardFace
            Case "CardSuit"
                My.Settings.CardSuit = lngCardSuit
            Case "CardType"
                My.Settings.CardType = lngCardType



            Case Else
                Err.Raise(vbObjectError + 1001, Me.ToString, "Eigenschaft """ & Info & """ kann nicht gespeichert werden.")
        End Select
        My.Settings.Save()

    End Sub






    Public Property CardBack() As ECB
        Get
            CardBack = lngCardBack
        End Get
        Set(value As ECB)
            lngCardBack = value
            NotifyPropertyChanged("CardBack")
        End Set
    End Property

    Public Property CardFace() As ECF
        Get
            CardFace = lngCardFace
        End Get
        Set(value As ECF)
            lngCardFace = value
            NotifyPropertyChanged("CardFace")
        End Set
    End Property

    Public Property CardSuit() As ECS
        Get
            CardSuit = lngCardSuit
        End Get
        Set(value As ECS)
            lngCardSuit = value
            NotifyPropertyChanged("CardSuit")
        End Set
    End Property

    Public Property CardType() As ECT
        Get
            CardType = lngCardType
        End Get
        Set(value As ECT)
            lngCardType = value
            NotifyPropertyChanged("CardType")
        End Set
    End Property


End Class
