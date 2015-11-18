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
        Me.btnClassA = New System.Windows.Forms.Button()
        Me.btnClassB = New System.Windows.Forms.Button()
        Me.btnClassC = New System.Windows.Forms.Button()
        Me.btnClassCasB = New System.Windows.Forms.Button()
        Me.btnClassBasC = New System.Windows.Forms.Button()
        Me.btnClassBChangeProperties = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'btnClassA
        '
        Me.btnClassA.Location = New System.Drawing.Point(12, 12)
        Me.btnClassA.Name = "btnClassA"
        Me.btnClassA.Size = New System.Drawing.Size(75, 23)
        Me.btnClassA.TabIndex = 0
        Me.btnClassA.Text = "Class A as A"
        Me.btnClassA.UseVisualStyleBackColor = True
        '
        'btnClassB
        '
        Me.btnClassB.Location = New System.Drawing.Point(12, 41)
        Me.btnClassB.Name = "btnClassB"
        Me.btnClassB.Size = New System.Drawing.Size(75, 23)
        Me.btnClassB.TabIndex = 1
        Me.btnClassB.Text = "Class B As B"
        Me.btnClassB.UseVisualStyleBackColor = True
        '
        'btnClassC
        '
        Me.btnClassC.Location = New System.Drawing.Point(12, 70)
        Me.btnClassC.Name = "btnClassC"
        Me.btnClassC.Size = New System.Drawing.Size(75, 23)
        Me.btnClassC.TabIndex = 2
        Me.btnClassC.Text = "Class C as C"
        Me.btnClassC.UseVisualStyleBackColor = True
        '
        'btnClassCasB
        '
        Me.btnClassCasB.Location = New System.Drawing.Point(93, 70)
        Me.btnClassCasB.Name = "btnClassCasB"
        Me.btnClassCasB.Size = New System.Drawing.Size(75, 23)
        Me.btnClassCasB.TabIndex = 4
        Me.btnClassCasB.Text = "Class C as B"
        Me.btnClassCasB.UseVisualStyleBackColor = True
        '
        'btnClassBasC
        '
        Me.btnClassBasC.Location = New System.Drawing.Point(93, 41)
        Me.btnClassBasC.Name = "btnClassBasC"
        Me.btnClassBasC.Size = New System.Drawing.Size(75, 23)
        Me.btnClassBasC.TabIndex = 3
        Me.btnClassBasC.Text = "Class B As C"
        Me.btnClassBasC.UseVisualStyleBackColor = True
        '
        'btnClassBChangeProperties
        '
        Me.btnClassBChangeProperties.Location = New System.Drawing.Point(12, 99)
        Me.btnClassBChangeProperties.Name = "btnClassBChangeProperties"
        Me.btnClassBChangeProperties.Size = New System.Drawing.Size(168, 23)
        Me.btnClassBChangeProperties.TabIndex = 5
        Me.btnClassBChangeProperties.Text = "Class B As B Change Properties"
        Me.btnClassBChangeProperties.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(205, 129)
        Me.Controls.Add(Me.btnClassBChangeProperties)
        Me.Controls.Add(Me.btnClassCasB)
        Me.Controls.Add(Me.btnClassBasC)
        Me.Controls.Add(Me.btnClassC)
        Me.Controls.Add(Me.btnClassB)
        Me.Controls.Add(Me.btnClassA)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "Form1"
        Me.Text = "Polymorphism"
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents btnClassA As System.Windows.Forms.Button
    Friend WithEvents btnClassB As System.Windows.Forms.Button
    Friend WithEvents btnClassC As System.Windows.Forms.Button
    Friend WithEvents btnClassCasB As System.Windows.Forms.Button
    Friend WithEvents btnClassBasC As System.Windows.Forms.Button
    Friend WithEvents btnClassBChangeProperties As System.Windows.Forms.Button

End Class
