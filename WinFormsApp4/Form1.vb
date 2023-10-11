Imports WinFormsApp4.Models
Imports System.Linq
Imports System.Data.Entity
Imports Microsoft.EntityFrameworkCore

Public Class Form1
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim vehiculos As New List(Of VehiculoDTO)

        Dim con As New BaseContext
        ' el include hace lo siguiente: cuando traigo los vehiculos, incluyo las marcas.
        'vehiculos = con.Vehiculos.Include("IdMarcaNavigation").ToList()
        vehiculos = (
            From ve In con.Vehiculos.
                Include("IdMarcaNavigation").
                Include("IdMarcaNavigation.IdPaisNavigation").
                Include("RutPropietarioNavigation")
            Order By ve.Nombre
            Select New VehiculoDTO With {
                .Id = ve.Id,
                .Nombre = ve.Nombre,
                .Precio = ve.Precio,
                .NombreCategoria = ve.IdMarcaNavigation.Nombre,
                .PaisCategoria = ve.IdMarcaNavigation.IdPaisNavigation.Nombre,
                .Propietario = ve.RutPropietarioNavigation.Nombre
                }
            ).ToList()

        DataGridView1.DataSource = vehiculos

    End Sub
End Class
