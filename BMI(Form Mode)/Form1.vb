Public Class BMI計算機

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If TextBox1.Text = ("") Or TextBox2.Text = ("") Then '判斷是否有資料尚未輸入
            MsgBox("有資料尚未輸入喔!")
        Else

            Dim w, h, bmi As Single 'w是體重，h是身高，bmi為BMI值

            h = TextBox1.Text
            w = TextBox2.Text
            bmi = w / (h / 100) ^ 2 '將輸入值轉換成變數並計算

            If bmi < 18.5 Then
                Label5.Text = ("體重過輕!")

            ElseIf bmi < 24 Then
                Label5.Text = ("體重正常!")

            ElseIf bmi < 27 Then
                Label5.Text = ("體重過重!")

            ElseIf bmi < 30 Then
                Label5.Text = ("輕度肥胖!")

            ElseIf bmi < 35 Then
                Label5.Text = ("中度肥胖!")

            ElseIf bmi > 34 Then
                Label5.Text = ("重度肥胖!") '判斷BMI值落在哪一個區段並輸出是否為正常值

            End If
        End If
    End Sub
End Class
