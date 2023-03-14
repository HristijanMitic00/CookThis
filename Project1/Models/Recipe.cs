using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Project1.Models
{
    public class Recipe
    {
        [Key]
        [Required]
        public int Id { get; set; }

        [Required]
        public string Name { get; set; }
        [Required]
        public string Ingridients { get; set; }
        [Required]
        public string Preparation { get; set; }
        public string RecipeLink { get; set; }
        public string Image { get; set; }
        [Range(1, 10, ErrorMessage = "Number between 1 and 10, 1 - easiest, 10 - hardest")]
        [Required]
        public int Difficulty { get; set; }
    }
}