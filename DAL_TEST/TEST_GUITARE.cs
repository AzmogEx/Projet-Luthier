using Microsoft.VisualStudio.TestTools.UnitTesting;
using LIB;
using System.Data.SqlTypes;

namespace LIB.Tests;

[TestClass()]
public class TEST_GUITARE {
    [Priority(1)]
    [TestMethod()]
    public async Task Get_All_GuitareTest() {
        // Arrange
        BASE_GUITARE La_Base = new BASE_GUITARE();

        // Act
        var Resultat = await La_Base.Get_All_Guitare();
        var Nombre_Guitares = Resultat.Length;

        // Assert
        Assert.IsFalse(Nombre_Guitares < 0,"Il n'y a rien dans la base ou il y a une erreur de connexion a la base");
    }

    [Priority(2)]
    [TestMethod()]
    public async Task Add_GuitareTest() {
        // Arrange
        BASE_GUITARE La_Base = new BASE_GUITARE();
        SqlMoney prixTotal = 1500;
        int idMicroBridge = 3;
        int idMicroCentral = 1;
        int idBoisManche = 4;
        int idBoisTouche = 4;
        int idUtilisateur = 1;
        int idMicroNeck = 5;
        int idVibrato = 3;
        int idBoisCorps = 7;

        // Act
        var Nouvelle_Guitare = await La_Base.Add_Guitare(prixTotal.Value,idMicroBridge,idMicroCentral,idBoisManche,
                                                          idBoisTouche,idUtilisateur,idMicroNeck,idVibrato,
                                                          idBoisCorps);

        Assert.IsFalse(Nouvelle_Guitare.idGuitare == 0,"La guitare n'a pas été ajoutée correctement.");
    }

    [Priority(4)]
    [TestMethod()]
    public void Update_GuitareTest() {
        // Arrange
        BASE_GUITARE La_Base = new BASE_GUITARE();

        // Act
        var Update = La_Base.Update_Guitare(5,1300,1,2,3,4,1,5,3,7);

        Assert.IsFalse(Update.IsCanceled,$"{Update.Exception}");
    }

    [Priority(3)]
    [TestMethod()]
    public async Task Delete_GuitareTest() {
        //Arrange
        BASE_GUITARE La_Base = new BASE_GUITARE();

        //Act
        int Suppression = await La_Base.Delete_Guitare(5);

        //Assert
        Assert.IsFalse(Suppression == 0,"La guitare n'existe pas ou alors il y a une erreur de connexion a la base");
    }
}
