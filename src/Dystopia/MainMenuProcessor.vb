Module MainMenuProcessor
	Friend Sub Run()
		Dim done = False
		While Not done
			AnsiConsole.Clear()
			Dim prompt As New SelectionPrompt(Of String) With {.Title = "[olive]Main Menu:[/]"}
			prompt.AddChoice(StartGameText)
			prompt.AddChoice(QuitText)
			Select Case AnsiConsole.Prompt(prompt)
				Case QuitText
					done = ConfirmProcessor.Run("Are you sure you want to quit?")
				Case StartGameText
					StartGameProcessor.Run(New World())
			End Select
		End While
	End Sub
End Module
