Module Module1

    Sub Main()

        Dim graph As New Graph

        graph.addnode("a")
        graph.addnode("b")
        graph.addnode("c")
        graph.addnode("d")
        graph.addnode("e")
        graph.addnode("f")
        graph.addnode("g")
        graph.addnode("h")

        graph.addEdge("a", "b")
        graph.addEdge("b", "c")
        graph.addEdge("b", "d")
        graph.addEdge("c", "d")
        graph.addEdge("c", "f")
        graph.addEdge("c", "e")
        graph.addEdge("f", "e")
        graph.addEdge("d", "g")
        graph.addEdge("d", "h")


        graph.printGraph()



    End Sub

End Module
