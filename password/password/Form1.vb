Public Class frmPassword
    Private Sub frmPassword_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        txtPassword.Focus()
    End Sub

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Me.Close()
    End Sub

    Private Sub btnValid_Click(sender As Object, e As EventArgs) Handles btnValid.Click
        Dim Response As DialogResult
        If txtPassword.Text = CStr(txtPassword.Tag) Then
            MessageBox.Show("You've passed Security!", "Access Granted", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
        Else
            Response = MessageBox.Show("Incorrect Password", "Access Denied", MessageBoxButtons.RetryCancel, MessageBoxIcon.Error)
            If Response = DialogResult.Retry Then
                txtPassword.SelectionStart = 0
                txtPassword.SelectionLength = Len(txtPassword.Text)
            Else
                Me.Close()
            End If
        End If
        txtPassword.Focus()
    End Sub
End Class
