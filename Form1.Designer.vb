<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(disposing As Boolean)
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
        lblTitle = New Label()
        Label1 = New Label()
        Label2 = New Label()
        grpFreeFall = New GroupBox()
        lblTimePrompt = New Label()
        txtTime = New TextBox()
        btnFreeFall = New Button()
        lblFreeFallResult = New Label()
        grpKinetic = New GroupBox()
        lblEnergyPrompt = New Label()
        txtEnergy = New TextBox()
        lblMassPrompt = New Label()
        txtMass = New TextBox()
        btnVelocity = New Button()
        lblVelocityResult = New Label()
        grpCompound = New GroupBox()
        lblPrincipalPrompt = New Label()
        txtPrincipal = New TextBox()
        lblRatePrompt = New Label()
        txtRate = New TextBox()
        lblYearsPrompt = New Label()
        txtYears = New TextBox()
        lblCompoundsPrompt = New Label()
        txtCompounds = New TextBox()
        btnCompound = New Button()
        lblCompoundResult = New Label()
        grpDecibel = New GroupBox()
        lblIntensityPrompt = New Label()
        txtIntensity = New TextBox()
        btnDecibel = New Button()
        lblDecibelResult = New Label()
        grpRichter = New GroupBox()
        lblRichterEnergyPrompt = New Label()
        txtRichterEnergy = New TextBox()
        btnRichter = New Button()
        lblRichterResult = New Label()
        grpPH = New GroupBox()
        lblHydrogenPrompt = New Label()
        txtHydrogen = New TextBox()
        btnPH = New Button()
        lblPHResult = New Label()
        grpFreeFall.SuspendLayout()
        grpKinetic.SuspendLayout()
        grpCompound.SuspendLayout()
        grpDecibel.SuspendLayout()
        grpRichter.SuspendLayout()
        grpPH.SuspendLayout()
        SuspendLayout()
        ' 
        ' lblTitle
        ' 
        lblTitle.AutoSize = True
        lblTitle.Font = New Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        lblTitle.Location = New Point(184, 27)
        lblTitle.Name = "lblTitle"
        lblTitle.Size = New Size(304, 31)
        lblTitle.TabIndex = 0
        lblTitle.Text = "Scientific Formula Calculator"
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Location = New Point(174, 7)
        Label1.Name = "Label1"
        Label1.Size = New Size(327, 20)
        Label1.TabIndex = 1
        Label1.Text = "-----------------------------------------------------"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Location = New Point(174, 58)
        Label2.Name = "Label2"
        Label2.Size = New Size(327, 20)
        Label2.TabIndex = 1
        Label2.Text = "-----------------------------------------------------"
        ' 
        ' grpFreeFall
        ' 
        grpFreeFall.Controls.Add(btnFreeFall)
        grpFreeFall.Controls.Add(txtTime)
        grpFreeFall.Controls.Add(lblFreeFallResult)
        grpFreeFall.Controls.Add(lblTimePrompt)
        grpFreeFall.Location = New Point(58, 93)
        grpFreeFall.Name = "grpFreeFall"
        grpFreeFall.Size = New Size(325, 147)
        grpFreeFall.TabIndex = 2
        grpFreeFall.TabStop = False
        grpFreeFall.Text = "1. Free Fall Distance"
        ' 
        ' lblTimePrompt
        ' 
        lblTimePrompt.AutoSize = True
        lblTimePrompt.Location = New Point(18, 42)
        lblTimePrompt.Name = "lblTimePrompt"
        lblTimePrompt.Size = New Size(112, 20)
        lblTimePrompt.TabIndex = 0
        lblTimePrompt.Text = "Time (seconds):"
        ' 
        ' txtTime
        ' 
        txtTime.Location = New Point(168, 41)
        txtTime.Name = "txtTime"
        txtTime.Size = New Size(45, 27)
        txtTime.TabIndex = 1
        txtTime.Text = "2"
        ' 
        ' btnFreeFall
        ' 
        btnFreeFall.Location = New Point(23, 87)
        btnFreeFall.Name = "btnFreeFall"
        btnFreeFall.Size = New Size(97, 31)
        btnFreeFall.TabIndex = 2
        btnFreeFall.Text = "Calculate"
        btnFreeFall.UseVisualStyleBackColor = True
        ' 
        ' lblFreeFallResult
        ' 
        lblFreeFallResult.AutoSize = True
        lblFreeFallResult.Location = New Point(142, 92)
        lblFreeFallResult.Name = "lblFreeFallResult"
        lblFreeFallResult.Size = New Size(79, 20)
        lblFreeFallResult.TabIndex = 0
        lblFreeFallResult.Text = "Distance: -"
        ' 
        ' grpKinetic
        ' 
        grpKinetic.Controls.Add(btnVelocity)
        grpKinetic.Controls.Add(lblVelocityResult)
        grpKinetic.Controls.Add(lblMassPrompt)
        grpKinetic.Controls.Add(lblEnergyPrompt)
        grpKinetic.Controls.Add(txtMass)
        grpKinetic.Controls.Add(txtEnergy)
        grpKinetic.Location = New Point(408, 93)
        grpKinetic.Name = "grpKinetic"
        grpKinetic.Size = New Size(330, 147)
        grpKinetic.TabIndex = 3
        grpKinetic.TabStop = False
        grpKinetic.Text = "2. Velocity from Kinetic Energy"
        ' 
        ' lblEnergyPrompt
        ' 
        lblEnergyPrompt.AutoSize = True
        lblEnergyPrompt.Location = New Point(27, 42)
        lblEnergyPrompt.Name = "lblEnergyPrompt"
        lblEnergyPrompt.Size = New Size(76, 20)
        lblEnergyPrompt.TabIndex = 0
        lblEnergyPrompt.Text = "Energy (J):"
        ' 
        ' txtEnergy
        ' 
        txtEnergy.Location = New Point(136, 42)
        txtEnergy.Name = "txtEnergy"
        txtEnergy.Size = New Size(45, 27)
        txtEnergy.TabIndex = 1
        txtEnergy.Text = "100"
        ' 
        ' lblMassPrompt
        ' 
        lblMassPrompt.AutoSize = True
        lblMassPrompt.Location = New Point(187, 45)
        lblMassPrompt.Name = "lblMassPrompt"
        lblMassPrompt.Size = New Size(75, 20)
        lblMassPrompt.TabIndex = 0
        lblMassPrompt.Text = "Mass (kg):"
        ' 
        ' txtMass
        ' 
        txtMass.Location = New Point(268, 45)
        txtMass.Name = "txtMass"
        txtMass.Size = New Size(45, 27)
        txtMass.TabIndex = 1
        txtMass.Text = "2"
        ' 
        ' btnVelocity
        ' 
        btnVelocity.Location = New Point(27, 87)
        btnVelocity.Name = "btnVelocity"
        btnVelocity.Size = New Size(97, 31)
        btnVelocity.TabIndex = 2
        btnVelocity.Text = "Calculate"
        btnVelocity.UseVisualStyleBackColor = True
        ' 
        ' lblVelocityResult
        ' 
        lblVelocityResult.AutoSize = True
        lblVelocityResult.Location = New Point(152, 92)
        lblVelocityResult.Name = "lblVelocityResult"
        lblVelocityResult.Size = New Size(74, 20)
        lblVelocityResult.TabIndex = 0
        lblVelocityResult.Text = "Velocity: -"
        ' 
        ' grpCompound
        ' 
        grpCompound.Controls.Add(btnCompound)
        grpCompound.Controls.Add(lblCompoundResult)
        grpCompound.Controls.Add(lblCompoundsPrompt)
        grpCompound.Controls.Add(lblYearsPrompt)
        grpCompound.Controls.Add(lblRatePrompt)
        grpCompound.Controls.Add(lblPrincipalPrompt)
        grpCompound.Controls.Add(txtCompounds)
        grpCompound.Controls.Add(txtYears)
        grpCompound.Controls.Add(txtRate)
        grpCompound.Controls.Add(txtPrincipal)
        grpCompound.Location = New Point(58, 269)
        grpCompound.Name = "grpCompound"
        grpCompound.Size = New Size(325, 174)
        grpCompound.TabIndex = 4
        grpCompound.TabStop = False
        grpCompound.Text = "3. Compound Interest"
        ' 
        ' lblPrincipalPrompt
        ' 
        lblPrincipalPrompt.AutoSize = True
        lblPrincipalPrompt.Location = New Point(18, 37)
        lblPrincipalPrompt.Name = "lblPrincipalPrompt"
        lblPrincipalPrompt.Size = New Size(69, 20)
        lblPrincipalPrompt.TabIndex = 0
        lblPrincipalPrompt.Text = "Principal:"
        ' 
        ' txtPrincipal
        ' 
        txtPrincipal.Location = New Point(93, 34)
        txtPrincipal.Name = "txtPrincipal"
        txtPrincipal.Size = New Size(45, 27)
        txtPrincipal.TabIndex = 1
        txtPrincipal.Text = "1000"
        ' 
        ' lblRatePrompt
        ' 
        lblRatePrompt.AutoSize = True
        lblRatePrompt.Location = New Point(144, 37)
        lblRatePrompt.Name = "lblRatePrompt"
        lblRatePrompt.Size = New Size(118, 20)
        lblRatePrompt.TabIndex = 0
        lblRatePrompt.Text = "Annual Rate (%):"
        ' 
        ' txtRate
        ' 
        txtRate.Location = New Point(268, 34)
        txtRate.Name = "txtRate"
        txtRate.Size = New Size(45, 27)
        txtRate.TabIndex = 1
        txtRate.Text = "5"
        ' 
        ' lblYearsPrompt
        ' 
        lblYearsPrompt.AutoSize = True
        lblYearsPrompt.Location = New Point(20, 72)
        lblYearsPrompt.Name = "lblYearsPrompt"
        lblYearsPrompt.Size = New Size(46, 20)
        lblYearsPrompt.TabIndex = 0
        lblYearsPrompt.Text = "Years:"
        ' 
        ' txtYears
        ' 
        txtYears.Location = New Point(72, 72)
        txtYears.Name = "txtYears"
        txtYears.Size = New Size(45, 27)
        txtYears.TabIndex = 1
        txtYears.Text = "10"
        ' 
        ' lblCompoundsPrompt
        ' 
        lblCompoundsPrompt.AutoSize = True
        lblCompoundsPrompt.Location = New Point(126, 79)
        lblCompoundsPrompt.Name = "lblCompoundsPrompt"
        lblCompoundsPrompt.Size = New Size(126, 20)
        lblCompoundsPrompt.TabIndex = 0
        lblCompoundsPrompt.Text = "Compounds/Year:"
        ' 
        ' txtCompounds
        ' 
        txtCompounds.Location = New Point(271, 76)
        txtCompounds.Name = "txtCompounds"
        txtCompounds.Size = New Size(45, 27)
        txtCompounds.TabIndex = 1
        txtCompounds.Text = "12"
        ' 
        ' btnCompound
        ' 
        btnCompound.Location = New Point(18, 120)
        btnCompound.Name = "btnCompound"
        btnCompound.Size = New Size(97, 31)
        btnCompound.TabIndex = 2
        btnCompound.Text = "Calculate"
        btnCompound.UseVisualStyleBackColor = True
        ' 
        ' lblCompoundResult
        ' 
        lblCompoundResult.AutoSize = True
        lblCompoundResult.Location = New Point(159, 125)
        lblCompoundResult.Name = "lblCompoundResult"
        lblCompoundResult.Size = New Size(103, 20)
        lblCompoundResult.TabIndex = 0
        lblCompoundResult.Text = "Future Value: -"
        ' 
        ' grpDecibel
        ' 
        grpDecibel.Controls.Add(btnDecibel)
        grpDecibel.Controls.Add(lblDecibelResult)
        grpDecibel.Controls.Add(lblIntensityPrompt)
        grpDecibel.Controls.Add(txtIntensity)
        grpDecibel.Location = New Point(408, 274)
        grpDecibel.Name = "grpDecibel"
        grpDecibel.Size = New Size(337, 169)
        grpDecibel.TabIndex = 5
        grpDecibel.TabStop = False
        grpDecibel.Text = "4. Sound Intensity — Decibels"
        ' 
        ' lblIntensityPrompt
        ' 
        lblIntensityPrompt.AutoSize = True
        lblIntensityPrompt.Location = New Point(27, 44)
        lblIntensityPrompt.Name = "lblIntensityPrompt"
        lblIntensityPrompt.Size = New Size(120, 20)
        lblIntensityPrompt.TabIndex = 0
        lblIntensityPrompt.Text = "Intensity (W/m²):"
        ' 
        ' txtIntensity
        ' 
        txtIntensity.Location = New Point(162, 44)
        txtIntensity.Name = "txtIntensity"
        txtIntensity.Size = New Size(45, 27)
        txtIntensity.TabIndex = 1
        txtIntensity.Text = "0.001"
        ' 
        ' btnDecibel
        ' 
        btnDecibel.Location = New Point(27, 79)
        btnDecibel.Name = "btnDecibel"
        btnDecibel.Size = New Size(97, 31)
        btnDecibel.TabIndex = 2
        btnDecibel.Text = "Calculate"
        btnDecibel.UseVisualStyleBackColor = True
        ' 
        ' lblDecibelResult
        ' 
        lblDecibelResult.AutoSize = True
        lblDecibelResult.Location = New Point(27, 126)
        lblDecibelResult.Name = "lblDecibelResult"
        lblDecibelResult.Size = New Size(102, 20)
        lblDecibelResult.TabIndex = 0
        lblDecibelResult.Text = "Sound Level: -"
        ' 
        ' grpRichter
        ' 
        grpRichter.Controls.Add(btnRichter)
        grpRichter.Controls.Add(lblRichterResult)
        grpRichter.Controls.Add(lblRichterEnergyPrompt)
        grpRichter.Controls.Add(txtRichterEnergy)
        grpRichter.Location = New Point(65, 457)
        grpRichter.Name = "grpRichter"
        grpRichter.Size = New Size(323, 145)
        grpRichter.TabIndex = 6
        grpRichter.TabStop = False
        grpRichter.Text = "5. Richter Magnitude"
        ' 
        ' lblRichterEnergyPrompt
        ' 
        lblRichterEnergyPrompt.AutoSize = True
        lblRichterEnergyPrompt.Location = New Point(16, 36)
        lblRichterEnergyPrompt.Name = "lblRichterEnergyPrompt"
        lblRichterEnergyPrompt.Size = New Size(135, 20)
        lblRichterEnergyPrompt.TabIndex = 0
        lblRichterEnergyPrompt.Text = "Earthquake Energy:"
        ' 
        ' txtRichterEnergy
        ' 
        txtRichterEnergy.Location = New Point(169, 36)
        txtRichterEnergy.Name = "txtRichterEnergy"
        txtRichterEnergy.Size = New Size(86, 27)
        txtRichterEnergy.TabIndex = 1
        txtRichterEnergy.Text = "10000000"
        ' 
        ' btnRichter
        ' 
        btnRichter.Location = New Point(16, 71)
        btnRichter.Name = "btnRichter"
        btnRichter.Size = New Size(97, 31)
        btnRichter.TabIndex = 2
        btnRichter.Text = "Calculate"
        btnRichter.UseVisualStyleBackColor = True
        ' 
        ' lblRichterResult
        ' 
        lblRichterResult.AutoSize = True
        lblRichterResult.Location = New Point(135, 82)
        lblRichterResult.Name = "lblRichterResult"
        lblRichterResult.Size = New Size(94, 20)
        lblRichterResult.TabIndex = 0
        lblRichterResult.Text = "Magnitude: -"
        ' 
        ' grpPH
        ' 
        grpPH.Controls.Add(btnPH)
        grpPH.Controls.Add(lblPHResult)
        grpPH.Controls.Add(lblHydrogenPrompt)
        grpPH.Controls.Add(txtHydrogen)
        grpPH.Location = New Point(430, 462)
        grpPH.Name = "grpPH"
        grpPH.Size = New Size(263, 149)
        grpPH.TabIndex = 7
        grpPH.TabStop = False
        grpPH.Text = "6. pH Calculator"
        ' 
        ' lblHydrogenPrompt
        ' 
        lblHydrogenPrompt.AutoSize = True
        lblHydrogenPrompt.Location = New Point(6, 38)
        lblHydrogenPrompt.Name = "lblHydrogenPrompt"
        lblHydrogenPrompt.Size = New Size(138, 20)
        lblHydrogenPrompt.TabIndex = 0
        lblHydrogenPrompt.Text = "Hydrogen Ion [H+]:"
        ' 
        ' txtHydrogen
        ' 
        txtHydrogen.Location = New Point(165, 38)
        txtHydrogen.Name = "txtHydrogen"
        txtHydrogen.Size = New Size(75, 27)
        txtHydrogen.TabIndex = 1
        txtHydrogen.Text = "0.000001"
        ' 
        ' btnPH
        ' 
        btnPH.Location = New Point(10, 72)
        btnPH.Name = "btnPH"
        btnPH.Size = New Size(97, 31)
        btnPH.TabIndex = 2
        btnPH.Text = "Calculate"
        btnPH.UseVisualStyleBackColor = True
        ' 
        ' lblPHResult
        ' 
        lblPHResult.AutoSize = True
        lblPHResult.Location = New Point(162, 77)
        lblPHResult.Name = "lblPHResult"
        lblPHResult.Size = New Size(42, 20)
        lblPHResult.TabIndex = 0
        lblPHResult.Text = "pH: -"
        ' 
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(782, 653)
        Controls.Add(grpPH)
        Controls.Add(grpRichter)
        Controls.Add(grpDecibel)
        Controls.Add(grpCompound)
        Controls.Add(grpKinetic)
        Controls.Add(grpFreeFall)
        Controls.Add(Label2)
        Controls.Add(Label1)
        Controls.Add(lblTitle)
        Name = "Form1"
        Text = "Scientific Formula Calculator"
        grpFreeFall.ResumeLayout(False)
        grpFreeFall.PerformLayout()
        grpKinetic.ResumeLayout(False)
        grpKinetic.PerformLayout()
        grpCompound.ResumeLayout(False)
        grpCompound.PerformLayout()
        grpDecibel.ResumeLayout(False)
        grpDecibel.PerformLayout()
        grpRichter.ResumeLayout(False)
        grpRichter.PerformLayout()
        grpPH.ResumeLayout(False)
        grpPH.PerformLayout()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents lblTitle As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents grpFreeFall As GroupBox
    Friend WithEvents btnFreeFall As Button
    Friend WithEvents txtTime As TextBox
    Friend WithEvents lblTimePrompt As Label
    Friend WithEvents lblFreeFallResult As Label
    Friend WithEvents grpKinetic As GroupBox
    Friend WithEvents btnVelocity As Button
    Friend WithEvents lblVelocityResult As Label
    Friend WithEvents lblMassPrompt As Label
    Friend WithEvents lblEnergyPrompt As Label
    Friend WithEvents txtMass As TextBox
    Friend WithEvents txtEnergy As TextBox
    Friend WithEvents grpCompound As GroupBox
    Friend WithEvents lblCompoundsPrompt As Label
    Friend WithEvents lblYearsPrompt As Label
    Friend WithEvents lblRatePrompt As Label
    Friend WithEvents lblPrincipalPrompt As Label
    Friend WithEvents txtYears As TextBox
    Friend WithEvents txtRate As TextBox
    Friend WithEvents txtPrincipal As TextBox
    Friend WithEvents txtCompounds As TextBox
    Friend WithEvents btnCompound As Button
    Friend WithEvents lblCompoundResult As Label
    Friend WithEvents grpDecibel As GroupBox
    Friend WithEvents btnDecibel As Button
    Friend WithEvents lblIntensityPrompt As Label
    Friend WithEvents txtIntensity As TextBox
    Friend WithEvents lblDecibelResult As Label
    Friend WithEvents grpRichter As GroupBox
    Friend WithEvents btnRichter As Button
    Friend WithEvents lblRichterEnergyPrompt As Label
    Friend WithEvents txtRichterEnergy As TextBox
    Friend WithEvents lblRichterResult As Label
    Friend WithEvents grpPH As GroupBox
    Friend WithEvents btnPH As Button
    Friend WithEvents lblPHResult As Label
    Friend WithEvents lblHydrogenPrompt As Label
    Friend WithEvents txtHydrogen As TextBox

End Class
