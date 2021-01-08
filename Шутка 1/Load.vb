Public Class Load
    Public config() As String
    Private Sub Load_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.Left = -160
        Dim file As String = Application.StartupPath + "/config.txt"
        If My.Computer.FileSystem.FileExists(file) Then
            config = IO.File.ReadAllLines(file)
            If config.Length = 2 Then
                If config(0) < 1 And config(0) > 360 Then
                    End
                End If
                If config(1) < 1 And config(1) > 360 Then
                    End
                End If
            Else
                End
            End If
        Else
            End
        End If
        If My.Computer.FileSystem.FileExists(Application.StartupPath + "/sound.wav") = False Then
            End
        End If
        Launch.Enabled = True
    End Sub
    Dim timers_dat As UShort = 0
    Private Sub Launch_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Launch.Tick
        If timers_dat = CType(config(0), UShort) Then
            Launch.Enabled = False
            Opens.Show()
            timers_dat = 0
            H_T.Enabled = True
            My.Computer.Audio.Play(Application.StartupPath + "/sound.wav", AudioPlayMode.Background)
        Else
            timers_dat += 1
        End If
    End Sub
    Private Sub H_T_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles H_T.Tick
        If timers_dat = CType(config(1), UShort) Then
            H_T.Enabled = False
            Opens.Hide()
        Else
            timers_dat += 1
        End If
    End Sub
End Class