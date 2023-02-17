using DispatcherWebApp.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;

namespace DispatcherWebApp.Pages;



public class DetailsModel : PageModel
{
    private readonly ILogger<CreateModel> _logger;
    private readonly OrdersDbContext _context;

    public DetailsModel(ILogger<CreateModel> logger,OrdersDbContext context)
    {
        _logger = logger;
        _context = context;
    }

    public OrdersEntity Order { get; set; }

    public async Task<IActionResult> OnGetAsync(int? idPlant, int? idOrder)
    {
        if (idPlant == null || idOrder == null)
        {
            return NotFound();
        }

        Order = await _context.Orders.FirstOrDefaultAsync(m => m.IDPlant == idPlant && m.IDOrder == idOrder);

        if (Order == null)
        {
            return NotFound();
        }

        return Page();
    }
}
