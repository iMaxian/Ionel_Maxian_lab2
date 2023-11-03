﻿using System.ComponentModel.DataAnnotations;

namespace Ionel_Maxian_lab2.Models
{
    public class Author
    {
        public int ID { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        // public string FullName => $"{FirstName} {LastName}";
        [Display(Name = "Full Name")] 
        public string FullName 
        { get 
            { 
                return FirstName + " " + LastName; 
            } 
        }
        public ICollection<Book>? Books { get; set; }


    }
}
