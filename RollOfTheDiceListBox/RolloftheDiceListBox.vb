'Noah Holloway
'RCET 2265
'Spring 2025
'Roll of the Dice List Box
'

Option Strict On
Option Explicit On
Option Compare Text
Public Class RolloftheDiceListBox
    Dim rand As New Random()

    Dim rollCounts(11) As Integer

    Private Sub RollButton_Click(sender As Object, e As EventArgs) Handles RollButton.Click
        ' Reset the roll counts to 0 for each new roll
        Array.Clear(rollCounts, 0, rollCounts.Length)

        For i As Integer = 1 To 1000
            Dim die1 As Integer = RandomNumberBetween(1, 6)
            Dim die2 As Integer = RandomNumberBetween(1, 6)
            Dim sum As Integer = die1 + die2
            rollCounts(sum - 2) += 1
        Next

        DisplayResults()
    End Sub

    Private Sub ClearButton_Click(sender As Object, e As EventArgs) Handles ClearButton.Click

        DiceValueLabel.Text = "Dice Values: "
        RollCountLabel.Text = "Roll Counts: "
        MostFrequentLabel.Text = "Most Frequent Roll: "
        Array.Clear(rollCounts, 0, rollCounts.Length)
    End Sub

    Private Sub ExitButton_Click(sender As Object, e As EventArgs) Handles ExitButton.Click
        Me.Close()
    End Sub

    Function RandomNumberBetween(min As Integer, max As Integer) As Integer
        Return rand.Next(min, max + 1)
    End Function

    Private Sub DisplayResults()

        Dim diceValues As String = "Dice Values: "
        For i As Integer = 2 To 12
            diceValues &= i.ToString().PadLeft(4) & " "
        Next
        DiceValueLabel.Text = diceValues


        Dim rollCountsText As String = "Roll Counts: "
        For i As Integer = 0 To 10
            rollCountsText &= rollCounts(i).ToString().PadLeft(4) & " "
        Next
        RollCountLabel.Text = rollCountsText

        Dim maxIndex As Integer = Array.IndexOf(rollCounts, rollCounts.Max()) + 2
        MostFrequentLabel.Text = $"Most Frequent Roll: {maxIndex}"
    End Sub

End Class


