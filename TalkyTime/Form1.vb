Public Class Form1

    Private Sub Button1_Click(sender As System.Object, e As System.EventArgs) Handles Button1.Click

        CreateObject("sapi.spvoice").Speak(InputBox("Enter your text", "Talk it"))

    End Sub
End Class
