﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProiectDAW.DTOs
{
    public class BookDetailsResponseDTO : BookUploadsResponseDTO
    {
        public double MeanRating { get; set; }

        public double RatingCount { get; set; }
    }
}
