using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Net.Http;
using System.Runtime.InteropServices;
using System.Threading.Tasks;
using System.Web;
using EXAMEN_FINAL.DAL;
using EXAMEN_FINAL.Models;
using Newtonsoft.Json;

namespace EXAMEN_FINAL.Services.Repository
{
    public abstract class GenericRepository<T> : IGenericRepository<T> where T : class
    {
        public JugadorContext _context = null;
        public DbSet<T> table = null ;

      

        public GenericRepository()
        {
            this._context = new JugadorContext();
            table = _context.Set<T>();
        }

        public GenericRepository(JugadorContext context)
        {
            this._context = context;
            table = _context.Set<T>();
        }



        public virtual async Task<IEnumerable<T>> GetAll()
        {
            return await table.ToListAsync();
        }

        public virtual async Task<T> GetById(object id)
        {
            return await table.FindAsync(id);
        }

        public virtual void Insert(T obj)
        {
            table.Add(obj);
        }

        public virtual void Update(T obj)
        {
            table.Attach(obj);
            _context.Entry(obj).State = EntityState.Modified;
        }

        public virtual async Task Delete(object id)
        {
            T existing = await table.FindAsync(id);
            table.Remove(existing);
        }

        public virtual async Task Save()
        {
            await _context.SaveChangesAsync();
        }

       
        public virtual async Task<IEnumerable<Jugador>> ListaJugadores()
        {
            return await _context.Jugador.ToListAsync();
        }

        public abstract Task DatosApi();

    }


}