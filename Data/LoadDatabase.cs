using Microsoft.AspNetCore.Identity;
using NetKubernetes.Models;

namespace NetKubernetes.Data;

public class LoadDatabase{
    public static async Task InsertarData(AppDbContext context, UserManager<Usuario> usuarioManager){
        if(!usuarioManager.Users.Any()){
            var usuario = new Usuario{
                Nombre = "Charly",
                Apellido = "Tlelo",
                Email = "ctlelo@aaacesa.com.mx",
                UserName = "cTlelo",
                Telefono = "5619404518"
            };

            await usuarioManager.CreateAsync(usuario, "Password123456@");
        }

        if(!context.Inmuebles!.Any())
        {
            context.Inmuebles!.AddRange(
                new Inmueble{
                    Nombre = "Casa de playa",
                    Direccion = "Av. El sol 32",
                    Precio = 450M,
                    FechaCreacion = DateTime.Now
                },

                 new Inmueble{
                    Nombre = "Casa de Invierno",
                    Direccion = "Av. La roca 101",
                    Precio = 250M,
                    FechaCreacion = DateTime.Now
                }
            );
        }

        context.SaveChanges();
    }
}