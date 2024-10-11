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
        Me.btnFetchDetails = New System.Windows.Forms.Button()
        Me.txtUserID = New System.Windows.Forms.TextBox()
        Me.lblUserID = New System.Windows.Forms.Label()
        Me.txtOutputUserID = New System.Windows.Forms.TextBox()
        Me.txtOutputTitle = New System.Windows.Forms.TextBox()
        Me.txtOutputForename = New System.Windows.Forms.TextBox()
        Me.txtOutputSurname = New System.Windows.Forms.TextBox()
        Me.lblOutput = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'btnFetchDetails
        '
        Me.btnFetchDetails.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnFetchDetails.Location = New System.Drawing.Point(67, 217)
        Me.btnFetchDetails.Name = "btnFetchDetails"
        Me.btnFetchDetails.Size = New System.Drawing.Size(292, 60)
        Me.btnFetchDetails.TabIndex = 0
        Me.btnFetchDetails.Text = "Find"
        Me.btnFetchDetails.UseVisualStyleBackColor = True
        '
        'txtUserID
        '
        Me.txtUserID.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtUserID.Location = New System.Drawing.Point(67, 158)
        Me.txtUserID.Name = "txtUserID"
        Me.txtUserID.Size = New System.Drawing.Size(292, 38)
        Me.txtUserID.TabIndex = 1
        '
        'lblUserID
        '
        Me.lblUserID.AutoSize = True
        Me.lblUserID.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblUserID.Location = New System.Drawing.Point(63, 124)
        Me.lblUserID.Name = "lblUserID"
        Me.lblUserID.Size = New System.Drawing.Size(67, 20)
        Me.lblUserID.TabIndex = 2
        Me.lblUserID.Text = "User ID"
        '
        'txtOutputUserID
        '
        Me.txtOutputUserID.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtOutputUserID.Location = New System.Drawing.Point(504, 154)
        Me.txtOutputUserID.Name = "txtOutputUserID"
        Me.txtOutputUserID.Size = New System.Drawing.Size(171, 38)
        Me.txtOutputUserID.TabIndex = 3
        '
        'txtOutputTitle
        '
        Me.txtOutputTitle.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtOutputTitle.Location = New System.Drawing.Point(504, 207)
        Me.txtOutputTitle.Name = "txtOutputTitle"
        Me.txtOutputTitle.Size = New System.Drawing.Size(171, 38)
        Me.txtOutputTitle.TabIndex = 4
        '
        'txtOutputForename
        '
        Me.txtOutputForename.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtOutputForename.Location = New System.Drawing.Point(504, 262)
        Me.txtOutputForename.Name = "txtOutputForename"
        Me.txtOutputForename.Size = New System.Drawing.Size(171, 38)
        Me.txtOutputForename.TabIndex = 5
        '
        'txtOutputSurname
        '
        Me.txtOutputSurname.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtOutputSurname.Location = New System.Drawing.Point(504, 315)
        Me.txtOutputSurname.Name = "txtOutputSurname"
        Me.txtOutputSurname.Size = New System.Drawing.Size(171, 38)
        Me.txtOutputSurname.TabIndex = 6
        '
        'lblOutput
        '
        Me.lblOutput.AutoSize = True
        Me.lblOutput.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblOutput.Location = New System.Drawing.Point(500, 124)
        Me.lblOutput.Name = "lblOutput"
        Me.lblOutput.Size = New System.Drawing.Size(59, 20)
        Me.lblOutput.TabIndex = 7
        Me.lblOutput.Text = "Output"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.lblOutput)
        Me.Controls.Add(Me.txtOutputSurname)
        Me.Controls.Add(Me.txtOutputForename)
        Me.Controls.Add(Me.txtOutputTitle)
        Me.Controls.Add(Me.txtOutputUserID)
        Me.Controls.Add(Me.lblUserID)
        Me.Controls.Add(Me.txtUserID)
        Me.Controls.Add(Me.btnFetchDetails)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents btnFetchDetails As Button
    Friend WithEvents txtUserID As TextBox
    Friend WithEvents lblUserID As Label
    Friend WithEvents txtOutputUserID As TextBox
    Friend WithEvents txtOutputTitle As TextBox
    Friend WithEvents txtOutputForename As TextBox
    Friend WithEvents txtOutputSurname As TextBox
    Friend WithEvents lblOutput As Label
End Class
