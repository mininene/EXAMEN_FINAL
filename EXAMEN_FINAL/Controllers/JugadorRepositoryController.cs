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
using EXAMEN_FINAL.Services.Repository.JugadoresRepository;

namespace EXAMEN_FINAL.Controllers
{
    public class JugadorRepositoryController : BaseController
    {
        private IJugadorRepository repositorio = null;

        public JugadorRepositoryController()
        {
            this.repositorio = new JugadorRepository();
        }

        public JugadorRepositoryController(IJugadorRepository repositorio)
        {
            this.repositorio = repositorio;
        }




        // GET: JugadorRepository
        public async Task<ActionResult> Index()
        {
            await repositorio.DatosApi();
            return View(await repositorio.GetAll());
        }

        // GET: JugadorRepository/Details/5
        public async Task<ActionResult> Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Jugador jugador = await repositorio.GetById(id);
            if (jugador == null)
            {
                return HttpNotFound();
            }
            return View(jugador);
        }

        // GET: JugadorRepository/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: JugadorRepository/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> Create([Bind(Include = "Id,NombreJugador,Valoracion,Pais,Dorsal")] Jugador jugador)
        {
            if (ModelState.IsValid)
            {
                repositorio.Insert(jugador);
                await repositorio.Save();
                return RedirectToAction("Index");
            }

            return View(jugador);
        }

        // GET: JugadorRepository/Edit/5
        public async Task<ActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Jugador jugador = await repositorio.GetById(id);
            if (jugador == null)
            {
                return HttpNotFound();
            }
            return View(jugador);
        }

        // POST: JugadorRepository/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> Edit([Bind(Include = "Id,NombreJugador,Valoracion,Pais,Dorsal")] Jugador jugador)
        {
            if (ModelState.IsValid)
            {
                repositorio.Update(jugador);
                await repositorio.Save();
                return RedirectToAction("Index");
            }
            return View(jugador);
        }

        // GET: JugadorRepository/Delete/5
        public async Task<ActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }

            Jugador jugador = await repositorio.GetById(id);
            if (jugador == null)
            {
                return HttpNotFound();
            }
            return View(jugador);
        }

        // POST: JugadorRepository/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> DeleteConfirmed(int id)
        {
            Jugador jugador = await repositorio.GetById(id);
            await repositorio.Delete(id);
            await repositorio.Save();
            return RedirectToAction("Index");
        }

     
    }
}
