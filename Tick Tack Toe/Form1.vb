Public Class Form1

    Dim plusone As Integer
    Dim check As Boolean
    Private Sub Color_Change()
        Button1.ForeColor = Color.Black
        Button2.ForeColor = Color.Black
        Button3.ForeColor = Color.Black
        Button4.ForeColor = Color.Black
        Button5.ForeColor = Color.Black
        Button6.ForeColor = Color.Black
        Button7.ForeColor = Color.Black
        Button8.ForeColor = Color.Black
        Button9.ForeColor = Color.Black
    End Sub
    Private Sub Enabled_False()
        Button1.Enabled = False
        Button2.Enabled = False
        Button3.Enabled = False
        Button4.Enabled = False
        Button5.Enabled = False
        Button6.Enabled = False
        Button7.Enabled = False
        Button8.Enabled = False
        Button9.Enabled = False
    End Sub
    Private Sub score()

        'XXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXX

        If (Button1.Text = "X" And Button2.Text = "X" And Button3.Text = "X") Then
            Button1.BackColor = Color.Tomato
            Button2.BackColor = Color.Tomato
            Button3.BackColor = Color.Tomato
            MessageBox.Show("Player X Wins :)", "Tic Tac Toe", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Label4.Text = Label4.Text + plusone
            Color_Change()
            Enabled_False()
        End If

        If (Button1.Text = "X" And Button4.Text = "X" And Button7.Text = "X") Then
            Button1.BackColor = Color.Tomato
            Button4.BackColor = Color.Tomato
            Button7.BackColor = Color.Tomato
            MessageBox.Show("Player X Wins :)", "Tic Tac Toe", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Label4.Text = Label4.Text + plusone
            Color_Change()
            Enabled_False()
        End If

        If (Button1.Text = "X" And Button5.Text = "X" And Button9.Text = "X") Then
            Button1.BackColor = Color.Tomato
            Button5.BackColor = Color.Tomato
            Button9.BackColor = Color.Tomato
            MessageBox.Show("Player X Wins :)", "Tic Tac Toe", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Label4.Text = Label4.Text + plusone
            Color_Change()
            Enabled_False()
        End If

        If (Button2.Text = "X" And Button5.Text = "X" And Button8.Text = "X") Then
            Button2.BackColor = Color.Tomato
            Button5.BackColor = Color.Tomato
            Button8.BackColor = Color.Tomato
            MessageBox.Show("Player X Wins :)", "Tic Tac Toe", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Label4.Text = Label4.Text + plusone
            Color_Change()
            Enabled_False()
        End If

        If (Button3.Text = "X" And Button6.Text = "X" And Button9.Text = "X") Then
            Button3.BackColor = Color.Tomato
            Button6.BackColor = Color.Tomato
            Button9.BackColor = Color.Tomato
            MessageBox.Show("Player X Wins :)", "Tic Tac Toe", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Label4.Text = Label4.Text + plusone
            Color_Change()
            Enabled_False()
        End If

        If (Button3.Text = "X" And Button5.Text = "X" And Button7.Text = "X") Then
            Button3.BackColor = Color.Tomato
            Button5.BackColor = Color.Tomato
            Button7.BackColor = Color.Tomato
            MessageBox.Show("Player X Wins :)", "Tic Tac Toe", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Label4.Text = Label4.Text + plusone
            Color_Change()
            Enabled_False()
        End If

        If (Button4.Text = "X" And Button5.Text = "X" And Button6.Text = "X") Then
            Button4.BackColor = Color.Tomato
            Button5.BackColor = Color.Tomato
            Button6.BackColor = Color.Tomato
            MessageBox.Show("Player X Wins :)", "Tic Tac Toe", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Label4.Text = Label4.Text + plusone
            Color_Change()
            Enabled_False()
        End If

        If (Button7.Text = "X" And Button8.Text = "X" And Button9.Text = "X") Then
            Button7.BackColor = Color.Tomato
            Button8.BackColor = Color.Tomato
            Button9.BackColor = Color.Tomato
            MessageBox.Show("Player X Wins :)", "Tic Tac Toe", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Label4.Text = Label4.Text + plusone
            Color_Change()
            Enabled_False()
        End If


        'OOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOO
        plusone = 1
        If (Button1.Text = "O" And Button2.Text = "O" And Button3.Text = "O") Then
            Button1.BackColor = Color.Tomato
            Button2.BackColor = Color.Tomato
            Button3.BackColor = Color.Tomato
            MessageBox.Show("Player O Wins :)", "Tic Tac Toe", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Label5.Text = Label5.Text + plusone
            Enabled_False()
        End If

        If (Button1.Text = "O" And Button4.Text = "O" And Button7.Text = "O") Then
            Button1.BackColor = Color.Tomato
            Button4.BackColor = Color.Tomato
            Button7.BackColor = Color.Tomato
            MessageBox.Show("Player O Wins :)", "Tic Tac Toe", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Label5.Text = Label5.Text + plusone
            Enabled_False()
        End If

        If (Button1.Text = "O" And Button5.Text = "O" And Button9.Text = "O") Then
            Button1.BackColor = Color.Tomato
            Button5.BackColor = Color.Tomato
            Button9.BackColor = Color.Tomato
            MessageBox.Show("Player O Wins :)", "Tic Tac Toe", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Label5.Text = Label5.Text + plusone
            Enabled_False()
        End If

        If (Button2.Text = "O" And Button5.Text = "O" And Button8.Text = "O") Then
            Button2.BackColor = Color.Tomato
            Button5.BackColor = Color.Tomato
            Button8.BackColor = Color.Tomato
            MessageBox.Show("Player O Wins :)", "Tic Tac Toe", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Label5.Text = Label5.Text + plusone
            Enabled_False()
        End If

        If (Button3.Text = "O" And Button6.Text = "O" And Button9.Text = "O") Then
            Button3.BackColor = Color.Tomato
            Button6.BackColor = Color.Tomato
            Button9.BackColor = Color.Tomato
            MessageBox.Show("Player O Wins :)", "Tic Tac Toe", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Label5.Text = Label5.Text + plusone
            Enabled_False()
        End If

        If (Button3.Text = "O" And Button5.Text = "O" And Button7.Text = "O") Then
            Button3.BackColor = Color.Tomato
            Button5.BackColor = Color.Tomato
            Button7.BackColor = Color.Tomato
            MessageBox.Show("Player O Wins :)", "Tic Tac Toe", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Label5.Text = Label5.Text + plusone
            Enabled_False()
        End If

        If (Button4.Text = "O" And Button5.Text = "O" And Button6.Text = "O") Then
            Button4.BackColor = Color.Tomato
            Button5.BackColor = Color.Tomato
            Button6.BackColor = Color.Tomato
            MessageBox.Show("Player O Wins :)", "Tic Tac Toe", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Label5.Text = Label5.Text + plusone
            Enabled_False()
        End If

        If (Button7.Text = "O" And Button8.Text = "O" And Button9.Text = "O") Then
            Button7.BackColor = Color.Tomato
            Button8.BackColor = Color.Tomato
            Button9.BackColor = Color.Tomato
            MessageBox.Show("Player O Wins :)", "Tic Tac Toe", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Label5.Text = Label5.Text + plusone
            Enabled_False()
        End If

    End Sub
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If (check = False) Then
            Button1.Text = "X"
            check = True
        Else
            Button1.Text = "O"
            check = False
        End If
        score()
        Button1.Enabled = False
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        If (check = False) Then
            Button2.Text = "X"
            check = True
        Else
            Button2.Text = "O"
            check = False
        End If
        score()
        Button2.Enabled = False
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        If (check = False) Then
            Button3.Text = "X"
            check = True
        Else
            Button3.Text = "O"
            check = False
        End If
        score()
        Button3.Enabled = False
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        If (check = False) Then
            Button4.Text = "X"
            check = True
        Else
            Button4.Text = "O"
            check = False
        End If
        score()
        Button4.Enabled = False
    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        If (check = False) Then
            Button5.Text = "X"
            check = True
        Else
            Button5.Text = "O"
            check = False
        End If
        score()
        Button5.Enabled = False
    End Sub

    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles Button6.Click
        If (check = False) Then
            Button6.Text = "X"
            check = True
        Else
            Button6.Text = "O"
            check = False
        End If
        score()
        Button6.Enabled = False
    End Sub

    Private Sub Button7_Click(sender As Object, e As EventArgs) Handles Button7.Click
        If (check = False) Then
            Button7.Text = "X"
            check = True
        Else
            Button7.Text = "O"
            check = False
        End If
        score()
        Button7.Enabled = False
    End Sub

    Private Sub Button8_Click(sender As Object, e As EventArgs) Handles Button8.Click
        If (check = False) Then
            Button8.Text = "X"
            check = True
        Else
            Button8.Text = "O"
            check = False
        End If
        score()
        Button8.Enabled = False
    End Sub

    Private Sub Button9_Click(sender As Object, e As EventArgs) Handles Button9.Click
        If (check = False) Then
            Button9.Text = "X"
            check = True
        Else
            Button9.Text = "O"
            check = False
        End If
        score()
        Button9.Enabled = False
    End Sub




    Private Sub Button12_Click(sender As Object, e As EventArgs) Handles Button12.Click
        Dim ex As DialogResult

        ex = MessageBox.Show("Confirm if you want to exit :(", "Tic Tac Toe", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
        If ex = DialogResult.Yes Then
            Application.Exit()
        End If

    End Sub

    Private Sub Label4_Click(sender As Object, e As EventArgs) Handles Label4.Click

    End Sub
End Class
