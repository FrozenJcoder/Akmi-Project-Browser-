Public Class Form1
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim window As New TabPage
        Dim newwindow As New window
        newwindow.Show()
        newwindow.Dock = DockStyle.Fill
        newwindow.TopLevel = False
        window.Controls.Add(newwindow)
        TabControl1.TabPages.Add(window)
    End Sub
End Class
