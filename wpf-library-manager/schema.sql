-- Sample database schema for the project; contains no real customer data.
CREATE DATABASE GestionLibreria;
GO
USE GestionLibreria;
GO
CREATE TABLE CLIENTE (
    idCliente INT IDENTITY(1,1) PRIMARY KEY,
    nombreCliente NVARCHAR(120) NOT NULL
);
CREATE TABLE PEDIDO (
    idPedido INT IDENTITY(1,1) PRIMARY KEY,
    idCliente INT NOT NULL REFERENCES CLIENTE(idCliente),
    fechaPedido DATE NOT NULL DEFAULT GETDATE(),
    formaPago NVARCHAR(50) NOT NULL
);
-- Example fictional records
INSERT INTO CLIENTE(nombreCliente) VALUES (N'Cliente Ejemplo'),(N'Cliente Prueba');
INSERT INTO PEDIDO(idCliente,formaPago) VALUES (1,N'Efectivo'),(2,N'Tarjeta');
