<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Cart
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Cart))
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.cart_prod_panel = New System.Windows.Forms.Panel()
        'Me.prod_cart_added = New System.Windows.Forms.Panel()
        'Me.prodprice_cart = New System.Windows.Forms.Label()
        'Me.prodtotal_cart = New System.Windows.Forms.Label()
        'Me.dollar_cart_total = New System.Windows.Forms.Label()
        'Me.dollar_cart_price = New System.Windows.Forms.Label()
        'Me.prodqty_cart = New System.Windows.Forms.Label()
        'Me.total_lb_cart = New System.Windows.Forms.Label()
        'Me.qty_lb_cart = New System.Windows.Forms.Label()
        'Me.prodname_cart = New System.Windows.Forms.Label()
        'Me.prodpic_cart = New System.Windows.Forms.PictureBox()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.subtotal_lb = New System.Windows.Forms.Label()
        Me.Label22 = New System.Windows.Forms.Label()
        Me.Panel5 = New System.Windows.Forms.Panel()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.checkout_btn = New System.Windows.Forms.Button()
        Me.cvv_tb = New System.Windows.Forms.TextBox()
        Me.cardnumber_tb = New System.Windows.Forms.TextBox()
        Me.nameoncard_tb = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label21 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label20 = New System.Windows.Forms.Label()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.Label19 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Panel4 = New System.Windows.Forms.Panel()
        Me.city_tb = New System.Windows.Forms.TextBox()
        Me.address_tb = New System.Windows.Forms.TextBox()
        Me.fullname_tb = New System.Windows.Forms.TextBox()
        Me.phone_tb = New System.Windows.Forms.TextBox()
        Me.email_tb = New System.Windows.Forms.TextBox()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label18 = New System.Windows.Forms.Label()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.Label17 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        'Me.removeprod_cart = New System.Windows.Forms.Button()
        Me.Panel1.SuspendLayout()
        Me.cart_prod_panel.SuspendLayout()
        'Me.prod_cart_added.SuspendLayout()
        'CType(Me.prodpic_cart, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel2.SuspendLayout()
        Me.Panel5.SuspendLayout()
        Me.Panel4.SuspendLayout()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(246, Byte), Integer), CType(CType(247, Byte), Integer), CType(CType(250, Byte), Integer))
        Me.Panel1.Controls.Add(Me.cart_prod_panel)
        Me.Panel1.Controls.Add(Me.Panel2)
        Me.Panel1.Controls.Add(Me.Panel5)
        Me.Panel1.Controls.Add(Me.Panel4)
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Location = New System.Drawing.Point(12, 12)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(994, 497)
        Me.Panel1.TabIndex = 0
        '
        'cart_prod_panel
        '
        Me.cart_prod_panel.AutoScroll = True
        'Me.cart_prod_panel.Controls.Add(Me.prod_cart_added)
        Me.cart_prod_panel.Location = New System.Drawing.Point(34, 63)
        Me.cart_prod_panel.Name = "cart_prod_panel"
        Me.cart_prod_panel.Size = New System.Drawing.Size(394, 330)
        Me.cart_prod_panel.TabIndex = 5
        ''
        ''prod_cart_added
        ''
        'Me.prod_cart_added.Controls.Add(Me.removeprod_cart)
        'Me.prod_cart_added.Controls.Add(Me.prodprice_cart)
        'Me.prod_cart_added.Controls.Add(Me.prodtotal_cart)
        'Me.prod_cart_added.Controls.Add(Me.dollar_cart_total)
        'Me.prod_cart_added.Controls.Add(Me.dollar_cart_price)
        'Me.prod_cart_added.Controls.Add(Me.prodqty_cart)
        'Me.prod_cart_added.Controls.Add(Me.total_lb_cart)
        'Me.prod_cart_added.Controls.Add(Me.qty_lb_cart)
        'Me.prod_cart_added.Controls.Add(Me.prodname_cart)
        'Me.prod_cart_added.Controls.Add(Me.prodpic_cart)
        'Me.prod_cart_added.Location = New System.Drawing.Point(4, 4)
        'Me.prod_cart_added.Name = "prod_cart_added"
        'Me.prod_cart_added.Size = New System.Drawing.Size(387, 104)
        'Me.prod_cart_added.TabIndex = 0
        ''
        ''prodprice_cart
        ''
        'Me.prodprice_cart.Anchor = System.Windows.Forms.AnchorStyles.None
        'Me.prodprice_cart.AutoSize = True
        'Me.prodprice_cart.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        'Me.prodprice_cart.ForeColor = System.Drawing.Color.FromArgb(CType(CType(161, Byte), Integer), CType(CType(162, Byte), Integer), CType(CType(164, Byte), Integer))
        'Me.prodprice_cart.Location = New System.Drawing.Point(135, 38)
        'Me.prodprice_cart.Name = "prodprice_cart"
        'Me.prodprice_cart.Size = New System.Drawing.Size(53, 19)
        'Me.prodprice_cart.TabIndex = 1
        'Me.prodprice_cart.Text = "125.00"
        'Me.prodprice_cart.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        ''
        ''prodtotal_cart
        ''
        'Me.prodtotal_cart.Anchor = System.Windows.Forms.AnchorStyles.None
        'Me.prodtotal_cart.AutoSize = True
        'Me.prodtotal_cart.BackColor = System.Drawing.Color.Transparent
        'Me.prodtotal_cart.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        'Me.prodtotal_cart.ForeColor = System.Drawing.Color.FromArgb(CType(CType(161, Byte), Integer), CType(CType(162, Byte), Integer), CType(CType(164, Byte), Integer))
        'Me.prodtotal_cart.Location = New System.Drawing.Point(246, 69)
        'Me.prodtotal_cart.Name = "prodtotal_cart"
        'Me.prodtotal_cart.Size = New System.Drawing.Size(77, 19)
        'Me.prodtotal_cart.TabIndex = 1
        'Me.prodtotal_cart.Text = "500000.00"
        'Me.prodtotal_cart.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        ''
        ''dollar_cart_total
        ''
        'Me.dollar_cart_total.AutoSize = True
        'Me.dollar_cart_total.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        'Me.dollar_cart_total.ForeColor = System.Drawing.Color.FromArgb(CType(CType(161, Byte), Integer), CType(CType(162, Byte), Integer), CType(CType(164, Byte), Integer))
        'Me.dollar_cart_total.Location = New System.Drawing.Point(234, 69)
        'Me.dollar_cart_total.Name = "dollar_cart_total"
        'Me.dollar_cart_total.Size = New System.Drawing.Size(17, 19)
        'Me.dollar_cart_total.TabIndex = 1
        'Me.dollar_cart_total.Text = "$"
        'Me.dollar_cart_total.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        ''
        ''dollar_cart_price
        ''
        'Me.dollar_cart_price.AutoSize = True
        'Me.dollar_cart_price.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        'Me.dollar_cart_price.ForeColor = System.Drawing.Color.FromArgb(CType(CType(161, Byte), Integer), CType(CType(162, Byte), Integer), CType(CType(164, Byte), Integer))
        'Me.dollar_cart_price.Location = New System.Drawing.Point(122, 38)
        'Me.dollar_cart_price.Name = "dollar_cart_price"
        'Me.dollar_cart_price.Size = New System.Drawing.Size(17, 19)
        'Me.dollar_cart_price.TabIndex = 1
        'Me.dollar_cart_price.Text = "$"
        'Me.dollar_cart_price.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        ''
        ''prodqty_cart
        ''
        'Me.prodqty_cart.AutoSize = True
        'Me.prodqty_cart.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        'Me.prodqty_cart.ForeColor = System.Drawing.Color.FromArgb(CType(CType(161, Byte), Integer), CType(CType(162, Byte), Integer), CType(CType(164, Byte), Integer))
        'Me.prodqty_cart.Location = New System.Drawing.Point(154, 69)
        'Me.prodqty_cart.Name = "prodqty_cart"
        'Me.prodqty_cart.Size = New System.Drawing.Size(33, 19)
        'Me.prodqty_cart.TabIndex = 1
        'Me.prodqty_cart.Text = "444"
        'Me.prodqty_cart.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        ''
        ''total_lb_cart
        ''
        'Me.total_lb_cart.AutoSize = True
        'Me.total_lb_cart.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        'Me.total_lb_cart.ForeColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(97, Byte), Integer), CType(CType(107, Byte), Integer))
        'Me.total_lb_cart.Location = New System.Drawing.Point(193, 69)
        'Me.total_lb_cart.Name = "total_lb_cart"
        'Me.total_lb_cart.Size = New System.Drawing.Size(45, 19)
        'Me.total_lb_cart.TabIndex = 1
        'Me.total_lb_cart.Text = "Total:"
        ''
        ''qty_lb_cart
        ''
        'Me.qty_lb_cart.AutoSize = True
        'Me.qty_lb_cart.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        'Me.qty_lb_cart.ForeColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(97, Byte), Integer), CType(CType(107, Byte), Integer))
        'Me.qty_lb_cart.Location = New System.Drawing.Point(122, 69)
        'Me.qty_lb_cart.Name = "qty_lb_cart"
        'Me.qty_lb_cart.Size = New System.Drawing.Size(36, 19)
        'Me.qty_lb_cart.TabIndex = 1
        'Me.qty_lb_cart.Text = "Qty:"
        ''
        ''prodname_cart
        ''
        'Me.prodname_cart.AutoSize = True
        'Me.prodname_cart.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        'Me.prodname_cart.ForeColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(97, Byte), Integer), CType(CType(107, Byte), Integer))
        'Me.prodname_cart.Location = New System.Drawing.Point(122, 8)
        'Me.prodname_cart.Name = "prodname_cart"
        'Me.prodname_cart.Size = New System.Drawing.Size(82, 19)
        'Me.prodname_cart.TabIndex = 1
        'Me.prodname_cart.Text = "Face Scuplt"
        ''
        ''prodpic_cart
        ''
        'Me.prodpic_cart.Image = CType(resources.GetObject("prodpic_cart.Image"), System.Drawing.Image)
        'Me.prodpic_cart.Location = New System.Drawing.Point(4, 4)
        'Me.prodpic_cart.Name = "prodpic_cart"
        'Me.prodpic_cart.Size = New System.Drawing.Size(95, 95)
        'Me.prodpic_cart.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        'Me.prodpic_cart.TabIndex = 0
        'Me.prodpic_cart.TabStop = False
        '
        'Panel2
        '
        Me.Panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel2.Controls.Add(Me.subtotal_lb)
        Me.Panel2.Controls.Add(Me.Label22)
        Me.Panel2.Location = New System.Drawing.Point(330, 402)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(98, 72)
        Me.Panel2.TabIndex = 4
        '
        'subtotal_lb
        '
        Me.subtotal_lb.BackColor = System.Drawing.Color.FromArgb(CType(CType(246, Byte), Integer), CType(CType(247, Byte), Integer), CType(CType(250, Byte), Integer))
        Me.subtotal_lb.Font = New System.Drawing.Font("Calibri", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.subtotal_lb.ForeColor = System.Drawing.Color.FromArgb(CType(CType(50, Byte), Integer), CType(CType(56, Byte), Integer), CType(CType(70, Byte), Integer))
        Me.subtotal_lb.Location = New System.Drawing.Point(3, 36)
        Me.subtotal_lb.Name = "subtotal_lb"
        Me.subtotal_lb.Size = New System.Drawing.Size(90, 23)
        Me.subtotal_lb.TabIndex = 1
        Me.subtotal_lb.Text = "$ 458.00"
        Me.subtotal_lb.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label22
        '
        Me.Label22.AutoSize = True
        Me.Label22.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Bold)
        Me.Label22.ForeColor = System.Drawing.Color.FromArgb(CType(CType(179, Byte), Integer), CType(CType(180, Byte), Integer), CType(CType(184, Byte), Integer))
        Me.Label22.Location = New System.Drawing.Point(14, 8)
        Me.Label22.Name = "Label22"
        Me.Label22.Size = New System.Drawing.Size(68, 19)
        Me.Label22.TabIndex = 0
        Me.Label22.Text = "Subtotal"
        '
        'Panel5
        '
        Me.Panel5.BackColor = System.Drawing.Color.FromArgb(CType(CType(38, Byte), Integer), CType(CType(44, Byte), Integer), CType(CType(59, Byte), Integer))
        Me.Panel5.Controls.Add(Me.Label6)
        Me.Panel5.Controls.Add(Me.checkout_btn)
        Me.Panel5.Controls.Add(Me.cvv_tb)
        Me.Panel5.Controls.Add(Me.cardnumber_tb)
        Me.Panel5.Controls.Add(Me.nameoncard_tb)
        Me.Panel5.Controls.Add(Me.Label3)
        Me.Panel5.Controls.Add(Me.Label21)
        Me.Panel5.Controls.Add(Me.Label4)
        Me.Panel5.Controls.Add(Me.Label20)
        Me.Panel5.Controls.Add(Me.Label13)
        Me.Panel5.Controls.Add(Me.Label19)
        Me.Panel5.Controls.Add(Me.Label2)
        Me.Panel5.Controls.Add(Me.Label9)
        Me.Panel5.Location = New System.Drawing.Point(740, 23)
        Me.Panel5.Name = "Panel5"
        Me.Panel5.Size = New System.Drawing.Size(241, 451)
        Me.Panel5.TabIndex = 3
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.BackColor = System.Drawing.Color.Transparent
        Me.Label6.Font = New System.Drawing.Font("Calibri", 14.0!, System.Drawing.FontStyle.Bold)
        Me.Label6.ForeColor = System.Drawing.Color.FromArgb(CType(CType(246, Byte), Integer), CType(CType(247, Byte), Integer), CType(CType(250, Byte), Integer))
        Me.Label6.Location = New System.Drawing.Point(20, 15)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(106, 23)
        Me.Label6.TabIndex = 0
        Me.Label6.Text = "Card Details"
        '
        'checkout_btn
        '
        Me.checkout_btn.BackColor = System.Drawing.Color.FromArgb(CType(CType(77, Byte), Integer), CType(CType(111, Byte), Integer), CType(CType(233, Byte), Integer))
        Me.checkout_btn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.checkout_btn.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.checkout_btn.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.checkout_btn.ForeColor = System.Drawing.Color.FromArgb(CType(CType(233, Byte), Integer), CType(CType(235, Byte), Integer), CType(CType(242, Byte), Integer))
        Me.checkout_btn.Location = New System.Drawing.Point(16, 388)
        Me.checkout_btn.Name = "checkout_btn"
        Me.checkout_btn.Size = New System.Drawing.Size(209, 47)
        Me.checkout_btn.TabIndex = 3
        Me.checkout_btn.Text = "Check Out"
        Me.checkout_btn.UseVisualStyleBackColor = False
        '
        'cvv_tb
        '
        Me.cvv_tb.BackColor = System.Drawing.Color.FromArgb(CType(CType(38, Byte), Integer), CType(CType(44, Byte), Integer), CType(CType(59, Byte), Integer))
        Me.cvv_tb.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.cvv_tb.Font = New System.Drawing.Font("Calibri", 11.0!, System.Drawing.FontStyle.Bold)
        Me.cvv_tb.ForeColor = System.Drawing.Color.FromArgb(CType(CType(233, Byte), Integer), CType(CType(235, Byte), Integer), CType(CType(242, Byte), Integer))
        Me.cvv_tb.Location = New System.Drawing.Point(24, 323)
        Me.cvv_tb.Name = "cvv_tb"
        Me.cvv_tb.Size = New System.Drawing.Size(199, 18)
        Me.cvv_tb.TabIndex = 1
        Me.cvv_tb.Text = "jennifer@norton.com"
        '
        'cardnumber_tb
        '
        Me.cardnumber_tb.BackColor = System.Drawing.Color.FromArgb(CType(CType(38, Byte), Integer), CType(CType(44, Byte), Integer), CType(CType(59, Byte), Integer))
        Me.cardnumber_tb.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.cardnumber_tb.Font = New System.Drawing.Font("Calibri", 11.0!, System.Drawing.FontStyle.Bold)
        Me.cardnumber_tb.ForeColor = System.Drawing.Color.FromArgb(CType(CType(233, Byte), Integer), CType(CType(235, Byte), Integer), CType(CType(242, Byte), Integer))
        Me.cardnumber_tb.Location = New System.Drawing.Point(24, 176)
        Me.cardnumber_tb.Name = "cardnumber_tb"
        Me.cardnumber_tb.Size = New System.Drawing.Size(199, 18)
        Me.cardnumber_tb.TabIndex = 1
        Me.cardnumber_tb.Text = "jennifer@norton.com"
        '
        'nameoncard_tb
        '
        Me.nameoncard_tb.BackColor = System.Drawing.Color.FromArgb(CType(CType(38, Byte), Integer), CType(CType(44, Byte), Integer), CType(CType(59, Byte), Integer))
        Me.nameoncard_tb.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.nameoncard_tb.Font = New System.Drawing.Font("Calibri", 11.0!, System.Drawing.FontStyle.Bold)
        Me.nameoncard_tb.ForeColor = System.Drawing.Color.FromArgb(CType(CType(233, Byte), Integer), CType(CType(235, Byte), Integer), CType(CType(242, Byte), Integer))
        Me.nameoncard_tb.Location = New System.Drawing.Point(24, 102)
        Me.nameoncard_tb.Name = "nameoncard_tb"
        Me.nameoncard_tb.Size = New System.Drawing.Size(199, 18)
        Me.nameoncard_tb.TabIndex = 1
        Me.nameoncard_tb.Text = "jennifer@norton.com"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.Font = New System.Drawing.Font("Calibri", 9.0!)
        Me.Label3.ForeColor = System.Drawing.Color.FromArgb(CType(CType(246, Byte), Integer), CType(CType(247, Byte), Integer), CType(CType(250, Byte), Integer))
        Me.Label3.Location = New System.Drawing.Point(21, 155)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(120, 14)
        Me.Label3.TabIndex = 0
        Me.Label3.Text = "16-digit Card number"
        '
        'Label21
        '
        Me.Label21.AutoSize = True
        Me.Label21.BackColor = System.Drawing.Color.Transparent
        Me.Label21.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Label21.ForeColor = System.Drawing.Color.FromArgb(CType(CType(233, Byte), Integer), CType(CType(235, Byte), Integer), CType(CType(242, Byte), Integer))
        Me.Label21.Location = New System.Drawing.Point(21, 336)
        Me.Label21.Name = "Label21"
        Me.Label21.Size = New System.Drawing.Size(193, 13)
        Me.Label21.TabIndex = 2
        Me.Label21.Text = "_______________________________"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.BackColor = System.Drawing.Color.Transparent
        Me.Label4.Font = New System.Drawing.Font("Calibri", 9.0!)
        Me.Label4.ForeColor = System.Drawing.Color.FromArgb(CType(CType(246, Byte), Integer), CType(CType(247, Byte), Integer), CType(CType(250, Byte), Integer))
        Me.Label4.Location = New System.Drawing.Point(21, 230)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(89, 14)
        Me.Label4.TabIndex = 0
        Me.Label4.Text = "Expiration date"
        '
        'Label20
        '
        Me.Label20.AutoSize = True
        Me.Label20.BackColor = System.Drawing.Color.Transparent
        Me.Label20.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Label20.ForeColor = System.Drawing.Color.FromArgb(CType(CType(233, Byte), Integer), CType(CType(235, Byte), Integer), CType(CType(242, Byte), Integer))
        Me.Label20.Location = New System.Drawing.Point(21, 264)
        Me.Label20.Name = "Label20"
        Me.Label20.Size = New System.Drawing.Size(193, 13)
        Me.Label20.TabIndex = 2
        Me.Label20.Text = "_______________________________"
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.BackColor = System.Drawing.Color.Transparent
        Me.Label13.Font = New System.Drawing.Font("Calibri", 9.0!)
        Me.Label13.ForeColor = System.Drawing.Color.FromArgb(CType(CType(246, Byte), Integer), CType(CType(247, Byte), Integer), CType(CType(250, Byte), Integer))
        Me.Label13.Location = New System.Drawing.Point(21, 81)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(82, 14)
        Me.Label13.TabIndex = 0
        Me.Label13.Text = "Name on card"
        '
        'Label19
        '
        Me.Label19.AutoSize = True
        Me.Label19.BackColor = System.Drawing.Color.Transparent
        Me.Label19.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Label19.ForeColor = System.Drawing.Color.FromArgb(CType(CType(233, Byte), Integer), CType(CType(235, Byte), Integer), CType(CType(242, Byte), Integer))
        Me.Label19.Location = New System.Drawing.Point(21, 189)
        Me.Label19.Name = "Label19"
        Me.Label19.Size = New System.Drawing.Size(193, 13)
        Me.Label19.TabIndex = 2
        Me.Label19.Text = "_______________________________"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Font = New System.Drawing.Font("Calibri", 9.0!)
        Me.Label2.ForeColor = System.Drawing.Color.FromArgb(CType(CType(246, Byte), Integer), CType(CType(247, Byte), Integer), CType(CType(250, Byte), Integer))
        Me.Label2.Location = New System.Drawing.Point(21, 302)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(27, 14)
        Me.Label2.TabIndex = 0
        Me.Label2.Text = "CVV"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.BackColor = System.Drawing.Color.Transparent
        Me.Label9.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Label9.ForeColor = System.Drawing.Color.FromArgb(CType(CType(233, Byte), Integer), CType(CType(235, Byte), Integer), CType(CType(242, Byte), Integer))
        Me.Label9.Location = New System.Drawing.Point(21, 115)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(193, 13)
        Me.Label9.TabIndex = 2
        Me.Label9.Text = "_______________________________"
        '
        'Panel4
        '
        Me.Panel4.BackColor = System.Drawing.Color.FromArgb(CType(CType(38, Byte), Integer), CType(CType(44, Byte), Integer), CType(CType(59, Byte), Integer))
        Me.Panel4.Controls.Add(Me.city_tb)
        Me.Panel4.Controls.Add(Me.address_tb)
        Me.Panel4.Controls.Add(Me.fullname_tb)
        Me.Panel4.Controls.Add(Me.phone_tb)
        Me.Panel4.Controls.Add(Me.email_tb)
        Me.Panel4.Controls.Add(Me.Label11)
        Me.Panel4.Controls.Add(Me.Label10)
        Me.Panel4.Controls.Add(Me.Label18)
        Me.Panel4.Controls.Add(Me.Label12)
        Me.Panel4.Controls.Add(Me.Label17)
        Me.Panel4.Controls.Add(Me.Label8)
        Me.Panel4.Controls.Add(Me.Label16)
        Me.Panel4.Controls.Add(Me.Label7)
        Me.Panel4.Controls.Add(Me.Label15)
        Me.Panel4.Controls.Add(Me.Label5)
        Me.Panel4.Controls.Add(Me.Label14)
        Me.Panel4.Location = New System.Drawing.Point(477, 23)
        Me.Panel4.Name = "Panel4"
        Me.Panel4.Size = New System.Drawing.Size(241, 451)
        Me.Panel4.TabIndex = 3
        '
        'city_tb
        '
        Me.city_tb.BackColor = System.Drawing.Color.FromArgb(CType(CType(38, Byte), Integer), CType(CType(44, Byte), Integer), CType(CType(59, Byte), Integer))
        Me.city_tb.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.city_tb.Font = New System.Drawing.Font("Calibri", 11.0!, System.Drawing.FontStyle.Bold)
        Me.city_tb.ForeColor = System.Drawing.Color.FromArgb(CType(CType(233, Byte), Integer), CType(CType(235, Byte), Integer), CType(CType(242, Byte), Integer))
        Me.city_tb.Location = New System.Drawing.Point(24, 385)
        Me.city_tb.Name = "city_tb"
        Me.city_tb.Size = New System.Drawing.Size(199, 18)
        Me.city_tb.TabIndex = 1
        Me.city_tb.Text = "jennifer@norton.com"
        '
        'address_tb
        '
        Me.address_tb.BackColor = System.Drawing.Color.FromArgb(CType(CType(38, Byte), Integer), CType(CType(44, Byte), Integer), CType(CType(59, Byte), Integer))
        Me.address_tb.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.address_tb.Font = New System.Drawing.Font("Calibri", 11.0!, System.Drawing.FontStyle.Bold)
        Me.address_tb.ForeColor = System.Drawing.Color.FromArgb(CType(CType(233, Byte), Integer), CType(CType(235, Byte), Integer), CType(CType(242, Byte), Integer))
        Me.address_tb.Location = New System.Drawing.Point(24, 323)
        Me.address_tb.Name = "address_tb"
        Me.address_tb.Size = New System.Drawing.Size(199, 18)
        Me.address_tb.TabIndex = 1
        Me.address_tb.Text = "jennifer@norton.com"
        '
        'fullname_tb
        '
        Me.fullname_tb.BackColor = System.Drawing.Color.FromArgb(CType(CType(38, Byte), Integer), CType(CType(44, Byte), Integer), CType(CType(59, Byte), Integer))
        Me.fullname_tb.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.fullname_tb.Font = New System.Drawing.Font("Calibri", 11.0!, System.Drawing.FontStyle.Bold)
        Me.fullname_tb.ForeColor = System.Drawing.Color.FromArgb(CType(CType(233, Byte), Integer), CType(CType(235, Byte), Integer), CType(CType(242, Byte), Integer))
        Me.fullname_tb.Location = New System.Drawing.Point(24, 102)
        Me.fullname_tb.Name = "fullname_tb"
        Me.fullname_tb.Size = New System.Drawing.Size(199, 18)
        Me.fullname_tb.TabIndex = 1
        Me.fullname_tb.Text = "jennifer@norton.com"
        '
        'phone_tb
        '
        Me.phone_tb.BackColor = System.Drawing.Color.FromArgb(CType(CType(38, Byte), Integer), CType(CType(44, Byte), Integer), CType(CType(59, Byte), Integer))
        Me.phone_tb.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.phone_tb.Font = New System.Drawing.Font("Calibri", 11.0!, System.Drawing.FontStyle.Bold)
        Me.phone_tb.ForeColor = System.Drawing.Color.FromArgb(CType(CType(233, Byte), Integer), CType(CType(235, Byte), Integer), CType(CType(242, Byte), Integer))
        Me.phone_tb.Location = New System.Drawing.Point(22, 176)
        Me.phone_tb.Name = "phone_tb"
        Me.phone_tb.Size = New System.Drawing.Size(199, 18)
        Me.phone_tb.TabIndex = 1
        Me.phone_tb.Text = "jennifer@norton.com"
        '
        'email_tb
        '
        Me.email_tb.BackColor = System.Drawing.Color.FromArgb(CType(CType(38, Byte), Integer), CType(CType(44, Byte), Integer), CType(CType(59, Byte), Integer))
        Me.email_tb.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.email_tb.Font = New System.Drawing.Font("Calibri", 11.0!, System.Drawing.FontStyle.Bold)
        Me.email_tb.ForeColor = System.Drawing.Color.FromArgb(CType(CType(233, Byte), Integer), CType(CType(235, Byte), Integer), CType(CType(242, Byte), Integer))
        Me.email_tb.Location = New System.Drawing.Point(22, 251)
        Me.email_tb.Name = "email_tb"
        Me.email_tb.Size = New System.Drawing.Size(199, 18)
        Me.email_tb.TabIndex = 1
        Me.email_tb.Text = "jennifer@norton.com"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.BackColor = System.Drawing.Color.Transparent
        Me.Label11.Font = New System.Drawing.Font("Calibri", 9.0!)
        Me.Label11.ForeColor = System.Drawing.Color.FromArgb(CType(CType(246, Byte), Integer), CType(CType(247, Byte), Integer), CType(CType(250, Byte), Integer))
        Me.Label11.Location = New System.Drawing.Point(21, 302)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(51, 14)
        Me.Label11.TabIndex = 0
        Me.Label11.Text = "Address"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.BackColor = System.Drawing.Color.Transparent
        Me.Label10.Font = New System.Drawing.Font("Calibri", 9.0!)
        Me.Label10.ForeColor = System.Drawing.Color.FromArgb(CType(CType(246, Byte), Integer), CType(CType(247, Byte), Integer), CType(CType(250, Byte), Integer))
        Me.Label10.Location = New System.Drawing.Point(21, 364)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(26, 14)
        Me.Label10.TabIndex = 0
        Me.Label10.Text = "City"
        '
        'Label18
        '
        Me.Label18.AutoSize = True
        Me.Label18.BackColor = System.Drawing.Color.Transparent
        Me.Label18.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Label18.ForeColor = System.Drawing.Color.FromArgb(CType(CType(233, Byte), Integer), CType(CType(235, Byte), Integer), CType(CType(242, Byte), Integer))
        Me.Label18.Location = New System.Drawing.Point(21, 398)
        Me.Label18.Name = "Label18"
        Me.Label18.Size = New System.Drawing.Size(193, 13)
        Me.Label18.TabIndex = 2
        Me.Label18.Text = "_______________________________"
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.BackColor = System.Drawing.Color.Transparent
        Me.Label12.Font = New System.Drawing.Font("Calibri", 9.0!)
        Me.Label12.ForeColor = System.Drawing.Color.FromArgb(CType(CType(246, Byte), Integer), CType(CType(247, Byte), Integer), CType(CType(250, Byte), Integer))
        Me.Label12.Location = New System.Drawing.Point(21, 230)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(85, 14)
        Me.Label12.TabIndex = 0
        Me.Label12.Text = "Email address"
        '
        'Label17
        '
        Me.Label17.AutoSize = True
        Me.Label17.BackColor = System.Drawing.Color.Transparent
        Me.Label17.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Label17.ForeColor = System.Drawing.Color.FromArgb(CType(CType(233, Byte), Integer), CType(CType(235, Byte), Integer), CType(CType(242, Byte), Integer))
        Me.Label17.Location = New System.Drawing.Point(21, 336)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(193, 13)
        Me.Label17.TabIndex = 2
        Me.Label17.Text = "_______________________________"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.BackColor = System.Drawing.Color.Transparent
        Me.Label8.Font = New System.Drawing.Font("Calibri", 9.0!)
        Me.Label8.ForeColor = System.Drawing.Color.FromArgb(CType(CType(246, Byte), Integer), CType(CType(247, Byte), Integer), CType(CType(250, Byte), Integer))
        Me.Label8.Location = New System.Drawing.Point(21, 155)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(86, 14)
        Me.Label8.TabIndex = 0
        Me.Label8.Text = "Phone number"
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.BackColor = System.Drawing.Color.Transparent
        Me.Label16.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Label16.ForeColor = System.Drawing.Color.FromArgb(CType(CType(233, Byte), Integer), CType(CType(235, Byte), Integer), CType(CType(242, Byte), Integer))
        Me.Label16.Location = New System.Drawing.Point(21, 115)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(193, 13)
        Me.Label16.TabIndex = 2
        Me.Label16.Text = "_______________________________"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.BackColor = System.Drawing.Color.Transparent
        Me.Label7.Font = New System.Drawing.Font("Calibri", 9.0!)
        Me.Label7.ForeColor = System.Drawing.Color.FromArgb(CType(CType(246, Byte), Integer), CType(CType(247, Byte), Integer), CType(CType(250, Byte), Integer))
        Me.Label7.Location = New System.Drawing.Point(21, 81)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(62, 14)
        Me.Label7.TabIndex = 0
        Me.Label7.Text = "Full name"
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.BackColor = System.Drawing.Color.Transparent
        Me.Label15.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Label15.ForeColor = System.Drawing.Color.FromArgb(CType(CType(233, Byte), Integer), CType(CType(235, Byte), Integer), CType(CType(242, Byte), Integer))
        Me.Label15.Location = New System.Drawing.Point(19, 189)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(193, 13)
        Me.Label15.TabIndex = 2
        Me.Label15.Text = "_______________________________"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.BackColor = System.Drawing.Color.Transparent
        Me.Label5.Font = New System.Drawing.Font("Calibri", 14.0!, System.Drawing.FontStyle.Bold)
        Me.Label5.ForeColor = System.Drawing.Color.FromArgb(CType(CType(246, Byte), Integer), CType(CType(247, Byte), Integer), CType(CType(250, Byte), Integer))
        Me.Label5.Location = New System.Drawing.Point(20, 15)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(135, 23)
        Me.Label5.TabIndex = 0
        Me.Label5.Text = "Address Details"
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.BackColor = System.Drawing.Color.Transparent
        Me.Label14.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Label14.ForeColor = System.Drawing.Color.FromArgb(CType(CType(233, Byte), Integer), CType(CType(235, Byte), Integer), CType(CType(242, Byte), Integer))
        Me.Label14.Location = New System.Drawing.Point(19, 264)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(193, 13)
        Me.Label14.TabIndex = 2
        Me.Label14.Text = "_______________________________"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Calibri", 20.0!, System.Drawing.FontStyle.Bold)
        Me.Label1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(38, Byte), Integer), CType(CType(44, Byte), Integer), CType(CType(59, Byte), Integer))
        Me.Label1.Location = New System.Drawing.Point(31, 23)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(197, 33)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "SHOPPING CART"
        ''
        ''removeprod_cart
        ''
        'Me.removeprod_cart.BackColor = System.Drawing.Color.Transparent
        'Me.removeprod_cart.BackgroundImage = CType(resources.GetObject("removeprod_cart.BackgroundImage"), System.Drawing.Image)
        'Me.removeprod_cart.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        'Me.removeprod_cart.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        'Me.removeprod_cart.Location = New System.Drawing.Point(349, 37)
        'Me.removeprod_cart.Name = "removeprod_cart"
        'Me.removeprod_cart.Size = New System.Drawing.Size(25, 26)
        'Me.removeprod_cart.TabIndex = 2
        'Me.removeprod_cart.UseVisualStyleBackColor = False
        '
        'Cart
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ButtonShadow
        Me.ClientSize = New System.Drawing.Size(1018, 521)
        Me.Controls.Add(Me.Panel1)
        Me.Name = "Cart"
        Me.Text = "Cart"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.cart_prod_panel.ResumeLayout(False)
        'Me.prod_cart_added.ResumeLayout(False)
        'Me.prod_cart_added.PerformLayout()
        'CType(Me.prodpic_cart, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        Me.Panel5.ResumeLayout(False)
        Me.Panel5.PerformLayout()
        Me.Panel4.ResumeLayout(False)
        Me.Panel4.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents Panel5 As Panel
    Friend WithEvents Panel4 As Panel
    Friend WithEvents Label6 As Label
    Friend WithEvents checkout_btn As Button
    Friend WithEvents Label11 As Label
    Friend WithEvents Label10 As Label
    Friend WithEvents Label12 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label13 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents email_tb As TextBox
    Friend WithEvents Label14 As Label
    Friend WithEvents cart_prod_panel As Panel
    Friend WithEvents Panel2 As Panel
    Friend WithEvents subtotal_lb As Label
    Friend WithEvents Label22 As Label
    Friend WithEvents cvv_tb As TextBox
    Friend WithEvents cardnumber_tb As TextBox
    Friend WithEvents nameoncard_tb As TextBox
    Friend WithEvents Label21 As Label
    Friend WithEvents Label20 As Label
    Friend WithEvents Label19 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents city_tb As TextBox
    Friend WithEvents address_tb As TextBox
    Friend WithEvents fullname_tb As TextBox
    Friend WithEvents phone_tb As TextBox
    Friend WithEvents Label18 As Label
    Friend WithEvents Label17 As Label
    Friend WithEvents Label16 As Label
    Friend WithEvents Label15 As Label
    ''Friend WithEvents prod_cart_added As Panel
    ''Friend WithEvents prodprice_cart As Label
    ''Friend WithEvents prodtotal_cart As Label
    ''Friend WithEvents dollar_cart_total As Label
    ''Friend WithEvents dollar_cart_price As Label
    ''Friend WithEvents prodqty_cart As Label
    ''Friend WithEvents total_lb_cart As Label
    ''Friend WithEvents qty_lb_cart As Label
    ''Friend WithEvents prodname_cart As Label
    ''Friend WithEvents prodpic_cart As PictureBox
    'Friend WithEvents removeprod_cart As Button
End Class
