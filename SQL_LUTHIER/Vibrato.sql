CREATE TABLE Vibrato(
   idVibrato INT IDENTITY,
   refVibrato VARCHAR(50) NOT NULL,
   prixVibrato MONEY NOT NULL,
   stockVibrato DECIMAL(15,2) NOT NULL,
   PRIMARY KEY(idVibrato)
);