CREATE PROCEDURE AddGuitare
    @prixTotal MONEY,
    @idMicroBridge INT,
    @idMicroCentral INT = NULL,
    @idBoisManche INT,
    @idBoisTouche INT,
    @idUtilisateur INT,
    @idMicroNeck INT,
    @idVibrato INT,
    @idBoisCorps INT
AS
    BEGIN
        INSERT INTO Guitare (prixTotal, idMicroBridge, idMicroCentral, idBoisManche, idBoisTouche, 
                             idUtilisateur, idMicroNeck, idVibrato, idBoisCorps)
        OUTPUT INSERTED.idGuitare, INSERTED.prixTotal, INSERTED.idMicroBridge, INSERTED.idMicroCentral,
               INSERTED.idBoisManche, INSERTED.idBoisTouche, INSERTED.idUtilisateur,
               INSERTED.idMicroNeck, INSERTED.idVibrato, INSERTED.idBoisCorps
        VALUES (@prixTotal, @idMicroBridge, @idMicroCentral, @idBoisManche, @idBoisTouche, 
                @idUtilisateur, @idMicroNeck, @idVibrato, @idBoisCorps);
END;