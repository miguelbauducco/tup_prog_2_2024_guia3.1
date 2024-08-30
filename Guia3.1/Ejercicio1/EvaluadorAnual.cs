using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio1
{
    public class EvaluadorAnual:Evaluador
    {

        public double TasaDepreciacion {  get; set; }



        public EvaluadorAnual(Moto vehiculo, int añoACalcular, double tasaDepreciacion) : base(vehiculo, añoACalcular) 
        {
        
            TasaDepreciacion = tasaDepreciacion;
        
        }

        public override double CalcularDepreciacion()
        {

            return Vehiculo.ValorFabricacion * (Math.Pow(1 - TasaDepreciacion, AñoACalcular - Vehiculo.Modelo));
            
        }

        public override string VerDescripcion()
        {
            return $"{base.VerDescripcion()}" +
                $"Evaluacion Anual, monto: {CalcularDepreciacion()}";
        }

    }
}
