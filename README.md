## Agregar librerias

En la consola de nuget

```shell
NuGet\Install-Package EntityFrameworkCore.VisualBasic -Version 7.0.0
NuGet\Install-Package Microsoft.EntityFrameworkCore.SqlServer -Version 7.0.11
NuGet\Install-Package Microsoft.EntityFrameworkCore.Tools -Version 7.0.11
```

## Generar el codigo para entity frameworks
Cambie lo que esta entre comillas por su conexion.

En la consola de nuget

```shell
Scaffold-DbContext "Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\cursovb2023\WinFormsApp4\WinFormsApp4\base11oct.mdf;Integrated Security=True;Connect Timeout=30" Microsoft.EntityFrameworkCore.SqlServer -OutputDir Models -Force  -Context BaseContext
```