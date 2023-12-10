using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using ecommerceMSASP.NETCORE.Data;
using ecommerceMSASP.NETCORE.Models;

namespace ecommerceMSASP.NETCORE.Pages.Products
{
    public class DetailsModel : PageModel
    {
        private readonly ecommerceMSASP.NETCORE.Data.EcommercedbContext _context;

        public DetailsModel(ecommerceMSASP.NETCORE.Data.EcommercedbContext context)
        {
            _context = context;
        }

        public Product Product { get; set; } = default!;

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var product = await _context.Products.FirstOrDefaultAsync(m => m.Id == id);
            if (product == null)
            {
                return NotFound();
            }
            else
            {
                Product = product;
            }
            return Page();
        }
    }
}
