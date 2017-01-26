<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
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

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        Me.list = New System.Windows.Forms.ImageList(Me.components)
        Me.up = New System.Windows.Forms.ImageList(Me.components)
        Me.left = New System.Windows.Forms.ImageList(Me.components)
        Me.right = New System.Windows.Forms.ImageList(Me.components)
        Me.Picplayer = New System.Windows.Forms.PictureBox()
        CType(Me.Picplayer, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'list
        '
        Me.list.ImageStream = CType(resources.GetObject("list.ImageStream"), System.Windows.Forms.ImageListStreamer)
        Me.list.TransparentColor = System.Drawing.Color.Transparent
        Me.list.Images.SetKeyName(0, "1.png")
        Me.list.Images.SetKeyName(1, "1.png")
        Me.list.Images.SetKeyName(2, "1.png")
        Me.list.Images.SetKeyName(3, "1.png")
        Me.list.Images.SetKeyName(4, "2 copy.png")
        Me.list.Images.SetKeyName(5, "2 copy.png")
        Me.list.Images.SetKeyName(6, "2 copy.png")
        Me.list.Images.SetKeyName(7, "2 copy.png")
        Me.list.Images.SetKeyName(8, "3.png")
        Me.list.Images.SetKeyName(9, "3.png")
        Me.list.Images.SetKeyName(10, "3.png")
        Me.list.Images.SetKeyName(11, "3.png")
        Me.list.Images.SetKeyName(12, "4.png")
        Me.list.Images.SetKeyName(13, "4.png")
        Me.list.Images.SetKeyName(14, "4.png")
        Me.list.Images.SetKeyName(15, "4.png")
        '
        'up
        '
        Me.up.ImageStream = CType(resources.GetObject("up.ImageStream"), System.Windows.Forms.ImageListStreamer)
        Me.up.TransparentColor = System.Drawing.Color.Transparent
        Me.up.Images.SetKeyName(0, "up1.png")
        Me.up.Images.SetKeyName(1, "up1.png")
        Me.up.Images.SetKeyName(2, "up1.png")
        Me.up.Images.SetKeyName(3, "up1.png")
        Me.up.Images.SetKeyName(4, "up2.png")
        Me.up.Images.SetKeyName(5, "up2.png")
        Me.up.Images.SetKeyName(6, "up2.png")
        Me.up.Images.SetKeyName(7, "up2.png")
        Me.up.Images.SetKeyName(8, "up3.png")
        Me.up.Images.SetKeyName(9, "up3.png")
        Me.up.Images.SetKeyName(10, "up3.png")
        Me.up.Images.SetKeyName(11, "up3.png")
        Me.up.Images.SetKeyName(12, "up4.png")
        Me.up.Images.SetKeyName(13, "up4.png")
        Me.up.Images.SetKeyName(14, "up4.png")
        Me.up.Images.SetKeyName(15, "up4.png")
        '
        'left
        '
        Me.left.ImageStream = CType(resources.GetObject("left.ImageStream"), System.Windows.Forms.ImageListStreamer)
        Me.left.TransparentColor = System.Drawing.Color.Transparent
        Me.left.Images.SetKeyName(0, "left1.png")
        Me.left.Images.SetKeyName(1, "left1.png")
        Me.left.Images.SetKeyName(2, "left1.png")
        Me.left.Images.SetKeyName(3, "left1.png")
        Me.left.Images.SetKeyName(4, "left2.png")
        Me.left.Images.SetKeyName(5, "left2.png")
        Me.left.Images.SetKeyName(6, "left2.png")
        Me.left.Images.SetKeyName(7, "left2.png")
        Me.left.Images.SetKeyName(8, "left3.png")
        Me.left.Images.SetKeyName(9, "left3.png")
        Me.left.Images.SetKeyName(10, "left3.png")
        Me.left.Images.SetKeyName(11, "left3.png")
        Me.left.Images.SetKeyName(12, "left4.png")
        Me.left.Images.SetKeyName(13, "left4.png")
        Me.left.Images.SetKeyName(14, "left4.png")
        Me.left.Images.SetKeyName(15, "left4.png")
        '
        'right
        '
        Me.right.ImageStream = CType(resources.GetObject("right.ImageStream"), System.Windows.Forms.ImageListStreamer)
        Me.right.TransparentColor = System.Drawing.Color.Transparent
        Me.right.Images.SetKeyName(0, "right1.png")
        Me.right.Images.SetKeyName(1, "right1.png")
        Me.right.Images.SetKeyName(2, "right1.png")
        Me.right.Images.SetKeyName(3, "right1.png")
        Me.right.Images.SetKeyName(4, "right2.png")
        Me.right.Images.SetKeyName(5, "right2.png")
        Me.right.Images.SetKeyName(6, "right2.png")
        Me.right.Images.SetKeyName(7, "right2.png")
        Me.right.Images.SetKeyName(8, "right3.png")
        Me.right.Images.SetKeyName(9, "right3.png")
        Me.right.Images.SetKeyName(10, "right3.png")
        Me.right.Images.SetKeyName(11, "right3.png")
        Me.right.Images.SetKeyName(12, "right4.png")
        Me.right.Images.SetKeyName(13, "right4.png")
        Me.right.Images.SetKeyName(14, "right4.png")
        Me.right.Images.SetKeyName(15, "right4.png")
        '
        'Picplayer
        '
        Me.Picplayer.Image = Global.movement_trial_1.My.Resources.Resources.up1
        Me.Picplayer.Location = New System.Drawing.Point(161, 148)
        Me.Picplayer.Name = "Picplayer"
        Me.Picplayer.Size = New System.Drawing.Size(67, 77)
        Me.Picplayer.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage
        Me.Picplayer.TabIndex = 0
        Me.Picplayer.TabStop = False
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(667, 452)
        Me.Controls.Add(Me.Picplayer)
        Me.Name = "Form1"
        Me.Text = "Form1"
        CType(Me.Picplayer, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents list As System.Windows.Forms.ImageList
    Friend WithEvents Picplayer As System.Windows.Forms.PictureBox
    Friend WithEvents up As System.Windows.Forms.ImageList
    Friend WithEvents left As System.Windows.Forms.ImageList
    Friend WithEvents right As System.Windows.Forms.ImageList

End Class
