﻿using System.ComponentModel.DataAnnotations;

namespace eTickets.Models
{
    public class Producer
    {
        [Key]
        public int ID { get; set; }
        public string ProfilePictureURL { get; set; }
        public string FullNAme { get; set; }
        public string Bio { get; set; }
    }
}
