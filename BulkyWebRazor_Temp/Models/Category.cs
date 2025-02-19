﻿using System;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace BulkyWebRazor_Temp.Models
{
    public class Category
    {
        // Primary key attribute for Category Model: Id property
        [Key]
        public int Id { get; set; }

        /**
         * Required attribute to ensure the Name property is not null or empty
         * The DisplayName helps display the string to be shown
         */
        [Required]
        [MaxLength(30)]
        [DisplayName("Category Name")]
        public string Name { get; set; }

        [DisplayName("Display Order")]
        [Range(1, 100, ErrorMessage = "Display Order must be between 1-100")]
        public int DisplayOrder { get; set; }

        // Default Constructor
        public Category()
        {
        }
    }
}

