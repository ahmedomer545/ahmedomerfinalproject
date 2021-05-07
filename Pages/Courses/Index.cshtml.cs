using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using ahmedomerfinalproject.Models;

namespace ahmedomerfinalproject.Pages.Courses
{
    public class IndexModel : PageModel
    {
        private readonly ahmedomerfinalproject.Models.CourseContext _context;

        public IndexModel(ahmedomerfinalproject.Models.CourseContext context)
        {
            _context = context;
        }

        public IList<Course> Course { get;set; }

        public async Task OnGetAsync()
        {
            Course = await _context.Course.ToListAsync();
        }
    }
}
