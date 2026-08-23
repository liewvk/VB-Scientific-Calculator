Public Class Form1

    ' ---------------------------------------------------------
    ' 1. FREE FALL
    ' Distance fallen:
    ' d = 0.5 × g × t²
    ' ---------------------------------------------------------

    Private Function FreeFallDistance(t As Double) As Double

        Const g As Double = 9.81

        Return Math.Round(
            0.5 * g * Math.Pow(t, 2), 3)

    End Function


    Private Sub btnFreeFall_Click(sender As Object,
                                  e As EventArgs) _
                                  Handles btnFreeFall.Click

        Dim time As Double

        If Not Double.TryParse(txtTime.Text, time) OrElse
           time < 0 Then

            MessageBox.Show(
                "Enter a valid non-negative time.",
                "Invalid Input")

            txtTime.Focus()
            Return

        End If

        Dim distance As Double =
            FreeFallDistance(time)

        lblFreeFallResult.Text =
            $"Distance: {distance} m"

    End Sub


    ' ---------------------------------------------------------
    ' 2. VELOCITY FROM KINETIC ENERGY
    '
    ' E = 1/2 mv²
    '
    ' Rearranged:
    ' v = √(2E/m)
    ' ---------------------------------------------------------

    Private Function VelocityFromEnergy(
        energy As Double,
        mass As Double) As Double

        If energy < 0 OrElse mass <= 0 Then
            Return 0
        End If

        Return Math.Round(
            Math.Sqrt(2 * energy / mass), 3)

    End Function


    Private Sub btnVelocity_Click(sender As Object,
                                  e As EventArgs) _
                                  Handles btnVelocity.Click

        Dim energy As Double
        Dim mass As Double

        If Not Double.TryParse(txtEnergy.Text, energy) OrElse
           energy < 0 Then

            MessageBox.Show(
                "Enter a valid energy value.",
                "Invalid Input")

            txtEnergy.Focus()
            Return

        End If

        If Not Double.TryParse(txtMass.Text, mass) OrElse
           mass <= 0 Then

            MessageBox.Show(
                "Mass must be greater than zero.",
                "Invalid Input")

            txtMass.Focus()
            Return

        End If

        Dim velocity As Double =
            VelocityFromEnergy(energy, mass)

        lblVelocityResult.Text =
            $"Velocity: {velocity} m/s"

    End Sub


    ' ---------------------------------------------------------
    ' 3. COMPOUND INTEREST
    '
    ' A = P(1 + r/n)^(nt)
    ' ---------------------------------------------------------

    Private Function CompoundAmount(
        principal As Double,
        annualRate As Double,
        compoundsPerYear As Integer,
        years As Double) As Double

        Dim rate As Double =
            annualRate / 100

        Dim amount As Double =
            principal *
            Math.Pow(
                1 + rate / compoundsPerYear,
                compoundsPerYear * years)

        Return Math.Round(amount, 2)

    End Function


    Private Sub btnCompound_Click(sender As Object,
                                  e As EventArgs) _
                                  Handles btnCompound.Click

        Dim principal As Double
        Dim rate As Double
        Dim years As Double
        Dim compounds As Integer

        If Not Double.TryParse(
            txtPrincipal.Text, principal) OrElse
            principal < 0 Then

            MessageBox.Show(
                "Enter a valid principal amount.",
                "Invalid Input")

            Return

        End If

        If Not Double.TryParse(
            txtRate.Text, rate) OrElse
            rate < 0 Then

            MessageBox.Show(
                "Enter a valid annual interest rate.",
                "Invalid Input")

            Return

        End If

        If Not Double.TryParse(
            txtYears.Text, years) OrElse
            years < 0 Then

            MessageBox.Show(
                "Enter a valid number of years.",
                "Invalid Input")

            Return

        End If

        If Not Integer.TryParse(
            txtCompounds.Text, compounds) OrElse
            compounds <= 0 Then

            MessageBox.Show(
                "Compounds per year must be greater than zero.",
                "Invalid Input")

            Return

        End If

        Dim amount As Double =
            CompoundAmount(
                principal,
                rate,
                compounds,
                years)

        lblCompoundResult.Text =
            $"Future Value: {amount:C2}"

    End Sub


    ' ---------------------------------------------------------
    ' 4. DECIBEL CALCULATOR
    '
    ' L = 10 × log10(I / I0)
    '
    ' I0 = 10^-12 W/m²
    ' ---------------------------------------------------------

    Private Function CalculateDecibels(
        intensity As Double) As Double

        Const referenceIntensity As Double = 0.000000000001

        If intensity <= 0 Then
            Return 0
        End If

        Return Math.Round(
            10 *
            Math.Log10(
                intensity / referenceIntensity), 2)

    End Function


    Private Sub btnDecibel_Click(sender As Object,
                                 e As EventArgs) _
                                 Handles btnDecibel.Click

        Dim intensity As Double

        If Not Double.TryParse(
            txtIntensity.Text, intensity) OrElse
            intensity <= 0 Then

            MessageBox.Show(
                "Intensity must be greater than zero.",
                "Invalid Input")

            txtIntensity.Focus()
            Return

        End If

        Dim decibels As Double =
            CalculateDecibels(intensity)

        lblDecibelResult.Text =
            $"Sound Level: {decibels} dB"

    End Sub


    ' ---------------------------------------------------------
    ' 5. RICHTER MAGNITUDE
    '
    ' M = (2/3) × Log10(E / E0)
    ' ---------------------------------------------------------

    Private Function RichterMagnitude(
        energy As Double) As Double

        Const E0 As Double = 10000

        If energy <= 0 Then
            Return 0
        End If

        Return Math.Round(
            (2.0 / 3.0) *
            Math.Log10(energy / E0), 1)

    End Function


    Private Sub btnRichter_Click(sender As Object,
                                 e As EventArgs) _
                                 Handles btnRichter.Click

        Dim energy As Double

        If Not Double.TryParse(
            txtRichterEnergy.Text, energy) OrElse
            energy <= 0 Then

            MessageBox.Show(
                "Energy must be greater than zero.",
                "Invalid Input")

            txtRichterEnergy.Focus()
            Return

        End If

        Dim magnitude As Double =
            RichterMagnitude(energy)

        lblRichterResult.Text =
            $"Magnitude: {magnitude}"

    End Sub


    ' ---------------------------------------------------------
    ' 6. pH CALCULATOR
    '
    ' pH = -Log10([H+])
    ' ---------------------------------------------------------

    Private Function CalculatePH(
        hConc As Double) As Double

        If hConc <= 0 Then
            Return 0
        End If

        Return Math.Round(
            -Math.Log10(hConc), 2)

    End Function


    Private Sub btnPH_Click(sender As Object,
                            e As EventArgs) _
                            Handles btnPH.Click

        Dim concentration As Double

        If Not Double.TryParse(
            txtHydrogen.Text, concentration) OrElse
            concentration <= 0 Then

            MessageBox.Show(
                "Hydrogen ion concentration must be greater than zero.",
                "Invalid Input")

            txtHydrogen.Focus()
            Return

        End If

        Dim ph As Double =
            CalculatePH(concentration)

        lblPHResult.Text =
            $"pH: {ph}"

    End Sub

End Class
