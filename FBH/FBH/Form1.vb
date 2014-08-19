Imports System.Text
Imports System.IO


Public Class Form1
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Timer1.Enabled = True

    End Sub
    Sub Main()
        Dim s As String = "ABCDEFGHIJKLMNOPQURSTUVWXYZabcdefghijklmnopqrstuvwxyz0123456789"
        Dim r As New Random


        Dim sb As New StringBuilder
        For i As Integer = 1 To (Int.Text)
            Dim idx As Integer = r.Next(0, 62)
            sb.Append(s.Substring(idx, 1))
            TextBox1.Text = sb.ToString


        Next

    End Sub


    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        Button1.Focus()
        Main()

        WebBrowser1.Document.GetElementById("email").SetAttribute("value", (TextBox1.Text) + "@gmail.com")
        WebBrowser1.Document.GetElementById("pass").SetAttribute("value", "password")
        WebBrowser1.Document.GetElementById("u_0_h").InvokeMember("click")
        WebBrowser1.Refresh()
        WebBrowser1.Navigate(TextBox2.Text)
        WebBrowser1.Navigate(TextBox3.Text)
        WebBrowser1.Document.GetElementById("email").SetAttribute("value", (TextBox1.Text) + "@gmail.com")
        WebBrowser1.Document.GetElementById("pass").SetAttribute("value", "password")
        WebBrowser1.Document.GetElementById("u_0_h").InvokeMember("click")
        Dim file As System.IO.StreamWriter
        file = My.Computer.FileSystem.OpenTextFileWriter("C:/Users/Desktop/9.txt", True)
        file.WriteLine(TextBox1.Text)
        file.Close()
        WebBrowser1.Refresh()
        WebBrowser1.Navigate(TextBox2.Text)
        WebBrowser1.Navigate(TextBox3.Text)
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Timer1.Enabled = False
        Timer2.Enabled = False
        Timer3.Enabled = False
        Open.Enabled = False


    End Sub


    Private Sub Timer2_Tick(sender As Object, e As EventArgs) Handles Timer2.Tick
        Timer1.Enabled = False

    End Sub

    Private Sub Timer3_Tick(sender As Object, e As EventArgs) Handles Timer3.Tick
        Timer1.Enabled = True
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Timer2.Enabled = True
        Timer3.Enabled = True
    End Sub

    Private Sub Open_Tick(sender As Object, e As EventArgs) Handles Open.Tick
        Dim ret As Object
        ret = Shell("C:\Users\Desktop\Execution\sanguinem.bat")
        Close()
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        Open.Enabled = True
    End Sub
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load


    End Sub

End Class
