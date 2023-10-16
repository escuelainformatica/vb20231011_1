Imports System
Imports System.Collections.Generic

Namespace Models
    Partial Public Class Musica
        Public Property Id As Integer

        Public Property Titulo As String

        Public Property IdDisco As Integer?

        Public Overridable Property IdDiscoNavigation As Disco
    End Class
End Namespace
