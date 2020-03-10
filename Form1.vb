Public Class ticTacToeForm
    Dim player As String = "X"
    'this is code
    Dim player1score As Integer
    Dim player2score As Integer

    Dim gameover As Boolean

    Sub resetscore()
        player1score = 0
        player2score = 0
        player = "X"
    End Sub

    Sub resetboard()
        Box1.Text = "  "
        Box2.Text = "  "
        Box3.Text = "  "
        Box4.Text = "  "
        Box5.Text = "  "
        Box6.Text = "  "
        Box7.Text = "  "
        Box8.Text = "  "
        Box9.Text = "  "
        Me.BackColor = Color.White
    End Sub

    Sub checkwinner()
        If Box1.Text = Box2.Text And Box2.Text = Box3.Text And Box1.Text <> "  " Or
           Box1.Text = Box4.Text And Box4.Text = Box7.Text And Box1.Text <> "  " Or
           Box1.Text = Box5.Text And Box5.Text = Box9.Text And Box1.Text <> "  " Or
           Box2.Text = Box5.Text And Box5.Text = Box8.Text And Box2.Text <> "  " Or
           Box3.Text = Box6.Text And Box6.Text = Box9.Text And Box3.Text <> "  " Or
           Box3.Text = Box5.Text And Box5.Text = Box7.Text And Box3.Text <> "  " Or
           Box4.Text = Box5.Text And Box5.Text = Box6.Text And Box4.Text <> "  " Or
           Box7.Text = Box8.Text And Box8.Text = Box9.Text And Box7.Text <> "  " Then
            Me.BackColor = Color.Green

            gameover = True
            If player = "O" Then
                player1score = player1score + 1
                playerAnswerScoreLabel1.Text = player1score
            Else
                player2score = player2score + 1
                playerAnswerScoreLabel2.Text = player2score
            End If
            ' Else
            '   Me.BackColor = Color.Red (removed due to screen being red every time it inputs a letter)
        End If
        ' этот текст
        ' здравствуйте моя дети!!
    End Sub
    Private Sub Box1_Click(sender As Object, e As EventArgs) Handles Box1.Click, Box2.Click, Box3.Click, Box4.Click, Box5.Click, Box6.Click, Box7.Click, Box8.Click, Box9.Click
        If sender.text = "  " And Not gameover Then
            sender.text = player
            If player = "X" Then
                player = "O"
            Else
                player = "X"
            End If
            checkwinner()
        End If
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Me.Close()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        resetboard()

        ' playerAnswerScoreLabel1.Text = " " (moved to new button for efficiency)
        ' playerAnswerScoreLabel2.Text = " " (moved to new button for efficiency)

        gameover = False
        ' resetscore() (moved to new button for efficiency)
        ' player1score = 0 (removed due to easier method being found)
        ' player2score = 0 (removed due to easier method being found)
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs)
        ' (everything below removed for being too complicated, and was replaced with easier method)
        ' If Box1.Text = Box2.Text And
        ' Box2.Text = Box3.Text And
        ' Box1.Text <> "  " Then
        ' Me.BackColor = Color.Green
        ' ElseIf Box1.Text = Box5.Text And
        ' Box5.Text = Box9.Text And
        ' Box1.Text <> "  " Then
        ' Me.BackColor = Color.Green
        ' ElseIf Box3.Text = Box5.Text And
        ' Box5.Text = Box7.Text And
        ' Box3.Text <> "  " Then
        ' Me.BackColor = Color.Green
        ' ElseIf Box1.Text = Box4.Text And
        ' Box4.Text = Box7.Text And
        ' Box1.Text <> "  " Then
        ' Me.BackColor = Color.Green
        ' ElseIf Box2.Text = Box5.Text And
        ' Box5.Text = Box8.Text And
        ' Box2.Text <> "  " Then
        ' Me.BackColor = Color.Green
        ' ElseIf Box3.Text = Box6.Text And
        ' Box6.Text = Box9.Text And
        ' Box3.Text <> "  " Then
        ' Me.BackColor = Color.Green
        ' ElseIf Box4.Text = Box5.Text And
        ' Box5.Text = Box6.Text And
        ' Box4.Text <> "  " Then
        ' Me.BackColor = Color.Green
        ' ElseIf Box7.Text = Box8.Text And
        ' Box8.Text = Box9.Text And
        ' Box7.Text <> "  " Then
        ' Me.BackColor = Color.Green
        ' Else
        ' Me.BackColor = Color.Red
        ' End If
    End Sub

    Private Sub Button3_Click_1(sender As Object, e As EventArgs) Handles Button3.Click
        playerAnswerScoreLabel1.Text = " "
        playerAnswerScoreLabel2.Text = " "
        resetscore()
    End Sub
End Class