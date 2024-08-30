using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio1
{
    public class EvaluadorLineal:Evaluador
    {

        public int VidaUtil {  get; set; }

        public EvaluadorLineal(Moto vehiculo, int añoACalcular, int vidaUtil) : base(vehiculo, añoACalcular)
        {

            VidaUtil= vidaUtil;
            this.añoACalcular = añoACalcular;

        }

        public override double CalcularDepreciacion()
        {

            int añosUso = AñoACalcular - Vehiculo.Modelo;

            double valor = 0;

            if (VidaUtil > 0 && añosUso > 0)
            {

                valor = Vehiculo.ValorFabricacion - (Vehiculo.ValorFabricacion * añosUso/VidaUtil);

            }

            return valor;

        }

        public override string VerDescripcion()
        {
            return $"{base.VerDescripcion()} " +
                $"Evaluacion lineal, monto {CalcularDepreciacion()}";
        }

    }
}
