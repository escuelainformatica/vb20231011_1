Imports WinFormsApp4.Models
Imports Microsoft.EntityFrameworkCore

Public Class Form3
    Private Sub ListarMusicaToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ListarMusicaToolStripMenuItem.Click
        PanelMusica.Visible = True
        Panel1.Visible = False
        PanelDisco.Visible = False
        PanelArtista.Visible = False
        PanelTodo.Visible = False
        Using con As New BaseContext() ' esta conexion solo va a ser valida dentro del using
            Dim musicas As New List(Of Musica)
            musicas = (From mus In con.Musicas).ToList()
            GrillaMusica.DataSource = musicas

        End Using
    End Sub

    Private Sub Label3_Click(sender As Object, e As EventArgs) Handles Label3.Click

    End Sub

    Private Sub ListarDiscoToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ListarDiscoToolStripMenuItem.Click
        PanelMusica.Visible = False
        Panel1.Visible = False
        PanelDisco.Visible = True
        PanelArtista.Visible = False
        PanelTodo.Visible = False

        Using con As New BaseContext() ' esta conexion solo va a ser valida dentro del using
            Dim discos As New List(Of Disco)
            discos = (From mus In con.Discos).ToList()
            GrillaDisco.DataSource = discos
        End Using
    End Sub

    Private Sub ListarArtistaToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ListarArtistaToolStripMenuItem.Click
        PanelMusica.Visible = False
        Panel1.Visible = False
        PanelDisco.Visible = False
        PanelArtista.Visible = True
        PanelTodo.Visible = False
        Using con As New BaseContext() ' esta conexion solo va a ser valida dentro del using
            Dim artistas As New List(Of Artista)
            artistas = (From mus In con.Artista).ToList()
            GrillaArtista.DataSource = artistas
        End Using
    End Sub

    Private Sub ListarTodoToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ListarTodoToolStripMenuItem.Click
        PanelMusica.Visible = False
        Panel1.Visible = False
        PanelDisco.Visible = False
        PanelArtista.Visible = False
        PanelTodo.Visible = True
        Using con As New BaseContext() ' esta conexion solo va a ser valida dentro del using
            Dim musicas As New List(Of ValoresDTO)
            musicas = (
                From mus In con.Musicas.
                    Include("IdDiscoNavigation").
                    Include("IdDiscoNavigation.IdArtistaNavigation")
                Select New ValoresDTO With {
                    .Id = mus.Id,
                    .Titulo = mus.Titulo,
                    .NombreDisco = mus.IdDiscoNavigation.NombreDisco,
                    .Nombre = mus.IdDiscoNavigation.IdArtistaNavigation.Nombre,
                    .Apellido = mus.IdDiscoNavigation.IdArtistaNavigation.Apellido
                    }
                    ).ToList()
            GrillaTodo.DataSource = musicas
        End Using
    End Sub
End Class