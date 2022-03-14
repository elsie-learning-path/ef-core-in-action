using EF_Core_In_Action.Models;
using Microsoft.AspNetCore.Mvc;

namespace EF_Core_In_Action.Controllers
{

    [ApiController]
    [Route("[controller]")]
    public class BookController : ControllerBase
    {
        private readonly AppDbContext _context;
        public BookController(AppDbContext dbContext)
        {
            _context = dbContext;
        }

        [HttpGet("[Action]")]
        public ActionResult<IEnumerable<Book>> GetList()
        {
            var result = _context.Books.ToList();
            return Ok(result);
        }

        [HttpPost("[Action]")]
        public ActionResult<Book> Add()
        {
            var newBook = new Book()
            {
                Title = "Hello World",
                Description = "Started with EF Core",
                PublishedOn = DateTime.Now,
                Author = new Author()
                {
                    Name = "Elsie",
                    WebUrl = "https://gitlab.com/lngmtri"
                }
            };

            _context.Add(newBook);

            _context.SaveChanges();

            return Ok(newBook);
        }

    }

}
