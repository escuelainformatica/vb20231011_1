Imports System
Imports System.Collections.Generic
Imports Microsoft.EntityFrameworkCore

Namespace Models
    Partial Public Class BaseContext
        Inherits DbContext

        Public Sub New()
        End Sub

        Public Sub New(options As DbContextOptions(Of BaseContext))
            MyBase.New(options)
        End Sub

        Public Overridable Property Artista As DbSet(Of Artista)

        Public Overridable Property Discos As DbSet(Of Disco)

        Public Overridable Property Marcas As DbSet(Of Marca)

        Public Overridable Property Musicas As DbSet(Of Musica)

        Public Overridable Property Pais As DbSet(Of Pai)

        Public Overridable Property Personas As DbSet(Of Persona)

        Public Overridable Property Vehiculos As DbSet(Of Vehiculo)

        Protected Overrides Sub OnConfiguring(optionsBuilder As DbContextOptionsBuilder)
            'TODO /!\ To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
            optionsBuilder.UseSqlServer("Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\cursovb2023\WinFormsApp4\WinFormsApp4\base11oct.mdf;Integrated Security=True;Connect Timeout=30")
        End Sub

        Protected Overrides Sub OnModelCreating(modelBuilder As ModelBuilder)
            modelBuilder.UseCollation("Modern_Spanish_CI_AS")

            modelBuilder.Entity(Of Artista)(
                Sub(entity)
                    entity.HasKey(Function(e) e.Id).HasName("PK__Artista__3214EC073214E96B")

                    entity.Property(Function(e) e.Apellido).
                        HasMaxLength(50).
                        IsUnicode(False)
                    entity.Property(Function(e) e.Nombre).
                        HasMaxLength(50).
                        IsUnicode(False)
                End Sub)

            modelBuilder.Entity(Of Disco)(
                Sub(entity)
                    entity.HasKey(Function(e) e.Id).HasName("PK__Disco__3214EC07CD09EBD6")

                    entity.ToTable("Disco")

                    entity.Property(Function(e) e.NombreDisco).
                        HasMaxLength(50).
                        IsUnicode(False)

                    entity.HasOne(Function(d) d.IdArtistaNavigation).WithMany(Function(p) p.Discos).
                        HasForeignKey(Function(d) d.IdArtista).
                        HasConstraintName("FK_Disco_ToTable")
                End Sub)

            modelBuilder.Entity(Of Marca)(
                Sub(entity)
                    entity.HasKey(Function(e) e.Id).HasName("PK__Marcas__3214EC076095A537")

                    entity.Property(Function(e) e.Id).ValueGeneratedNever()
                    entity.Property(Function(e) e.Nombre).
                        HasMaxLength(50).
                        IsUnicode(False)

                    entity.HasOne(Function(d) d.IdPaisNavigation).WithMany(Function(p) p.Marcas).
                        HasForeignKey(Function(d) d.IdPais).
                        HasConstraintName("FK_Marcas_ToTable")
                End Sub)

            modelBuilder.Entity(Of Musica)(
                Sub(entity)
                    entity.HasKey(Function(e) e.Id).HasName("PK__Musica__3214EC07AFB310F8")

                    entity.ToTable("Musica")

                    entity.Property(Function(e) e.Titulo).
                        HasMaxLength(50).
                        IsUnicode(False)

                    entity.HasOne(Function(d) d.IdDiscoNavigation).WithMany(Function(p) p.Musicas).
                        HasForeignKey(Function(d) d.IdDisco).
                        HasConstraintName("FK_Musica_ToTable")
                End Sub)

            modelBuilder.Entity(Of Pai)(
                Sub(entity)
                    entity.HasKey(Function(e) e.Id).HasName("PK__Pais__3214EC07481F50BA")

                    entity.Property(Function(e) e.Id).ValueGeneratedNever()
                    entity.Property(Function(e) e.Nombre).
                        HasMaxLength(10).
                        IsFixedLength()
                End Sub)

            modelBuilder.Entity(Of Persona)(
                Sub(entity)
                    entity.HasKey(Function(e) e.Rut).HasName("PK__Persona__CAF03661C2671574")

                    entity.ToTable("Persona")

                    entity.Property(Function(e) e.Rut).
                        HasMaxLength(12).
                        IsUnicode(False)
                    entity.Property(Function(e) e.Nombre).
                        HasMaxLength(50).
                        IsUnicode(False)
                End Sub)

            modelBuilder.Entity(Of Vehiculo)(
                Sub(entity)
                    entity.HasKey(Function(e) e.Id).HasName("PK__Vehiculo__3214EC07F74B9C87")

                    entity.Property(Function(e) e.Id).ValueGeneratedNever()
                    entity.Property(Function(e) e.Nombre).
                        HasMaxLength(50).
                        IsUnicode(False)
                    entity.Property(Function(e) e.RutPropietario).
                        HasMaxLength(12).
                        IsUnicode(False)

                    entity.HasOne(Function(d) d.IdMarcaNavigation).WithMany(Function(p) p.Vehiculos).
                        HasForeignKey(Function(d) d.IdMarca).
                        HasConstraintName("FK_Vehiculos_ToTable")

                    entity.HasOne(Function(d) d.RutPropietarioNavigation).WithMany(Function(p) p.Vehiculos).
                        HasForeignKey(Function(d) d.RutPropietario).
                        HasConstraintName("FK_Vehiculos_ToTable_1")
                End Sub)

            OnModelCreatingPartial(modelBuilder)
        End Sub

        Partial Private Sub OnModelCreatingPartial(modelBuilder As ModelBuilder)
        End Sub
    End Class
End Namespace
