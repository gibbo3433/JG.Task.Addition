using Microsoft.AspNetCore.Mvc;
using JG.Task.Addition.Models;
using JG.Task.Addition.Data;
using System.Threading.Tasks;

namespace JG.Task.Addition.Controllers
{
    [ApiController]

    public class CalculatorController : Controller
    {
        private readonly ApplicationDbContext _context;

        public CalculatorController(ApplicationDbContext context)
        {
            _context = context;
        }
    }
}
