Public Class Graph

    Dim vertexCount As Integer
    Dim vertices() As gNode
    Dim edgeMatrix(,) As Boolean

    Public Sub New()
        vertexCount = 0
        ReDim vertices(25)
        ReDim edgeMatrix(25, 25)

        For i = 0 To 25
            For j = 0 To 25
                edgeMatrix(i, j) = False
            Next
        Next
    End Sub

    Public Sub addnode(ByVal name As String)
        Dim v As New gNode(name)

        vertexCount += 1

        vertices(v.showIndex) = v
    End Sub

    Public Sub addEdge(ByVal start As String, ByVal fin As String)
        Dim startIndex As Integer = Asc(UCase(start)) - Asc("A")
        Dim finIndex As Integer = Asc(UCase(fin)) - Asc("A")

        edgeMatrix(startIndex, finIndex) = True
        edgeMatrix(finIndex, startIndex) = True

    End Sub

    Public Function showVertex(ByVal index As Integer) As String
        Return vertices(index).showLabel
    End Function

    Public Sub printGraph()

        Dim nodepair As String = ""
        Dim flag As Boolean = False

        For i = 0 To 25
            flag = False
            For j = 0 To 25
                If edgeMatrix(i, j) = True Then
                    flag = True
                    nodepair = vertices(i).showLabel & vertices(j).showLabel
                    Console.Write(nodepair & " ")
                End If
            Next
            If flag <> False Then
                Console.WriteLine("")
            End If
        Next
    End Sub



End Class
