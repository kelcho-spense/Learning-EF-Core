using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using ecommerceMSASP.NETCORE.Data;
using ecommerceMSASP.NETCORE.Models;

namespace ecommerceMSASP.NETCORE.Pages.Orders
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
        ViewData["CustomerId"] = new SelectList(_context.Customers, "Id", "Id");
            return Page();
        }

        [BindProperty]
        public Order Order { get; set; } = default!;

        // To protect from overposting attacks, see https://aka.ms/RazorPagesCRUD
        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            _context.Orders.Add(Order);
            await _context.SaveChangesAsync();

            return RedirectToPage("./Index");
        }
    }
}
