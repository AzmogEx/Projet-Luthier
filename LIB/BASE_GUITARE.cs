using Dapper;
using Microsoft.Data.SqlClient;
using Microsoft.IdentityModel.Protocols;
using Newtonsoft.Json;
using System.Configuration;
using System.Data;
using System.Data.SqlTypes;

namespace LIB;

public class BASE_GUITARE :IBASE_GUITARE {

    private string Chaine_Connexion;

    public BASE_GUITARE() {
        string cheminConfig = Path.Combine(AppDomain.CurrentDomain.BaseDirectory,"config.json");
        var laConfig = File.ReadAllText(cheminConfig);
        dynamic fichier = JsonConvert.DeserializeObject(laConfig);

        Chaine_Connexion = fichier.ConnectionString;
    }

    //----------------------------------------------------------

    public async Task<GUITARE[]> Get_All_Guitare() {
        using SqlConnection La_Connexion = new SqlConnection(Chaine_Connexion);
        La_Connexion.Open();
        var Resultat = await La_Connexion.QueryAsync<GUITARE>("GetAllGuitare",commandType: CommandType.StoredProcedure);
        return Resultat.ToArray();
    }
    
    //----------------------------------------------------------
    public async Task<GUITARE> Get_Guitare_By_Id(int P_Id) {
        using SqlConnection La_Connexion = new SqlConnection(Chaine_Connexion);
        La_Connexion.Open();
        var parametres = new { Id = P_Id };
        var Resultat = await La_Connexion.QuerySingleOrDefaultAsync<GUITARE>("GetGuitareById",parametres, commandType: CommandType.StoredProcedure);
        return Resultat;
    }

    //----------------------------------------------------------

    public async Task<GUITARE> Add_Guitare(decimal prixTotal,int idMicroBridge,int idMicroCentral,int idBoisManche,int idBoisTouche,
        int idUtilisateur,int idMicroNeck,int idVibrato,int idBoisCorps) {
        using SqlConnection La_Connexion = new SqlConnection(Chaine_Connexion);
        La_Connexion.Open();
        var parametres = new {
            prixTotal,
            idMicroBridge,
            idMicroCentral,
            idBoisManche,
            idBoisTouche,
            idUtilisateur,
            idMicroNeck,
            idVibrato,
            idBoisCorps,
        };
        var Resultat = await La_Connexion.QuerySingleOrDefaultAsync<GUITARE>("AddGuitare",parametres,commandType: CommandType.StoredProcedure);
        return Resultat;
    }

    //----------------------------------------------------------

    public async Task<GUITARE> Update_Guitare(int idGuitare,decimal prixTotal,int idMicroBridge,int idMicroCentral,int idBoisManche,
        int idBoisTouche,int idUtilisateur,int idMicroNeck,int idVibrato,int idBoisCorps) {
        using SqlConnection La_Connexion = new SqlConnection(Chaine_Connexion);
        La_Connexion.Open();

        var parametres = new {
            idGuitare,
            prixTotal,
            idMicroBridge,
            idMicroCentral,
            idBoisManche,
            idBoisTouche,
            idUtilisateur,
            idMicroNeck,
            idVibrato,
            idBoisCorps
        };

        var Resultat = await La_Connexion.QuerySingleOrDefaultAsync<GUITARE>("UpdateGuitare",parametres,commandType: CommandType.StoredProcedure);
        return Resultat;
    }
    //----------------------------------------------------------

    public async Task<int> Delete_Guitare(int idGuitare) {
        using SqlConnection La_Connexion = new SqlConnection(Chaine_Connexion);
        La_Connexion.Open();

        var parametres = new { idGuitare };

        var Resultat = await La_Connexion.ExecuteScalarAsync<int>(
            "DelGuitare",
            parametres,
            commandType: CommandType.StoredProcedure
        );

        return Resultat;
    }
}