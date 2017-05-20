Imports Newtonsoft.Json
Imports System.Net
Imports System.Text
Public Class JsonPost

    Private urlToPost As String = ""

    Public Sub New(ByVal urlToPost As String)
        Me.urlToPost = urlToPost
    End Sub

    Public Function postData(ByVal ObjData As Process1) As Boolean
        Dim webClient As New WebClient()
        Dim resByte As Byte()
        Dim resString As String
        Dim reqString() As Byte

        Try
            webClient.Headers("content-type") = "application/json"
            reqString = Encoding.Default.GetBytes(JsonConvert.SerializeObject(ObjData, Formatting.Indented))
            resByte = webClient.UploadData(Me.urlToPost, "post", reqString)
            resString = Encoding.Default.GetString(resByte)
            Console.WriteLine(resString)
            webClient.Dispose()
            Return True
        Catch ex As Exception
            Console.WriteLine(ex.Message)
        End Try
        Return False
    End Function

End Class