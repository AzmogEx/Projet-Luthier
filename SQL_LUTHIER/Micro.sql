CREATE TABLE Micro(
   idMicro INT IDENTITY,
   refMicro VARCHAR(50) NOT NULL,
   prixMicro MONEY NOT NULL,
   stockMicro DECIMAL(15,2) NOT NULL,
   PRIMARY KEY(idMicro)
);