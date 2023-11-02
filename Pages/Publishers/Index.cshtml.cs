﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using Ionel_Maxian_lab2.Data;
using Ionel_Maxian_lab2.Models;

namespace Ionel_Maxian_lab2.Pages.Publishers
{
    public class IndexModel : PageModel
    {
        private readonly Ionel_Maxian_lab2.Data.Ionel_Maxian_lab2Context _context;

        public IndexModel(Ionel_Maxian_lab2.Data.Ionel_Maxian_lab2Context context)
        {
            _context = context;
        }

        public IList<Publisher> Publisher { get;set; } = default!;

        public async Task OnGetAsync()
        {
            if (_context.Publisher != null)
            {
                Publisher = await _context.Publisher.ToListAsync();
            }
        }
    }
}
