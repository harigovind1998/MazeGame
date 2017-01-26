Public Class Form1
    Dim myvlable(26) As Label
    Dim hlable(28) As Label
    Dim flash As Integer = 0
    Dim stopaudio(2) As Label
    Private Sub Form1_KeyDown(sender As Object, e As KeyEventArgs) Handles MyBase.KeyDown

        For x As Integer = 0 To 2
            If Character1.Bounds.IntersectsWith(stopaudio(x).Bounds) Then
                My.Computer.Audio.Stop()
                flash = 0
            End If
        Next
        If flash = 1 Then
            My.Computer.Audio.Play(My.Resources.thunder_sound_FX_Grant_Evans_1523270250, AudioPlayMode.Background)
            flash = 2
        End If
        If e.KeyCode = Keys.Up Then
            Character1.Top = Character1.Top - 2
            flashlight.Top = flashlight.Top - 2
            For d As Integer = 0 To 28
                If Character1.Bounds.IntersectsWith(hlable(d).Bounds) Then
                    Character1.Top = Character1.Top + 2
                    flashlight.Top = flashlight.Top + 2
                End If
            Next
            For a As Integer = 0 To 26
                If Character1.Bounds.IntersectsWith(myvlable(a).Bounds) Then
                    Character1.Top = Character1.Top + 2
                    flashlight.Top = flashlight.Top + 2
                End If
            Next
        End If


        If e.KeyCode = Keys.Left Then
            Character1.Left = Character1.Left - 2
            flashlight.Left = flashlight.Left - 2
            For d As Integer = 0 To 26
                If Character1.Bounds.IntersectsWith(myvlable(d).Bounds) Then
                    Character1.Left = Character1.Left + 2
                    flashlight.Left = flashlight.Left + 2
                End If
            Next
            For a As Integer = 0 To 28
                If Character1.Bounds.IntersectsWith(hlable(a).Bounds) Then
                    Character1.Left = Character1.Left + 2
                    flashlight.Left = flashlight.Left + 2
                End If
            Next
        End If


        If e.KeyCode = Keys.Down Then
            Character1.Top = Character1.Top + 2
            flashlight.Top = flashlight.Top + 2
            For d As Integer = 0 To 28
                If Character1.Bounds.IntersectsWith(hlable(d).Bounds) Then
                    Character1.Top = Character1.Top - 2
                    flashlight.Top = flashlight.Top - 2
                End If
            Next
            For a As Integer = 0 To 26
                If Character1.Bounds.IntersectsWith(myvlable(a).Bounds) Then
                    Character1.Top = Character1.Top - 2
                    flashlight.Top = flashlight.Top - 2
                End If
            Next
        End If

        If e.KeyCode = Keys.Right Then
            Character1.Left = Character1.Left + 2
            flashlight.Left = flashlight.Left + 2
            For d As Integer = 0 To 26
                If Character1.Bounds.IntersectsWith(myvlable(d).Bounds) Then
                    Character1.Left = Character1.Left - 2
                    flashlight.Left = flashlight.Left - 2
                End If
            Next
            For a As Integer = 0 To 28
                If Character1.Bounds.IntersectsWith(hlable(a).Bounds) Then
                    Character1.Left = Character1.Left - 2
                    flashlight.Left = flashlight.Left - 2
                End If
            Next
        End If


    End Sub
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        myvlable(0) = V1
        myvlable(1) = V2
        myvlable(2) = V3
        myvlable(3) = V4
        myvlable(4) = V5
        myvlable(5) = V6
        myvlable(6) = V7
        myvlable(7) = V8
        myvlable(8) = V9
        myvlable(9) = V10
        myvlable(10) = V11
        myvlable(11) = V12
        myvlable(12) = V13
        myvlable(13) = V14
        myvlable(14) = V15
        myvlable(15) = V16
        myvlable(16) = V17
        myvlable(17) = V18
        myvlable(18) = V19
        myvlable(19) = V20
        myvlable(20) = V21
        myvlable(21) = V22
        myvlable(22) = V23
        myvlable(23) = V24
        myvlable(24) = V25
        myvlable(25) = V26
        myvlable(26) = V27

        hlable(0) = H1
        hlable(1) = H2
        hlable(2) = H3
        hlable(3) = H4
        hlable(4) = H5
        hlable(5) = H6
        hlable(6) = H7
        hlable(7) = H8
        hlable(8) = H9
        hlable(9) = H10
        hlable(10) = H11
        hlable(11) = H12
        hlable(12) = H13
        hlable(13) = H14
        hlable(14) = H15
        hlable(15) = H16
        hlable(16) = H17
        hlable(17) = H18
        hlable(18) = H19
        hlable(19) = H20
        hlable(20) = H21
        hlable(21) = H22
        hlable(22) = H23
        hlable(23) = H24
        hlable(24) = H25
        hlable(25) = H26
        hlable(26) = H27
        hlable(27) = H28
        hlable(28) = H29

        stopaudio(0) = Label2
        stopaudio(1) = Label3
        stopaudio(2) = Label4


    End Sub
    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick

        If Character1.Bounds.IntersectsWith(Label1.Bounds) Then
            If flashlight.Visible = True Then
                flashlight.Visible = False
            End If
            If flashlight.Visible = False Then
                flashlight.Visible = True
            End If
            If flash = 0 Then
                flash = 1
            End If
        End If
       


    End Sub

End Class

