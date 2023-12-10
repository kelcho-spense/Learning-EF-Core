using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using ecommerceMSASP.NETCORE.Data;
using ecommerceMSASP.NETCORE.Models;

namespace ecommerceMSASP.NETCORE.Pages.Products
{
    public class CreateModel : PageModel
    {
        private readonly ecommerceMSASP.NETCORE.Data.EcommercedbContext _context;

        public CreateModel(ecommerceMSASP.NETCORE.Data.EcommercedbContext context)
        {
            _context = context;
        }

        public IActionResult OnGet()
        {
            return Page();
        }

        [BindProperty]
        public Product Product { get; set; } = default!;

        // To protect from overposting attacks, see https://aka.ms/RazorPagesCRUD
        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            _context.Products.Add(Product);
            await _context.SaveChangesAsync();

            return RedirectToPage("./Index");
        }
    }
}
