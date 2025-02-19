﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BulkyWebRazor_Temp.Data;
using BulkyWebRazor_Temp.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace BulkyWebRazor_Temp.Pages.Categories
{
    [BindProperties]
    public class DeleteModel : PageModel
    {
        private readonly ApplicationDbContext _db;

        public Category Category { get; set; }
        public DeleteModel(ApplicationDbContext db)
        {
            _db = db;
        }
        public IActionResult OnGet(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            Category = _db.Categories.Find(id);

            if (Category == null)
            {
                return NotFound();
            }

            return Page();
        }


        public IActionResult OnPost(int? id)
        {
            Category? obj = _db.Categories.Find(id);

            if (obj == null)
            {
                return NotFound();
            }

            var category = _db.Categories.Find(id);

            if (category == null)
            {
                return NotFound();
            }

            _db.Categories.Remove(category);
            _db.SaveChanges();
            TempData["success"] = "Category DELETED!";
            return RedirectToPage("/Categories/Index");
        }
    }
}
