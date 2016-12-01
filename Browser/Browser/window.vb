Imports Awesomium.Core

Public Class window
    Private Sub FrozenEraToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles FrozenEraToolStripMenuItem.Click

    End Sub

    Private Sub SettingsToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SettingsToolStripMenuItem.Click
        Settings.Show()
    End Sub

    Private Sub Panel1_Paint(sender As Object, e As PaintEventArgs) Handles Panel1.Paint

    End Sub

    Private Sub window_Load(sender As Object, e As EventArgs) Handles Me.Load
        WebControl1.Source = New Uri(My.Settings.HomePage)

    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        WebControl1.Source = New Uri(My.Settings.HomePage)
    End Sub

    Private Sub MenuStrip1_ItemClicked(sender As Object, e As ToolStripItemClickedEventArgs) Handles MenuStrip1.ItemClicked

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If WebControl1.CanGoBack Then
            WebControl1.GoBack()
        End If
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        If WebControl1.CanGoForward Then
            WebControl1.GoForward()

        End If
    End Sub

    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles Button6.Click
        If WebControl1.IsNavigating Then
            WebControl1.Stop()

        End If
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        WebControl1.Reload(ignoreCache:=True)
    End Sub

    Private Sub Button7_Click(sender As Object, e As EventArgs) Handles Button7.Click
        If TextBox1.Text.Contains(".com") Or TextBox1.Text.Contains(".net") Or TextBox1.Text.Contains(".org") Or TextBox1.Text.Contains(".gr") Or TextBox1.Text.Contains(".edu") Or TextBox1.Text.Contains(".eu") Or TextBox1.Text.Contains(".mil") Or TextBox1.Text.Contains(".name") Then
            Try
                WebControl1.Source = New Uri(TextBox1.Text)
            Catch ex As System.UriFormatException
                WebControl1.Source = New Uri("http://" + TextBox1.Text)
                TextBox1.Text = ("http://" + TextBox1.Text)
            End Try
        Else : WebControl1.Source = New Uri("https://www.google.gr/?gfe_rd=cr&ei=C9h4VJn8E6_j8wf-wILgBg#q=" & TextBox1.Text)
        End If
    End Sub

    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles TextBox1.TextChanged

    End Sub

    Private Sub TextBox1_KeyDown(sender As Object, e As KeyEventArgs) Handles TextBox1.KeyDown
        If e.KeyCode = Keys.Enter Then
            If TextBox1.Text.Contains(".com") Or TextBox1.Text.Contains(".net") Or TextBox1.Text.Contains(".org") Or TextBox1.Text.Contains(".gr") Or TextBox1.Text.Contains(".edu") Or TextBox1.Text.Contains(".eu") Or TextBox1.Text.Contains(".mil") Or TextBox1.Text.Contains(".name") Then
                Try
                    WebControl1.Source = New Uri(TextBox1.Text)
                Catch ex As System.UriFormatException
                    WebControl1.Source = New Uri("http://" + TextBox1.Text)
                    TextBox1.Text = ("http://" + TextBox1.Text)
                End Try
            Else : WebControl1.Source = New Uri("https://www.google.gr/?gfe_rd=cr&ei=C9h4VJn8E6_j8wf-wILgBg#q=" & TextBox1.Text)
            End If
        End If
    End Sub

    Private Sub Awesomium_Windows_Forms_WebControl_ShowCreatedWebView(sender As Object, e As ShowCreatedWebViewEventArgs) Handles WebControl1.ShowCreatedWebView

    End Sub

    Private Sub WebControl1_LoadingFrameComplete(sender As Object, e As FrameEventArgs) Handles WebControl1.LoadingFrameComplete
        Parent.Text = WebControl1.Title
        TextBox1.Text = WebControl1.Source.ToString
    End Sub

    Private Sub AboutToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AboutToolStripMenuItem.Click

    End Sub

    Private Sub AboutApplicationToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AboutApplicationToolStripMenuItem.Click
        MsgBox("This browser is a Frozen Browser, from Frozen era, its solid like an iceberg and it's melting on the mouth like an icecube")
    End Sub

    Private Sub AboutProgrammerToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AboutProgrammerToolStripMenuItem.Click
        MsgBox("If you are a programmer with no life and no skills and you have a computer from 80's then this is the browser to use..You are sick of the fast explorers?You are missing the Explorer ? Then USE THIS Explorer Duplicate!Peace and love brother!")
    End Sub
End Class