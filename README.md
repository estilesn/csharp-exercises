# Evaluación Diagnóstica

Este proyecto está desarrollado en **.NET** y puede ejecutarse fácilmente desde la terminal usando el CLI de `dotnet`.

---

## Requisitos

* Tener instalado **.NET SDK**
* Puedes descargarlo desde: https://dotnet.microsoft.com/download

Para verificar que está instalado correctamente, ejecuta en la terminal:

```
dotnet --version
```

---

## Ejecutar el proyecto

1. Abre una terminal en la carpeta donde está el proyecto.
2. Ejecuta el siguiente comando:

```
dotnet run
```

Esto compilará y ejecutará el proyecto automáticamente.

---

## Crear un ejecutable

Si prefieres generar un archivo ejecutable (`.exe`), puedes usar:

```
dotnet publish -c Release
```

Después de compilar, el ejecutable se encontrará en:

```
bin/Release/
```

Dentro de esa carpeta encontrarás el archivo `.exe`, que puedes ejecutar directamente (especialmente útil en **Windows**).

---

## Si el proyecto no ejecuta por la versión de .NET

Si al ejecutar el proyecto aparece un error relacionado con la versión de **.NET**, puedes modificar el archivo:

```
Evaluacion.csproj
```

Busca la línea similar a esta:

```xml
<Project Sdk="Microsoft.NET.Sdk">
```

y revisa la versión del framework especificada más abajo, por ejemplo:

```xml
<TargetFramework>net8.0</TargetFramework>
```

Si tu computadora tiene otra versión instalada, puedes cambiarla por la que tengas disponible, por ejemplo:

```xml
<TargetFramework>net7.0</TargetFramework>
```

Guarda los cambios y vuelve a ejecutar:

```
dotnet run
```

---

## Notas

* El proyecto está pensado para ejecutarse desde **terminal o línea de comandos** con C# 10.0.
* Funciona en **Windows, Linux y macOS** siempre que tengas instalado el **.NET SDK**.
* Si usas **Visual Studio** o **Visual Studio Code**, también puedes ejecutar el proyecto directamente desde el entorno de desarrollo.
