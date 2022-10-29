using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CentralTelefonica
{
    public class Local : Llamada
    {
        protected float costo;

        public Local(float costo, Llamada llamada) : this(llamada.NroOrigen, costo, llamada.Duracion, llamada.NroDestino)
        {
        }

        public Local(string origen, float costo, float duracion, string destino) : base(duracion, origen, destino)
        {

            this.costo = costo;
        }
        public override float CostoLlamada
        { get { return this.CalcularCosto(); } }

        protected override string Mostrar ()
        {
            StringBuilder stringBuilder = new StringBuilder ();
            stringBuilder.AppendLine($"{base.Mostrar()}");
            stringBuilder.AppendLine($"costo de la llamada: {CostoLlamada}");
           return stringBuilder.ToString ();
        }

        public override bool Equals(object obj)
        {
            return obj is Local;
        }

        private float CalcularCosto()
        {
           return this.costo * this.duracion;
        }

        public override string ToString()
        {
            return Mostrar();
        }
    }
}
