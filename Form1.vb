Public Class frm_off

    Dim v_hours, v_minutes, v_seconds, v_time As Int64

    Private Sub btn_schedule_Click(sender As Object, e As EventArgs) Handles btn_schedule.Click

        Shell("shutdown -s -t " & v_time.ToString)

    End Sub


    Private Sub nudHours_TextChanged(sender As Object, e As EventArgs) Handles nudHours.TextChanged

        timeChanged()
    End Sub

    Private Sub nudMinutes_TextChanged(sender As Object, e As EventArgs) Handles nudMinutes.TextChanged
        timeChanged()
    End Sub

    Private Sub nudseconds_TextChanged(sender As Object, e As EventArgs) Handles nudSeconds.TextChanged
        timeChanged()
    End Sub

    Private Sub txt_Hours_KeyPress(sender As Object, e As KeyPressEventArgs)
        If Asc(e.KeyChar) <> 8 Then
            If Asc(e.KeyChar) < 48 Or Asc(e.KeyChar) > 57 Then
                e.Handled = True
            End If
        End If
    End Sub

    Private Sub btn_cancel_Click(sender As Object, e As EventArgs) Handles btn_cancel.Click
        Try
            Shell("shutdown /a")
        Catch exception As Exception
            MessageBox.Show("No hay ningún apagado programado")
        End Try
    End Sub

    Private Sub txt_Minutes_KeyPress(sender As Object, e As KeyPressEventArgs)
        If Asc(e.KeyChar) <> 8 Then
            If Asc(e.KeyChar) < 48 Or Asc(e.KeyChar) > 57 Then
                e.Handled = True
            End If
        End If
    End Sub

    Private Sub txt_seconds_KeyPress(sender As Object, e As KeyPressEventArgs)
        If Asc(e.KeyChar) <> 8 Then
            If Asc(e.KeyChar) < 48 Or Asc(e.KeyChar) > 57 Then
                e.Handled = True
            End If
        End If
    End Sub


    Sub timeChanged()
        If String.IsNullOrEmpty(nudHours.Value) Then
            v_hours = 0
        Else
            v_hours = nudHours.Value
        End If
        If String.IsNullOrEmpty(nudMinutes.Value) Then
            v_minutes = 0
        Else
            v_minutes = nudMinutes.Value
        End If
        If String.IsNullOrEmpty(nudSeconds.Value) Then
            v_seconds = 0
        Else
            v_seconds = nudSeconds.Value
        End If
        v_time = (v_hours * 3600) + (v_minutes * 60) + v_seconds
        lbl_total_time.Text = v_time.ToString
    End Sub


End Class
