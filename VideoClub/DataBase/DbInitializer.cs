using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using VideoClub.Models;

namespace VideoClub.DataBase
{
    public class DbInitializer
    {
        public static void Initialize(VideoClubDbContext context)
        {
            context.Database.EnsureCreated();
            if (context.Peliculas.Any())
            {
                return;   // DB has been seeded
            }

            byte[] data = System.Text.Encoding.ASCII.GetBytes("123456");
            data = new System.Security.Cryptography.SHA256Managed().ComputeHash(data);

            context.Clientes.Add(new Cliente()
            {
                Id = Guid.NewGuid(),
                Nombre = "rodolfo",
                Apellido = "gomez",
                Dni = "15231521",
                Email = "rgomez@mail.com",
                Password = data,
                Domicilio = "calle falsa 123"
            });

            var verde = new Categoria()
            {
                Id = Guid.NewGuid(),
                Disenio = "green",
                DiasDeAlquiler = 7,
                Precio = 100,
                Descripcion = "Estreno"
            };

            var drama = new Genero()
            {
                Id = Guid.NewGuid(),
                Descripcion = "Drama"
            };

            var titanic = new Pelicula()
            {
                Id = Guid.NewGuid(),
                Titulo = "Titanic",
                AnioLanzamiento = 1994,
                Duracion = 190,
                Stock = 5,
                Categoria = verde
            };
            var a = new PeliculaGenero()
            {
                Id = Guid.NewGuid(),
                Genero = drama,
                Pelicula = titanic
            };

            context.PeliculasGeneros.Add(a);
            titanic.PeliculaGeneros.Add(a);

            context.Peliculas.Add(titanic);
            context.Categorias.Add(verde);
            context.SaveChanges();
        }
    }
}
