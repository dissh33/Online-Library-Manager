﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Library.Data.Models
{
    public class Patron
    {
        public int Id { get; set; }

        [Required]
        [Display(Name = "First Name")]
        [StringLength(30, ErrorMessage = "Limit first name to 30 characters.")]
        public string FirstName { get; set; }

        [Required]
        [Display(Name = "Last Name")]
        [StringLength(30, ErrorMessage = "Limit last name to 30 characters.")]
        public string LastName { get; set; }

        [Required]
        [StringLength(150)]
        public string Address { get; set; }

        [Required] 
        public DateTime DateOfBirth { get; set; }

        [StringLength(20)]
        public string Telephone { get; set; }

        [Required]
        [Display(Name = "Library Card")]
        public LibraryCard LibraryCard { get; set; }
        public LibraryBranch HomeLibraryBranch { get; set; }
    }
}
