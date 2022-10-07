Imports Xunit

Public Class WorldShould
    <Fact>
    Sub create()
        Dim messages As New List(Of String)
        Dim subject As IWorld = New World()
        subject.Create(Sub(message) messages.Add(message))
        messages.ShouldNotBeEmpty
    End Sub
End Class


