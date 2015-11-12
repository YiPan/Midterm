Public Class Form1

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click

        Dim c, f As Single 'c是攝氏，f為華氏

        f = TextBox1.Text '如果要轉換成攝氏，就假設輸入值為華氏

        c = (f - 32) / 1.8

        TextBox1.Text = c '計算並輸出
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click

        Dim c, f As Single 'c是攝氏，f為華氏

        c = TextBox1.Text '如果要轉換成華氏，就假設輸入值為攝氏

        f = c * 1.8 + 32

        TextBox1.Text = f '計算並輸出

    End Sub
End Class
