using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SampleWebDotNetCore.Models
{
    public class Film
    {
         private InfyContext context;

        public int FilmId { get; set; }

        public string Title { get; set; }

        public string Description { get; set; }

        public int ReleaseYear { get; set; }

        public int Length { get; set; }

        public string Rating { get; set; }
    }
}

