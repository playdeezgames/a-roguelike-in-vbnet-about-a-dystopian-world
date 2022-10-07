Public Class World
    Implements IWorld

    Public Sub Create(messageHandler As Action(Of String)) Implements IWorld.Create
        messageHandler("Creating World...")
        messageHandler("DONE!")
    End Sub
End Class
