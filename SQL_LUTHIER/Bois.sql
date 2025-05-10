CREATE TABLE Bois(
   idBois INT IDENTITY,
   refBois VARCHAR(50) NOT NULL,
   prixBois MONEY NOT NULL,
   stockBois DECIMAL(15,2) NOT NULL,
   PRIMARY KEY(idBois)
);