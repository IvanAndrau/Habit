using HabitTracker.Database;
using Microsoft.AspNetCore.Http.HttpResults;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace HabitTracker.Controllers;

[ApiController]
[Route("api/[controller]")]

public class HabitController : ControllerBase
{
    private readonly HabitTrackerDbContext _context;

    public HabitController(HabitTrackerDbContext context)
    {
        _context = context;
    }

    //[HttpGet("route")]
    //public async Task<IActionResult> GetHabitsAsync()
    //{
    //    var variable = await _context.Habits.ToListAsync();
    //    return Ok(variable);
    //}
}
