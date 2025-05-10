CREATE PROCEDURE DelGuitare ( @P_Id int) AS
BEGIN
    DELETE FROM Guitare
    OUTPUT DELETED.IdGuitare
    WHERE idGuitare = @P_Id;
END;