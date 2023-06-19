using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Hilfe.Data;
using Hilfe.Models;

namespace Hilfe.Pages.Issues
{
    public class DetailModel : PageModel
    {
        private readonly IssueDbContext _context;
        public DetailModel(IssueDbContext context) => _context = context;
        public async void OnGet(uint id)
        {
            Issue = await _context.Issues.FindAsync(id);
        }

        public Issue? Issue { get; private set;}
    }
}
