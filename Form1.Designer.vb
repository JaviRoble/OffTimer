<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frm_off
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
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

    'Requerido por el Diseñador de Windows Forms
    Private components As System.ComponentModel.IContainer

    'NOTA: el Diseñador de Windows Forms necesita el siguiente procedimiento
    'Se puede modificar usando el Diseñador de Windows Forms.  
    'No lo modifique con el editor de código.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frm_off))
        Me.btn_schedule = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.lbl_hours = New System.Windows.Forms.Label()
        Me.lbl_minutes = New System.Windows.Forms.Label()
        Me.lbl_seconds = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.lbl_total_time = New System.Windows.Forms.Label()
        Me.nudHours = New System.Windows.Forms.NumericUpDown()
        Me.nudSeconds = New System.Windows.Forms.NumericUpDown()
        Me.nudMinutes = New System.Windows.Forms.NumericUpDown()
        Me.btn_cancel = New System.Windows.Forms.Button()
        CType(Me.nudHours, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.nudSeconds, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.nudMinutes, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'btn_schedule
        '
        Me.btn_schedule.Location = New System.Drawing.Point(15, 109)
        Me.btn_schedule.Name = "btn_schedule"
        Me.btn_schedule.Size = New System.Drawing.Size(120, 23)
        Me.btn_schedule.TabIndex = 3
        Me.btn_schedule.Text = "Programar apagado"
        Me.btn_schedule.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(12, 36)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(114, 13)
        Me.Label1.TabIndex = 4
        Me.Label1.Text = "Tiempo para apagado:"
        '
        'lbl_hours
        '
        Me.lbl_hours.AutoSize = True
        Me.lbl_hours.Location = New System.Drawing.Point(131, 17)
        Me.lbl_hours.Name = "lbl_hours"
        Me.lbl_hours.Size = New System.Drawing.Size(18, 13)
        Me.lbl_hours.TabIndex = 8
        Me.lbl_hours.Text = "H:"
        '
        'lbl_minutes
        '
        Me.lbl_minutes.AutoSize = True
        Me.lbl_minutes.Location = New System.Drawing.Point(182, 17)
        Me.lbl_minutes.Name = "lbl_minutes"
        Me.lbl_minutes.Size = New System.Drawing.Size(18, 13)
        Me.lbl_minutes.TabIndex = 9
        Me.lbl_minutes.Text = "m:"
        '
        'lbl_seconds
        '
        Me.lbl_seconds.AutoSize = True
        Me.lbl_seconds.Location = New System.Drawing.Point(233, 17)
        Me.lbl_seconds.Name = "lbl_seconds"
        Me.lbl_seconds.Size = New System.Drawing.Size(15, 13)
        Me.lbl_seconds.TabIndex = 10
        Me.lbl_seconds.Text = "s:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(87, 79)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(92, 13)
        Me.Label2.TabIndex = 11
        Me.Label2.Text = "Segundos totales:"
        '
        'lbl_total_time
        '
        Me.lbl_total_time.AutoSize = True
        Me.lbl_total_time.Location = New System.Drawing.Point(185, 79)
        Me.lbl_total_time.Name = "lbl_total_time"
        Me.lbl_total_time.Size = New System.Drawing.Size(13, 13)
        Me.lbl_total_time.TabIndex = 12
        Me.lbl_total_time.Text = "0"
        '
        'nudHours
        '
        Me.nudHours.Location = New System.Drawing.Point(134, 34)
        Me.nudHours.Maximum = New Decimal(New Integer() {24, 0, 0, 0})
        Me.nudHours.Name = "nudHours"
        Me.nudHours.Size = New System.Drawing.Size(45, 20)
        Me.nudHours.TabIndex = 13
        '
        'nudSeconds
        '
        Me.nudSeconds.Location = New System.Drawing.Point(236, 34)
        Me.nudSeconds.Maximum = New Decimal(New Integer() {60, 0, 0, 0})
        Me.nudSeconds.Name = "nudSeconds"
        Me.nudSeconds.Size = New System.Drawing.Size(45, 20)
        Me.nudSeconds.TabIndex = 14
        '
        'nudMinutes
        '
        Me.nudMinutes.Location = New System.Drawing.Point(185, 34)
        Me.nudMinutes.Maximum = New Decimal(New Integer() {60, 0, 0, 0})
        Me.nudMinutes.Name = "nudMinutes"
        Me.nudMinutes.Size = New System.Drawing.Size(45, 20)
        Me.nudMinutes.TabIndex = 15
        '
        'btn_cancel
        '
        Me.btn_cancel.Location = New System.Drawing.Point(174, 109)
        Me.btn_cancel.Name = "btn_cancel"
        Me.btn_cancel.Size = New System.Drawing.Size(102, 23)
        Me.btn_cancel.TabIndex = 16
        Me.btn_cancel.Text = "Cancelar apagado"
        Me.btn_cancel.UseVisualStyleBackColor = True
        '
        'frm_off
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(288, 146)
        Me.Controls.Add(Me.btn_cancel)
        Me.Controls.Add(Me.nudMinutes)
        Me.Controls.Add(Me.nudSeconds)
        Me.Controls.Add(Me.nudHours)
        Me.Controls.Add(Me.lbl_total_time)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.lbl_seconds)
        Me.Controls.Add(Me.lbl_minutes)
        Me.Controls.Add(Me.lbl_hours)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.btn_schedule)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frm_off"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Apagar"
        CType(Me.nudHours, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.nudSeconds, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.nudMinutes, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents btn_schedule As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents lbl_hours As Label
    Friend WithEvents lbl_minutes As Label
    Friend WithEvents lbl_seconds As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents lbl_total_time As Label
    Friend WithEvents nudHours As NumericUpDown
    Friend WithEvents nudSeconds As NumericUpDown
    Friend WithEvents nudMinutes As NumericUpDown
    Friend WithEvents btn_cancel As Button
End Class
