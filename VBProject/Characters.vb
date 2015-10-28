Public Class Characters
    Dim CharacterList = New List(Of String)

    Public Sub PrintCharacters()

        CharacterList.Add("WereWolf")
        CharacterList.Add("WereWolf")
        For i = 0 To CharacterList.Count - 1
            MsgBox(CharacterList.Item(i), , "Can't Look!")
        Next


    End Sub
End Class
