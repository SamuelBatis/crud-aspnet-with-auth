using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using crud_aspnet_with_auth.Data;
using crud_aspnet_with_auth.Models;

namespace crud_aspnet_with_auth.Pages_Premiums
{
    public class IndexModel : PageModel
    {
        private readonly crud_aspnet_with_auth.Data.ApplicationDbContext _context;

        public IndexModel(crud_aspnet_with_auth.Data.ApplicationDbContext context)
        {
            _context = context;
        }

        public IList<Premium> Premium { get;set; } = default!;

        public async Task OnGetAsync()
        {
            Premium = await _context.Premiums.ToListAsync();
        }
    }
}
