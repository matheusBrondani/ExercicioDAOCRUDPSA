﻿using System;
using System.Collections.Generic;
using System.Text;

namespace ExercicioDAOCRUD.PL
{
    class Genre
    {
        public int GenreID { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }

        public ICollection<Movie> Movies { get; set; }
    }
}
