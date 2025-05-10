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
    IF NOT EXISTS (
        SELECT 1 FROM Guitare 
        WHERE prixTotal = @prixTotal
        AND idMicroBridge = @idMicroBridge
        AND idMicroCentral = @idMicroCentral
        AND idBoisManche = @idBoisManche
        AND idBoisTouche = @idBoisTouche
        AND idUtilisateur = @idUtilisateur
        AND idMicroNeck = @idMicroNeck
        AND idVibrato = @idVibrato
        AND idBoisCorps = @idBoisCorps
    )
    BEGIN
        INSERT INTO Guitare (prixTotal, idMicroBridge, idMicroCentral, idBoisManche, idBoisTouche, 
                             idUtilisateur, idMicroNeck, idVibrato, idBoisCorps)
        OUTPUT INSERTED.idGuitare, INSERTED.prixTotal, INSERTED.idMicroBridge, INSERTED.idMicroCentral,
               INSERTED.idBoisManche, INSERTED.idBoisTouche, INSERTED.idUtilisateur,
               INSERTED.idMicroNeck, INSERTED.idVibrato, INSERTED.idBoisCorps
        VALUES (@prixTotal, @idMicroBridge, @idMicroCentral, @idBoisManche, @idBoisTouche, 
                @idUtilisateur, @idMicroNeck, @idVibrato, @idBoisCorps);
    END
    ELSE
    BEGIN
        SELECT NULL;
    END;
END;