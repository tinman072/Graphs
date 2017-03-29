Public Class gNode

    Private label As String
    Private visited As Boolean
    Private index As Integer

    Public Sub New(ByVal name As String)
        label = UCase(name)
        visited = False
        index = makeIndex(UCase(name))
    End Sub

    Public Function showIndex() As Integer
        Return index
    End Function

    Public Function showLabel() As String
        Return label
    End Function

    Public Sub setVisited()
        visited = True
    End Sub

    Public Sub setNotVisited()
        visited = False
    End Sub

    Public Function wasVisited() As Boolean
        Return visited
    End Function

    Private Function makeIndex(ByVal name As String) As Integer
        Dim index As Integer = 0
        index = Asc(name) - Asc("A")
        Return index
    End Function
End Class
