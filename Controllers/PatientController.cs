using Microsoft.AspNetCore.Mvc;
using MedicalDirectiveSystem.Models;
using Microsoft.EntityFrameworkCore;

namespace MedicalDirectiveSystem.Controllers
{
    public class PatientController : Controller
    {
        private readonly MedicalDirectiveContext _context;

        public PatientController(MedicalDirectiveContext context)
        {
            _context = context;
        }

        // GET: Patient/List
        public async Task<IActionResult> List() //list()為病患列表
        {
            var patients = await _context.Patients.ToListAsync();
            return View(patients);
        }

        // GET: Patient/Create
        public IActionResult Create() //create()為新增病患
        {
            return View();
        }

        // POST: Patient/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create(Patient patient) //post create()資料後寫入Datqabase
        {
            if (ModelState.IsValid)
            {
                _context.Add(patient);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(List));
            }
            return View(patient);
        }
    }
}
