﻿using System;
using System.Collections.Generic;
using System.Text;

namespace BlazorAppVS.Shared.Entities
{
    public class GenderMovie
    {
        public int MovieId { get; set; }
        public int GenderId { get; set; }
        public Gender Gender { get; set; }
        public Movie Movie { get; set; }
    }
}
