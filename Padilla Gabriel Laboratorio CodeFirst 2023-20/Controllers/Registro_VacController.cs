using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using Padilla_Gabriel_Laboratorio_CodeFirst_2023_20.Data;
using Padilla_Gabriel_Laboratorio_CodeFirst_2023_20.Models;

namespace Padilla_Gabriel_Laboratorio_CodeFirst_2023_20.Controllers
{
    public class Registro_VacController : Controller
    {
        private readonly Padilla_Gabriel_Laboratorio_CodeFirst_2023_20Context _context;

        public Registro_VacController(Padilla_Gabriel_Laboratorio_CodeFirst_2023_20Context context)
        {
            _context = context;
        }

        // GET: Registro_Vac
        public async Task<IActionResult> Index()
        {
            return View(await _context.Registro_VacModel.ToListAsync());
        }

        // GET: Registro_Vac/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var registro_VacModel = await _context.Registro_VacModel
                .FirstOrDefaultAsync(m => m.Id == id);
            if (registro_VacModel == null)
            {
                return NotFound();
            }

            return View(registro_VacModel);
        }

        // GET: Registro_Vac/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Registro_Vac/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,FechaVacunacion")] Registro_VacModel registro_VacModel)
        {
            if (ModelState.IsValid)
            {
                _context.Add(registro_VacModel);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(registro_VacModel);
        }

        // GET: Registro_Vac/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var registro_VacModel = await _context.Registro_VacModel.FindAsync(id);
            if (registro_VacModel == null)
            {
                return NotFound();
            }
            return View(registro_VacModel);
        }

        // POST: Registro_Vac/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,FechaVacunacion")] Registro_VacModel registro_VacModel)
        {
            if (id != registro_VacModel.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(registro_VacModel);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!Registro_VacModelExists(registro_VacModel.Id))
                    {
                        return NotFound();
                    }
                    else
                    {
                        throw;
                    }
                }
                return RedirectToAction(nameof(Index));
            }
            return View(registro_VacModel);
        }

        // GET: Registro_Vac/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var registro_VacModel = await _context.Registro_VacModel
                .FirstOrDefaultAsync(m => m.Id == id);
            if (registro_VacModel == null)
            {
                return NotFound();
            }

            return View(registro_VacModel);
        }

        // POST: Registro_Vac/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var registro_VacModel = await _context.Registro_VacModel.FindAsync(id);
            if (registro_VacModel != null)
            {
                _context.Registro_VacModel.Remove(registro_VacModel);
            }

            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool Registro_VacModelExists(int id)
        {
            return _context.Registro_VacModel.Any(e => e.Id == id);
        }
    }
}
