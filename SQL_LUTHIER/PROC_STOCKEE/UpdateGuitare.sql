CREATE PROCEDURE updateGuitare
    @prixTotal MONEY,
    @idMicroBridge INT,
    @idMicroCentral INT = NULL,
    @idBoisManche INT,
    @idBoisTouche INT,
    @idUtilisateur INT,
    @idMicroNeck INT,
    @idVibrato INT,
    @idBoisCorps INT,
    @idGuitare INT
AS
BEGIN
    -- Mise à jour des informations de la guitare existante
    UPDATE Guitare
    SET 
        prixTotal = @prixTotal,
        idMicroBridge = @idMicroBridge,
        idMicroCentral = @idMicroCentral,
        idBoisManche = @idBoisManche,
        idBoisTouche = @idBoisTouche,
        idUtilisateur = @idUtilisateur,
        idMicroNeck = @idMicroNeck,
        idVibrato = @idVibrato,
        idBoisCorps = @idBoisCorps
    WHERE idGuitare = @idGuitare;
END;