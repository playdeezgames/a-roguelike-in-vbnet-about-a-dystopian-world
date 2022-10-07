Public Class WorldDataShould
    <Fact>
    Sub clear_all_world_data()
        Dim subject As IWorldData = New WorldData()
        subject.Clear()
    End Sub
End Class


