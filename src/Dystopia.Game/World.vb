Public Class World
    Implements IWorld
    Private ReadOnly worldData As IWorldData
    Sub New(worldData As IWorldData)
        Me.worldData = worldData
    End Sub

    Public Sub Create(messageHandler As Action(Of String)) Implements IWorld.Create
        worldData.Clear()
        messageHandler("Creating World...")
        messageHandler("DONE!")
    End Sub
End Class
