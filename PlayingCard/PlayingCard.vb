Imports System.ComponentModel

Namespace Global
    Namespace CS
        Namespace Gaming

            ''' <summary>
            ''' Class to show (paint) a playing cards for card-games.
            ''' </summary>
            Public Class PlayingCard

#Region "Public Constants"
                ''' <summary>
                ''' Use the SizeRatio to compute correct ratio between height 
                ''' and width of the control while changing the size. Optimal
                ''' size for the card picture (My.Resources.Cardnn) would be 
                ''' 96 / 71 = 1.352112676056338 (Height / Width)
                ''' </summary>
                Public Const SizeRatio As Double = (96 / 71)
#End Region

#Region "Public Enumerations"
                ''' <summary>
                ''' Enumeration for card backsite
                ''' </summary>
                Public Enum ECB As Integer 'EnumCardBack
                    CrossHatch = 53
                    Clouds = 54
                    BlueCurtain = 55
                    StriatedFish = 56
                    Frog = 57
                    RedWhirl = 58
                    Beach = 59
                    BlueSquares = 60
                    Purple = 61
                    DesertMoon = 62
                    Astronaut = 63
                    OrangeStripes = 64
                    SportCars = 65
                    'Unused = 66
                    X = 67
                    O = 68
                End Enum

                ''' <summary>
                ''' Enumeration for card faces
                ''' </summary>
                Public Enum ECF As Integer 'EnumCardFace
                    Ace = 1
                    Two = 2
                    Three = 3
                    Four = 4
                    Five = 5
                    Six = 6
                    Seven = 7
                    Eight = 8
                    Nine = 9
                    Ten = 10
                    Jack = 11
                    Queen = 12
                    King = 13
                End Enum

                ''' <summary>
                ''' Enumeration for card suits
                ''' </summary>
                Public Enum ECS As Integer 'EnumCardSuit
                    Clubs = 0
                    Diamonds = 13
                    Hearts = 26
                    Spades = 39
                End Enum

                ''' <summary>
                ''' Enumeration for card types (face or backsite)
                ''' </summary>
                Public Enum ECT As Integer 'EnumCardType
                    Faces = 0
                    Backs = 1
                End Enum
#End Region

#Region "Private Variables"
                ''' <summary>
                ''' To save property CardBack value
                ''' </summary>
                Private intCardBack As ECB = ECB.CrossHatch

                ''' <summary>
                ''' To save property CardFace value
                ''' </summary>
                Private intCardFace As ECF = ECF.Ace

                ''' <summary>
                ''' To save property CardSuit value
                ''' </summary>
                Private intCardSuit As ECS = ECS.Hearts

                ''' <summary>
                ''' To save property CardType value
                ''' </summary>
                Private intCardType As ECT = ECT.Backs
#End Region

#Region "Public Events"
                ''' <summary>
                ''' Occurs when the control is clicked.
                ''' </summary>
                Public Shadows Event Click(sender As Object, e As EventArgs)

                ''' <summary>
                ''' Occurs when the control is double-clicked.
                ''' </summary>
                Public Shadows Event DoubleClick(sender As Object, e As EventArgs)

                'Public Shadows Event KeyDown(sender As Object, e As KeyEventArgs)
                'Public Shadows Event KeyPress(sender As Object, e As KeyPressEventArgs)
                'Public Shadows Event KeyUp(sender As Object, e As KeyEventArgs)
                'Public Shadows Event MouseDown(sender As Object, e As MouseEventArgs)
                'Public Shadows Event MouseMove(sender As Object, e As MouseEventArgs)
                'Public Shadows Event MouseUp(sender As Object, e As MouseEventArgs)
#End Region

#Region "Private Methods"
                ''' <summary>
                ''' Method to save properties into settings and repaint the control when properies where changed
                ''' </summary>
                ''' <param name="Info">Property name to save value from</param>
                Private Sub NotifyPropertyChanged(Info As String)

                    Dim lngTemp As Long = 0
                    If intCardType = ECT.Faces Then

                        lngTemp = intCardSuit + intCardFace
                        Select Case lngTemp
                            Case 1
                                PictureBox.Image = My.Resources.Card01
                            Case 2
                                PictureBox.Image = My.Resources.Card02
                            Case 3
                                PictureBox.Image = My.Resources.Card03
                            Case 4
                                PictureBox.Image = My.Resources.Card04
                            Case 5
                                PictureBox.Image = My.Resources.Card05
                            Case 6
                                PictureBox.Image = My.Resources.Card06
                            Case 7
                                PictureBox.Image = My.Resources.Card07
                            Case 8
                                PictureBox.Image = My.Resources.Card08
                            Case 9
                                PictureBox.Image = My.Resources.Card09
                            Case 10
                                PictureBox.Image = My.Resources.Card10
                            Case 11
                                PictureBox.Image = My.Resources.Card11
                            Case 12
                                PictureBox.Image = My.Resources.Card12
                            Case 13
                                PictureBox.Image = My.Resources.Card13
                            Case 14
                                PictureBox.Image = My.Resources.Card14
                            Case 15
                                PictureBox.Image = My.Resources.Card15
                            Case 16
                                PictureBox.Image = My.Resources.Card16
                            Case 17
                                PictureBox.Image = My.Resources.Card17
                            Case 18
                                PictureBox.Image = My.Resources.Card18
                            Case 19
                                PictureBox.Image = My.Resources.Card19
                            Case 20
                                PictureBox.Image = My.Resources.Card20
                            Case 21
                                PictureBox.Image = My.Resources.Card21
                            Case 22
                                PictureBox.Image = My.Resources.Card22
                            Case 23
                                PictureBox.Image = My.Resources.Card23
                            Case 24
                                PictureBox.Image = My.Resources.Card24
                            Case 25
                                PictureBox.Image = My.Resources.Card25
                            Case 26
                                PictureBox.Image = My.Resources.Card26
                            Case 27
                                PictureBox.Image = My.Resources.Card27
                            Case 28
                                PictureBox.Image = My.Resources.Card28
                            Case 29
                                PictureBox.Image = My.Resources.Card29
                            Case 30
                                PictureBox.Image = My.Resources.Card30
                            Case 31
                                PictureBox.Image = My.Resources.Card31
                            Case 32
                                PictureBox.Image = My.Resources.Card32
                            Case 33
                                PictureBox.Image = My.Resources.Card33
                            Case 34
                                PictureBox.Image = My.Resources.Card34
                            Case 35
                                PictureBox.Image = My.Resources.Card35
                            Case 36
                                PictureBox.Image = My.Resources.Card36
                            Case 37
                                PictureBox.Image = My.Resources.Card37
                            Case 38
                                PictureBox.Image = My.Resources.Card38
                            Case 39
                                PictureBox.Image = My.Resources.Card39
                            Case 40
                                PictureBox.Image = My.Resources.Card40
                            Case 41
                                PictureBox.Image = My.Resources.Card41
                            Case 42
                                PictureBox.Image = My.Resources.Card42
                            Case 43
                                PictureBox.Image = My.Resources.Card43
                            Case 44
                                PictureBox.Image = My.Resources.Card44
                            Case 45
                                PictureBox.Image = My.Resources.Card45
                            Case 46
                                PictureBox.Image = My.Resources.Card46
                            Case 47
                                PictureBox.Image = My.Resources.Card47
                            Case 48
                                PictureBox.Image = My.Resources.Card48
                            Case 49
                                PictureBox.Image = My.Resources.Card49
                            Case 50
                                PictureBox.Image = My.Resources.Card50
                            Case 51
                                PictureBox.Image = My.Resources.Card51
                            Case 52
                                PictureBox.Image = My.Resources.Card52
                            Case Else
                                Err.Raise(vbObjectError + 1000, Me.ToString, "Resource " & lngTemp.ToString & " does not exist.")
                        End Select

                    Else

                        lngTemp = intCardBack
                        Select Case lngTemp
                            Case 53
                                PictureBox.Image = My.Resources.Card53
                            Case 54
                                PictureBox.Image = My.Resources.Card54
                            Case 55
                                PictureBox.Image = My.Resources.Card55
                            Case 56
                                PictureBox.Image = My.Resources.Card56
                            Case 57
                                PictureBox.Image = My.Resources.Card57
                            Case 58
                                PictureBox.Image = My.Resources.Card58
                            Case 59
                                PictureBox.Image = My.Resources.Card59
                            Case 60
                                PictureBox.Image = My.Resources.Card60
                            Case 61
                                PictureBox.Image = My.Resources.Card61
                            Case 62
                                PictureBox.Image = My.Resources.Card62
                            Case 63
                                PictureBox.Image = My.Resources.Card63
                            Case 64
                                PictureBox.Image = My.Resources.Card64
                            Case 65
                                PictureBox.Image = My.Resources.Card65
                            Case 67
                                PictureBox.Image = My.Resources.Card67
                            Case 68
                                PictureBox.Image = My.Resources.Card68
                            Case Else
                                Err.Raise(vbObjectError + 1000, Me.ToString, "Resource " & lngTemp.ToString & " does not exist.")
                        End Select

                    End If
                    Refresh()

                    Select Case Info
                        Case "" 'nothing to save
                        Case "CardBack"
                            My.Settings.CardBack = intCardBack
                        Case "CardFace"
                            My.Settings.CardFace = intCardFace
                        Case "CardSuit"
                            My.Settings.CardSuit = intCardSuit
                        Case "CardType"
                            My.Settings.CardType = intCardType
                        Case Else
                            Err.Raise(vbObjectError + 1001, Me.ToString, "Can not save property """ & Info & """.")
                    End Select
                    My.Settings.Save()

                End Sub

                ''' <summary>
                ''' Make PictureBox click event to this controls click event
                ''' </summary>
                Private Sub PictureBox_Click(sender As Object, e As EventArgs) Handles PictureBox.Click
                    RaiseEvent Click(sender, e)
                End Sub

                ''' <summary>
                ''' Make PictureBox double-click event to this controls double-click event
                ''' </summary>
                Private Sub PictureBox_DoubleClick(sender As Object, e As EventArgs) Handles PictureBox.DoubleClick
                    RaiseEvent DoubleClick(sender, e)
                End Sub
#End Region

#Region "CreateClass Methods"
                ''' <summary>
                ''' Creates an returns a PlayingCard object
                ''' </summary>
                Public Sub New()

                    ' Required for designer !
                    InitializeComponent()

                    ' Load property values from settings
                    My.Settings.Reload()
                    intCardBack = My.Settings.CardBack
                    intCardFace = My.Settings.CardFace
                    intCardSuit = My.Settings.CardSuit
                    intCardType = My.Settings.CardType

                    ' Repaint after property changed (without saving)
                    NotifyPropertyChanged("")

                End Sub
#End Region

#Region "PublicProperties"
                ''' <summary>
                ''' Property to store backsite of the card
                ''' </summary>
                Public Property CardBack() As ECB
                    Get
                        Return intCardBack
                    End Get
                    Set(value As ECB)
                        intCardBack = value
                        NotifyPropertyChanged("CardBack")
                    End Set
                End Property

                ''' <summary>
                ''' Property to store face of the card
                ''' </summary>
                Public Property CardFace() As ECF
                    Get
                        Return intCardFace
                    End Get
                    Set(value As ECF)
                        intCardFace = value
                        NotifyPropertyChanged("CardFace")
                    End Set
                End Property

                ''' <summary>
                ''' Property to store suit of the card
                ''' </summary>
                Public Property CardSuit() As ECS
                    Get
                        Return intCardSuit
                    End Get
                    Set(value As ECS)
                        intCardSuit = value
                        NotifyPropertyChanged("CardSuit")
                    End Set
                End Property

                ''' <summary>
                ''' Property to store type of the card (front or back)
                ''' </summary>
                Public Property CardType() As ECT
                    Get
                        CardType = intCardType
                    End Get
                    Set(value As ECT)
                        intCardType = value
                        NotifyPropertyChanged("CardType")
                    End Set
                End Property
#End Region

            End Class

        End Namespace
    End Namespace
End Namespace