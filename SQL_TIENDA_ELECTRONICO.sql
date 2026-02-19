-- Forzar desconexiones y eliminar base si existe
IF EXISTS (SELECT * FROM sys.databases WHERE name = 'TIENDA_ELECTRONICA')
BEGIN
    ALTER DATABASE TIENDA_ELECTRONICA SET SINGLE_USER WITH ROLLBACK IMMEDIATE;
    DROP DATABASE TIENDA_ELECTRONICA;
END
GO

-- Crear base de datos
CREATE DATABASE TIENDA_ELECTRONICA;
GO

-- Usar la base de datos recién creada
USE TIENDA_ELECTRONICA;
GO

-- Crear tablas
CREATE TABLE Categoria (
    ID_Categoria INT PRIMARY KEY,
    Nombre_Categoria VARCHAR(100),
    Descripcion_Categoria VARCHAR(255),
    Estado BIT DEFAULT 1
);
GO

CREATE TABLE Producto (
    ID_Producto INT PRIMARY KEY,
    Nombre VARCHAR(100),
    Descripcion VARCHAR(255),
    Precio_unitario DECIMAL(10,2),
    Stock INT,
    ID_Categoria INT,
    FOREIGN KEY (ID_Categoria) REFERENCES Categoria(ID_Categoria)
);
GO

CREATE TABLE Proveedor (
    ID_Proveedor INT PRIMARY KEY,
    Nombre_Proveedor VARCHAR(100),
    Telefono VARCHAR(20),
    Email VARCHAR(100),
    Direccion VARCHAR(255)
);
GO

CREATE TABLE Producto_Proveedor (
    ID_Producto INT,
    ID_Proveedor INT,
    Precio_Compras DECIMAL(10,2),
    PRIMARY KEY (ID_Producto, ID_Proveedor),
    FOREIGN KEY (ID_Producto) REFERENCES Producto(ID_Producto),
    FOREIGN KEY (ID_Proveedor) REFERENCES Proveedor(ID_Proveedor)
);
GO

CREATE TABLE Tipo_Transaccion (
    ID_Tipo_Transaccion INT PRIMARY KEY,
    Descripcion VARCHAR(100),
    Operacion VARCHAR(50)
);
GO

CREATE TABLE Transacciones (
    ID_Transaccion INT IDENTITY(1,1) PRIMARY KEY,
    ID_Producto INT,
    Fecha_Hora DATETIME,
    Cantidad INT,
    ID_Tipo_Transaccion INT,
    Direccion VARCHAR(255),
    FOREIGN KEY (ID_Producto) REFERENCES Producto(ID_Producto),
    FOREIGN KEY (ID_Tipo_Transaccion) REFERENCES Tipo_Transaccion(ID_Tipo_Transaccion)
);
GO

-- Insertar datos en Categoria
INSERT INTO Categoria (ID_Categoria, Nombre_Categoria, Descripcion_Categoria, Estado) VALUES 
(1, 'Computadoras', 'Computadoras y laptops', 1),
(2, 'Telefonía', 'Teléfonos móviles y accesorios', 1),
(3, 'Audio', 'Equipos y accesorios de audio', 1),
(4, 'Videojuegos', 'Consolas y juegos', 1),
(5, 'Accesorios', 'Accesorios para dispositivos electrónicos', 1);
GO

-- Insertar datos en Producto
INSERT INTO Producto (ID_Producto, Nombre, Descripcion, Precio_unitario, Stock, ID_Categoria) VALUES
(101, 'Laptop HP 14"', 'Laptop HP 14 pulgadas con procesador Intel i5', 750.00, 10, 1),
(102, 'Smartphone Samsung S21', 'Smartphone Samsung Galaxy S21, 128GB', 650.00, 15, 2),
(103, 'Audífonos Sony', 'Audífonos inalámbricos Sony WH-1000XM4', 300.00, 25, 3),
(104, 'Consola PS5', 'PlayStation 5 edición estándar', 500.00, 8, 4),
(105, 'Mouse Logitech', 'Mouse inalámbrico Logitech MX Master 3', 100.00, 30, 5);
GO

-- Insertar datos en Proveedor
INSERT INTO Proveedor (ID_Proveedor, Nombre_Proveedor, Telefono, Email, Direccion) VALUES 
(201, 'Tech Supplier', '12345678', 'proveedor@tech.com', 'Calle Principal 123'),
(202, 'Mobile Distributors', '87654321', 'ventas@mobiledist.com', 'Avenida Secundaria 45'),
(203, 'Audio Solutions', '23456789', 'contacto@audiosolutions.com', 'Boulevard Central 67'),
(204, 'GameWorld', '34567890', 'info@gameworld.com', 'Calle Juegos 89'),
(205, 'Accessories Plus', '45678901', 'ventas@accessoriesplus.com', 'Calle Accesorios 101');
GO

-- Insertar datos en Producto_Proveedor
INSERT INTO Producto_Proveedor (ID_Producto, ID_Proveedor, Precio_Compras) VALUES
(101, 201, 700.00),
(102, 202, 600.00),
(103, 203, 270.00),
(104, 204, 480.00),
(105, 205, 90.00);
GO

-- Insertar datos en Tipo_Transaccion
INSERT INTO Tipo_Transaccion (ID_Tipo_Transaccion, Descripcion, Operacion) VALUES
(301, 'Venta', 'Salida'),
(302, 'Compra', 'Entrada'),
(303, 'Devolución', 'Entrada'),
(304, 'Ajuste', 'Entrada/Salida'),
(305, 'Transferencia', 'Entrada/Salida');
GO

-- Insertar datos en Transacciones
INSERT INTO Transacciones (ID_Producto, Fecha_Hora, Cantidad, ID_Tipo_Transaccion, Direccion)
VALUES (@ID_Producto, @Fecha_Hora, @Cantidad, @ID_Tipo_Transaccion, @Direccion)
GO

-- Consultas SELECT
SELECT * FROM Categoria;
SELECT * FROM Producto;
SELECT * FROM Proveedor;
SELECT * FROM Producto_Proveedor;
SELECT * FROM Tipo_Transaccion;
SELECT * FROM Transacciones;
GO

-- Actualizar un registro
-- Actualizar el stock del producto 'Consola PS5' (ID_Producto = 104) a 5 unidades
UPDATE Producto
SET Stock = 5
WHERE ID_Producto = 104;
GO

-- Eliminar un registro
-- Para eliminar el proveedor 'Accessories Plus' (ID_Proveedor = 205), primero eliminar sus relaciones en Producto_Proveedor
--DELETE FROM Producto_Proveedor
-- WHERE ID_Proveedor = 205;
-- GO

-- DELETE FROM Proveedor
-- WHERE ID_Proveedor = 205;
-- GO
