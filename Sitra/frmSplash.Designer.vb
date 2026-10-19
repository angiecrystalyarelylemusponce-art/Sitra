<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmSplash
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
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmSplash))
        Me.Label1 = New System.Windows.Forms.Label()
        Me.lblSistemaSysterre = New System.Windows.Forms.Label()
        Me.lblVersion = New System.Windows.Forms.Label()
        Me.lblDesarrollador = New System.Windows.Forms.Label()
        Me.lblPlataformaWindows = New System.Windows.Forms.Label()
        Me.ProgressBar1 = New System.Windows.Forms.ProgressBar()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.Label4 = New System.Windows.Forms.Label()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Uighur", 24.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(356, -1)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(27, 38)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "  "
        '
        'lblSistemaSysterre
        '
        Me.lblSistemaSysterre.AutoSize = True
        Me.lblSistemaSysterre.Font = New System.Drawing.Font("Stencil", 30.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblSistemaSysterre.Location = New System.Drawing.Point(234, 68)
        Me.lblSistemaSysterre.Name = "lblSistemaSysterre"
        Me.lblSistemaSysterre.Size = New System.Drawing.Size(403, 47)
        Me.lblSistemaSysterre.TabIndex = 1
        Me.lblSistemaSysterre.Text = "Sistema Systerre"
        '
        'lblVersion
        '
        Me.lblVersion.AutoSize = True
        Me.lblVersion.Font = New System.Drawing.Font("Microsoft Uighur", 30.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblVersion.Location = New System.Drawing.Point(234, 115)
        Me.lblVersion.Name = "lblVersion"
        Me.lblVersion.Size = New System.Drawing.Size(157, 48)
        Me.lblVersion.TabIndex = 2
        Me.lblVersion.Text = "Version 1.0"
        '
        'lblDesarrollador
        '
        Me.lblDesarrollador.AutoSize = True
        Me.lblDesarrollador.Font = New System.Drawing.Font("Microsoft Uighur", 21.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblDesarrollador.Location = New System.Drawing.Point(355, 6)
        Me.lblDesarrollador.Name = "lblDesarrollador"
        Me.lblDesarrollador.Size = New System.Drawing.Size(258, 35)
        Me.lblDesarrollador.TabIndex = 3
        Me.lblDesarrollador.Text = "Desarrollador: Angie Lemus"
        '
        'lblPlataformaWindows
        '
        Me.lblPlataformaWindows.AutoSize = True
        Me.lblPlataformaWindows.Font = New System.Drawing.Font("Microsoft Uighur", 27.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblPlataformaWindows.Location = New System.Drawing.Point(14, 174)
        Me.lblPlataformaWindows.Name = "lblPlataformaWindows"
        Me.lblPlataformaWindows.Size = New System.Drawing.Size(348, 45)
        Me.lblPlataformaWindows.TabIndex = 5
        Me.lblPlataformaWindows.Text = "Plataforma: Windows 10 y 11"
        '
        'ProgressBar1
        '
        Me.ProgressBar1.Location = New System.Drawing.Point(363, 186)
        Me.ProgressBar1.Name = "ProgressBar1"
        Me.ProgressBar1.Size = New System.Drawing.Size(232, 23)
        Me.ProgressBar1.TabIndex = 8
        '
        'Timer1
        '
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Uighur", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(485, 41)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(128, 27)
        Me.Label4.TabIndex = 9
        Me.Label4.Text = "Copyright © 2026"
        '
        'PictureBox2
        '
        Me.PictureBox2.Image = Global.Sitra.My.Resources.Resources.startup
        Me.PictureBox2.Location = New System.Drawing.Point(619, 6)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(32, 38)
        Me.PictureBox2.TabIndex = 7
        Me.PictureBox2.TabStop = False
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = Global.Sitra.My.Resources.Resources.images
        Me.PictureBox1.Location = New System.Drawing.Point(22, 12)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(206, 152)
        Me.PictureBox1.TabIndex = 6
        Me.PictureBox1.TabStop = False
        '
        'frmSplash
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(666, 268)
        Me.ControlBox = False
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.ProgressBar1)
        Me.Controls.Add(Me.PictureBox2)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.lblPlataformaWindows)
        Me.Controls.Add(Me.lblDesarrollador)
        Me.Controls.Add(Me.lblVersion)
        Me.Controls.Add(Me.lblSistemaSysterre)
        Me.Controls.Add(Me.Label1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "frmSplash"
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents lblSistemaSysterre As Label
    Friend WithEvents lblVersion As Label
    Friend WithEvents lblDesarrollador As Label
    Friend WithEvents lblPlataformaWindows As Label
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents ProgressBar1 As ProgressBar
    Friend WithEvents Timer1 As Timer
    Friend WithEvents Label4 As Label
End Class
