Public Class Admin_DB
    Private Sub btncreateShift_Click(sender As Object, e As EventArgs) Handles btncreateShift.Click
        Admin_CreateShift.Show()
        Me.Hide()
    End Sub

    Private Sub btnschedule_Click(sender As Object, e As EventArgs) Handles btnschedule.Click
        Admin_Schedule.Show()
        Me.Hide()
    End Sub

End Class
