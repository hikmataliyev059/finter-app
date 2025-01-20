using finter_app.DAL.Context;
using finter_app.ViewModels;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace finter_app.Controllers;

public class HomeController : Controller
{
    private readonly AppDbContext _context;

    public HomeController(AppDbContext context)
    {
        _context = context;
    }

    public async Task<IActionResult> Index()
    {
        var agent = await _context.Agents.ToListAsync();
        var position = await _context.Positions.ToListAsync();

        HomeVm vm = new HomeVm()
        {
            Agents = agent,
            Positions = position,
        };
        return View(vm);
    }
}
