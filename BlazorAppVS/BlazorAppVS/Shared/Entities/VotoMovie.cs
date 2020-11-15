using System;
using System.Collections.Generic;
using System.Text;

namespace BlazorAppVS.Shared.Entities
{
    public class VotoMovie
    {
        public int Id { get; set; }
        public int Voto { get; set; }
        public DateTime FechaVoto { get; set; }
        public int MovieId { get; set; }
        public Movie Movie { get; set; }
    }
}
