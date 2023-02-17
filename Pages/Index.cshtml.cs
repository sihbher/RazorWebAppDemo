using DispatcherWebApp.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;

namespace DispatcherWebApp.Pages;

public class IndexModel : PageModel
{
    private readonly ILogger<IndexModel> _logger;
    private readonly OrdersDbContext _context;
    public IList<OrdersEntity> Order { get; set; } = default!;

    // [BindProperty(SupportsGet = true)]
    // public string? SearchString { get; set; }

    // public SelectList? Genres { get; set; }

    // [BindProperty(SupportsGet = true)]
    // public string? MovieGenre { get; set; }



    public IndexModel(ILogger<IndexModel> logger, OrdersDbContext context)
    {
        _logger = logger;
        _context = context;
    }



    public async Task OnGetAsync()
    {
        try
        {
            if (_context.Orders != null)
            {
                Order = await _context.Orders.ToListAsync();
            }
        }
        catch (Exception ex)
        {
            Console.WriteLine(ex.Message);
        }
    }
}
