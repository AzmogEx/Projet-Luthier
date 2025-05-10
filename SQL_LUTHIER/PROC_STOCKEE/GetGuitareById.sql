CREATE PROCEDURE GetGuitareById (@P_Id int) AS 
BEGIN
    SELECT * FROM Guitare 
    WHERE idGuitare = @P_Id;
END;
