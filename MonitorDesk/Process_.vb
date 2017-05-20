<Serializable()> _
Public Class Process_
    Public Property pName As String
    Public Property piD As String

    Public Sub New()
    End Sub

    Public Sub New(ByVal pnam As String, ByVal pid As String)
        Me.pName = pnam
        Me.piD = pid
    End Sub

    Public Function getpName() As String
        Return Me.pName
    End Function

    Public Sub SetpName(ByVal pname As String)
        Me.pName = pname
    End Sub



    Public Function getpiD() As String
        Return Me.piD
    End Function

    Public Sub SetpiD(ByVal pid As String)
        Me.piD = pid
    End Sub

End Class
