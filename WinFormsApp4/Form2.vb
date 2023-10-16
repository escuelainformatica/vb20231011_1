Imports WinFormsApp4.Models
Imports Microsoft.EntityFrameworkCore

Public Class Form2


    Private Sub Form2_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim con As New BaseContext()
        Dim musicas As List(Of MusicaDTO)
        Dim musicaNoDTO As List(Of Musica)

        musicaNoDTO = (From mus In con.Musicas.
                       Include("IdDiscoNavigation").
                       Include("IdDiscoNavigation.IdArtistaNavigation")
                           ).ToList()

        musicas = (From mus In con.Musicas.
                       Include("IdDiscoNavigation").
                       Include("IdDiscoNavigation.IdArtistaNavigation")
                   Select New MusicaDTO With {
                       .titulo_musica = mus.Titulo,
                       .titulo_disco = mus.IdDiscoNavigation.NombreDisco,
                       .musico = mus.IdDiscoNavigation.IdArtistaNavigation.Nombre + " " + mus.IdDiscoNavigation.IdArtistaNavigation.Apellido
                       }
            ).ToList()

        DataGridView1.DataSource = musicas
        DataGridView1.Refresh()

    End Sub
End Class