Public Class Form3
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim num As Integer
        'Si lo que hay en el texto no se puede convertir a integer, da un error de formato
        Try
            num = CInt(TextBox1.Text)
        Catch
            MsgBox("Error de formato")
            Exit Sub
        End Try
        If ComboBox1.Text = "Al final" Then
            ListBox1.Items.Add(TextBox1.Text)
        End If
        If ComboBox1.Text = "Al principio" Then
            Dim pos As Integer
            pos = 0
            ListBox1.Items.Insert(0, TextBox1.Text)
        End If

        If ComboBox1.Text = "En el lugar que toque" Then
            If CInt(ListBox1.Items.Count()) = CInt("0") Then
                ListBox1.Items.Add(TextBox1.Text)

            Else
                Dim i = 0
                For i = 0 To ListBox1.Items.Count() - 1 Step 1
                    If (CDbl(TextBox1.Text) < CDbl(ListBox1.Items.Item(i))) Then
                        ListBox1.Items.Insert(i, CDbl(TextBox1.Text))
                        Exit For

                    ElseIf (i = ListBox1.Items.Count() - 1) Then
                        ListBox1.Items.Add(TextBox1.Text)
                        Exit For

                    End If
                Next i

                i = 0
            End If
        End If
        'Con esto borramos lo que hay en la caja
        TextBox1.Text = ""
    End Sub

    Private Sub ButtonEliminar_Click(sender As Object, e As EventArgs) Handles ButtonEliminar.Click
        Dim pos As Integer

        pos = (ListBox1.SelectedIndex)
        Try
            ListBox1.Items.RemoveAt(pos)
        Catch ex As Exception
            MsgBox("Tienes que que seleccionar que quieres borrar")
        End Try
    End Sub


    Private Sub ButtonMaxMin_Click(sender As Object, e As EventArgs) Handles ButtonMaxMin.Click
        Dim max As Integer
        Dim min As Integer
        Dim suma As Integer
        Dim media As Integer
        Dim i As Integer
        Dim printar As String

        Try
            max = ListBox1.Items.Item(0)
            min = ListBox1.Items.Item(0)
        Catch
            MsgBox("No hay datos en la tabla")
            Exit Sub
        End Try


        For i = 0 To ListBox1.Items.Count() - 1 Step 1
            suma = suma + ListBox1.Items.Item(i)

            If (CDbl(ListBox1.Items.Item(i) > max)) Then
                max = ListBox1.Items.Item(i)

            ElseIf (CDbl(ListBox1.Items.Item(i) < max)) Then
                min = ListBox1.Items.Item(i)

            End If
        Next i

        media = suma / i
        printar = "El numero mas grande es: " + CStr(max) + vbCr + "El mas pequeño es: " + CStr(min) + vbCr + "La media es: " + CStr(media)
        MsgBox(printar)
    End Sub


    ''Cremaos un boton de ordenar y los radioButton para ordenar los numeros
    Private Sub ButtonOrdenar_Click(sender As Object, e As EventArgs) Handles ButtonOrdenar.Click
        Dim I, J, aux, max As Integer
        max = ListBox1.Items.Count - 1
        'Hacemos un bucle dentro para otro para ordenar todos los numeros
        If (RadioButtonAsc.Checked = True) And (RadioButtonNumerica.Checked = True) Then
            For I = 0 To max
                For J = 0 To max
                    If CDbl(ListBox1.Items.Item(I)) < CDbl(ListBox1.Items.Item(J)) Then
                        aux = CDbl(ListBox1.Items.Item(J))
                        ListBox1.Items.Item(J) = ListBox1.Items.Item(I)
                        ListBox1.Items.Item(I) = aux
                    End If
                Next J
            Next I



        ElseIf (RadioButtonAsc.Checked = False) And (RadioButtonNumerica.Checked = True) Then
            For I = 0 To max
                For J = 0 To max
                    If CDbl(ListBox1.Items.Item(I)) > CDbl(ListBox1.Items.Item(J)) Then
                        aux = CDbl(ListBox1.Items.Item(J))
                        ListBox1.Items.Item(J) = ListBox1.Items.Item(I)
                        ListBox1.Items.Item(I) = aux
                    End If
                Next J
            Next I


        End If

        If (RadioButtonAsc.Checked = True) And (RadioButtonAscii.Checked = True) Then
            For I = 0 To max
                For J = 0 To max
                    If CStr(ListBox1.Items.Item(I)) < CStr(ListBox1.Items.Item(J)) Then
                        aux = CStr(ListBox1.Items.Item(J))
                        ListBox1.Items.Item(J) = ListBox1.Items.Item(I)
                        ListBox1.Items.Item(I) = aux
                    End If
                Next J
            Next I



        ElseIf (RadioButtonAsc.Checked = False) And (RadioButtonAscii.Checked = True) Then
            For I = 0 To max
                For J = 0 To max
                    If CStr(ListBox1.Items.Item(I)) > CStr(ListBox1.Items.Item(J)) Then
                        aux = CStr(ListBox1.Items.Item(J))
                        ListBox1.Items.Item(J) = ListBox1.Items.Item(I)
                        ListBox1.Items.Item(I) = aux
                    End If
                Next J
            Next I


        End If




    End Sub

End Class
