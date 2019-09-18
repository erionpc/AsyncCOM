VERSION 1.0 CLASS
BEGIN
  MultiUse = -1  'True
  Persistable = 0  'NotPersistable
  DataBindingBehavior = 0  'vbNone
  DataSourceBehavior  = 0  'vbNone
  MTSTransactionMode  = 0  'NotAnMTSObject
END
Attribute VB_Name = "Test"
Attribute VB_GlobalNameSpace = False
Attribute VB_Creatable = True
Attribute VB_PredeclaredId = False
Attribute VB_Exposed = True
Option Explicit
Const mc_ThisClass As String = "COM.Test"

Private oNetFactory As AsyncCOM_TestCommonLib.Factory

Public Function TestVB6(testInput As String) As String
    Dim result As String
    result = NetFactory.TestFactoryMethod()
    TestVB6 = result & " - " & testInput
End Function

Private Property Get NetFactory() As AsyncCOM_TestCommonLib.Factory
    If oNetFactory Is Nothing Then
        Set oNetFactory = New AsyncCOM_TestCommonLib.Factory
    End If
    Set NetFactory = oNetFactory
End Property
