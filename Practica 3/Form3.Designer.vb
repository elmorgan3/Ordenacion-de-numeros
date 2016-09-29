<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form3
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Requerido por el Diseñador de Windows Forms
    Private components As System.ComponentModel.IContainer

    'NOTA: el Diseñador de Windows Forms necesita el siguiente procedimiento
    'Se puede modificar usando el Diseñador de Windows Forms.  
    'No lo modifique con el editor de código.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.ListBox1 = New System.Windows.Forms.ListBox()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.ComboBox1 = New System.Windows.Forms.ComboBox()
        Me.ButtonEliminar = New System.Windows.Forms.Button()
        Me.ButtonMaxMin = New System.Windows.Forms.Button()
        Me.RadioButtonNumerica = New System.Windows.Forms.RadioButton()
        Me.RadioButtonAscii = New System.Windows.Forms.RadioButton()
        Me.RadioButtonAsc = New System.Windows.Forms.RadioButton()
        Me.RadioButtonDes = New System.Windows.Forms.RadioButton()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.ButtonOrdenar = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(12, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(89, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Texto a introducir"
        '
        'TextBox1
        '
        Me.TextBox1.Location = New System.Drawing.Point(15, 25)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(100, 20)
        Me.TextBox1.TabIndex = 1
        '
        'ListBox1
        '
        Me.ListBox1.FormattingEnabled = True
        Me.ListBox1.Location = New System.Drawing.Point(121, 9)
        Me.ListBox1.Name = "ListBox1"
        Me.ListBox1.ScrollAlwaysVisible = True
        Me.ListBox1.SelectionMode = System.Windows.Forms.SelectionMode.MultiExtended
        Me.ListBox1.Size = New System.Drawing.Size(120, 95)
        Me.ListBox1.TabIndex = 2
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(15, 51)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(75, 23)
        Me.Button1.TabIndex = 3
        Me.Button1.Text = "Añadir"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'ComboBox1
        '
        Me.ComboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.ComboBox1.FormattingEnabled = True
        Me.ComboBox1.Items.AddRange(New Object() {"Al final", "Al principio", "En el lugar que toque"})
        Me.ComboBox1.Location = New System.Drawing.Point(121, 110)
        Me.ComboBox1.Name = "ComboBox1"
        Me.ComboBox1.Size = New System.Drawing.Size(121, 21)
        Me.ComboBox1.TabIndex = 4
        '
        'ButtonEliminar
        '
        Me.ButtonEliminar.Location = New System.Drawing.Point(121, 138)
        Me.ButtonEliminar.Name = "ButtonEliminar"
        Me.ButtonEliminar.Size = New System.Drawing.Size(120, 23)
        Me.ButtonEliminar.TabIndex = 5
        Me.ButtonEliminar.Text = "Eliminar seleccionado"
        Me.ButtonEliminar.UseVisualStyleBackColor = True
        '
        'ButtonMaxMin
        '
        Me.ButtonMaxMin.Location = New System.Drawing.Point(121, 167)
        Me.ButtonMaxMin.Name = "ButtonMaxMin"
        Me.ButtonMaxMin.Size = New System.Drawing.Size(120, 23)
        Me.ButtonMaxMin.TabIndex = 6
        Me.ButtonMaxMin.Text = "Max, Min, y Media"
        Me.ButtonMaxMin.UseVisualStyleBackColor = True
        '
        'RadioButtonNumerica
        '
        Me.RadioButtonNumerica.AutoSize = True
        Me.RadioButtonNumerica.Checked = True
        Me.RadioButtonNumerica.Location = New System.Drawing.Point(21, 22)
        Me.RadioButtonNumerica.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.RadioButtonNumerica.Name = "RadioButtonNumerica"
        Me.RadioButtonNumerica.Size = New System.Drawing.Size(70, 17)
        Me.RadioButtonNumerica.TabIndex = 7
        Me.RadioButtonNumerica.TabStop = True
        Me.RadioButtonNumerica.Text = "Numerica"
        Me.RadioButtonNumerica.UseVisualStyleBackColor = True
        '
        'RadioButtonAscii
        '
        Me.RadioButtonAscii.AutoSize = True
        Me.RadioButtonAscii.Location = New System.Drawing.Point(21, 47)
        Me.RadioButtonAscii.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.RadioButtonAscii.Name = "RadioButtonAscii"
        Me.RadioButtonAscii.Size = New System.Drawing.Size(52, 17)
        Me.RadioButtonAscii.TabIndex = 8
        Me.RadioButtonAscii.Text = "ASCII"
        Me.RadioButtonAscii.UseVisualStyleBackColor = True
        '
        'RadioButtonAsc
        '
        Me.RadioButtonAsc.AutoSize = True
        Me.RadioButtonAsc.Checked = True
        Me.RadioButtonAsc.Location = New System.Drawing.Point(20, 25)
        Me.RadioButtonAsc.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.RadioButtonAsc.Name = "RadioButtonAsc"
        Me.RadioButtonAsc.Size = New System.Drawing.Size(82, 17)
        Me.RadioButtonAsc.TabIndex = 9
        Me.RadioButtonAsc.TabStop = True
        Me.RadioButtonAsc.Text = "Ascendente"
        Me.RadioButtonAsc.UseVisualStyleBackColor = True
        '
        'RadioButtonDes
        '
        Me.RadioButtonDes.AutoSize = True
        Me.RadioButtonDes.Location = New System.Drawing.Point(20, 47)
        Me.RadioButtonDes.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.RadioButtonDes.Name = "RadioButtonDes"
        Me.RadioButtonDes.Size = New System.Drawing.Size(89, 17)
        Me.RadioButtonDes.TabIndex = 10
        Me.RadioButtonDes.Text = "Descendente"
        Me.RadioButtonDes.UseVisualStyleBackColor = True
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.RadioButtonAscii)
        Me.GroupBox1.Controls.Add(Me.RadioButtonNumerica)
        Me.GroupBox1.Location = New System.Drawing.Point(284, 10)
        Me.GroupBox1.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Padding = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.GroupBox1.Size = New System.Drawing.Size(148, 81)
        Me.GroupBox1.TabIndex = 13
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Tipo de ordenacion"
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.RadioButtonAsc)
        Me.GroupBox2.Controls.Add(Me.RadioButtonDes)
        Me.GroupBox2.Location = New System.Drawing.Point(284, 97)
        Me.GroupBox2.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Padding = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.GroupBox2.Size = New System.Drawing.Size(148, 81)
        Me.GroupBox2.TabIndex = 14
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Orden"
        '
        'ButtonOrdenar
        '
        Me.ButtonOrdenar.Location = New System.Drawing.Point(284, 183)
        Me.ButtonOrdenar.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.ButtonOrdenar.Name = "ButtonOrdenar"
        Me.ButtonOrdenar.Size = New System.Drawing.Size(148, 35)
        Me.ButtonOrdenar.TabIndex = 15
        Me.ButtonOrdenar.Text = "Ordenar"
        Me.ButtonOrdenar.UseVisualStyleBackColor = True
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(3, 81)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(112, 23)
        Me.Button2.TabIndex = 16
        Me.Button2.Text = "Añadir preguntando"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(553, 407)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.ButtonOrdenar)
        Me.Controls.Add(Me.ButtonMaxMin)
        Me.Controls.Add(Me.ButtonEliminar)
        Me.Controls.Add(Me.ComboBox1)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.ListBox1)
        Me.Controls.Add(Me.TextBox1)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.GroupBox2)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents TextBox1 As System.Windows.Forms.TextBox
    Friend WithEvents ListBox1 As System.Windows.Forms.ListBox
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents ComboBox1 As System.Windows.Forms.ComboBox
    Friend WithEvents ButtonEliminar As System.Windows.Forms.Button
    Friend WithEvents ButtonMaxMin As System.Windows.Forms.Button
    Friend WithEvents RadioButtonNumerica As RadioButton
    Friend WithEvents RadioButtonAscii As RadioButton
    Friend WithEvents RadioButtonAsc As RadioButton
    Friend WithEvents RadioButtonDes As RadioButton
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents ButtonOrdenar As Button
    Friend WithEvents Button2 As System.Windows.Forms.Button
End Class
