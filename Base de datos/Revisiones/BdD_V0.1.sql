CREATE DATABASE Pruebas1;

USE DATABASE Pruebas1;

CREATE TABLE Usuario(U_Nombre VARCHAR(30) NOT NULL,
U_ID INTEGER(8) NOT NULL PRIMARY KEY,
U_Contraseña INTEGER(20) NOT NULL);

CREATE TABLE Jugador (J_Nombre VARCHAR(30) NOT NULL,
J_ID INTEGER(8) NOT NULL PRIMARY KEY);

CREATE TABLE Perfil (P_Nombre VARCHAR(30) NOT NULL,
P_ID INTEGER(8) NOT NULL PRIMARY KEY,
P_puntaje INTEGER(6));