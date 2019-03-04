Option Explicit On
Imports System.ComponentModel

Public Class Card

    Implements INotifyPropertyChanged

    ' Auflistung für Kartenrückseite
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

    ' Auflistung für Spielkarten (Vorderseite)
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

    ' Auflistung für Kartenfarbe
    Public Enum ECS As Long
        ecsClubs = 0
        ecsDiamonds = 13
        ecsHearts = 26
        ecsSpades = 39
    End Enum

    ' Auflistung für Kartenseite
    Public Enum ECT As Long
        ectFaces = 0
        ectBacks = 1
    End Enum

    Private lngHeight As Integer ' Höhe UserControl
    Private lngWidth As Integer ' Breite UserControl
    Private lngCardBack As ECB = ECB.ecbCrossHatch ' Kartenrückseite
    Private lngCardFace As ECF = ECF.ecfAce ' Kartenvorderseite
    Private lngCardSuit As ECS = ECS.ecsHearts ' Kartenfarbe
    Private lngCardType As ECT = ECT.ectBacks ' Kartenseite

    Public Sub New()

        ' Dieser Aufruf ist für den Designer erforderlich.
        InitializeComponent()

        ' Fügen Sie Initialisierungen nach dem InitializeComponent()-Aufruf hinzu.

        ' Breite und Höhe der Ressourcen-Bilder als Usercontrol Ausmaße übernehmen
        lngHeight = My.Resources.cards32_1.Height
        lngWidth = My.Resources.cards32_1.Width
        Me.MaximumSize = New Size(lngWidth, lngHeight)
        Me.MinimumSize = New Size(lngWidth, lngHeight)

        ' Designzeit Einstellungen zu Laufzeit übernehmen
        My.Settings.Reload()
        lngCardBack = My.Settings.CardBack
        lngCardFace = My.Settings.CardFace
        lngCardSuit = My.Settings.CardSuit
        lngCardType = My.Settings.CardType

        ' Anzeige neu Zeichnen nach Eigenschaftenänderung
        NotifyPropertyChanged("")

    End Sub

    Public Event PropertyChanged As PropertyChangedEventHandler Implements INotifyPropertyChanged.PropertyChanged

    Public Shadows Event Click(sender As Object, e As EventArgs)
    Public Shadows Event DoubleClick(sender As Object, e As EventArgs)
    'Public Shadows Event KeyDown(sender As Object, e As KeyEventArgs)
    'Public Shadows Event KeyPress(sender As Object, e As KeyPressEventArgs)
    'Public Shadows Event KeyUp(sender As Object, e As KeyEventArgs)
    'Public Shadows Event MouseDown(sender As Object, e As MouseEventArgs)
    'Public Shadows Event MouseMove(sender As Object, e As MouseEventArgs)
    'Public Shadows Event MouseUp(sender As Object, e As MouseEventArgs)










    Private Sub NotifyPropertyChanged(Info As String)
        RaiseEvent PropertyChanged(Me, New PropertyChangedEventArgs(Info))

        Dim lngTemp As Long = 0
        Debug.Print("Card.NotifyPropertyChanged")
        If lngCardType = ECT.ectFaces Then

            lngTemp = lngCardSuit + lngCardFace
            Select Case lngTemp
                Case 1
                    picMain.Image = My.Resources.cards32_1
                Case 2
                    picMain.Image = My.Resources.cards32_2
                Case 3
                    picMain.Image = My.Resources.cards32_3
                Case 4
                    picMain.Image = My.Resources.cards32_4
                Case 5
                    picMain.Image = My.Resources.cards32_5
                Case 6
                    picMain.Image = My.Resources.cards32_6
                Case 7
                    picMain.Image = My.Resources.cards32_7
                Case 8
                    picMain.Image = My.Resources.cards32_8
                Case 9
                    picMain.Image = My.Resources.cards32_9
                Case 10
                    picMain.Image = My.Resources.cards32_10
                Case 11
                    picMain.Image = My.Resources.cards32_11
                Case 12
                    picMain.Image = My.Resources.cards32_12
                Case 13
                    picMain.Image = My.Resources.cards32_13
                Case 14
                    picMain.Image = My.Resources.cards32_14
                Case 15
                    picMain.Image = My.Resources.cards32_15
                Case 16
                    picMain.Image = My.Resources.cards32_16
                Case 17
                    picMain.Image = My.Resources.cards32_17
                Case 18
                    picMain.Image = My.Resources.cards32_18
                Case 19
                    picMain.Image = My.Resources.cards32_19
                Case 20
                    picMain.Image = My.Resources.cards32_20
                Case 21
                    picMain.Image = My.Resources.cards32_21
                Case 22
                    picMain.Image = My.Resources.cards32_22
                Case 23
                    picMain.Image = My.Resources.cards32_23
                Case 24
                    picMain.Image = My.Resources.cards32_24
                Case 25
                    picMain.Image = My.Resources.cards32_25
                Case 26
                    picMain.Image = My.Resources.cards32_26
                Case 27
                    picMain.Image = My.Resources.cards32_27
                Case 28
                    picMain.Image = My.Resources.cards32_28
                Case 29
                    picMain.Image = My.Resources.cards32_29
                Case 30
                    picMain.Image = My.Resources.cards32_30
                Case 31
                    picMain.Image = My.Resources.cards32_31
                Case 32
                    picMain.Image = My.Resources.cards32_32
                Case 33
                    picMain.Image = My.Resources.cards32_33
                Case 34
                    picMain.Image = My.Resources.cards32_34
                Case 35
                    picMain.Image = My.Resources.cards32_35
                Case 36
                    picMain.Image = My.Resources.cards32_36
                Case 37
                    picMain.Image = My.Resources.cards32_37
                Case 38
                    picMain.Image = My.Resources.cards32_38
                Case 39
                    picMain.Image = My.Resources.cards32_39
                Case 40
                    picMain.Image = My.Resources.cards32_40
                Case 41
                    picMain.Image = My.Resources.cards32_41
                Case 42
                    picMain.Image = My.Resources.cards32_42
                Case 43
                    picMain.Image = My.Resources.cards32_43
                Case 44
                    picMain.Image = My.Resources.cards32_44
                Case 45
                    picMain.Image = My.Resources.cards32_45
                Case 46
                    picMain.Image = My.Resources.cards32_46
                Case 47
                    picMain.Image = My.Resources.cards32_47
                Case 48
                    picMain.Image = My.Resources.cards32_48
                Case 49
                    picMain.Image = My.Resources.cards32_49
                Case 50
                    picMain.Image = My.Resources.cards32_50
                Case 51
                    picMain.Image = My.Resources.cards32_51
                Case 52
                    picMain.Image = My.Resources.cards32_52
                Case Else
                    Err.Raise(vbObjectError + 1000, Me.ToString, "Ressource " & lngTemp.ToString & " ist nicht vorhanden.")
            End Select

        Else

            lngTemp = lngCardBack
            Select Case lngTemp
                Case 53
                    picMain.Image = My.Resources.cards32_53
                Case 54
                    picMain.Image = My.Resources.cards32_54
                Case 55
                    picMain.Image = My.Resources.cards32_55
                Case 56
                    picMain.Image = My.Resources.cards32_56
                Case 57
                    picMain.Image = My.Resources.cards32_57
                Case 58
                    picMain.Image = My.Resources.cards32_58
                Case 59
                    picMain.Image = My.Resources.cards32_59
                Case 60
                    picMain.Image = My.Resources.cards32_60
                Case 61
                    picMain.Image = My.Resources.cards32_61
                Case 62
                    picMain.Image = My.Resources.cards32_62
                Case 63
                    picMain.Image = My.Resources.cards32_63
                Case 64
                    picMain.Image = My.Resources.cards32_64
                Case 65
                    picMain.Image = My.Resources.cards32_65
                Case 67
                    picMain.Image = My.Resources.cards32_67
                Case 68
                    picMain.Image = My.Resources.cards32_68
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




    Private Sub picMain_Click(sender As Object, e As EventArgs) Handles picMain.Click
        Debug.Print("picMain_Click")
        RaiseEvent Click(sender, e)
    End Sub

    Private Sub picMain_DoubleClick(sender As Object, e As EventArgs) Handles picMain.DoubleClick
        Debug.Print("picMain_DoubleClick")
        RaiseEvent DoubleClick(sender, e)
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
