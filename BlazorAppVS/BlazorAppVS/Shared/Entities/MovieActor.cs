using System;
using System.Collections.Generic;
using System.Text;

namespace BlazorAppVS.Shared.Entities
{
    public class MovieActor
    {
        public int PeopleId { get; set; }
        public int MovieId { get; set; }
        public People People { get; set; }
        public Movie Movie { get; set; }
        public string Personaje { get; set; }
        public int Orden { get; set; }
    }
}
