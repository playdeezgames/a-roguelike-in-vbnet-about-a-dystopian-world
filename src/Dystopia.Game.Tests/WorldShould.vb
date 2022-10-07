Public Class WorldShould
    <Fact>
    Sub create()
        Dim messages As New List(Of String)
        Dim worldData As New Mock(Of IWorldData)
        Dim subject As IWorld = New World(worldData.Object)
        subject.Create(Sub(message) messages.Add(message))
        messages.ShouldNotBeEmpty
        worldData.Verify(Sub(x) x.Clear())
        worldData.VerifyNoOtherCalls()
    End Sub
End Class


