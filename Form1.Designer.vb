<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormArray
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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.txNim = New System.Windows.Forms.TextBox()
        Me.txNama = New System.Windows.Forms.TextBox()
        Me.cbKelamin = New System.Windows.Forms.ComboBox()
        Me.cbProdi = New System.Windows.Forms.ComboBox()
        Me.btProses = New System.Windows.Forms.Button()
        Me.ListView1 = New System.Windows.Forms.ListView()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Times New Roman", 24.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(79, 53)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(478, 36)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Absensi Siswa SMKN 1 SUBANG"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Times New Roman", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(109, 147)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(40, 21)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "NIS"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Times New Roman", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(109, 200)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(53, 21)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Nama"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Times New Roman", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(109, 244)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(111, 21)
        Me.Label4.TabIndex = 3
        Me.Label4.Text = "Jenis Kelamin"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Times New Roman", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(109, 290)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(66, 21)
        Me.Label5.TabIndex = 4
        Me.Label5.Text = "Jurusan"
        '
        'txNim
        '
        Me.txNim.Location = New System.Drawing.Point(247, 147)
        Me.txNim.Name = "txNim"
        Me.txNim.Size = New System.Drawing.Size(233, 20)
        Me.txNim.TabIndex = 5
        '
        'txNama
        '
        Me.txNama.Location = New System.Drawing.Point(247, 202)
        Me.txNama.Name = "txNama"
        Me.txNama.Size = New System.Drawing.Size(233, 20)
        Me.txNama.TabIndex = 6
        '
        'cbKelamin
        '
        Me.cbKelamin.FormattingEnabled = True
        Me.cbKelamin.Location = New System.Drawing.Point(247, 246)
        Me.cbKelamin.Name = "cbKelamin"
        Me.cbKelamin.Size = New System.Drawing.Size(233, 21)
        Me.cbKelamin.TabIndex = 7
        '
        'cbProdi
        '
        Me.cbProdi.FormattingEnabled = True
        Me.cbProdi.Location = New System.Drawing.Point(247, 292)
        Me.cbProdi.Name = "cbProdi"
        Me.cbProdi.Size = New System.Drawing.Size(233, 21)
        Me.cbProdi.TabIndex = 8
        '
        'btProses
        '
        Me.btProses.Location = New System.Drawing.Point(474, 339)
        Me.btProses.Name = "btProses"
        Me.btProses.Size = New System.Drawing.Size(105, 43)
        Me.btProses.TabIndex = 9
        Me.btProses.Text = "Proses"
        Me.btProses.UseVisualStyleBackColor = True
        '
        'ListView1
        '
        Me.ListView1.HideSelection = False
        Me.ListView1.Location = New System.Drawing.Point(0, 420)
        Me.ListView1.Name = "ListView1"
        Me.ListView1.Size = New System.Drawing.Size(619, 235)
        Me.ListView1.TabIndex = 10
        Me.ListView1.UseCompatibleStateImageBehavior = False
        '
        'FormArray
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(620, 655)
        Me.Controls.Add(Me.ListView1)
        Me.Controls.Add(Me.btProses)
        Me.Controls.Add(Me.cbProdi)
        Me.Controls.Add(Me.cbKelamin)
        Me.Controls.Add(Me.txNama)
        Me.Controls.Add(Me.txNim)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Name = "FormArray"
        Me.Text = "Form1"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents txNim As TextBox
    Friend WithEvents txNama As TextBox
    Friend WithEvents cbKelamin As ComboBox
    Friend WithEvents cbProdi As ComboBox
    Friend WithEvents btProses As Button
    Friend WithEvents ListView1 As ListView
End Class
