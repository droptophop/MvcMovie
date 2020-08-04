using System;
using System.ComponentModel.DataAnnotations;

namespace MvcMovie.Models
{
    public class Movie
    {
        [Required]
        public int id { get; set; }
        [Required]
        public string title { get; set; }
        [DataType(DataType.Date)]
        public DateTime ReleaseDate { get; set; }
        public string genre { get; set; }
        [Required]
        public decimal price { get; set; }
    }
}