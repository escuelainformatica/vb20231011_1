Imports System
Imports System.Collections.Generic

Namespace Models
    Partial Public Class Disco
        Public Property Id As Integer

        Public Property NombreDisco As String

        Public Property IdArtista As Integer?

        Public Overridable Property IdArtistaNavigation As Artista

        Public Overridable ReadOnly Property Musicas As ICollection(Of Musica) = New List(Of Musica)()
    End Class
End Namespace
