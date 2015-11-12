Public Class Form1

    Private Sub txtUserName_TextChanged(sender As Object, e As EventArgs) Handles txtUserName.TextChanged

        Dim et As TextBox = CType(sender, TextBox)

        If (String.IsNullOrEmpty(et.Text)) Then

            et.BackColor = Color.MistyRose

        End If                            '判斷txtUserName的Text是否為空白，是的話顏色改變

    End Sub

    Private Sub txtPassword_TextChanged(sender As Object, e As EventArgs) Handles txtPassword.TextChanged

        Dim et As TextBox = CType(sender, TextBox)

        If (String.IsNullOrEmpty(et.Text)) Then

            et.BackColor = Color.MistyRose

        End If                            '判斷txtPassword的Text是否為空白，是的話顏色改變

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click

        If txtUserName.Text = ("login") And txtPassword.Text = ("abc123") Then '利用if判斷帳密是否正確

            MsgBox("帳戶密碼正確")
            Close()                        '帳密正確的話提示使用者並關閉表單

        Else

            MsgBox("帳號或密碼錯誤")
            txtUserName.BackColor = Color.MistyRose
            txtPassword.BackColor = Color.MistyRose '帳密錯誤的話將顏色改變並提示使用者

        End If

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        End '關閉表單
    End Sub
End Class
