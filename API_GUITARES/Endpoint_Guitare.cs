using LIB;
using Microsoft.AspNetCore.Http.HttpResults;
using Microsoft.AspNetCore.Mvc;
using static System.Net.Mime.MediaTypeNames;

namespace API_GUITARES; 
public static class Endpoint_Guitare {
    public static void Ajoute_Map_Guitare(this WebApplication P_Serveur) {
        P_Serveur.MapGet("/Guitares/GetAll",On_Get_All_Guitare).WithOpenApi();

        P_Serveur.MapGet("/Guitares/Get/{id}",On_Get_Guitares_By_Id).WithOpenApi()
                                                                    .Produces(200)
                                                                    .Produces(404);

        P_Serveur.MapDelete("/Guitares/Del/{id}",On_Delete_Guitares).WithOpenApi()
                                                                 .Produces(200)
                                                                 .Produces(404);


        P_Serveur.MapPut("/Guitares/Add",On_Add_Guitare).WithOpenApi()
                                                        .Produces(200)
                                                        .Produces(404);

        P_Serveur.MapPut("/Guitares/Update",Update_Guitares).WithOpenApi()
                                                            .Produces(200)
                                                            .Produces(404);
    }


    private static async Task<List<GUITARE>> On_Get_All_Guitare(IBASE_GUITARE P_Base) {
        var Les_Guitares = await P_Base.Get_All_Guitare();
        return Les_Guitares != null ? Les_Guitares.ToList() : new List<GUITARE>();
    }

    private static async Task<GUITARE> On_Get_Guitares_By_Id(IBASE_GUITARE P_Base,[FromRoute] int id) {
        return await P_Base.Get_Guitare_By_Id(id);
    }

    private static async Task<Results<Ok<GUITARE>,NotFound>> On_Delete_Guitares(IBASE_GUITARE P_Base,[FromRoute] int id) {
        var result = await P_Base.Delete_Guitare(id);
        if(result > 0) {
            return TypedResults.Ok(new GUITARE { idGuitare = id });
        }
        else {
            return TypedResults.NotFound();
        }
    }

    private static async Task<GUITARE> On_Add_Guitare(IBASE_GUITARE P_Base,
                                        [FromBody] GUITARE P_Info) {
        return await P_Base.Add_Guitare((decimal)P_Info.prixTotal,P_Info.idMicroBridge,P_Info.idMicroCentral,P_Info.idBoisManche,
                                P_Info.idBoisTouche,P_Info.idUtilisateur,P_Info.idMicroNeck,P_Info.idVibrato,P_Info.idBoisCorps);
    }
    
private static async Task<GUITARE> Update_Guitares(IBASE_GUITARE P_Base,
                                        [FromBody] GUITARE P_Info) {
        return await P_Base.Update_Guitare(P_Info.idGuitare,(decimal)P_Info.prixTotal,P_Info.idMicroBridge,P_Info.idMicroCentral,
            P_Info.idBoisManche,P_Info.idBoisTouche,P_Info.idUtilisateur,P_Info.idMicroNeck,P_Info.idVibrato,P_Info.idBoisCorps);
    }
}
