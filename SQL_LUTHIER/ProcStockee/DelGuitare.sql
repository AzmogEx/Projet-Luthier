CREATE PROCEDURE DelGuitare (@idGuitare int) AS
BEGIN
    DELETE FROM Guitare
    OUTPUT DELETED.IdGuitare
    WHERE idGuitare = @idGuitare;
END;