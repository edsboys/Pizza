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
        Label1 = New Label()
        chkcheese = New CheckBox()
        btnPrice = New Button()
        Label2 = New Label()
        nucQuantity = New NumericUpDown()
        Label3 = New Label()
        chkmeat = New CheckBox()
        chkCrust = New CheckBox()
        rdochicken = New RadioButton()
        rdobbq = New RadioButton()
        rdosteak = New RadioButton()
        lblDisplay = New Label()
        Label4 = New Label()
        bntClear = New Button()
        Label5 = New Label()
        CType(nucQuantity, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Segoe UI Semibold", 12F, FontStyle.Bold Or FontStyle.Italic, GraphicsUnit.Point)
        Label1.ForeColor = SystemColors.ActiveCaptionText
        Label1.Location = New Point(429, 101)
        Label1.Name = "Label1"
        Label1.Size = New Size(145, 32)
        Label1.TabIndex = 0
        Label1.Text = "Pizza Menu "
        ' 
        ' chkcheese
        ' 
        chkcheese.AutoSize = True
        chkcheese.Font = New Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point)
        chkcheese.Location = New Point(208, 283)
        chkcheese.Name = "chkcheese"
        chkcheese.Size = New Size(180, 36)
        chkcheese.TabIndex = 1
        chkcheese.Text = "Extra Cheese"
        chkcheese.UseVisualStyleBackColor = True
        ' 
        ' btnPrice
        ' 
        btnPrice.Cursor = Cursors.Hand
        btnPrice.Location = New Point(159, 556)
        btnPrice.Name = "btnPrice"
        btnPrice.Size = New Size(427, 65)
        btnPrice.TabIndex = 2
        btnPrice.Text = "Display Price"
        btnPrice.UseVisualStyleBackColor = True
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Font = New Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point)
        Label2.Location = New Point(208, 448)
        Label2.Name = "Label2"
        Label2.Size = New Size(70, 32)
        Label2.TabIndex = 0
        Label2.Text = "Price:"
        ' 
        ' nucQuantity
        ' 
        nucQuantity.Font = New Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point)
        nucQuantity.Location = New Point(649, 372)
        nucQuantity.Name = "nucQuantity"
        nucQuantity.Size = New Size(180, 39)
        nucQuantity.TabIndex = 3
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Font = New Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point)
        Label3.Location = New Point(321, 31)
        Label3.Name = "Label3"
        Label3.Size = New Size(400, 48)
        Label3.TabIndex = 0
        Label3.Text = "Amberfield Pizza Shop"
        ' 
        ' chkmeat
        ' 
        chkmeat.AutoSize = True
        chkmeat.Font = New Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point)
        chkmeat.Location = New Point(433, 283)
        chkmeat.Name = "chkmeat"
        chkmeat.Size = New Size(159, 36)
        chkmeat.TabIndex = 1
        chkmeat.Text = "Extra Meat"
        chkmeat.UseVisualStyleBackColor = True
        ' 
        ' chkCrust
        ' 
        chkCrust.AutoSize = True
        chkCrust.Font = New Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point)
        chkCrust.Location = New Point(629, 283)
        chkCrust.Name = "chkCrust"
        chkCrust.Size = New Size(168, 36)
        chkCrust.TabIndex = 1
        chkCrust.Text = "Thick Crust "
        chkCrust.UseVisualStyleBackColor = True
        ' 
        ' rdochicken
        ' 
        rdochicken.AutoSize = True
        rdochicken.Font = New Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point)
        rdochicken.Location = New Point(208, 151)
        rdochicken.Name = "rdochicken"
        rdochicken.Size = New Size(241, 36)
        rdochicken.TabIndex = 4
        rdochicken.TabStop = True
        rdochicken.Text = "Chicken and Mayo"
        rdochicken.UseVisualStyleBackColor = True
        ' 
        ' rdobbq
        ' 
        rdobbq.AutoSize = True
        rdobbq.Font = New Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point)
        rdobbq.Location = New Point(477, 151)
        rdobbq.Name = "rdobbq"
        rdobbq.Size = New Size(87, 36)
        rdobbq.TabIndex = 4
        rdobbq.TabStop = True
        rdobbq.Text = "BBQ"
        rdobbq.UseVisualStyleBackColor = True
        ' 
        ' rdosteak
        ' 
        rdosteak.AutoSize = True
        rdosteak.Font = New Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point)
        rdosteak.Location = New Point(597, 151)
        rdosteak.Name = "rdosteak"
        rdosteak.Size = New Size(228, 36)
        rdosteak.TabIndex = 4
        rdosteak.TabStop = True
        rdosteak.Text = "Steak and Kidney"
        rdosteak.UseVisualStyleBackColor = True
        ' 
        ' lblDisplay
        ' 
        lblDisplay.BackColor = SystemColors.ButtonHighlight
        lblDisplay.BorderStyle = BorderStyle.FixedSingle
        lblDisplay.Font = New Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point)
        lblDisplay.Location = New Point(649, 448)
        lblDisplay.Name = "lblDisplay"
        lblDisplay.Size = New Size(195, 48)
        lblDisplay.TabIndex = 5
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Font = New Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point)
        Label4.Location = New Point(208, 372)
        Label4.Name = "Label4"
        Label4.Size = New Size(111, 32)
        Label4.TabIndex = 0
        Label4.Text = "Quantity:"
        ' 
        ' bntClear
        ' 
        bntClear.BackColor = SystemColors.ButtonHighlight
        bntClear.Location = New Point(677, 556)
        bntClear.Name = "bntClear"
        bntClear.Size = New Size(211, 65)
        bntClear.TabIndex = 6
        bntClear.Text = "Clear"
        bntClear.UseVisualStyleBackColor = False
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.Font = New Font("Segoe UI Semibold", 13F, FontStyle.Bold Or FontStyle.Italic, GraphicsUnit.Point)
        Label5.Location = New Point(429, 230)
        Label5.Name = "Label5"
        Label5.Size = New Size(185, 36)
        Label5.TabIndex = 0
        Label5.Text = "Topings Menu "
        ' 
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(10F, 25F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(1033, 664)
        Controls.Add(bntClear)
        Controls.Add(lblDisplay)
        Controls.Add(rdosteak)
        Controls.Add(rdobbq)
        Controls.Add(rdochicken)
        Controls.Add(nucQuantity)
        Controls.Add(btnPrice)
        Controls.Add(chkCrust)
        Controls.Add(chkmeat)
        Controls.Add(chkcheese)
        Controls.Add(Label4)
        Controls.Add(Label2)
        Controls.Add(Label3)
        Controls.Add(Label5)
        Controls.Add(Label1)
        Name = "Form1"
        Text = "Form1"
        CType(nucQuantity, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents chkcheese As CheckBox
    Friend WithEvents btnPrice As Button
    Friend WithEvents NumericUpDown1 As NumericUpDown
    Friend WithEvents Label2 As Label
    Friend WithEvents nucQuantity As NumericUpDown
    Friend WithEvents Label3 As Label
    Friend WithEvents chkmeat As CheckBox
    Friend WithEvents chkCrust As CheckBox
    Friend WithEvents rdochicken As RadioButton
    Friend WithEvents rdobbq As RadioButton
    Friend WithEvents rdosteak As RadioButton
    Friend WithEvents lblDisplay As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents bntClear As Button
    Friend WithEvents Label5 As Label
End Class
