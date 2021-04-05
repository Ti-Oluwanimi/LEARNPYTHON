Public Class GAME_MENU
    Private Sub RadioButton1_CheckedChanged(sender As Object, e As EventArgs)

    End Sub
    Private Sub GAME_MENU_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim SAPI
        SAPI = CreateObject("SAPI.spvoice")
        SAPI.Speak("Welcome Player!")

        MsgBox("10 questions will be asked of which you must supply answers to. Goodluck!")
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        main.Show()
        Me.Close()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Button2.Enabled = False
        Button1.Enabled = True
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Button4.Enabled = True
        Dim SAPI
        SAPI = CreateObject("SAPI.spvoice")
        Dim rnd As New Random
        Label1.Text = rnd.Next(1, 15)

        Label4.Text = Val(Label4.Text) + 1
        If Val(Label4.Text) > 10 Then
            Label3.Text = (Val(Label3.Text) / 40) * 100
            Label3.Visible = True
            If Val(Label3.Text) > 79 And Val(Label3.Text) < 101 Then
                SAPI.Speak("Great job. You are a professional and an advanced python programmer. Make sure you keep learning")
            ElseIf Val(Label3.Text) > 59 And Val(Label3.Text) < 80 Then
                SAPI.Speak("Good job. You are an intermediate python programmer. You can still do better and know more about the theoretical and practical use of python")
            ElseIf Val(Label3.Text) > 39 And Val(Label3.Text) < 60 Then
                SAPI.Speak("Well done. You are still a beginner. Do well to learn more about python programming")
            Else
                SAPI.Speak("You didn't do well this time. Please go through the fundamentals once again. Practice more and keep learning")
            End If
        End If

        If Label1.Text = "1" Then
            Label2.Text = "What function is used to print out values or results in a python code snippet? (Case Sensitive)"
        ElseIf Label1.Text = "2" Then
            Label2.Text = "What function is used to fit in parameters while using a supervised learning algorithm in python?"
        ElseIf Label1.Text = "3" Then
            Label2.Text = "a = 3
                           b = 4
                           c = a+b
                           print(c). What would be the output of c?"
        ElseIf Label1.Text = "4" Then
            Label2.Text = "What function converts an integer to hexadecimal string? Let x represent the value of the integer"
        ElseIf Label1.Text = "5" Then
            Label2.Text = "What is the output for the code: 
                           y = [4, 5, 1j]
                           y.sort()"
        ElseIf Label1.Text = "6" Then
            Label2.Text = "What function converts a single character to its integer value in python? Let x represent the value of the integer"
        ElseIf Label1.Text = "7" Then
            Label2.Text = "What function is used to generate random numbers in python using method?"
        ElseIf Label1.Text = "8" Then
            Label2.Text = "Which method is used to convert raw byte data to a string?"
        ElseIf Label1.Text = "9" Then
            Label2.Text = "Which method is used to convert string to a raw byte data?"
        ElseIf Label1.Text = "10" Then
            Label2.Text = "The name of the python library used for data preprocessing is?"
        ElseIf Label1.Text = "11" Then
            Label2.Text = "Which command is used to shuffle a list 'L'?"
        ElseIf Label1.Text = "12" Then
            Label2.Text = "eval('1+3*2') would print out which result?"
        ElseIf Label1.Text = "13" Then
            Label2.Text = "Common native data structures in Python are Dictionaries, Lists, Strings, Tuples, Sets, Replace. Which among the listed data structure is wrong?"
        ElseIf Label1.Text = "14" Then
            Label2.Text = "a = [1,2,3,4,5]
                           a[3] = 7
                           print(a)"
        ElseIf Label1.Text = "15" Then
            Label2.Text = "Which loop is faster between the 'for' and 'while' loop?"
        End If
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        Button4.Enabled = False

        If Label1.Text = "1" And TextBox1.Text = "print" Then
            Label3.Text = Val(Label3.Text) + 4
        Else

        End If

        If Label1.Text = "2" And TextBox1.Text = ".fit" Then
            Label3.Text = Val(Label3.Text) + 4
        ElseIf Label1.Text = "2" And TextBox1.Text = "fit" Then
            Label3.Text = Val(Label3.Text) + 4
        Else

        End If
        If Label1.Text = "3" And TextBox1.Text = "7" Then
            Label3.Text = Val(Label3.Text) + 4
        Else

        End If
        If Label1.Text = "4" And TextBox1.Text = "hex(x)" Then
            Label3.Text = Val(Label3.Text) + 4
        Else

        End If
        If Label1.Text = "5" And TextBox1.Text = "Type error" Then
            Label3.Text = Val(Label3.Text) + 4
        Else

        End If
        If Label1.Text = "6" And TextBox1.Text = "unichr(x)" Then
            Label3.Text = Val(Label3.Text) + 4
        Else

        End If
        If Label1.Text = "7" And TextBox1.Text = "random.randint()" Then
            Label3.Text = Val(Label3.Text) + 4
        ElseIf Label1.Text = "7" And TextBox1.Text = "random.uniform()" Then
            Label3.Text = Val(Label3.Text) + 4
        ElseIf Label1.Text = "7" And TextBox1.Text = "random.random()" Then
            Label3.Text = Val(Label3.Text) + 4
        Else
        End If
        If Label1.Text = "8" And TextBox1.Text = "encode()" Then
            Label3.Text = Val(Label3.Text) + 4
        Else

        End If
        If Label1.Text = "9" And TextBox1.Text = "decode()" Then
            Label3.Text = Val(Label3.Text) + 4
        Else

        End If
        If Label1.Text = "10" And TextBox1.Text = "sklearn" Then
            Label3.Text = Val(Label3.Text) + 4
        Else

        End If
        If Label1.Text = "11" And TextBox1.Text = "random.Shuffle(L)" Then
            Label3.Text = Val(Label3.Text) + 4
        Else

        End If
        If Label1.Text = "12" And TextBox1.Text = "7" Then
            Label3.Text = Val(Label3.Text) + 4
        Else

        End If
        If Label1.Text = "13" And TextBox1.Text = "Replace" Then
            Label3.Text = Val(Label3.Text) + 4
        Else

        End If
        If Label1.Text = "14" And TextBox1.Text = "[1,2,3,7,5]" Then
            Label3.Text = Val(Label3.Text) + 4
        Else

        End If
        If Label1.Text = "15" And TextBox1.Text = "for" Then
            Label3.Text = Val(Label3.Text) + 4
        Else

        End If
    End Sub

    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles TextBox1.TextChanged

    End Sub

    Private Sub TextBox1_MouseClick(sender As Object, e As MouseEventArgs) Handles TextBox1.MouseClick
        TextBox1.Text = String.Empty
    End Sub
End Class