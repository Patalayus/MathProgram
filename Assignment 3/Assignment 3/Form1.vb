Public Class Form1
    'This is where I am defining the variables in which I am going to use in my program.
    'These variables will allow for my program to be able to operate and assign values to these different
    'varibles to allow for the program to be able to function sufficiently.
    Dim AddValue As String
    Dim MinusValue As String
    Dim Answer As String
    Dim HelpCount As Integer
    Dim Button8_Stage0 As Integer
    Dim Score As Integer
    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        'This is a private subroutine for the TextBox5 which is located in my GUI interface.
        'This subroutine will make the text which apprears in the subroutine the minus symbol when Button2
        'is clicked on the GUI.
        TextBox5.Text = "-"
        AddValue = 2
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        'This is a function which means that the text which is displayed in the textbox when Button3
        'is clicked is the division symbol.
        TextBox5.Text = "/"
        AddValue = 4
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        'Tthis is a function which means that the text which is displayed in the textbox when Button1
        'is clicked is the plus symbol.
        TextBox5.Text = "+"
        AddValue = 1
    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'These two statements simply mean that when the form loads, the picture boxes for the
        'verification of the different outcomes of the program calculations are not visible
        'during the initialisation of the program GUI.
        PictureBox2.Visible = False
        PictureBox1.Visible = False
        Label11.Visible = False
        Label12.Visible = False
        Label13.Visible = False
        Label14.Visible = False
        Label15.Visible = False
        Label16.Visible = False
        HelpCount = 0
        Score = 0
    End Sub

    Private Sub HScrollBar1_Scroll(sender As Object, e As ScrollEventArgs) Handles HScrollBar1.Scroll
        'This is a function for the scroll bar to generate random numbers based on user input.
        'This is does by the 'Randomize()' function of the program code and this is used to declare
        'the different values of the program scroll bar as integers in the code and so they are
        'compatible with the rest of the program and are not 'unstable' so to speak.
        Randomize()
        Dim value As Integer = CInt(Int((6 * Rnd()) + 1))
        Dim value2 As Integer = CInt(Int((6 * Rnd()) + 1))
        Dim value3 As Integer = CInt(Int((20 * Rnd()) + 1))
        Dim value4 As Integer = CInt(Int((20 * Rnd()) + 1))
        Dim value5 As Integer = CInt(Int((1000 * Rnd()) + 1))
        Dim value6 As Integer = CInt(Int((1000 * Rnd()) + 1))

        'This section states that is the scroll bar value is '0', so if the scroll bar is at
        ' the lowest setting, then TextBox1.Text and TextBox2.Text are value and value2.
        ' and this can be applied to the section above as the section above states that value
        ' and value2 are the most simple values of the TextBoxes and therefore the most simple
        ' calculations in which the user will have to answer.

        'This also applies to the other sections of this subroutine as these work to state that if the
        'scroll bar is adjusted to a higher difficulty, then the caluculation in which the user will
        'have to solve, will be more difficult. 
        If HScrollBar1.Value = 0 Then
            TextBox1.Text = value
            TextBox2.Text = value2
        End If
        If HScrollBar1.Value = 1 Then
            TextBox1.Text = value3
            TextBox2.Text = value4
        End If
        If HScrollBar1.Value = 2 Then
            TextBox1.Text = value5
            TextBox2.Text = value6
        End If
    End Sub

    Private Sub TextBox4_TextChanged(sender As Object, e As EventArgs)

    End Sub

    Private Sub TextBox5_TextChanged(sender As Object, e As EventArgs) Handles TextBox5.TextChanged

    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        'This subroutine means that is Button4 is clicked, then the text inside of TextBox5 will be
        ' the multiplication symbol. This is becasue the user will be trying to times 2 randomly
        'generated numbers together.
        TextBox5.Text = "x"
        AddValue = 3
    End Sub

    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles TextBox1.TextChanged

    End Sub

    Private Sub TextBox2_TextChanged(sender As Object, e As EventArgs) Handles TextBox2.TextChanged

    End Sub

    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles PictureBox1.Click


    End Sub

    Private Sub PictureBox2_Click(sender As Object, e As EventArgs) Handles PictureBox2.Click

    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        'This subroutine of program code is the most advanced and required the most thought to produce.
        'This section states that for the different values of the TextBox5, different calculations will occur.
        'And this is done throughthe implementation of the variable AddValue.
        'It works much like a count. Dependant on what value the AddValue is, a section of the subroutine will run.
        'The section below is if the AddValue is a value 1, then the result will be two numbers will be added together.
        If AddValue = 1 Then
            Dim Number1 As Integer
            Dim Number2 As Integer
            Dim Result As String
            Number2 = TextBox2.Text
            Number1 = TextBox1.Text
            PictureBox2.Visible = False
            Result = Number1 + Number2
            If Result = Answer Then
                PictureBox2.Visible = True
                Score += 1
                TextBox4.Text = Score
            ElseIf Result <> Answer Then
                PictureBox1.Visible = True
                Score -= 1
                TextBox4.Text = Score
            End If
            'This section is if the AddValue is a value 2, then the result will be two numbers subtracted from each other.
        ElseIf AddValue = 2 Then
            Dim Number1 As Integer
            Dim Number2 As Integer
            Dim Result As String
            Number2 = TextBox2.Text
            Number1 = TextBox1.Text
            PictureBox2.Visible = False
            Result = Number1 - Number2
            If Result = Answer Then
                PictureBox2.Visible = True
                Score += 1
                TextBox4.Text = Score
            ElseIf Result <> Answer Then
                PictureBox1.Visible = True
                Score -= 1
                TextBox4.Text = Score
            End If
            'This section is if the AddValue is a value 3, then the result will be two numbers multiplied together.
        ElseIf AddValue = 3 Then
            Dim Number1 As Integer
            Dim Number2 As Integer
            Dim Result As String
            Number2 = TextBox2.Text
            Number1 = TextBox1.Text
            PictureBox2.Visible = False
            Result = Number1 * Number2
            If Result = Answer Then
                PictureBox2.Visible = True
                Score += 1
                TextBox4.Text = Score
            ElseIf Result <> Answer Then
                PictureBox1.Visible = True
                Score -= 1
                TextBox4.Text = Score
            End If
            'This section is if the AddValue is a value 4, then the result will be two numbers divided.
        ElseIf AddValue = 4 Then
            Dim Number1 As Integer
            Dim Number2 As Integer
            Dim Result As String
            Number2 = TextBox2.Text
            Number1 = TextBox1.Text
            PictureBox2.Visible = False
            Result = Number1 / Number2
            If Result = Answer Then
                PictureBox2.Visible = True
                Score += 1
                TextBox4.Text = Score
            ElseIf Result <> Answer Then
                PictureBox1.Visible = True
                Score -= 1
                TextBox4.Text = Score
            End If
        End If
    End Sub

    Private Sub TextBox3_TextChanged(sender As Object, e As EventArgs) Handles TextBox3.TextChanged

        Answer = TextBox3.Text
    End Sub

    Private Sub Label2_Click(sender As Object, e As EventArgs) Handles Label2.Click

    End Sub

    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click

    End Sub

    Private Sub Label7_Click(sender As Object, e As EventArgs) Handles Label7.Click

    End Sub

    Private Sub Label3_Click(sender As Object, e As EventArgs) Handles Label3.Click

    End Sub

    Private Sub Label4_Click(sender As Object, e As EventArgs) Handles Label4.Click

    End Sub

    Private Sub Label5_Click(sender As Object, e As EventArgs) Handles Label5.Click

    End Sub

    Private Sub Label6_Click(sender As Object, e As EventArgs) Handles Label6.Click

    End Sub

    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles Button6.Click
        Me.Close()
        'This is a subroutine solely for closing the GUI form.
        'When the leave button is clicked, or the close button, then the form will close as a result.
    End Sub

    Private Sub Button7_Click(sender As Object, e As EventArgs) Handles Button7.Click
        'This is the subroutine for the reset button of the program. If this button is clicked, then
        ' the program will reset all of the values back to zero and the verification pictures will become invisible 
        ' until the conclution of the next calculation.
        TextBox1.Text = 0
        TextBox2.Text = 0
        TextBox3.Text = 0
        PictureBox2.Visible = False
        PictureBox1.Visible = False
    End Sub

    Private Sub TextBox4_TextChanged_1(sender As Object, e As EventArgs)

    End Sub

    Private Sub Label8_Click(sender As Object, e As EventArgs) Handles Label8.Click

    End Sub

    Private Sub Label11_Click(sender As Object, e As EventArgs) Handles Label11.Click

    End Sub

    Private Sub Label12_Click(sender As Object, e As EventArgs) Handles Label12.Click

    End Sub

    Private Sub Label13_Click(sender As Object, e As EventArgs) Handles Label13.Click

    End Sub

    Private Sub Label14_Click(sender As Object, e As EventArgs) Handles Label14.Click

    End Sub

    Private Sub Label15_Click(sender As Object, e As EventArgs) Handles Label15.Click

    End Sub

    Private Sub Label16_Click(sender As Object, e As EventArgs) Handles Label16.Click

    End Sub

    Private Sub Button8_Click(sender As Object, e As EventArgs) Handles Button8.Click
        'This is the help stage of the code and so when the user clicks the help button in the top right,
        '   instructions are displayed that will explain to the user what they are meant to do and how they can use the program
        'This is for the users who haven't used the program before and so they are unsure on how to use the program and need an explanation
        ' on how the program funcitons.
        'I have used cases here to deminstrate the different states in which the button can be.
        ' This allow for the button to have more than just one boolean function.
        ' The button can not be clicked once to allow for the instructions to be presented and then clicked again to get rid of them.
        Select Case Button8_Stage0
            Case 0
                Label11.Visible = True
                Label12.Visible = True
                Label13.Visible = True
                Label14.Visible = True
                Label15.Visible = True
                Label16.Visible = True
                Button8_Stage0 += 1
                'This stage enables for the instructions to be visible and when the case is no longer in use, it minuses 1 from the Button_Stage0 variable
            Case 1
                Label11.Visible = False
                Label12.Visible = False
                Label13.Visible = False
                Label14.Visible = False
                Label15.Visible = False
                Label16.Visible = False
                Button8_Stage0 -= 1
                'This stage therefore hides the instruction to the prorgam and when this case is no longer in use, it pluses 1 to the Button_Stage0 variable
        End Select
    End Sub

    Private Sub ToolTip1_Popup(sender As Object, e As PopupEventArgs) Handles ToolTip1.Popup

    End Sub

    Private Sub TextBox4_TextChanged_2(sender As Object, e As EventArgs) Handles TextBox4.TextChanged

    End Sub
End Class
