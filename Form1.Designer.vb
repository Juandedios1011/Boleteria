<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        tbx_nombre = New Label()
        tbx_apellido = New Label()
        tbx_cedula = New Label()
        tbx_fecha = New Label()
        tbx = New Label()
        tbx_item = New Label()
        Button1 = New Button()
        TextBox1 = New TextBox()
        TextBox2 = New TextBox()
        TextBox3 = New TextBox()
        TextBox5 = New TextBox()
        TextBox6 = New TextBox()
        cb_nombre_item = New ComboBox()
        Label1 = New Label()
        PictureBox1 = New PictureBox()
        Label2 = New Label()
        CType(PictureBox1, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' tbx_nombre
        ' 
        tbx_nombre.AutoSize = True
        tbx_nombre.Font = New Font("Segoe UI", 12.0F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        tbx_nombre.Location = New Point(87, 134)
        tbx_nombre.Name = "tbx_nombre"
        tbx_nombre.Size = New Size(91, 28)
        tbx_nombre.TabIndex = 0
        tbx_nombre.Text = "nombre "
        ' 
        ' tbx_apellido
        ' 
        tbx_apellido.AutoSize = True
        tbx_apellido.Font = New Font("Segoe UI", 12.0F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        tbx_apellido.Location = New Point(410, 142)
        tbx_apellido.Name = "tbx_apellido"
        tbx_apellido.Size = New Size(91, 28)
        tbx_apellido.TabIndex = 1
        tbx_apellido.Text = "Apellido"
        ' 
        ' tbx_cedula
        ' 
        tbx_cedula.AutoSize = True
        tbx_cedula.Font = New Font("Segoe UI", 12.0F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        tbx_cedula.Location = New Point(715, 138)
        tbx_cedula.Name = "tbx_cedula"
        tbx_cedula.Size = New Size(76, 28)
        tbx_cedula.TabIndex = 2
        tbx_cedula.Text = "Cedula"
        ' 
        ' tbx_fecha
        ' 
        tbx_fecha.AutoSize = True
        tbx_fecha.Font = New Font("Segoe UI", 12.0F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        tbx_fecha.Location = New Point(778, 51)
        tbx_fecha.Name = "tbx_fecha"
        tbx_fecha.Size = New Size(72, 28)
        tbx_fecha.TabIndex = 3
        tbx_fecha.Text = "Fecha "
        ' 
        ' tbx
        ' 
        tbx.AutoSize = True
        tbx.Font = New Font("Segoe UI", 12.0F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        tbx.Location = New Point(87, 266)
        tbx.Name = "tbx"
        tbx.Size = New Size(104, 28)
        tbx.TabIndex = 4
        tbx.Text = "Producto "
        ' 
        ' tbx_item
        ' 
        tbx_item.AutoSize = True
        tbx_item.Font = New Font("Segoe UI", 12.0F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        tbx_item.Location = New Point(87, 364)
        tbx_item.Name = "tbx_item"
        tbx_item.Size = New Size(77, 28)
        tbx_item.TabIndex = 5
        tbx_item.Text = "Precio "
        ' 
        ' Button1
        ' 
        Button1.Location = New Point(877, 408)
        Button1.Name = "Button1"
        Button1.Size = New Size(143, 32)
        Button1.TabIndex = 6
        Button1.Text = "Button1"
        Button1.UseVisualStyleBackColor = True
        ' 
        ' TextBox1
        ' 
        TextBox1.Location = New Point(184, 139)
        TextBox1.Name = "TextBox1"
        TextBox1.Size = New Size(152, 27)
        TextBox1.TabIndex = 7
        ' 
        ' TextBox2
        ' 
        TextBox2.Location = New Point(507, 142)
        TextBox2.Name = "TextBox2"
        TextBox2.Size = New Size(152, 27)
        TextBox2.TabIndex = 8
        ' 
        ' TextBox3
        ' 
        TextBox3.Location = New Point(797, 139)
        TextBox3.Name = "TextBox3"
        TextBox3.Size = New Size(152, 27)
        TextBox3.TabIndex = 9
        ' 
        ' TextBox5
        ' 
        TextBox5.Location = New Point(184, 365)
        TextBox5.Name = "TextBox5"
        TextBox5.Size = New Size(152, 27)
        TextBox5.TabIndex = 11
        ' 
        ' TextBox6
        ' 
        TextBox6.Location = New Point(856, 51)
        TextBox6.Name = "TextBox6"
        TextBox6.Size = New Size(152, 27)
        TextBox6.TabIndex = 12
        ' 
        ' cb_nombre_item
        ' 
        cb_nombre_item.FormattingEnabled = True
        cb_nombre_item.Items.AddRange(New Object() {"Refresco ", "Dorito ", "Duro frio ", "Pepito ", "Chocolate ", "Coca "})
        cb_nombre_item.Location = New Point(193, 271)
        cb_nombre_item.Name = "cb_nombre_item"
        cb_nombre_item.Size = New Size(120, 28)
        cb_nombre_item.TabIndex = 14
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Segoe UI", 18.0F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label1.Location = New Point(145, 38)
        Label1.Name = "Label1"
        Label1.Size = New Size(282, 41)
        Label1.TabIndex = 15
        Label1.Text = "TIENDA DON PEPE"
        ' 
        ' PictureBox1
        ' 
        PictureBox1.Image = My.Resources.Resources.Captura_de_pantalla_2024_07_12_185109
        PictureBox1.Location = New Point(532, 199)
        PictureBox1.Name = "PictureBox1"
        PictureBox1.Size = New Size(318, 321)
        PictureBox1.TabIndex = 16
        PictureBox1.TabStop = False
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Font = New Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label2.Location = New Point(871, 364)
        Label2.Name = "Label2"
        Label2.Size = New Size(164, 25)
        Label2.TabIndex = 17
        Label2.Text = "Ojo dale al boton "
        ' 
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(8.0F, 20.0F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = SystemColors.ActiveCaption
        ClientSize = New Size(1047, 515)
        Controls.Add(Label2)
        Controls.Add(PictureBox1)
        Controls.Add(Label1)
        Controls.Add(cb_nombre_item)
        Controls.Add(TextBox6)
        Controls.Add(TextBox5)
        Controls.Add(TextBox3)
        Controls.Add(TextBox2)
        Controls.Add(TextBox1)
        Controls.Add(Button1)
        Controls.Add(tbx_item)
        Controls.Add(tbx)
        Controls.Add(tbx_fecha)
        Controls.Add(tbx_cedula)
        Controls.Add(tbx_apellido)
        Controls.Add(tbx_nombre)
        Name = "Form1"
        Text = "Form1"
        CType(PictureBox1, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents tbx_nombre As Label
    Friend WithEvents tbx_apellido As Label
    Friend WithEvents tbx_cedula As Label
    Friend WithEvents tbx_fecha As Label
    Friend WithEvents tbx As Label
    Friend WithEvents tbx_item As Label
    Friend WithEvents Button1 As Button
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents TextBox2 As TextBox
    Friend WithEvents TextBox3 As TextBox
    Friend WithEvents TextBox5 As TextBox
    Friend WithEvents TextBox6 As TextBox
    Friend WithEvents cb_nombre_item As ComboBox
    Friend WithEvents Label1 As Label
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents Label2 As Label

End Class
