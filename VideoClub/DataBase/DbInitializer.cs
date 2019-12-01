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

            var amarillo = new Categoria()
            {
                Id = Guid.NewGuid(),
                Disenio = "yellow",
                DiasDeAlquiler = 7,
                Precio = 100,
                Descripcion = "Estreno"
            };

            var titanic = new Pelicula()
            {
                Id = Guid.NewGuid(),
                Titulo = "Titanic",
                AnioLanzamiento = 1994,
                Duracion = 190,
                Stock = 5,
                Categoria = amarillo
            };

            context.Peliculas.Add(titanic);
            context.Categorias.Add(amarillo);
            context.SaveChanges();
        }
    }
}
