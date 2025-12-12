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
        Me.tbHiddenID = New System.Windows.Forms.TextBox()
        Me.ButtonConnect = New System.Windows.Forms.Button()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.ButtonViewDeleted = New System.Windows.Forms.Button()
        Me.ButtonDelete = New System.Windows.Forms.Button()
        Me.ButtonUpdate = New System.Windows.Forms.Button()
        Me.ButtonRead = New System.Windows.Forms.Button()
        Me.btnExit = New System.Windows.Forms.Button()
        Me.ButtonInsert = New System.Windows.Forms.Button()
        Me.tbYearFound = New System.Windows.Forms.TextBox()
        Me.tbCountry = New System.Windows.Forms.TextBox()
        Me.tbArtifactName = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.cbCondition = New System.Windows.Forms.ComboBox()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'tbHiddenID
        '
        Me.tbHiddenID.Location = New System.Drawing.Point(12, 557)
        Me.tbHiddenID.Name = "tbHiddenID"
        Me.tbHiddenID.Size = New System.Drawing.Size(100, 20)
        Me.tbHiddenID.TabIndex = 31
        Me.tbHiddenID.Text = " "
        '
        'ButtonConnect
        '
        Me.ButtonConnect.Font = New System.Drawing.Font("Bahnschrift Condensed", 48.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ButtonConnect.Location = New System.Drawing.Point(12, 447)
        Me.ButtonConnect.Name = "ButtonConnect"
        Me.ButtonConnect.Size = New System.Drawing.Size(640, 104)
        Me.ButtonConnect.TabIndex = 30
        Me.ButtonConnect.Text = "Connect MySQL"
        Me.ButtonConnect.UseVisualStyleBackColor = True
        '
        'DataGridView1
        '
        Me.DataGridView1.BackgroundColor = System.Drawing.Color.DimGray
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.GridColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.DataGridView1.Location = New System.Drawing.Point(12, 233)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.Size = New System.Drawing.Size(644, 150)
        Me.DataGridView1.TabIndex = 29
        '
        'ButtonViewDeleted
        '
        Me.ButtonViewDeleted.Font = New System.Drawing.Font("Cambria", 8.25!)
        Me.ButtonViewDeleted.Location = New System.Drawing.Point(12, 418)
        Me.ButtonViewDeleted.Name = "ButtonViewDeleted"
        Me.ButtonViewDeleted.Size = New System.Drawing.Size(644, 23)
        Me.ButtonViewDeleted.TabIndex = 28
        Me.ButtonViewDeleted.Text = "View Deleted"
        Me.ButtonViewDeleted.UseVisualStyleBackColor = True
        '
        'ButtonDelete
        '
        Me.ButtonDelete.Font = New System.Drawing.Font("Cambria", 8.25!)
        Me.ButtonDelete.Location = New System.Drawing.Point(12, 204)
        Me.ButtonDelete.Name = "ButtonDelete"
        Me.ButtonDelete.Size = New System.Drawing.Size(644, 23)
        Me.ButtonDelete.TabIndex = 26
        Me.ButtonDelete.Text = "Delete Data"
        Me.ButtonDelete.UseVisualStyleBackColor = True
        '
        'ButtonUpdate
        '
        Me.ButtonUpdate.Font = New System.Drawing.Font("Cambria", 8.25!)
        Me.ButtonUpdate.Location = New System.Drawing.Point(12, 175)
        Me.ButtonUpdate.Name = "ButtonUpdate"
        Me.ButtonUpdate.Size = New System.Drawing.Size(644, 23)
        Me.ButtonUpdate.TabIndex = 27
        Me.ButtonUpdate.Text = "Update Data"
        Me.ButtonUpdate.UseVisualStyleBackColor = True
        '
        'ButtonRead
        '
        Me.ButtonRead.Font = New System.Drawing.Font("Cambria", 8.25!)
        Me.ButtonRead.Location = New System.Drawing.Point(12, 146)
        Me.ButtonRead.Name = "ButtonRead"
        Me.ButtonRead.Size = New System.Drawing.Size(644, 23)
        Me.ButtonRead.TabIndex = 25
        Me.ButtonRead.Text = "Read Data"
        Me.ButtonRead.UseVisualStyleBackColor = True
        '
        'btnExit
        '
        Me.btnExit.Font = New System.Drawing.Font("Cambria", 8.25!)
        Me.btnExit.Location = New System.Drawing.Point(12, 389)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(644, 23)
        Me.btnExit.TabIndex = 24
        Me.btnExit.Text = "Exit"
        Me.btnExit.UseVisualStyleBackColor = True
        '
        'ButtonInsert
        '
        Me.ButtonInsert.Font = New System.Drawing.Font("Cambria", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ButtonInsert.Location = New System.Drawing.Point(12, 117)
        Me.ButtonInsert.Name = "ButtonInsert"
        Me.ButtonInsert.Size = New System.Drawing.Size(644, 23)
        Me.ButtonInsert.TabIndex = 23
        Me.ButtonInsert.Text = "Insert Data"
        Me.ButtonInsert.UseVisualStyleBackColor = True
        '
        'tbYearFound
        '
        Me.tbYearFound.Location = New System.Drawing.Point(95, 62)
        Me.tbYearFound.Name = "tbYearFound"
        Me.tbYearFound.Size = New System.Drawing.Size(557, 20)
        Me.tbYearFound.TabIndex = 21
        '
        'tbCountry
        '
        Me.tbCountry.Location = New System.Drawing.Point(95, 36)
        Me.tbCountry.Name = "tbCountry"
        Me.tbCountry.Size = New System.Drawing.Size(557, 20)
        Me.tbCountry.TabIndex = 20
        '
        'tbArtifactName
        '
        Me.tbArtifactName.Location = New System.Drawing.Point(95, 10)
        Me.tbArtifactName.Name = "tbArtifactName"
        Me.tbArtifactName.Size = New System.Drawing.Size(557, 20)
        Me.tbArtifactName.TabIndex = 19
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(18, 13)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(71, 13)
        Me.Label1.TabIndex = 33
        Me.Label1.Text = "Artifact Name"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(18, 39)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(43, 13)
        Me.Label2.TabIndex = 33
        Me.Label2.Text = "Country"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(18, 65)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(62, 13)
        Me.Label3.TabIndex = 33
        Me.Label3.Text = "Year Found"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(18, 92)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(51, 13)
        Me.Label4.TabIndex = 33
        Me.Label4.Text = "Condition"
        '
        'cbCondition
        '
        Me.cbCondition.FormattingEnabled = True
        Me.cbCondition.Items.AddRange(New Object() {"Excellent", "Good", "Fair", "Poor"})
        Me.cbCondition.Location = New System.Drawing.Point(95, 88)
        Me.cbCondition.Name = "cbCondition"
        Me.cbCondition.Size = New System.Drawing.Size(354, 21)
        Me.cbCondition.TabIndex = 34
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(675, 585)
        Me.Controls.Add(Me.cbCondition)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.tbHiddenID)
        Me.Controls.Add(Me.ButtonConnect)
        Me.Controls.Add(Me.DataGridView1)
        Me.Controls.Add(Me.ButtonViewDeleted)
        Me.Controls.Add(Me.ButtonDelete)
        Me.Controls.Add(Me.ButtonUpdate)
        Me.Controls.Add(Me.ButtonRead)
        Me.Controls.Add(Me.btnExit)
        Me.Controls.Add(Me.ButtonInsert)
        Me.Controls.Add(Me.tbYearFound)
        Me.Controls.Add(Me.tbCountry)
        Me.Controls.Add(Me.tbArtifactName)
        Me.Name = "Form1"
        Me.Text = "Form1"
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents tbHiddenID As TextBox
    Friend WithEvents ButtonConnect As Button
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents ButtonViewDeleted As Button
    Friend WithEvents ButtonDelete As Button
    Friend WithEvents ButtonUpdate As Button
    Friend WithEvents ButtonRead As Button
    Friend WithEvents btnExit As Button
    Friend WithEvents ButtonInsert As Button
    Friend WithEvents tbYearFound As TextBox
    Friend WithEvents tbCountry As TextBox
    Friend WithEvents tbArtifactName As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents cbCondition As ComboBox
End Class
