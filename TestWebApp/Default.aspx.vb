Imports System.Threading.Tasks
Imports AsyncCOM.NewCommonLib

Public Class _Default
    Inherits System.Web.UI.Page

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        If (Not Me.IsPostBack) Then
            lblResult.Text = ""
            lblError.Text = ""
        End If
    End Sub

    Protected Sub btnGetResult_Click(sender As Object, e As EventArgs)
        Try
            Dim test = New Test()
            Dim result = Task.Run(Async Function() Await test.MyAsyncronousMethod()).Result
            lblResult.Text = result
        Catch ex As Exception
            lblError.Text = ex.Message
        End Try

    End Sub

    Private Function CallCOM()
        Dim COM As Object = CreateObject("COM.Test")
        Dim result As String = COM.TestVB6("test")
        Return result
    End Function


End Class