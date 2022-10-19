using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;
using System.Xml.Linq;
using Vidly.Models;

namespace Vidly.DTOs
{
    public class MovieDto
    {
        public int Id { get; set; }

        [Required]
        public string Name { get; set; }

        [Required]
        public DateTime ReleaseDate { get; set; } = DateTime.Parse("1 Jan 0001");

        [Required]
        public DateTime DateAdded { get; set; }

        [Required]
        [Range(1, 20, ErrorMessage = "Number in stock must be between 1 and 20.")]
        public Byte NumberInStock { get; set; } = 0;

        [Required]
        public byte GenreId { get; set; }
    }
}