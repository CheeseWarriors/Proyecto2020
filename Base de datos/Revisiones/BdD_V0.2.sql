DROP IF EXISTS Pruebas;
CREATE DATABASE Pruebas;
USE DATABASE Pruebas;

CREATE TABLE Usuario(U_Nombre VARCHAR(30) NOT NULL,
U_ID INTEGER(8) NOT NULL PRIMARY KEY,
U_Contraseña INTEGER(20) NOT NULL,
U_Sal VARCHAR(100) NOT NULL,
U_Hash VARCHAR(88) NOT NULL,
U_Categoria ENUM ('Administrador','Jugador') DEFAULT 'Jugador'
);

CREATE TABLE Perfil(Pe_Nombre REFERENCES Usuario(U_Nombre),
Pe_ID INTEGER(8) NOT NULL PRIMARY KEY,
Pe_Puntaje REFERENCES Partida(Pa_Puntaje)
);

CREATE TABLE Partida(Pa_ID INTEGER(10) NOT NULL PRIMARY KEY;
Pa_Puntaje INTEGER(2)
);

/*
CREATE TABLE Jugador (J_Nombre VARCHAR(30) NOT NULL,
J_ID INTEGER(8) NOT NULL PRIMARY KEY);
*/