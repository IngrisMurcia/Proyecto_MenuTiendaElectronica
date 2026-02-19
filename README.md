Aplicación de escritorio desarrollada en C# con Windows Forms (.NET Framework) para la administración de una tienda electrónica. El sistema permite gestionar productos, categorías, proveedores y transacciones, integrando una base de datos mediante DataSet tipado.

Funcionalidades principales: Gestión de Productos, Gestión de Categorías, Gestión de Proveedores, Gestión de Tipos de Transacción, Registro de Transacciones, Interfaz gráfica amigable con menú principal, Conexión a base de datos mediante TIENDA_ELECTRONICADataSet, Configuración de conexión en App.config

Estructura del Proyecto
El proyecto incluye:
•	Formularios principales:
  - Form1 (Formulario principal)
  - STMTiendaElectronica (Menú principal)
  - FrmCategoria
  - FrmProducto
  - FrmProveedor
  - FrmTipoTransaccion
  - FrmTransacciones

•	Archivos importantes:
  - Program.cs – Punto de entrada de la aplicación
  - App.config – Configuración de conexión a la base de datos
  - TIENDA_ELECTRONICADataSet – DataSet tipado para manejo de datos
  - Archivos .Designer.cs y .resx – Componentes visuales y recursos
  
Tecnologías utilizadas: C#, Windows Forms, .NET Framework, ADO.NET, SQL Server 

Cómo ejecutar el proyecto:
1.	Clonar el repositorio
2.	Abrir el archivo .sln en Visual Studio.
3.	Configurar la cadena de conexión en App.config.

