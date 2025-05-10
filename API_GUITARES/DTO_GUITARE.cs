using LIB;
using System.Data.SqlTypes;
using System.Text.Json.Serialization;

namespace API_GUITARES; 

    public class DTO_GUITARE {
        [JsonPropertyName("idGuitare")]  public int idGuitare { get; set; }
        [JsonPropertyName("prixTotal")] public SqlMoney prixTotal { get; set; }
        [JsonPropertyName("idMicroBridge")] public int idMicroBridge { get; set; }
        [JsonPropertyName("idMicroCentral")] public int idMicroCentral { get; set; }
        [JsonPropertyName("idBoisManche")] public int idBoisManche { get; set; }
        [JsonPropertyName("idBoisTouche")] public int idBoisTouche { get; set; }
        [JsonPropertyName("idUtilisateur")] public int idUtilisateur { get; set; }
        [JsonPropertyName("idMicroNeck")] public int idMicroNeck { get; set; }
        [JsonPropertyName("idVibrato")] public int idVibrato { get; set; }
        [JsonPropertyName("idBoisCorps")] public int idBoisCorps { get; set; }

    //------------------------

    public static DTO_GUITARE Create(int P_Id,SqlMoney P_Prix,int P_idmicroBridge, int P_idMicroCentral, int P_idBoisManche, int P_idBoisTouche, int P_idUtilisateur, int P_idMicroNeck, int P_idVibrato, int P_idBoisCorps) {
        return new DTO_GUITARE() { idGuitare = P_Id,prixTotal = P_Prix, idMicroBridge = P_idmicroBridge, idMicroCentral = P_idMicroCentral, idBoisManche = P_idBoisManche, idBoisTouche = P_idBoisTouche, idUtilisateur = P_idUtilisateur, idMicroNeck = P_idMicroNeck, idVibrato = P_idVibrato, idBoisCorps = P_idBoisCorps };
    }
    //-------------------------
    public static DTO_GUITARE Create(GUITARE P_Guitare) {
        return new DTO_GUITARE() { idGuitare = P_Guitare.idGuitare,idMicroBridge = P_Guitare.idMicroBridge,idMicroCentral = P_Guitare.idMicroCentral,idBoisManche = P_Guitare.idBoisManche,idBoisTouche = P_Guitare.idBoisTouche,idUtilisateur = P_Guitare.idUtilisateur,idMicroNeck = P_Guitare.idMicroNeck,idVibrato = P_Guitare.idVibrato,idBoisCorps = P_Guitare.idBoisCorps };
    }
    //-------------------------
}
