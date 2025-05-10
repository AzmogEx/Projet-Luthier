/*
Modèle de script de post-déploiement							
--------------------------------------------------------------------------------------
 Ce fichier contient des instructions SQL qui seront ajoutées au script de compilation.		
 Utilisez la syntaxe SQLCMD pour inclure un fichier dans le script de post-déploiement.			
 Exemple :      :r .\monfichier.sql								
 Utilisez la syntaxe SQLCMD pour référencer une variable dans le script de post-déploiement.		
 Exemple :      :setvar TableName MyTable							
               SELECT * FROM [$(TableName)]					
--------------------------------------------------------------------------------------
*/

IF NOT EXISTS (SELECT name FROM sys.database_principals WHERE name = 'USER_LOGIN') BEGIN
	CREATE USER USER_LOGIN WITH password='StrongPassword123!';
	EXEC sp_addrolemember 'db_datareader', 'USER_LOGIN';
	EXEC sp_addrolemember 'db_datawriter', 'USER_LOGIN';
END
	GRANT EXECUTE TO USER_LOGIN;
	GO