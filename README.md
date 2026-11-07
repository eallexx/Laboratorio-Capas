# Parcial #2 - Capas
07/11/2026

## Contenido del repositorio
En este proyecto se encuentra el desarrollo de un programa que hace uso de una arquitectura de Capas y el patrón MVP en C#.
Este cuenta con una pagina de inicio de sesión, una interfaz principal que muestra las diferentes opciones del sistema, información del usuario que ingreso y la hora actual,
además, permite modificar, añadir o eliminar productos que se encuentran en la base de datos *Productos*.

## Tecnologías utilizadas
- C#
- Visual Studio
- MySql

## Capturas del programa

Pantalla de inicio de Sesion

<img width="720" height="379" alt="image" src="https://github.com/user-attachments/assets/55a39f57-e212-415b-8cad-746c617f0dd6" />

Interfaz del programa una vez se inicie sesión

<img width="1303" height="652" alt="image" src="https://github.com/user-attachments/assets/cf43ddbd-e689-459b-a4d6-659d737a54e1" />

Pantalla de conexión a la base de datos a través de la opción de productos

<img width="1301" height="649" alt="image" src="https://github.com/user-attachments/assets/22b2d8aa-21cc-44fb-995f-e036b46a382e" />

## Estructura de Carpetas
```text
Laboratorio-Capas
├──Datos
|  ├──Properties/
|  ├──Class1.cs
|  ├──D_Usuario.cs
|  ├──Datos.csproj
|  ├──App.config
|  └──Packages.config
├──Entidades
|  ├──Properties/
|  ├──Class1.cs
|  ├──E_Usuario.cs
|  ├──Entidades.csproj
|  ├──App.config
|  └──Packages.config
├──Negocio
|  ├──Properties/
|  ├──Class1.cs
|  ├──HashService.cs
|  ├──IHashService.cs
|  ├──IVerificarHashService.cs
|  ├──Negocio.csproj
|  ├──App.config
|  └──Packages.config
├──Presentacion
|  ├──Properties/
|  ├──Resources/
|  ├──App.config
|  ├──Form1.Designer.cs
|  ├──Form1.cs
|  ├──Form1.resx
|  ├──FrmPrincipal.cs
|  ├──Presentacion.csproj
|  ├──Program.cs
|  └──Packages.config
└──Productos
   ├──Properties/              
   ├──Resources/               
   ├──App.config               
   ├──conexion.cs              
   ├──Form1.Designer.cs        
   ├──Form1.cs                 
   ├──Form1.resx               
   ├──IvalidadotorCampo.cs     
   ├──Laboratorio4.csproj      
   ├──Producto.cs              
   ├──Program.cs               
   ├──ValidadorDecimal.cs      
   ├──ValidadorEntero.cs        
   ├──ValidadorTexto.cs        
   └──packages.config          

```

## Información del estudiante
Nombre: Ellis Anria

Institución: Universidad tecnológica de Panamá
