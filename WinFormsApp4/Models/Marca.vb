Imports System
Imports System.Collections.Generic

Namespace Models
    Partial Public Class Marca
        Public Property Id As Integer

        Public Property Nombre As String

        Public Property IdPais As Integer?

        Public Overridable Property IdPaisNavigation As Pai

        Public Overridable ReadOnly Property Vehiculos As ICollection(Of Vehiculo) = New List(Of Vehiculo)()
    End Class
End Namespace
