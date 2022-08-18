Option Strict Off
Imports System.Data
Imports System.Data.SqlClient
Imports System.IO
Imports System.Windows.Forms
Public Class Form1
    Dim x As Integer
    Dim range As Integer
    Dim btnstest As New List(Of Button)
    Dim nmstest As New List(Of NumericUpDown)
    Dim paneltest As New List(Of Panel)

    Dim Prd_Panel As New Panel
    Dim PQl2 As New Label
    Dim NumericUpDown1 As New NumericUpDown
    Dim PDl As New Label
    Dim Addbtn As New Button
    Dim PDT As New RichTextBox
    Dim PQl As New Label
    Dim PQld As New Label
    Dim PPlD As New Label
    Dim PPl As New Label
    Dim PPb As New PictureBox
    Dim Pname As New Label
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Panel3.HorizontalScroll.Enabled = True
        Panel3.AutoScroll = True
        Panel3.HorizontalScroll.Minimum = 0

        Using db As New db_numabunEntities

            Dim P = (From C In db.Categories Join D In db.Pictures On C.PictureId Equals D.Id
                     Join F In db.PictureBinaries On D.Id Equals F.PictureId
                     Where C.Deleted = False Select F.BinaryData, C.Name).ToList
            Dim x = 40
            Dim Flag = 0

            For i As Integer = 0 To P.Count - 1
                Dim btn As New Button


                Dim mStream As New MemoryStream(P(i).BinaryData)
                '
                'Button4
                '
                btn.BackColor = System.Drawing.Color.White
                btn.Location = New System.Drawing.Point(x, 5)
                btn.Name = "Button" & i
                btn.Size = New System.Drawing.Size(165, 144)
                btn.TabIndex = 2
                btn.Text = P(i).Name
                btn.TextAlign = ContentAlignment.BottomCenter
                btn.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
                btn.BackgroundImage = Image.FromStream(mStream)
                btn.BackgroundImageLayout = ImageLayout.Zoom
                btn.UseVisualStyleBackColor = True
                Panel3.Controls.Add(btn)
                x += 200
                AddHandler btn.Click, AddressOf Me.Button_Click
            Next
            range = Panel3.Size.Width
        End Using

    End Sub


    Private Sub Button_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Panel2.Controls.Clear()

        Using db As New db_numabunEntities
            Dim b As Button = DirectCast(sender, Button)
            Dim Prdct = (From Prd In db.Products Join Pcm In db.Product_Category_Mapping On Prd.Id Equals Pcm.ProductId
                         Join cat In db.Categories On cat.Id Equals Pcm.CategoryId
                         Join Ppm In db.Product_Picture_Mapping On Prd.Id Equals Ppm.ProductId
                         Join pb In db.PictureBinaries On Ppm.PictureId Equals pb.PictureId
                         Where b.Text = cat.Name
                         Select Prd.Id, Prd.Name, Prd.ShortDescription, Prd.Price, Pcm.CategoryId,
                                Cname = cat.Name, Ppm.PictureId, pb.BinaryData).ToList

            Dim xcard = 11
            Dim ycard = 8
            Dim Flag = 0

            btnstest = New List(Of Button)
            nmstest = New List(Of NumericUpDown)
            paneltest = New List(Of Panel)



            For i As Integer = 0 To Prdct.Count - 1

                Prd_Panel = New Panel
                PQl2 = New Label
                NumericUpDown1 = New NumericUpDown
                PDl = New Label
                Addbtn = New Button
                PDT = New RichTextBox
                PQl = New Label
                PQld = New Label
                PPlD = New Label
                PPl = New Label
                PPb = New PictureBox
                Pname = New Label
                Dim mStream As New MemoryStream(Prdct(i).BinaryData)

                'Prd_Panel
                Prd_Panel.BackColor = System.Drawing.Color.White
                Prd_Panel.Location = New System.Drawing.Point(xcard, ycard)
                Prd_Panel.Name = "Prd_Panel" + i.ToString
                Prd_Panel.Size = New System.Drawing.Size(250, 305)
                Prd_Panel.TabIndex = 0

                'PQl2
                PQl2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
                PQl2.Location = New System.Drawing.Point(27, 263)
                PQl2.Name = "PQl2"
                PQl2.Size = New System.Drawing.Size(58, 13)
                PQl2.Text = "Quantity:"

                'NumericUpDown1
                NumericUpDown1.Location = New System.Drawing.Point(93, 261)
                NumericUpDown1.Name = b.Text + i.ToString
                NumericUpDown1.Size = New System.Drawing.Size(55, 20)

                'PDl
                PDl.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
                PDl.Location = New System.Drawing.Point(24, 148)
                PDl.Name = "PDl"
                PDl.Size = New System.Drawing.Size(75, 13)
                PDl.TabIndex = 6
                PDl.Text = "Description:"
                'Addbtn
                Addbtn.BackColor = System.Drawing.Color.SandyBrown
                Addbtn.Location = New System.Drawing.Point(160, 255)
                Addbtn.Name = b.Text + i.ToString
                Addbtn.Size = New System.Drawing.Size(60, 33)
                Addbtn.Text = "Add to Cart"
                AddHandler Addbtn.Click, AddressOf Add_Button_Click

                'PDT
                PDT.CausesValidation = False
                PDT.Location = New System.Drawing.Point(27, 169)
                PDT.Name = "PDT" + i.ToString
                PDT.ReadOnly = True
                PDT.Size = New System.Drawing.Size(199, 75)
                PDT.Text = Prdct(i).ShortDescription
                'PQl
                PQl.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
                PQl.Location = New System.Drawing.Point(168, 96)
                PQl.Name = "PQl"
                PQl.Size = New System.Drawing.Size(58, 13)
                PQl.Text = "Quantity:"
                'PQlD
                '
                PQld.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
                PQld.Location = New System.Drawing.Point(168, 110)
                PQld.Name = "PQlD" + i.ToString
                PQld.Size = New System.Drawing.Size(58, 13)
                PQld.Text = NumericUpDown1.Value.ToString
                'PPl
                PPl.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
                PPl.Location = New System.Drawing.Point(168, 40)
                PPl.Name = "PPl"
                PPl.Size = New System.Drawing.Size(40, 13)
                PPl.Text = "Price:"
                'PPlD
                PPlD.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
                PPlD.Location = New System.Drawing.Point(168, 60)
                PPlD.Name = "PPlD" + i.ToString
                PPlD.Size = New System.Drawing.Size(40, 13)
                PPlD.Text = Prdct(i).Price
                'PPb
                PPb.BackColor = System.Drawing.SystemColors.ButtonHighlight
                PPb.Location = New System.Drawing.Point(27, 35)
                PPb.Name = "PPb" + i.ToString
                PPb.BackgroundImage = Image.FromStream(mStream)
                PPb.BackgroundImageLayout = ImageLayout.Zoom
                PPb.Size = New System.Drawing.Size(132, 100)
                'Pname
                Pname.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
                Pname.Location = New System.Drawing.Point(0, 5)
                Pname.Name = "Pname" + i.ToString
                Pname.Size = New System.Drawing.Size(Prd_Panel.Width, 30)
                Pname.AutoSize = False
                Pname.Anchor = AnchorStyles.Left
                Pname.Anchor = AnchorStyles.Right
                Dim name As String = Prdct(i).Name
                If Prdct(i).Name.Length >= Prd_Panel.Width / 10 Then
                    Dim leng = name.Length / 2
                    name = name.Insert(leng, vbNewLine)
                End If
                Pname.Text = name
                Pname.TextAlign = ContentAlignment.MiddleCenter


                If (Flag < 2) Then
                    Flag += 1
                    xcard += 270
                    ycard += 0
                Else
                    Panel2.AutoScroll = True
                    Flag = 0
                    xcard = 11
                    ycard += 323
                End If
                Panel2.Controls.Add(Prd_Panel)
                Prd_Panel.Controls.Add(PQl2)
                Prd_Panel.Controls.Add(NumericUpDown1)
                Prd_Panel.Controls.Add(PDl)
                Prd_Panel.Controls.Add(Addbtn)
                Prd_Panel.Controls.Add(PDT)
                Prd_Panel.Controls.Add(PQl)
                Prd_Panel.Controls.Add(PQld)
                Prd_Panel.Controls.Add(PPl)
                Prd_Panel.Controls.Add(PPlD)
                Prd_Panel.Controls.Add(PPb)
                Prd_Panel.Controls.Add(Pname)
                nmstest.Add(NumericUpDown1)
                btnstest.Add(Addbtn)
                paneltest.Add(Prd_Panel)


            Next

        End Using
    End Sub
    '
    '
    '
    Dim Prod As New List(Of String)

    Private Sub Add_Button_Click(ByVal sender As Object, e As EventArgs)
        Dim senderbtn As String = sender.Name.ToString
        Dim respectivenumeric As NumericUpDown
        Dim pnl As New Panel

        For Each p In paneltest
            If p.Controls.Contains(New Button) Then

            End If
        Next

        For Each num In nmstest
            If num.Name = senderbtn Then
                respectivenumeric = num
            End If
        Next


    End Sub
    '
    '
    '
    Private Sub Right_Arrow_Click(sender As Object, e As EventArgs) Handles Right_Arrow.Click
        Try
            Me.Panel3.AutoScrollPosition = New Point(x, 0)
            If x < range - 100 Then
                x += 100
            Else
                x += 0
            End If
        Catch er As System.ArgumentOutOfRangeException
        End Try
    End Sub
    '
    'LEFT ARROW
    '
    Private Sub Left_Arrow_Click(sender As Object, e As EventArgs) Handles Left_Arrow.Click
        Try
            Me.Panel3.AutoScrollPosition = New Point(x, 0)
            If Me.Panel3.AutoScrollPosition = New Point(0, 0) Then
                x -= 0
            Else
                x -= 100
            End If
        Catch er As System.ArgumentOutOfRangeException
        End Try
    End Sub

    Private Sub Cart_btn_Click(sender As Object, e As EventArgs) Handles Cart_btn.Click

        If Me.Prod.Count > 0 Then
            Using db As New db_numabunEntities

                'Dim Prdct = (From Prd In db.Products Join Pcm In db.Product_Category_Mapping On Prd.Id Equals Pcm.ProductId
                '             Join cat In db.Categories On cat.Id Equals Pcm.CategoryId
                '             Join Ppm In db.Product_Picture_Mapping On Prd.Id Equals Ppm.ProductId
                '             Join pb In db.PictureBinaries On Ppm.PictureId Equals pb.PictureId
                '             Where Prod.Item = cat.Name
                '             Select Prd.Id, Prd.Name, Prd.ShortDescription, Prd.Price, Pcm.CategoryId,
                '                Cname = cat.Name, Ppm.PictureId, pb.BinaryData).ToList


                For i As Integer = 0 To Prod.Count - 1
                    Dim incartProduct = (From a In db.Products Where Prod(i) = a.Name
                                         Select a.Name, a.Price, a.ProductCost, a.StockQuantity).ToList()




                    MessageBox.Show("Working Bro")

                    Dim cart_prod_panel As New System.Windows.Forms.Panel()
                    Dim prod_cart_added As New System.Windows.Forms.Panel()
                    Dim prodprice_cart As New System.Windows.Forms.Label()
                    Dim prodtotal_cart As New System.Windows.Forms.Label()
                    Dim dollar_cart_total As New System.Windows.Forms.Label()
                    Dim dollar_cart_price As New System.Windows.Forms.Label()
                    Dim prodqty_cart As New System.Windows.Forms.Label()
                    Dim total_lb_cart As New System.Windows.Forms.Label()
                    Dim qty_lb_cart As New System.Windows.Forms.Label()
                    Dim prodname_cart As New System.Windows.Forms.Label()
                    Dim prodpic_cart As New System.Windows.Forms.PictureBox()
                    Dim removeprod_cart As New System.Windows.Forms.Button()
                    '
                    'cart_prod_panel
                    '
                    cart_prod_panel.AutoScroll = True
                    cart_prod_panel.Location = New System.Drawing.Point(34, 63)
                    cart_prod_panel.Name = "cart_prod_panel"
                    cart_prod_panel.Size = New System.Drawing.Size(394, 330)
                    cart_prod_panel.TabIndex = 5
                    '
                    'prod_cart_added
                    '
                    prod_cart_added.Location = New System.Drawing.Point(4, 4)
                    prod_cart_added.Name = "prod_cart_added"
                    prod_cart_added.Size = New System.Drawing.Size(387, 104)
                    prod_cart_added.TabIndex = 0
                    '
                    'prodprice_cart
                    '
                    prodprice_cart.Anchor = System.Windows.Forms.AnchorStyles.None
                    prodprice_cart.AutoSize = True
                    prodprice_cart.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
                    prodprice_cart.ForeColor = System.Drawing.Color.FromArgb(CType(CType(161, Byte), Integer), CType(CType(162, Byte), Integer), CType(CType(164, Byte), Integer))
                    prodprice_cart.Location = New System.Drawing.Point(135, 38)
                    prodprice_cart.Name = "prodprice_cart"
                    prodprice_cart.Size = New System.Drawing.Size(53, 19)
                    prodprice_cart.TabIndex = 1
                    prodprice_cart.Text = incartProduct(i).Price
                    prodprice_cart.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
                    '
                    'prodtotal_cart
                    '
                    prodtotal_cart.Anchor = System.Windows.Forms.AnchorStyles.None
                    prodtotal_cart.AutoSize = True
                    prodtotal_cart.BackColor = System.Drawing.Color.Transparent
                    prodtotal_cart.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
                    prodtotal_cart.ForeColor = System.Drawing.Color.FromArgb(CType(CType(161, Byte), Integer), CType(CType(162, Byte), Integer), CType(CType(164, Byte), Integer))
                    prodtotal_cart.Location = New System.Drawing.Point(246, 69)
                    prodtotal_cart.Name = "prodtotal_cart"
                    prodtotal_cart.Size = New System.Drawing.Size(77, 19)
                    prodtotal_cart.TabIndex = 1
                    prodtotal_cart.Text = ""
                    prodtotal_cart.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
                    '
                    'dollar_cart_total
                    '
                    dollar_cart_total.AutoSize = True
                    dollar_cart_total.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
                    dollar_cart_total.ForeColor = System.Drawing.Color.FromArgb(CType(CType(161, Byte), Integer), CType(CType(162, Byte), Integer), CType(CType(164, Byte), Integer))
                    dollar_cart_total.Location = New System.Drawing.Point(234, 69)
                    dollar_cart_total.Name = "dollar_cart_total"
                    dollar_cart_total.Size = New System.Drawing.Size(17, 19)
                    dollar_cart_total.TabIndex = 1
                    dollar_cart_total.Text = "$"
                    dollar_cart_total.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
                    '
                    'dollar_cart_price
                    '
                    dollar_cart_price.AutoSize = True
                    dollar_cart_price.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
                    dollar_cart_price.ForeColor = System.Drawing.Color.FromArgb(CType(CType(161, Byte), Integer), CType(CType(162, Byte), Integer), CType(CType(164, Byte), Integer))
                    dollar_cart_price.Location = New System.Drawing.Point(122, 38)
                    dollar_cart_price.Name = "dollar_cart_price"
                    dollar_cart_price.Size = New System.Drawing.Size(17, 19)
                    dollar_cart_price.TabIndex = 1
                    dollar_cart_price.Text = "$"
                    dollar_cart_price.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
                    '
                    'prodqty_cart
                    '
                    prodqty_cart.AutoSize = True
                    prodqty_cart.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
                    prodqty_cart.ForeColor = System.Drawing.Color.FromArgb(CType(CType(161, Byte), Integer), CType(CType(162, Byte), Integer), CType(CType(164, Byte), Integer))
                    prodqty_cart.Location = New System.Drawing.Point(154, 69)
                    prodqty_cart.Name = "prodqty_cart"
                    prodqty_cart.Size = New System.Drawing.Size(33, 19)
                    prodqty_cart.TabIndex = 1
                    prodqty_cart.Text = "444"
                    prodqty_cart.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
                    '
                    'total_lb_cart
                    '
                    total_lb_cart.AutoSize = True
                    total_lb_cart.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
                    total_lb_cart.ForeColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(97, Byte), Integer), CType(CType(107, Byte), Integer))
                    total_lb_cart.Location = New System.Drawing.Point(193, 69)
                    total_lb_cart.Name = "total_lb_cart"
                    total_lb_cart.Size = New System.Drawing.Size(45, 19)
                    total_lb_cart.TabIndex = 1
                    total_lb_cart.Text = "Total:"
                    '
                    'qty_lb_cart
                    '
                    qty_lb_cart.AutoSize = True
                    qty_lb_cart.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
                    qty_lb_cart.ForeColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(97, Byte), Integer), CType(CType(107, Byte), Integer))
                    qty_lb_cart.Location = New System.Drawing.Point(122, 69)
                    qty_lb_cart.Name = "qty_lb_cart"
                    qty_lb_cart.Size = New System.Drawing.Size(36, 19)
                    qty_lb_cart.TabIndex = 1
                    qty_lb_cart.Text = "Qty:"
                    '
                    'prodname_cart
                    '
                    prodname_cart.AutoSize = True
                    prodname_cart.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
                    prodname_cart.ForeColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(97, Byte), Integer), CType(CType(107, Byte), Integer))
                    prodname_cart.Location = New System.Drawing.Point(122, 8)
                    prodname_cart.Name = "prodname_cart"
                    prodname_cart.Size = New System.Drawing.Size(82, 19)
                    prodname_cart.TabIndex = 1
                    prodname_cart.Text = incartProduct(i).Name
                    '
                    'prodpic_cart
                    '
                    'Me.prodpic_cart.Image = CType(Resources.GetObject("prodpic_cart.Image"), System.Drawing.Image)
                    prodpic_cart.Location = New System.Drawing.Point(4, 4)
                    prodpic_cart.Name = "prodpic_cart"
                    prodpic_cart.Size = New System.Drawing.Size(95, 95)
                    prodpic_cart.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
                    prodpic_cart.TabIndex = 0
                    prodpic_cart.TabStop = False
                    '
                    'removeprod_cart
                    '
                    removeprod_cart.BackColor = System.Drawing.Color.Transparent
                    removeprod_cart.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
                    removeprod_cart.FlatStyle = System.Windows.Forms.FlatStyle.Popup
                    removeprod_cart.Location = New System.Drawing.Point(349, 37)
                    removeprod_cart.Name = "removeprod_cart"
                    removeprod_cart.Size = New System.Drawing.Size(25, 26)
                    removeprod_cart.TabIndex = 2
                    removeprod_cart.UseVisualStyleBackColor = False



                    cart_prod_panel.Controls.Add(prod_cart_added)
                    prod_cart_added.Controls.Add(removeprod_cart)
                    prod_cart_added.Controls.Add(prodprice_cart)
                    prod_cart_added.Controls.Add(prodtotal_cart)
                    prod_cart_added.Controls.Add(dollar_cart_total)
                    prod_cart_added.Controls.Add(dollar_cart_price)
                    prod_cart_added.Controls.Add(prodqty_cart)
                    prod_cart_added.Controls.Add(total_lb_cart)
                    prod_cart_added.Controls.Add(qty_lb_cart)
                    prod_cart_added.Controls.Add(prodname_cart)
                    prod_cart_added.Controls.Add(prodpic_cart)
                Next



            End Using
        End If
        Cart.Show()
    End Sub
End Class