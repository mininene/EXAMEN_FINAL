using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Threading.Tasks;
using System.Net;
using System.Web;
using System.Web.Mvc;
using EXAMEN_FINAL.DAL;
using EXAMEN_FINAL.Models;

namespace EXAMEN_FINAL.Controllers
{
    public class JugadorController : BaseController
    {
        private JugadorContext db = new JugadorContext();

        // GET: Jugador
        public async Task<ActionResult> Index()
        {
            return View(await db.Jugador.ToListAsync());
        }

        // GET: Jugador/Details/5
        public async Task<ActionResult> Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Jugador jugador = await db.Jugador.FindAsync(id);
            if (jugador == null)
            {
                return HttpNotFound();
            }
            return View(jugador);
        }

        // GET: Jugador/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Jugador/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> Create([Bind(Include = "Id,NombreJugador,Valoracion,Pais,Dorsal")] Jugador jugador)
        {
            if (ModelState.IsValid)
            {
                db.Jugador.Add(jugador);
                await db.SaveChangesAsync();
                return RedirectToAction("Index");
            }

            return View(jugador);
        }

        // GET: Jugador/Edit/5
        public async Task<ActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Jugador jugador = await db.Jugador.FindAsync(id);
            if (jugador == null)
            {
                return HttpNotFound();
            }
            return View(jugador);
        }

        // POST: Jugador/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> Edit([Bind(Include = "Id,NombreJugador,Valoracion,Pais,Dorsal")] Jugador jugador)
        {
            if (ModelState.IsValid)
            {
                db.Entry(jugador).State = EntityState.Modified;
                await db.SaveChangesAsync();
                return RedirectToAction("Index");
            }
            return View(jugador);
        }

        // GET: Jugador/Delete/5
        public async Task<ActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Jugador jugador = await db.Jugador.FindAsync(id);
            if (jugador == null)
            {
                return HttpNotFound();
            }
            return View(jugador);
        }

        // POST: Jugador/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> DeleteConfirmed(int id)
        {
            Jugador jugador = await db.Jugador.FindAsync(id);
            db.Jugador.Remove(jugador);
            await db.SaveChangesAsync();
            return RedirectToAction("Index");
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }
    }
}
