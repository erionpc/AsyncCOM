Imports System
Imports System.Runtime.InteropServices

<Guid("0c162fd0-1628-483c-85c0-6c1b94835222"),
    InterfaceType(ComInterfaceType.InterfaceIsDual)>
Public Interface IFactory
    <DispId(1)> Function TestFactoryMethod() As <MarshalAs(UnmanagedType.BStr)> String
End Interface


<Guid("c091f830-9c71-4bd0-8426-1c795594b328"),
    ClassInterface(ClassInterfaceType.None),
    ProgId("AsyncCOM_TestCommonLib.Factory"),
    ComDefaultInterface(GetType(IFactory))>
Public Class Factory
    Implements IFactory

    Public testVar As String

    Public Sub New()
        testVar = "test"
    End Sub

    Public Function TestFactoryMethod() As <MarshalAs(UnmanagedType.BStr)> String Implements IFactory.TestFactoryMethod
        Return "reached .NET factory"
    End Function

    <ComVisible(False)>
    Public Function COMDependentMethod() As String
        Dim COM As Object = CreateObject("COM.Test")
        Dim result As String = COM.TestVB6("test")
        Return result
    End Function

End Class

