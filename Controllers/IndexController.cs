// using System.Data.SqlClient;
// using DispatcherWebApp.Models;
// //using System.Web.Mvc;
// using Microsoft.AspNetCore.Mvc;
// using Microsoft.EntityFrameworkCore;

// public class IndexController : Controller
// {
//     private readonly OrdersDbContext _context;

//     public IndexController(OrdersDbContext context)
//     {
//         _context = context;
//     }

//     // GET: Orders
//     public IActionResult Index()
//     {
//         List<Orders> orders = _context.Orders.ToList();
//         return View("Index",orders);
//     }

//     // GET: Orders/Details/5
//     public IActionResult Details(int? idPlant, int? idOrder)
//     {
//         if (idPlant == null || idOrder == null)
//         {
//             return NotFound();
//         }

//         Orders order = _context.Orders
//             .FirstOrDefault(m => m.IDPlant == idPlant && m.IDOrder == idOrder);
//         if (order == null)
//         {
//             return NotFound();
//         }

//         return View(order);
//     }

//     // GET: Orders/Create
//     public IActionResult Create()
//     {
//         return View();
//     }

//     // POST: Orders/Create
//     [HttpPost]
//     [ValidateAntiForgeryToken]
//     public IActionResult Create([Bind("IDPlant,IDOrder,Amount,Price,Dispatched,CreatedTimeStamp,LastUpdatedTimeStamp")] Orders order)
//     {
//         if (ModelState.IsValid)
//         {
//             _context.Add(order);
//             _context.SaveChanges();
//             return RedirectToAction(nameof(Index));
//         }
//         return View(order);
//     }


//     // GET: Orders/Edit/5
//     public IActionResult Edit(int? idPlant, int? idOrder)
//     {
//         if (idPlant == null || idOrder == null)
//         {
//             return NotFound();
//         }

//         Orders order = _context.Orders
//             .FirstOrDefault(m => m.IDPlant == idPlant && m.IDOrder == idOrder);
//         if (order == null)
//         {
//             return NotFound();
//         }

//         return View(order);
//     }

//     // POST: Orders/Edit/5
//     [HttpPost]
//     [ValidateAntiForgeryToken]
//     public IActionResult Edit(int idPlant, int idOrder, [Bind("IDPlant,IDOrder,Amount,Price,Dispatched,CreatedTimeStamp,LastUpdatedTimeStamp")] Orders order)
//     {
//         if (idPlant != order.IDPlant || idOrder != order.IDOrder)
//         {
//             return NotFound();
//         }

//         if (ModelState.IsValid)
//         {
//             try
//             {
//                 _context.Update(order);
//                 _context.SaveChanges();
//             }
//             catch (DbUpdateConcurrencyException)
//             {
//                 if (!OrderExists(order.IDPlant, order.IDOrder))
//                 {
//                     return NotFound();
//                 }
//                 else
//                 {
//                     throw;
//                 }
//             }
//             return RedirectToAction(nameof(Index));
//         }
//         return View(order);
//     }

//     // GET: Orders/Delete/5
//     public IActionResult Delete(int? idPlant, int? idOrder)
//     {
//         if (idPlant == null || idOrder == null)
//         {
//             return NotFound();
//         }

//         Orders order = _context.Orders
//             .FirstOrDefault(m => m.IDPlant == idPlant && m.IDOrder == idOrder);
//         if (order == null)
//         {
//             return NotFound();
//         }

//         return View(order);
//     }

//     // POST: Orders/Delete/5
//     [HttpPost, ActionName("Delete")]
//     [ValidateAntiForgeryToken]
//     public IActionResult DeleteConfirmed(int idPlant, int idOrder)
//     {
//         Orders order = _context.Orders
//             .FirstOrDefault(m => m.IDPlant == idPlant && m.IDOrder == idOrder);
//         _context.Orders.Remove(order);
//         _context.SaveChanges();
//         return RedirectToAction(nameof(Index));
//     }

//     private bool OrderExists(int idPlant, int idOrder)
//     {
//         return _context.Orders.Any(m => m.IDPlant == idPlant && m.IDOrder == idOrder);
//     }


// }
