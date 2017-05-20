<Serializable()> _
Public Class Process1
    Public Property mac As String
    Public Property process As List(Of Process_)

    Public Sub New()
    End Sub
    Public Sub New(ByVal mc As String, ByVal pro As List(Of Process_))
        Me.mac = mc
        Me.process = pro
    End Sub
    Public Function getprocess() As List(Of Process_)
        Return Me.process
    End Function

    Public Sub SetProcess(ByVal pro As List(Of Process_))
        Me.process = pro
    End Sub

    Public Function getmac() As String
        Return Me.mac
    End Function

    Public Sub Setmac(ByVal macad As String)
        Me.mac = macad
    End Sub



End Class
