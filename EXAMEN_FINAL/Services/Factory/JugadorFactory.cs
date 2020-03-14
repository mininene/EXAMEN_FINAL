using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Diagnostics.Eventing.Reader;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Antlr.Runtime;
using EXAMEN_FINAL.Models;
using EXAMEN_FINAL.Services.Repository;
using EXAMEN_FINAL.Services.Specification;

namespace EXAMEN_FINAL.Services.Factory
{
    public class JugadorFactory: IJugadorFactory
    {

        private Jugador _jugador;
        private IValidationRegisterSpecification _validationRegisterSpecification = new ValidationRegisterSpecification();
        private List<Jugador> ListajugadorValido= new List<Jugador>();
        private List<Jugador> ListajugadorInvalido= new List<Jugador>();
        //private IValidationRegisterSpecification _validationRegisterSpecification1;

        //public JugadorFactory(IValidationRegisterSpecification validationRegisterSpecification1)
        //{
        //    _validationRegisterSpecification1 = validationRegisterSpecification1;
        //}

        public List<Jugador> CreateJugador(List<Jugador> jugador)
        {
            try
            {

                foreach (var item in jugador)
                {
                    //_jugador = new Jugador();
                    if (_validationRegisterSpecification.IsSatisfiedBy(item) == true)
                    {
                        ListajugadorValido.Add(item);
                    }
                    else { /*throw new FactoryException("No se ha podido crear el objeto ");*/ }

                }
               
                

            }
            catch (Exception ex)
            {
                /*throw new FactoryException("No se ha podido crear el objeto de rebelde", ex)*/;
            }
            return ListajugadorValido;

        }

       


    }
}