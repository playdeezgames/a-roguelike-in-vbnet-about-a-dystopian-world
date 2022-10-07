Imports System

Module Program
    Sub Main(args As String())
        Dim figlet As New FigletText("A Roguelike in VB.Net About a Dystopian World") With {.Color = Color.Blue, .Alignment = Justify.Center}
        AnsiConsole.Clear()
        AnsiConsole.Write(figlet)
        AnsiConsole.MarkupLine("A Production of TheGrumpyGameDev")
        Dim prompt As New SelectionPrompt(Of String) With {.Title = ""}
        prompt.AddChoice("Ok")
        AnsiConsole.Prompt(prompt)
    End Sub
End Module
