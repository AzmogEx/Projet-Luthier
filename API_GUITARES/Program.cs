using LIB;
using Scalar.AspNetCore;
using static System.Net.Mime.MediaTypeNames;

namespace API_GUITARES; 
public class Program {
    public static void Main(string[] args) {
        var builder = WebApplication.CreateBuilder(args);

        builder.Services.AddAuthorization();
        builder.Services.AddEndpointsApiExplorer();
        builder.Services.AddControllers().AddControllersAsServices();
        builder.Services.AddSingleton<IBASE_GUITARE,BASE_GUITARE>();


        //builder.Services.AddOpenApi();

        var app = builder.Build();

        //app.MapOpenApi();

        if(app.Environment.IsDevelopment()) {
            app.MapScalarApiReference();
        }

        app.MapGet("/",() => "Hello world!");

        app.UseHttpsRedirection();
        app.UseAuthorization();

        app.Ajoute_Map_Guitare();

        app.Run();
    }
}
