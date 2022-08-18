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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.HScrollBar1 = New System.Windows.Forms.HScrollBar()
        Me.Cart_btn = New System.Windows.Forms.Button()
        Me.Left_Arrow = New System.Windows.Forms.Button()
        Me.Right_Arrow = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'Panel2
        '
        Me.Panel2.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Panel2.BackColor = System.Drawing.SystemColors.GradientInactiveCaption
        Me.Panel2.Location = New System.Drawing.Point(12, 187)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(826, 322)
        Me.Panel2.TabIndex = 0
        '
        'Panel3
        '
        Me.Panel3.BackColor = System.Drawing.Color.PapayaWhip
        Me.Panel3.Location = New System.Drawing.Point(97, 12)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(660, 169)
        Me.Panel3.TabIndex = 2
        '
        'HScrollBar1
        '
        Me.HScrollBar1.Location = New System.Drawing.Point(0, 0)
        Me.HScrollBar1.Name = "HScrollBar1"
        Me.HScrollBar1.Size = New System.Drawing.Size(80, 17)
        Me.HScrollBar1.TabIndex = 0
        '
        'Cart_btn
        '
        Me.Cart_btn.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Cart_btn.BackColor = System.Drawing.Color.Coral
        Me.Cart_btn.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Cart_btn.Font = New System.Drawing.Font("Calibri", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Cart_btn.Location = New System.Drawing.Point(639, 519)
        Me.Cart_btn.Name = "Cart_btn"
        Me.Cart_btn.Size = New System.Drawing.Size(118, 58)
        Me.Cart_btn.TabIndex = 3
        Me.Cart_btn.Text = "Open Cart"
        Me.Cart_btn.UseVisualStyleBackColor = False
        '
        'Left_Arrow
        '
        Me.Left_Arrow.BackColor = System.Drawing.Color.Khaki
        Me.Left_Arrow.Image = CType(resources.GetObject("Left_Arrow.Image"), System.Drawing.Image)
        Me.Left_Arrow.Location = New System.Drawing.Point(12, 21)
        Me.Left_Arrow.Name = "Left_Arrow"
        Me.Left_Arrow.Padding = New System.Windows.Forms.Padding(0, 0, 10, 0)
        Me.Left_Arrow.Size = New System.Drawing.Size(79, 144)
        Me.Left_Arrow.TabIndex = 1
        Me.Left_Arrow.UseVisualStyleBackColor = False
        '
        'Right_Arrow
        '
        Me.Right_Arrow.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Right_Arrow.BackColor = System.Drawing.Color.Khaki
        Me.Right_Arrow.Image = CType(resources.GetObject("Right_Arrow.Image"), System.Drawing.Image)
        Me.Right_Arrow.Location = New System.Drawing.Point(759, 21)
        Me.Right_Arrow.Name = "Right_Arrow"
        Me.Right_Arrow.Padding = New System.Windows.Forms.Padding(10, 0, 0, 0)
        Me.Right_Arrow.Size = New System.Drawing.Size(79, 144)
        Me.Right_Arrow.TabIndex = 1
        Me.Right_Arrow.UseVisualStyleBackColor = False
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.BurlyWood
        Me.ClientSize = New System.Drawing.Size(850, 585)
        Me.Controls.Add(Me.Cart_btn)
        Me.Controls.Add(Me.Panel3)
        Me.Controls.Add(Me.Left_Arrow)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.Right_Arrow)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Panel2 As Panel
    Friend WithEvents Left_Arrow As Button
    Friend WithEvents Right_Arrow As Button
    Friend WithEvents Panel3 As Panel
    Friend WithEvents HScrollBar1 As HScrollBar
    Friend WithEvents Cart_btn As Button
End Class
