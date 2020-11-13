﻿using System;
using System.Collections.Generic;
using System.Text;

namespace BlazorAppVS.Shared.Entities
{
    public class Movie
    {
        public string Title { get; set; }
        public DateTime ReleaseDate { get; set; }

        public string Poster { get; set; }
        public string TitleCortado
        {
            get
            {
                if (string.IsNullOrWhiteSpace(Title))
                {
                    return null;
                }

                if (Title.Length > 60)
                {
                    return Title.Substring(0, 60) + "...";
                }
                else
                {
                    return Title;
                }
            }
        }

    }
}