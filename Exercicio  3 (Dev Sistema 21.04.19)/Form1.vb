Public Class Form1


    Private Sub CréditosToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CréditosToolStripMenuItem.Click
        Form2.Show()

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim cont As Integer = NumericUpDown1.Value
        If ComboBox1.Text() = "+" Then
            For index = 1 To 10
                ListBox1.Items.Add(NumericUpDown1.Value & ComboBox1.Text() & index & "=" & NumericUpDown1.Value + ++index)
            Next

        ElseIf ComboBox1.Text() = "-" Then
            For index = 1 To 10
                cont = cont + 1
                ListBox1.Items.Add(cont & ComboBox1.Text() & NumericUpDown1.Value & "=" & (cont - NumericUpDown1.Value))
            Next

        ElseIf ComboBox1.Text() = "*" Then
            For index = 1 To 10
                ListBox1.Items.Add(NumericUpDown1.Value & ComboBox1.Text() & index & "=" & NumericUpDown1.Value * ++index)
            Next

        ElseIf ComboBox1.Text() = "/" Then

            For index = 1 To 10
                ListBox1.Items.Add(cont & ComboBox1.Text() & NumericUpDown1.Value & "=" & (cont / NumericUpDown1.Value))
                cont = cont + 4
            Next

        End If
    End Sub

    Private Sub NovoToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles NovoToolStripMenuItem.Click
        ListBox1.Items.Clear()
        NumericUpDown1.Value = NumericUpDown1.Minimum
        ComboBox1.ResetText()
    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        NumericUpDown1.Maximum = 9
        NumericUpDown1.Minimum = 1
    End Sub


    Private Sub AdiçãoToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AdiçãoToolStripMenuItem.Click
        ComboBox1.Text = "+"
    End Sub

    Private Sub SubtraçãoToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SubtraçãoToolStripMenuItem.Click
        ComboBox1.Text = "-"
    End Sub

    Private Sub MultiplicaçãoToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles MultiplicaçãoToolStripMenuItem.Click
        ComboBox1.Text = "*"
    End Sub

    Private Sub DivisãoToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles DivisãoToolStripMenuItem.Click
        ComboBox1.Text = "/"
    End Sub


End Class
