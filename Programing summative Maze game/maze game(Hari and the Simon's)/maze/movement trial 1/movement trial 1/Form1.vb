Public Class Form1
    Private imageindex As Integer = 0
    Private Sub Form1_KeyDown(sender As Object, e As KeyEventArgs) Handles MyBase.KeyDown
        If e.KeyCode = Keys.Down Then
            Picplayer.Image = list.Images(imageindex)

            If imageindex = 15 Then
                imageindex = 0
            Else : imageindex += 1
            End If
        End If
        If e.KeyCode = Keys.Up Then
            Picplayer.Image = up.Images(imageindex)
            If imageindex = 15 Then
                imageindex = 0
            Else : imageindex += 1
            End If
        End If
        If e.KeyCode = Keys.Right Then
            Picplayer.Image = right.Images(imageindex)
            If imageindex = 15 Then
                imageindex = 0
            Else : imageindex += 1
            End If
        End If
        If e.KeyCode = Keys.Left Then
            Picplayer.Image = left.Images(imageindex)
            If imageindex = 15 Then
                imageindex = 0
            Else : imageindex += 1
            End If
        End If
    End Sub

    
End Class
