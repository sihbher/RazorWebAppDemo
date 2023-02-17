using DispatcherWebApp.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;

namespace DispatcherWebApp.Pages;

public class CreateModel : PageModel
{
    private readonly ILogger<CreateModel> _logger;
    private readonly OrdersDbContext _context;

    public CreateModel(ILogger<CreateModel> logger, OrdersDbContext context)
    {
        _logger = logger;
        _context = context;
    }

    [BindProperty]
    public OrdersEntity Order { get; set; }

    public async Task<IActionResult> OnPostAsync()
    {
        if (!ModelState.IsValid)
        {
            return Page();
        }

        Order.LastUpdatedTimeStamp= DateTime.Now;
        Order.CreatedTimeStamp = DateTime.Now;
       
        _context.Orders.Add(Order);
        await _context.SaveChangesAsync();

        return RedirectToPage("./Index");
    }

}