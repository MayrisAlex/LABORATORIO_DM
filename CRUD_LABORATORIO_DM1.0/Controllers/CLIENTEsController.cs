using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using CRUD_LABORATORIO_DM1._0.Data;
using CRUD_LABORATORIO_DM1._0.Models;
using Microsoft.AspNetCore.Authorization;

namespace CRUD_LABORATORIO_DM1._0.Controllers
{
    [Authorize]
    public class CLIENTEsController : Controller
    {
        private readonly ApplicationDbContext _context;

        public CLIENTEsController(ApplicationDbContext context)
        {
            _context = context;
        }
        [Authorize(Roles = "Admi,User")]
        // GET: CLIENTEs
        public async Task<IActionResult> Index()
        {
            return View(await _context.CLIENTE.ToListAsync());
        }
        [Authorize(Roles = "Admi")]
        // GET: CLIENTEs/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var cLIENTE = await _context.CLIENTE
                .FirstOrDefaultAsync(m => m.ID_CLIENTE == id);
            if (cLIENTE == null)
            {
                return NotFound();
            }

            return View(cLIENTE);
        }
        [Authorize(Roles = "Admi")]


        
   
        // GET: CLIENTEs/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: CLIENTEs/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("ID_CLIENTE,CEDULA,NOMBRE,APELLIDO,EMAIL,TELEFONO,DIRECCION,USUARIO,DESCRIPCION_SERVICIO,FECHA_RECEPCION,FECHA_ENTREGA,OBSERVACIONES")] CLIENTE cLIENTE)
        {
            if (ModelState.IsValid)
            {
                _context.Add(cLIENTE);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(cLIENTE);
        }
        [Authorize(Roles = "Admi")]

        // GET: CLIENTEs/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var cLIENTE = await _context.CLIENTE.FindAsync(id);
            if (cLIENTE == null)
            {
                return NotFound();
            }
            return View(cLIENTE);
        }

        // POST: CLIENTEs/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        [Authorize(Roles = "Admi")]
        public async Task<IActionResult> Edit(int id, [Bind("ID_CLIENTE,CEDULA,NOMBRE,APELLIDO,EMAIL,TELEFONO,DIRECCION,USUARIO,DESCRIPCION_SERVICIO,FECHA_RECEPCION,FECHA_ENTREGA,OBSERVACIONES")] CLIENTE cLIENTE)
        {
            if (id != cLIENTE.ID_CLIENTE)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(cLIENTE);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!CLIENTEExists(cLIENTE.ID_CLIENTE))
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
            return View(cLIENTE);
        }
        [Authorize(Roles = "Admi")]
        // GET: CLIENTEs/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var cLIENTE = await _context.CLIENTE
                .FirstOrDefaultAsync(m => m.ID_CLIENTE == id);
            if (cLIENTE == null)
            {
                return NotFound();
            }

            return View(cLIENTE);
        }
        [Authorize(Roles = "Admi")]

        // POST: CLIENTEs/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
    
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var cLIENTE = await _context.CLIENTE.FindAsync(id);
            _context.CLIENTE.Remove(cLIENTE);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool CLIENTEExists(int id)
        {
            return _context.CLIENTE.Any(e => e.ID_CLIENTE == id);
        }
    }
}
