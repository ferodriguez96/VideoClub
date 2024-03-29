﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace VideoClub.Models
{
    public class Genero
    {
        [Key]
        public Guid Id { get; set; }

        [Required]
        [MaxLength(50)]
        [Display(Name = "Descripción")]
        public string Descripcion { get; set; }

        public virtual ICollection<PeliculaGenero> PeliculasGeneros { get; set; }
    }
}
