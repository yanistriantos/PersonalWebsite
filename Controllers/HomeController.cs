using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using PersonalWebsite.Data;
using PersonalWebsite.Models;

namespace PersonalWebsite.Controllers;

public class HomeController : Controller
{
    private readonly ApplicationDbContext _context;

    public HomeController(ApplicationDbContext context)
    {
        _context = context;
    }

    public IActionResult Index()
    {
        return View();
    } 

    public IActionResult Privacy()
    {
        return View();
    }

    [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
    public IActionResult Error()
    {
        return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
    }

    public IActionResult About()
    {
        return View();
    }

    public IActionResult Contact()
    {
        return View();
    }

    public IActionResult Services()
    {
        return View();
    }

    public IActionResult Downloads()
    {
        return View();
    }

    public IActionResult Comments(string sortBy = "date", string order = "newest")
    {
        try
        {
            IQueryable<Comment> comments = _context.Comments;

            // Sort by date (newest/oldest)
            if (sortBy == "date")
            {
                comments = order == "newest" 
                    ? comments.OrderByDescending(c => c.CreatedDate).ThenBy(c => c.Username)
                    : comments.OrderBy(c => c.CreatedDate).ThenBy(c => c.Username);
            }
            // Sort by username (A-Z or Z-A)
            else if (sortBy == "username")
            {
                comments = order == "asc" 
                    ? comments.OrderBy(c => c.Username).ThenByDescending(c => c.CreatedDate)
                    : comments.OrderByDescending(c => c.Username).ThenByDescending(c => c.CreatedDate);
            }

            return View(comments.ToList());
        }
        catch (Exception)
        {
            return View(new List<Comment>());
        }
    }

    [HttpPost]
    public IActionResult AddComment(string username, string message)
    {
        if (string.IsNullOrEmpty(username) || string.IsNullOrEmpty(message))
        {
            return BadRequest();
        }

        try
        {
            var comment = new Comment
            {
                Username = username,
                Message = message,
                CreatedDate = DateTime.Now,
                SessionId = HttpContext.Session.Id
            };

            _context.Comments.Add(comment);
            _context.SaveChanges();

            return Ok();
        }
        catch (Exception)
        {
            return StatusCode(500, "Database error. Please make sure the database is set up correctly.");
        }
    }

    [HttpPost]
    public IActionResult EditComment(int id, string message)
    {
        var comment = _context.Comments.Find(id);
        if (comment == null)
        {
            return NotFound();
        }

        comment.Message = message;
        _context.SaveChanges();

        return Ok();
    }

    [HttpPost]
    public IActionResult DeleteComment(int id)
    {
        var comment = _context.Comments.Find(id);
        if (comment == null)
        {
            return NotFound();
        }

        _context.Comments.Remove(comment);
        _context.SaveChanges();

        return Ok();
    }
}
