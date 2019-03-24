Imports CS.Gaming

Public Class Form1

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        cboTyp.Items.Add("Back")
        cboTyp.Items.Add("Face")
        cboTyp.SelectedIndex = 1

        cboFaces.Items.Add("Ace")
        cboFaces.Items.Add("Two")
        cboFaces.Items.Add("Three")
        cboFaces.Items.Add("Four")
        cboFaces.Items.Add("Five")
        cboFaces.Items.Add("Six")
        cboFaces.Items.Add("Seven")
        cboFaces.Items.Add("Eight")
        cboFaces.Items.Add("Nine")
        cboFaces.Items.Add("Ten")
        cboFaces.Items.Add("Jack")
        cboFaces.Items.Add("Queen")
        cboFaces.Items.Add("King")
        cboFaces.SelectedIndex = 11

        cboSuit.Items.Add("Clubs")
        cboSuit.Items.Add("Diamonds")
        cboSuit.Items.Add("Hearts")
        cboSuit.Items.Add("Spades")
        cboSuit.SelectedIndex = 2

        cboBack.Items.Add("CrossHatch")
        cboBack.Items.Add("Clouds")
        cboBack.Items.Add("BlueCurtain")
        cboBack.Items.Add("StriatedFish")
        cboBack.Items.Add("Frog")
        cboBack.Items.Add("RedWhirl")
        cboBack.Items.Add("Beach")
        cboBack.Items.Add("BlueSquares")
        cboBack.Items.Add("Purple")
        cboBack.Items.Add("DesertMoon")
        cboBack.Items.Add("Astronaut")
        cboBack.Items.Add("OrangeStripes")
        cboBack.Items.Add("SportCars")
        cboBack.Items.Add("X")
        cboBack.Items.Add("O")
        cboBack.SelectedIndex = 0

    End Sub

    Private Sub cboTyp_SelectedValueChanged(sender As Object, e As EventArgs) Handles cboTyp.SelectedValueChanged

        Select Case cboTyp.SelectedIndex
            Case 0
                PlayingCard.CardType = PlayingCard.ECT.Backs
                cboFaces.Enabled = False
                cboSuit.Enabled = False
                cboBack.Enabled = True
            Case 1
                PlayingCard.CardType = PlayingCard.ECT.Faces
                cboFaces.Enabled = True
                cboSuit.Enabled = True
                cboBack.Enabled = False
        End Select

    End Sub

    Private Sub cboFaces_SelectedValueChanged(sender As Object, e As EventArgs) Handles cboFaces.SelectedValueChanged

        Select Case cboFaces.SelectedIndex
            Case 0
                PlayingCard.CardFace = PlayingCard.ECF.Ace
            Case 1
                PlayingCard.CardFace = PlayingCard.ECF.Two
            Case 2
                PlayingCard.CardFace = PlayingCard.ECF.Three
            Case 3
                PlayingCard.CardFace = PlayingCard.ECF.Four
            Case 4
                PlayingCard.CardFace = PlayingCard.ECF.Five
            Case 5
                PlayingCard.CardFace = PlayingCard.ECF.Six
            Case 6
                PlayingCard.CardFace = PlayingCard.ECF.Seven
            Case 7
                PlayingCard.CardFace = PlayingCard.ECF.Eight
            Case 8
                PlayingCard.CardFace = PlayingCard.ECF.Nine
            Case 9
                PlayingCard.CardFace = PlayingCard.ECF.Ten
            Case 10
                PlayingCard.CardFace = PlayingCard.ECF.Jack
            Case 11
                PlayingCard.CardFace = PlayingCard.ECF.Queen
            Case 12
                PlayingCard.CardFace = PlayingCard.ECF.King
        End Select

    End Sub

    Private Sub cboBack_SelectedValueChanged(sender As Object, e As EventArgs) Handles cboBack.SelectedValueChanged

        Select Case cboBack.SelectedIndex
            Case 0
                PlayingCard.CardBack = PlayingCard.ECB.CrossHatch
            Case 1
                PlayingCard.CardBack = PlayingCard.ECB.Clouds
            Case 2
                PlayingCard.CardBack = PlayingCard.ECB.BlueCurtain
            Case 3
                PlayingCard.CardBack = PlayingCard.ECB.StriatedFish
            Case 4
                PlayingCard.CardBack = PlayingCard.ECB.Frog
            Case 5
                PlayingCard.CardBack = PlayingCard.ECB.RedWhirl
            Case 6
                PlayingCard.CardBack = PlayingCard.ECB.Beach
            Case 7
                PlayingCard.CardBack = PlayingCard.ECB.BlueSquares
            Case 8
                PlayingCard.CardBack = PlayingCard.ECB.Purple
            Case 9
                PlayingCard.CardBack = PlayingCard.ECB.DesertMoon
            Case 10
                PlayingCard.CardBack = PlayingCard.ECB.Astronaut
            Case 11
                PlayingCard.CardBack = PlayingCard.ECB.OrangeStripes
            Case 12
                PlayingCard.CardBack = PlayingCard.ECB.SportCars
            Case 13
                PlayingCard.CardBack = PlayingCard.ECB.X
            Case 14
                PlayingCard.CardBack = PlayingCard.ECB.O
        End Select

    End Sub

    Private Sub cboSuit_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cboSuit.SelectedIndexChanged

        Select Case cboSuit.SelectedIndex
            Case 0
                PlayingCard.CardSuit = PlayingCard.ECS.Clubs
            Case 1
                PlayingCard.CardSuit = PlayingCard.ECS.Diamonds
            Case 2
                PlayingCard.CardSuit = PlayingCard.ECS.Hearts
            Case 3
                PlayingCard.CardSuit = PlayingCard.ECS.Spades
        End Select

    End Sub

End Class
