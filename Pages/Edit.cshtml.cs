using DispatcherWebApp.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;

namespace DispatcherWebApp.Pages;

public class EditModel : PageModel
{
    private readonly ILogger<CreateModel> _logger;
    private readonly OrdersDbContext _context;

    public EditModel(ILogger<CreateModel> logger, OrdersDbContext context)
    {
        _logger = logger;
        _context = context;
    }

    [BindProperty]
    public OrdersEntity Order { get; set; }

    public async Task<IActionResult> OnGetAsync(int? idPlant, int? idOrder)
    {
        if (idPlant == null || idOrder == null)
        {
            return NotFound();
        }

        Order = await _context.Orders.FindAsync(idPlant, idOrder);

        if (Order == null)
        {
            return NotFound();
        }

        return Page();
    }

    public async Task<IActionResult> OnPostAsync()
    {
        if (!ModelState.IsValid)
        {
            return Page();
        }

        _context.Attach(Order).State = EntityState.Modified;

        try
        {
            await _context.SaveChangesAsync();
        }
        catch (DbUpdateConcurrencyException)
        {
            if (!OrderExists(Order.IDPlant, Order.IDOrder))
            {
                return NotFound();
            }
            else
            {
                throw;
            }
        }

        return RedirectToPage("./Details", new { idPlant = Order.IDPlant, idOrder = Order.IDOrder });
    }

    private bool OrderExists(int idPlant, int idOrder)
    {
        return _context.Orders.Any(o => o.IDPlant == idPlant && o.IDOrder == idOrder);
    }

}