Module StartGameProcessor
    Friend Sub Run(world As IWorld)
        world.Create(AddressOf HandleCreateMessage)
    End Sub
    Private Sub HandleCreateMessage(message As String)

    End Sub
End Module
