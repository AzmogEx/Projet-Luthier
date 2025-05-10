CREATE TABLE Utilisateurs(
   idUtilisateur INT IDENTITY,
   username VARCHAR(50) NOT NULL,
   motDePasse VARCHAR(512),
   email VARCHAR(50),
   adressePostal VARCHAR(50),
   PRIMARY KEY(idUtilisateur)
);