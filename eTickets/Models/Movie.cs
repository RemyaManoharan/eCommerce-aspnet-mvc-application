﻿using eTickets.Data;
using System.ComponentModel.DataAnnotations;

namespace eTickets.Models
{
    public class Movie
    {
        [Key]
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public string ImageUrl { get; set; }
        public double Price { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
        public string Title { get; set; }
        public MovieCategory MovieCategory { get; set; }

    }
}
