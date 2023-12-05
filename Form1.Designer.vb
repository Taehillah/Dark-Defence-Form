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
        components = New ComponentModel.Container()
        Dim resources As ComponentModel.ComponentResourceManager = New ComponentModel.ComponentResourceManager(GetType(Form1))
        Guna2Elipse1 = New Guna.UI2.WinForms.Guna2Elipse(components)
        saafLogo = New PictureBox()
        LogoLabel = New Label()
        CType(saafLogo, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' Guna2Elipse1
        ' 
        Guna2Elipse1.TargetControl = Me
        ' 
        ' saafLogo
        ' 
        saafLogo.BackgroundImage = CType(resources.GetObject("saafLogo.BackgroundImage"), Image)
        saafLogo.BackgroundImageLayout = ImageLayout.Stretch
        saafLogo.Image = CType(resources.GetObject("saafLogo.Image"), Image)
        saafLogo.InitialImage = CType(resources.GetObject("saafLogo.InitialImage"), Image)
        saafLogo.Location = New Point(360, 42)
        saafLogo.Name = "saafLogo"
        saafLogo.Size = New Size(60, 60)
        saafLogo.TabIndex = 0
        saafLogo.TabStop = False
        ' 
        ' LogoLabel
        ' 
        LogoLabel.AutoSize = True
        LogoLabel.Font = New Font("Baskerville Old Face", 10F, FontStyle.Regular, GraphicsUnit.Point)
        LogoLabel.Location = New Point(256, 114)
        LogoLabel.Name = "LogoLabel"
        LogoLabel.Size = New Size(271, 16)
        LogoLabel.TabIndex = 2
        LogoLabel.Text = "South African Air Force Clearing In|Out Form"
        ' 
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.FromArgb(CByte(34), CByte(37), CByte(46))
        ClientSize = New Size(800, 450)
        Controls.Add(LogoLabel)
        Controls.Add(saafLogo)
        ForeColor = Color.Transparent
        FormBorderStyle = FormBorderStyle.None
        Name = "Form1"
        Text = "Form1"
        CType(saafLogo, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Guna2Elipse1 As Guna.UI2.WinForms.Guna2Elipse
    Friend WithEvents saafLogo As PictureBox
    Friend WithEvents Guna2TextBox1 As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents LogoLabel As Label
End Class
