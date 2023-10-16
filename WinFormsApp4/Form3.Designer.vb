<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form3
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Requerido por el Diseñador de Windows Forms
    Private components As System.ComponentModel.IContainer

    'NOTA: el Diseñador de Windows Forms necesita el siguiente procedimiento
    'Se puede modificar usando el Diseñador de Windows Forms.  
    'No lo modifique con el editor de código.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        MenuStrip1 = New MenuStrip()
        ListarMusicaToolStripMenuItem = New ToolStripMenuItem()
        ListarDiscoToolStripMenuItem = New ToolStripMenuItem()
        ListarArtistaToolStripMenuItem = New ToolStripMenuItem()
        ListarTodoToolStripMenuItem = New ToolStripMenuItem()
        Panel1 = New Panel()
        PanelMusica = New Panel()
        Label1 = New Label()
        GrillaMusica = New DataGridView()
        PanelDisco = New Panel()
        GrillaDisco = New DataGridView()
        Label2 = New Label()
        PanelArtista = New Panel()
        Label3 = New Label()
        GrillaArtista = New DataGridView()
        PanelTodo = New Panel()
        GrillaTodo = New DataGridView()
        Label4 = New Label()
        MenuStrip1.SuspendLayout()
        PanelMusica.SuspendLayout()
        CType(GrillaMusica, ComponentModel.ISupportInitialize).BeginInit()
        PanelDisco.SuspendLayout()
        CType(GrillaDisco, ComponentModel.ISupportInitialize).BeginInit()
        PanelArtista.SuspendLayout()
        CType(GrillaArtista, ComponentModel.ISupportInitialize).BeginInit()
        PanelTodo.SuspendLayout()
        CType(GrillaTodo, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' MenuStrip1
        ' 
        MenuStrip1.ImageScalingSize = New Size(20, 20)
        MenuStrip1.Items.AddRange(New ToolStripItem() {ListarMusicaToolStripMenuItem, ListarDiscoToolStripMenuItem, ListarArtistaToolStripMenuItem, ListarTodoToolStripMenuItem})
        MenuStrip1.Location = New Point(0, 0)
        MenuStrip1.Name = "MenuStrip1"
        MenuStrip1.Size = New Size(800, 28)
        MenuStrip1.TabIndex = 0
        MenuStrip1.Text = "MenuStrip1"
        ' 
        ' ListarMusicaToolStripMenuItem
        ' 
        ListarMusicaToolStripMenuItem.Name = "ListarMusicaToolStripMenuItem"
        ListarMusicaToolStripMenuItem.Size = New Size(108, 24)
        ListarMusicaToolStripMenuItem.Text = "Listar Musica"
        ' 
        ' ListarDiscoToolStripMenuItem
        ' 
        ListarDiscoToolStripMenuItem.Name = "ListarDiscoToolStripMenuItem"
        ListarDiscoToolStripMenuItem.Size = New Size(99, 24)
        ListarDiscoToolStripMenuItem.Text = "Listar Disco"
        ' 
        ' ListarArtistaToolStripMenuItem
        ' 
        ListarArtistaToolStripMenuItem.Name = "ListarArtistaToolStripMenuItem"
        ListarArtistaToolStripMenuItem.Size = New Size(105, 24)
        ListarArtistaToolStripMenuItem.Text = "Listar Artista"
        ' 
        ' ListarTodoToolStripMenuItem
        ' 
        ListarTodoToolStripMenuItem.Name = "ListarTodoToolStripMenuItem"
        ListarTodoToolStripMenuItem.Size = New Size(96, 24)
        ListarTodoToolStripMenuItem.Text = "Listar Todo"
        ' 
        ' Panel1
        ' 
        Panel1.Dock = DockStyle.Fill
        Panel1.Location = New Point(0, 28)
        Panel1.Name = "Panel1"
        Panel1.Size = New Size(800, 422)
        Panel1.TabIndex = 1
        ' 
        ' PanelMusica
        ' 
        PanelMusica.Controls.Add(Label1)
        PanelMusica.Controls.Add(GrillaMusica)
        PanelMusica.Dock = DockStyle.Fill
        PanelMusica.Location = New Point(0, 28)
        PanelMusica.Name = "PanelMusica"
        PanelMusica.Size = New Size(800, 422)
        PanelMusica.TabIndex = 0
        PanelMusica.Visible = False
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Segoe UI", 16.2F, FontStyle.Bold, GraphicsUnit.Point)
        Label1.Location = New Point(16, 13)
        Label1.Name = "Label1"
        Label1.Size = New Size(251, 38)
        Label1.TabIndex = 1
        Label1.Text = "Listado de Musica"
        ' 
        ' GrillaMusica
        ' 
        GrillaMusica.Anchor = AnchorStyles.Top Or AnchorStyles.Bottom Or AnchorStyles.Left Or AnchorStyles.Right
        GrillaMusica.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        GrillaMusica.Location = New Point(12, 60)
        GrillaMusica.Name = "GrillaMusica"
        GrillaMusica.RowHeadersWidth = 51
        GrillaMusica.RowTemplate.Height = 29
        GrillaMusica.Size = New Size(776, 350)
        GrillaMusica.TabIndex = 0
        ' 
        ' PanelDisco
        ' 
        PanelDisco.Controls.Add(GrillaDisco)
        PanelDisco.Controls.Add(Label2)
        PanelDisco.Dock = DockStyle.Fill
        PanelDisco.Location = New Point(0, 28)
        PanelDisco.Name = "PanelDisco"
        PanelDisco.Size = New Size(800, 422)
        PanelDisco.TabIndex = 1
        PanelDisco.Visible = False
        ' 
        ' GrillaDisco
        ' 
        GrillaDisco.Anchor = AnchorStyles.Top Or AnchorStyles.Bottom Or AnchorStyles.Left Or AnchorStyles.Right
        GrillaDisco.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        GrillaDisco.Location = New Point(12, 60)
        GrillaDisco.Name = "GrillaDisco"
        GrillaDisco.RowHeadersWidth = 51
        GrillaDisco.RowTemplate.Height = 29
        GrillaDisco.Size = New Size(776, 350)
        GrillaDisco.TabIndex = 1
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Font = New Font("Segoe UI", 16.2F, FontStyle.Bold, GraphicsUnit.Point)
        Label2.Location = New Point(12, 13)
        Label2.Name = "Label2"
        Label2.Size = New Size(179, 38)
        Label2.TabIndex = 0
        Label2.Text = "Listar Discos"
        ' 
        ' PanelArtista
        ' 
        PanelArtista.Controls.Add(Label3)
        PanelArtista.Controls.Add(GrillaArtista)
        PanelArtista.Dock = DockStyle.Fill
        PanelArtista.Location = New Point(0, 28)
        PanelArtista.Name = "PanelArtista"
        PanelArtista.Size = New Size(800, 422)
        PanelArtista.TabIndex = 2
        PanelArtista.Visible = False
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Font = New Font("Segoe UI", 16.2F, FontStyle.Bold, GraphicsUnit.Point)
        Label3.Location = New Point(12, 13)
        Label3.Name = "Label3"
        Label3.Size = New Size(185, 38)
        Label3.TabIndex = 3
        Label3.Text = "Listar Artista"
        ' 
        ' GrillaArtista
        ' 
        GrillaArtista.Anchor = AnchorStyles.Top Or AnchorStyles.Bottom Or AnchorStyles.Left Or AnchorStyles.Right
        GrillaArtista.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        GrillaArtista.Location = New Point(12, 60)
        GrillaArtista.Name = "GrillaArtista"
        GrillaArtista.RowHeadersWidth = 51
        GrillaArtista.RowTemplate.Height = 29
        GrillaArtista.Size = New Size(776, 350)
        GrillaArtista.TabIndex = 2
        ' 
        ' PanelTodo
        ' 
        PanelTodo.Controls.Add(GrillaTodo)
        PanelTodo.Controls.Add(Label4)
        PanelTodo.Dock = DockStyle.Fill
        PanelTodo.Location = New Point(0, 28)
        PanelTodo.Name = "PanelTodo"
        PanelTodo.Size = New Size(800, 422)
        PanelTodo.TabIndex = 3
        PanelTodo.Visible = False
        ' 
        ' GrillaTodo
        ' 
        GrillaTodo.Anchor = AnchorStyles.Top Or AnchorStyles.Bottom Or AnchorStyles.Left Or AnchorStyles.Right
        GrillaTodo.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        GrillaTodo.Location = New Point(12, 60)
        GrillaTodo.Name = "GrillaTodo"
        GrillaTodo.RowHeadersWidth = 51
        GrillaTodo.RowTemplate.Height = 29
        GrillaTodo.Size = New Size(776, 350)
        GrillaTodo.TabIndex = 5
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Font = New Font("Segoe UI", 16.2F, FontStyle.Bold, GraphicsUnit.Point)
        Label4.Location = New Point(12, 13)
        Label4.Name = "Label4"
        Label4.Size = New Size(160, 38)
        Label4.TabIndex = 4
        Label4.Text = "Listar Todo"
        ' 
        ' Form3
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(800, 450)
        Controls.Add(PanelMusica)
        Controls.Add(PanelArtista)
        Controls.Add(PanelTodo)
        Controls.Add(PanelDisco)
        Controls.Add(Panel1)
        Controls.Add(MenuStrip1)
        MainMenuStrip = MenuStrip1
        Name = "Form3"
        Text = "Form3"
        MenuStrip1.ResumeLayout(False)
        MenuStrip1.PerformLayout()
        PanelMusica.ResumeLayout(False)
        PanelMusica.PerformLayout()
        CType(GrillaMusica, ComponentModel.ISupportInitialize).EndInit()
        PanelDisco.ResumeLayout(False)
        PanelDisco.PerformLayout()
        CType(GrillaDisco, ComponentModel.ISupportInitialize).EndInit()
        PanelArtista.ResumeLayout(False)
        PanelArtista.PerformLayout()
        CType(GrillaArtista, ComponentModel.ISupportInitialize).EndInit()
        PanelTodo.ResumeLayout(False)
        PanelTodo.PerformLayout()
        CType(GrillaTodo, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents ListarMusicaToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ListarDiscoToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ListarArtistaToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ListarTodoToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents Panel1 As Panel
    Friend WithEvents PanelMusica As Panel
    Friend WithEvents PanelDisco As Panel
    Friend WithEvents PanelArtista As Panel
    Friend WithEvents PanelTodo As Panel
    Friend WithEvents Label1 As Label
    Friend WithEvents GrillaMusica As DataGridView
    Friend WithEvents GrillaDisco As DataGridView
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents GrillaArtista As DataGridView
    Friend WithEvents GrillaTodo As DataGridView
    Friend WithEvents Label4 As Label
End Class
