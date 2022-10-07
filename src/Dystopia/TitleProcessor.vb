Module TitleProcessor
    Friend Sub Run()
        Dim figlet As New FigletText("A Roguelike in VB.Net About a Dystopian World") With {.Color = Color.Blue, .Alignment = Justify.Center}
        AnsiConsole.Clear()
        AnsiConsole.Write(figlet)
        AnsiConsole.MarkupLine("A Production of TheGrumpyGameDev")
        Dim prompt As New SelectionPrompt(Of String) With {.Title = ""}
        prompt.AddChoice(OkText)
        AnsiConsole.Prompt(prompt)
        MainMenuProcessor.Run()
    End Sub
End Module
