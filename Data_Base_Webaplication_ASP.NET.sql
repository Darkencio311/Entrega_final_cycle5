CREATE DATABASE TiendaDB;
GO
USE TiendaDB;


CREATE TABLE Usuarios (
    Id INT IDENTITY(1,1) PRIMARY KEY,
    NombreUsuario NVARCHAR(50) NOT NULL,
    Contrase�a NVARCHAR(255) NOT NULL
);


CREATE TABLE Productos (
    Id INT IDENTITY(1,1) PRIMARY KEY,
    Nombre NVARCHAR(100) NOT NULL,
    Precio DECIMAL(10,2) NOT NULL,
    Descripcion NVARCHAR(255) NULL
);


CREATE TABLE Rese�as (
    Id INT IDENTITY(1,1) PRIMARY KEY,
    Comentario NVARCHAR(500) NOT NULL,
    Calificacion INT CHECK (Calificacion BETWEEN 1 AND 5),
    ProductoId INT,
    FOREIGN KEY (ProductoId) REFERENCES Productos(Id)
);


INSERT INTO Usuarios (NombreUsuario, Contrase�a) VALUES ('admin', '1234');

INSERT INTO Productos (Nombre, Precio, Descripcion) VALUES
('RTX 4060 Ti', 399.99, 'NVIDIA GeForce RTX 4060 Ti 8GB'),
('RTX 4070', 599.99, 'NVIDIA GeForce RTX 4070 12GB'),
('RX 6800 XT', 499.99, 'AMD Radeon RX 6800 XT 16GB'),
('RTX 4090', 1599.99, 'NVIDIA GeForce RTX 4090 24GB');
