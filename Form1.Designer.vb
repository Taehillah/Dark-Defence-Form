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
        Dim CustomizableEdges3 As Guna.UI2.WinForms.Suite.CustomizableEdges = New Guna.UI2.WinForms.Suite.CustomizableEdges()
        Dim CustomizableEdges1 As Guna.UI2.WinForms.Suite.CustomizableEdges = New Guna.UI2.WinForms.Suite.CustomizableEdges()
        Dim CustomizableEdges2 As Guna.UI2.WinForms.Suite.CustomizableEdges = New Guna.UI2.WinForms.Suite.CustomizableEdges()
        Guna2Elipse1 = New Guna.UI2.WinForms.Guna2Elipse(components)
        saafLogo = New PictureBox()
        LogoLabel = New Label()
        Line = New Guna.UI2.WinForms.Guna2Shapes()
        lblForceNo = New Label()
        Guna2TextBox1 = New Guna.UI2.WinForms.Guna2TextBox()
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
        ' Line
        ' 
        Line.BackColor = Color.Transparent
        Line.BorderColor = Color.Transparent
        Line.BorderThickness = 0
        Line.FillColor = Color.FromArgb(CByte(16), CByte(168), CByte(246))
        Line.LineThickness = 1
        Line.Location = New Point(219, 133)
        Line.Name = "Line"
        Line.PolygonSides = 2
        Line.PolygonSkip = 1
        Line.Rotate = 0F
        Line.RoundedEdges = CustomizableEdges3
        Line.Shape = Guna.UI2.WinForms.Enums.ShapeType.Line
        Line.Size = New Size(345, 1)
        Line.TabIndex = 3
        Line.Text = "Guna2Shapes1"
        Line.UseTransparentBackground = True
        Line.Zoom = 80
        ' 
        ' lblForceNo
        ' 
        lblForceNo.AutoSize = True
        lblForceNo.Font = New Font("Baskerville Old Face", 9F, FontStyle.Regular, GraphicsUnit.Point)
        lblForceNo.Location = New Point(117, 168)
        lblForceNo.Name = "lblForceNo"
        lblForceNo.Size = New Size(77, 14)
        lblForceNo.TabIndex = 4
        lblForceNo.Text = "Force Number"
        ' 
        ' Guna2TextBox1
        ' 
        Guna2TextBox1.CustomizableEdges = CustomizableEdges1
        Guna2TextBox1.DefaultText = ""
        Guna2TextBox1.DisabledState.BorderColor = Color.FromArgb(CByte(208), CByte(208), CByte(208))
        Guna2TextBox1.DisabledState.FillColor = Color.FromArgb(CByte(226), CByte(226), CByte(226))
        Guna2TextBox1.DisabledState.ForeColor = Color.FromArgb(CByte(138), CByte(138), CByte(138))
        Guna2TextBox1.DisabledState.PlaceholderForeColor = Color.FromArgb(CByte(138), CByte(138), CByte(138))
        Guna2TextBox1.FillColor = Color.FromArgb(CByte(34), CByte(37), CByte(46))
        Guna2TextBox1.FocusedState.BorderColor = Color.FromArgb(CByte(94), CByte(148), CByte(255))
        Guna2TextBox1.Font = New Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point)
        Guna2TextBox1.HoverState.BorderColor = Color.FromArgb(CByte(94), CByte(148), CByte(255))
        Guna2TextBox1.Location = New Point(121, 187)
        Guna2TextBox1.Name = "Guna2TextBox1"
        Guna2TextBox1.PasswordChar = ChrW(0)
        Guna2TextBox1.PlaceholderText = ""
        Guna2TextBox1.SelectedText = ""
        Guna2TextBox1.ShadowDecoration.CustomizableEdges = CustomizableEdges2
        Guna2TextBox1.Size = New Size(200, 24)
        Guna2TextBox1.TabIndex = 5
        ' 
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.FromArgb(CByte(34), CByte(37), CByte(46))
        ClientSize = New Size(800, 450)
        Controls.Add(Guna2TextBox1)
        Controls.Add(lblForceNo)
        Controls.Add(LogoLabel)
        Controls.Add(saafLogo)
        Controls.Add(Line)
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
    Friend WithEvents Line As Guna.UI2.WinForms.Guna2Shapes
    Friend WithEvents lblForceNo As Label
End Class
