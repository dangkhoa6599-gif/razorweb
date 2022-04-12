using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using newapp2.Models;

namespace newapp2.Pages.Students
{
    public class IndexModel : PageModel
    {
        private readonly newapp2.Data.SchoolContext _context;

        public IndexModel(newapp2.Data.SchoolContext context)
        {
            _context = context;
        }

        public IList<Student> Student { get;set; }

        public async Task OnGetAsync()
        {
            Student = await _context.Students.ToListAsync();
        }
    }
}
