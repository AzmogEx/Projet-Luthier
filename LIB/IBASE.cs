using System;
using System.Collections.Generic;
using System.Data.SqlTypes;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LIB;
public class GUITARE {
    public int idGuitare { get; set; }
    public SqlMoney prixTotal { get; set; }
    public int idMicroBridge { get; set; }
    public int idMicroCentral { get; set; }
    public int idBoisManche { get; set; }
    public int idBoisTouche { get; set; }
    public int idUtilisateur { get; set; }
    public int idMicroNeck { get; set; }
    public int idVibrato { get; set; }
    public int idBoisCorps { get; set; }
}

public interface IBASE_GUITARE {
    Task<GUITARE> Add_Guitare(decimal prixTotal,int idMicroBridge,int idMicroCentral,int idBoisManche,int idBoisTouche,
        int idUtilisateur,int idMicroNeck,int idVibrato,int idBoisCorps);
    Task<int> Delete_Guitare(int idGuitare);
    Task<GUITARE[]> Get_All_Guitare();
    Task<GUITARE> Get_Guitare_By_Id(int P_Id);
    Task<GUITARE> Update_Guitare(int idGuitare,decimal prixTotal,int idMicroBridge,int idMicroCentral,int idBoisManche,
        int idBoisTouche,int idUtilisateur,int idMicroNeck,int idVibrato,int idBoisCorps);
}