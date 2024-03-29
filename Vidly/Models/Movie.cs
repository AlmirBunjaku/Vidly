﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Vidly.Models
{
    public class Movie
    {
        public int Id { get; set; }
        [Required]
        public string Name { get; set; }
        [Required]
        [Display(Name = "Release Date")]
        public DateTime ReleaseDate { get; set; } = DateTime.Parse("1 Jan 0001");
        [Required]
        public DateTime DateAdded { get; set; }
        [Required]
        [Range(1, 20, ErrorMessage = "Number in stock must be between 1 and 20.")]
        [Display(Name = "Number in Stock")]
        public Byte NumberInStock { get; set; } = 0;
        public Genre Genre { get; set; }

        [Required]
        [Display(Name = "Genre")]
        public byte GenreId { get; set; }
    }
}