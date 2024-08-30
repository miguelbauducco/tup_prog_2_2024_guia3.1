using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio1
{
    public abstract class Evaluador
    {
        public int AñoACalcular
        {
            get
            {
                return añoACalcular;
            }

        }

        protected int añoACalcular;

        public Moto vehiculo;
        public Moto Vehiculo
        {
            get
            {
                return vehiculo;
            }
        }



        public Evaluador(Moto vehiculo, int añoACalcular)
        {

            this.vehiculo = vehiculo;
           
        }

        public abstract double CalcularDepreciacion();

        public virtual string VerDescripcion()
        {

            return $"Vehiculo: {Vehiculo.VerDescripcion()}";

        }

    }
}
