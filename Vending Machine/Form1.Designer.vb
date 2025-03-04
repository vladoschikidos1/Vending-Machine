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
        Me.IblTitle = New System.Windows.Forms.Label()
        Me.chkCocaCola = New System.Windows.Forms.CheckBox()
        Me.chkPrime = New System.Windows.Forms.CheckBox()
        Me.chkSprite = New System.Windows.Forms.CheckBox()
        Me.chkWater = New System.Windows.Forms.CheckBox()
        Me.chkTango = New System.Windows.Forms.CheckBox()
        Me.IstOrders = New System.Windows.Forms.ListBox()
        Me.numCoke = New System.Windows.Forms.NumericUpDown()
        Me.IblCost = New System.Windows.Forms.Label()
        Me.btnFinish = New System.Windows.Forms.Button()
        Me.numPrime = New System.Windows.Forms.NumericUpDown()
        Me.numSprite = New System.Windows.Forms.NumericUpDown()
        Me.numWater = New System.Windows.Forms.NumericUpDown()
        Me.numTango = New System.Windows.Forms.NumericUpDown()
        CType(Me.numCoke, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.numPrime, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.numSprite, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.numWater, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.numTango, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'IblTitle
        '
        Me.IblTitle.AutoSize = True
        Me.IblTitle.Font = New System.Drawing.Font("Microsoft Sans Serif", 27.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.IblTitle.Location = New System.Drawing.Point(234, 9)
        Me.IblTitle.Name = "IblTitle"
        Me.IblTitle.Size = New System.Drawing.Size(308, 42)
        Me.IblTitle.TabIndex = 0
        Me.IblTitle.Text = "Vending Machine"
        '
        'chkCocaCola
        '
        Me.chkCocaCola.AutoSize = True
        Me.chkCocaCola.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chkCocaCola.Location = New System.Drawing.Point(175, 102)
        Me.chkCocaCola.Name = "chkCocaCola"
        Me.chkCocaCola.Size = New System.Drawing.Size(161, 28)
        Me.chkCocaCola.TabIndex = 1
        Me.chkCocaCola.Text = "CocaCola £2.00"
        Me.chkCocaCola.UseVisualStyleBackColor = True
        '
        'chkPrime
        '
        Me.chkPrime.AutoSize = True
        Me.chkPrime.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chkPrime.Location = New System.Drawing.Point(175, 153)
        Me.chkPrime.Name = "chkPrime"
        Me.chkPrime.Size = New System.Drawing.Size(128, 28)
        Me.chkPrime.TabIndex = 2
        Me.chkPrime.Text = "Prime £2.50"
        Me.chkPrime.UseVisualStyleBackColor = True
        '
        'chkSprite
        '
        Me.chkSprite.AutoSize = True
        Me.chkSprite.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chkSprite.Location = New System.Drawing.Point(174, 200)
        Me.chkSprite.Name = "chkSprite"
        Me.chkSprite.Size = New System.Drawing.Size(127, 28)
        Me.chkSprite.TabIndex = 3
        Me.chkSprite.Text = "Sprite £2.50"
        Me.chkSprite.UseVisualStyleBackColor = True
        '
        'chkWater
        '
        Me.chkWater.AutoSize = True
        Me.chkWater.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chkWater.Location = New System.Drawing.Point(173, 249)
        Me.chkWater.Name = "chkWater"
        Me.chkWater.Size = New System.Drawing.Size(128, 28)
        Me.chkWater.TabIndex = 4
        Me.chkWater.Text = "Water £1.00"
        Me.chkWater.UseVisualStyleBackColor = True
        '
        'chkTango
        '
        Me.chkTango.AutoSize = True
        Me.chkTango.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chkTango.Location = New System.Drawing.Point(173, 295)
        Me.chkTango.Name = "chkTango"
        Me.chkTango.Size = New System.Drawing.Size(134, 28)
        Me.chkTango.TabIndex = 5
        Me.chkTango.Text = "Tango £2.50"
        Me.chkTango.UseVisualStyleBackColor = True
        '
        'IstOrders
        '
        Me.IstOrders.FormattingEnabled = True
        Me.IstOrders.Location = New System.Drawing.Point(509, 72)
        Me.IstOrders.Name = "IstOrders"
        Me.IstOrders.Size = New System.Drawing.Size(183, 303)
        Me.IstOrders.TabIndex = 6
        '
        'numCoke
        '
        Me.numCoke.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.numCoke.Location = New System.Drawing.Point(357, 101)
        Me.numCoke.Name = "numCoke"
        Me.numCoke.Size = New System.Drawing.Size(42, 29)
        Me.numCoke.TabIndex = 7
        '
        'IblCost
        '
        Me.IblCost.AutoSize = True
        Me.IblCost.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.IblCost.Location = New System.Drawing.Point(86, 346)
        Me.IblCost.Name = "IblCost"
        Me.IblCost.Size = New System.Drawing.Size(184, 29)
        Me.IblCost.TabIndex = 8
        Me.IblCost.Text = "Cost of order £0"
        '
        'btnFinish
        '
        Me.btnFinish.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnFinish.Location = New System.Drawing.Point(91, 388)
        Me.btnFinish.Name = "btnFinish"
        Me.btnFinish.Size = New System.Drawing.Size(193, 50)
        Me.btnFinish.TabIndex = 9
        Me.btnFinish.Text = "Finish and Pay"
        Me.btnFinish.UseVisualStyleBackColor = True
        '
        'numPrime
        '
        Me.numPrime.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.numPrime.Location = New System.Drawing.Point(357, 152)
        Me.numPrime.Name = "numPrime"
        Me.numPrime.Size = New System.Drawing.Size(42, 29)
        Me.numPrime.TabIndex = 10
        '
        'numSprite
        '
        Me.numSprite.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.numSprite.Location = New System.Drawing.Point(357, 200)
        Me.numSprite.Name = "numSprite"
        Me.numSprite.Size = New System.Drawing.Size(42, 29)
        Me.numSprite.TabIndex = 11
        '
        'numWater
        '
        Me.numWater.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.numWater.Location = New System.Drawing.Point(357, 249)
        Me.numWater.Name = "numWater"
        Me.numWater.Size = New System.Drawing.Size(42, 29)
        Me.numWater.TabIndex = 12
        '
        'numTango
        '
        Me.numTango.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.numTango.Location = New System.Drawing.Point(357, 295)
        Me.numTango.Name = "numTango"
        Me.numTango.Size = New System.Drawing.Size(42, 29)
        Me.numTango.TabIndex = 13
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.numTango)
        Me.Controls.Add(Me.numWater)
        Me.Controls.Add(Me.numSprite)
        Me.Controls.Add(Me.numPrime)
        Me.Controls.Add(Me.btnFinish)
        Me.Controls.Add(Me.IblCost)
        Me.Controls.Add(Me.numCoke)
        Me.Controls.Add(Me.IstOrders)
        Me.Controls.Add(Me.chkTango)
        Me.Controls.Add(Me.chkWater)
        Me.Controls.Add(Me.chkSprite)
        Me.Controls.Add(Me.chkPrime)
        Me.Controls.Add(Me.chkCocaCola)
        Me.Controls.Add(Me.IblTitle)
        Me.Name = "Form1"
        Me.Text = "Form1"
        CType(Me.numCoke, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.numPrime, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.numSprite, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.numWater, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.numTango, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents IblTitle As Label
    Friend WithEvents chkCocaCola As CheckBox
    Friend WithEvents chkPrime As CheckBox
    Friend WithEvents chkSprite As CheckBox
    Friend WithEvents chkWater As CheckBox
    Friend WithEvents chkTango As CheckBox
    Friend WithEvents IstOrders As ListBox
    Friend WithEvents numCoke As NumericUpDown
    Friend WithEvents IblCost As Label
    Friend WithEvents btnFinish As Button
    Friend WithEvents numPrime As NumericUpDown
    Friend WithEvents numSprite As NumericUpDown
    Friend WithEvents numWater As NumericUpDown
    Friend WithEvents numTango As NumericUpDown
End Class
