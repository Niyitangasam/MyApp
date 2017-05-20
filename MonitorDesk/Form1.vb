Imports System.Text
Imports System.Management
Imports System.Net.NetworkInformation

Public Class Form1

    Public proc As Process1
    Private pro As List(Of Process_)
    Private running As Process_
    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

    End Sub


    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click

        Dim a As New StringBuilder()
        Dim pName As String
        Dim piD As String


        pro = New List(Of Process_)

        For Each b In Process.GetProcesses(".")
            Try

                If b.MainWindowTitle.Length > 0 Then

                    a.Append("Window Title:  " + b.MainWindowTitle.ToString() + Environment.NewLine)
                    a.Append("Process Name:  " + b.ProcessName.ToString() + Environment.NewLine)
                    a.Append(Environment.NewLine)
                    pName = b.MainWindowTitle.ToString()
                    piD = b.ProcessName.ToString()
                    running = New Process_()
                    running.SetpName(pName)
                    running.SetpiD(piD)
                    pro.Add(running)
                End If
            Catch ex As Exception

            End Try
        Next
        Dim mac As String
        mac = getMacAddress()
        Me.proc = New Process1()
        Me.proc.Setmac(mac)
        Dim res As Boolean
        Me.proc.SetProcess(pro)
        Console.WriteLine("They are " + pro.Count.ToString + " Elements")
        Dim toPost As JsonPost = New JsonPost("https://computermon-b9477.firebaseio.com/processes.json")
        res = toPost.postData(proc)
        Console.WriteLine("In object they are" + proc.ToString)
        If (res) Then
            MsgBox("Data Posted")
        Else
            MsgBox("Not Posted")

        End If


        TextBox1.Text = pro.ToArray.ToString



    End Sub

    Public Function getMacAddress()
        Dim nics() As NetworkInterface = NetworkInterface.GetAllNetworkInterfaces()
        Return nics(1).GetPhysicalAddress.ToString
    End Function


End Class



