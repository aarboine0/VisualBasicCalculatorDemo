Imports System.Drawing.Imaging
Imports System.Drawing.Drawing2D
Public Class Form1

    Dim f As Double
    Dim s As Double
    Dim ans As Double
    Dim input As Double = 0
    Dim op As String
    Dim n As Int32
    Dim found As Boolean = False

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        Dim GBrush As New LinearGradientBrush(Me.DisplayRectangle, Color.CadetBlue, Color.Purple,
                                              LinearGradientMode.Vertical
                                              )

        Me.BackgroundImage = New Bitmap(Me.Width, Me.Height)
        Dim g As Graphics = Graphics.FromImage(Me.BackgroundImage)

        g.FillRectangle(GBrush, Me.DisplayRectangle)

    End Sub

    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click, Button2.Click, Button3.Click, Button4.Click, Button5.Click, Button6.Click, Button7.Click, Button8.Click, Button9.Click, Button11.Click, Button12.Click
        Dim b As Button = sender
        If (Label1.Text = "0") Or (found) Then
            Label1.Text = ""
            Label1.Text = b.Text
            found = False

        ElseIf (b.Text = ".") Then
            If (Not Label1.Text.Contains(".")) Then
                Label1.Text = Label1.Text + b.Text
            End If
        Else
            Label1.Text = Label1.Text + b.Text

        End If
    End Sub

    Private Sub Button10_Click(sender As Object, e As EventArgs) Handles Button10.Click

    End Sub

    Private Sub Button13_Click(sender As Object, e As EventArgs) Handles Button13.Click
        Label1.Text = Math.PI
    End Sub

    Private Sub Button31_Click(sender As Object, e As EventArgs) Handles Button31.Click
        If (Label1.Text.Contains("-")) Then
            Label1.Text = Label1.Text.Remove(0, 1)
        Else
            Label1.Text = "-" + Label1.Text
        End If
    End Sub

    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles TextBox1.TextChanged

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub Button15_Click(sender As Object, e As EventArgs) Handles Button15.Click
        Label1.Text = "0"
        input = 0
        Label2.Text = ""
    End Sub

    Private Sub Label2_Click(sender As Object, e As EventArgs) Handles Label2.Click

    End Sub

    Private Sub Button14_Click(sender As Object, e As EventArgs) Handles Button14.Click
        Label1.Text = "0"
        Label2.Text = ""
    End Sub

    Private Sub Button19_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub arithmetic_function(sender As Object, e As EventArgs) Handles Button19.Click, Button18.Click, Button17.Click, Button21.Click, Button23.Click, Button32.Click

        Dim ops As Button = sender
        If (input <> 0) Then
            Button20.PerformClick()
            found = True
            op = ops.Text
            Label2.Text = input & "   " & op
        Else
            op = ops.Text
            input = Double.Parse(Label1.Text)
            found = True
            Label2.Text = input & "   " & op
        End If



    End Sub

    Private Sub Button20_Click(sender As Object, e As EventArgs) Handles Button20.Click

        If Label1.Text = "" Then
            s = 0
        Else
            s = Label1.Text
        End If

        Select Case op
            Case "+"
                Label1.Text = (input + Double.Parse(Label1.Text)).ToString
                Label2.Text = ""
            Case "-"
                Label1.Text = (input - Double.Parse(Label1.Text)).ToString
                Label2.Text = ""
            Case "*"
                Label1.Text = (input * Double.Parse(Label1.Text)).ToString
                Label2.Text = ""
            Case "/"
                Label1.Text = (input / Double.Parse(Label1.Text)).ToString
                Label2.Text = ""
            Case "^"
                Label1.Text = (input ^ Double.Parse(Label1.Text)).ToString
                Label2.Text = ""
            Case "MOD"
                Label1.Text = (input Mod Double.Parse(Label1.Text)).ToString
                Label2.Text = ""

        End Select

        input = Double.Parse(Label1.Text)
        op = ""

    End Sub

    Private Sub Label3_Click(sender As Object, e As EventArgs) Handles Label3.Click

    End Sub

    Private Sub Button29_Click(sender As Object, e As EventArgs) Handles Button29.Click
        If Int32.TryParse(Label1.Text, n) Then
            Label1.Text = Convert.ToString(n, 2)
        Else
            Label1.Text = ""
        End If
    End Sub

    Private Sub Button26_Click(sender As Object, e As EventArgs) Handles Button26.Click
        ans = Math.Sin(Label1.Text)
        Label1.Text = ans
        Label2.Text = ""
    End Sub

    Private Sub Button28_Click(sender As Object, e As EventArgs) Handles Button28.Click
        ans = Math.Tan(Label1.Text)
        Label1.Text = ans
        Label2.Text = ""
    End Sub

    Private Sub Button27_Click(sender As Object, e As EventArgs) Handles Button27.Click
        ans = Math.Cos(Label1.Text)
        Label1.Text = ans
        Label2.Text = ""
    End Sub

    Private Sub Button25_Click(sender As Object, e As EventArgs) Handles Button25.Click
        Dim ilog As Double
        ilog = Double.Parse(Label1.Text)
        Label2.Text = System.Convert.ToString("log" + "(" + (Label1.Text) + ")")
        ilog = Math.Log10(ilog)
        Label1.Text = System.Convert.ToString(ilog)

    End Sub

    Private Sub Button16_Click(sender As Object, e As EventArgs) Handles Button16.Click
        Dim isrt As Double
        isrt = Double.Parse(Label1.Text)
        Label2.Text = System.Convert.ToString("Sqrt" + "(" + (Label1.Text) + ")")
        isrt = Math.Sqrt(isrt)
        Label1.Text = System.Convert.ToString(isrt)


    End Sub

    Private Sub Button40_Click(sender As Object, e As EventArgs) Handles Button40.Click
        Dim asin As Double
        asin = Double.Parse(Label1.Text)
        Label2.Text = System.Convert.ToString("arcsin" + "(" + (Label1.Text) + ")")
        asin = Math.Asin(asin)
        Label1.Text = System.Convert.ToString(asin)
    End Sub

    Private Sub Button33_Click(sender As Object, e As EventArgs) Handles Button33.Click
        Dim ilog As Double
        ilog = Double.Parse(Label1.Text)
        Label2.Text = System.Convert.ToString("ln" + "(" + (Label1.Text) + ")")
        ilog = Math.Log(ilog)
        Label1.Text = System.Convert.ToString(ilog)
    End Sub

    Private Sub Button39_Click(sender As Object, e As EventArgs) Handles Button39.Click
        Dim acos As Double
        acos = Double.Parse(Label1.Text)
        Label2.Text = System.Convert.ToString("arccos" + "(" + (Label1.Text) + ")")
        acos = Math.Acos(acos)
        Label1.Text = System.Convert.ToString(acos)
    End Sub

    Private Sub Button38_Click(sender As Object, e As EventArgs) Handles Button38.Click
        Dim atan As Double
        atan = Double.Parse(Label1.Text)
        Label2.Text = System.Convert.ToString("arctan" + "(" + (Label1.Text) + ")")
        atan = Math.Atan(atan)
        Label1.Text = System.Convert.ToString(atan)
    End Sub

    Private Sub ScientificToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ScientificToolStripMenuItem.Click
        Me.Width = 615
        Label1.Width = 523
        Me.Text = "Scientific Calculator"

    End Sub

    Private Sub UnitConversionToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles UnitConversionToolStripMenuItem.Click
        Me.Width = 944
        Label1.Width = 523
        Me.Text = "Scientific Calculator + Unit Converter"
    End Sub

    Private Sub Button24_Click(sender As Object, e As EventArgs) Handles Button24.Click
        'Percent Method
        Dim a As Double
        a = Convert.ToDouble(Label1.Text) / Convert.ToDouble(100)
        Label1.Text = System.Convert.ToString(a)
    End Sub

    Private Sub CheckBox1_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox1.CheckedChanged

    End Sub

    Private Sub Label5_Click(sender As Object, e As EventArgs) Handles Label5.Click

    End Sub

    Private Sub Panel1_Paint(sender As Object, e As PaintEventArgs)

    End Sub

    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles PictureBox1.Click

    End Sub

    Private Sub CheckBox4_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox4.CheckedChanged

    End Sub

    Private Sub Button34_Click(sender As Object, e As EventArgs) Handles Button34.Click
        Dim a As Double
        'radians to degrees, we multiply it by 180°/π.
        a = Convert.ToDouble(Label1.Text) * (Convert.ToDouble(180) / Math.PI)
        Label1.Text = System.Convert.ToString(a)
    End Sub

    Private Sub Button35_Click(sender As Object, e As EventArgs) Handles Button35.Click
        Dim a As Double
        ' degrees to radians, we multiply it by π/180°
        a = Convert.ToDouble(Label1.Text) * (Math.PI / Convert.ToDouble(180))
        Label1.Text = System.Convert.ToString(a)
    End Sub

    Private Sub Button30_Click(sender As Object, e As EventArgs) Handles Button30.Click
        Dim ie As Double
        'ie = Double.Parse(Label1.Text)
        'Label2.Text = System.Convert.ToString((Label1.Text) + "e")
        ie = Math.E
        Label1.Text = System.Convert.ToString(ie)

    End Sub
End Class
