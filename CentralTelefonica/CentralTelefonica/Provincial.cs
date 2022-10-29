using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CentralTelefonica
{
    public class Provincial : Llamada
    {
        public enum eFranja
        {
            Franja_1,
            Franja_2,
            Franja_3,
        }

        protected eFranja franjaHoraria;
        
        public Provincial(eFranja miFranja,Llamada llamada ) : this(llamada.NroOrigen, miFranja, llamada.Duracion, llamada.NroDestino)
        {
        }

        public Provincial(string origen, eFranja franja, float duracion, string destino) : base(duracion, origen, destino)
        {

            this.franjaHoraria = franja;
        }

        private float CalcularCosto()
        {
            float costo = 0;
            switch (franjaHoraria)
            {
                case eFranja.Franja_1:
                    costo = (float)(this.Duracion * 0.99);
                break;

                case eFranja.Franja_2:
                    costo = (float)(this.Duracion * 1.25);
                break;

                default:
                    costo = (float)(this.Duracion * 0.66);
                break;
            }
            return costo;
        }
        protected override string Mostrar()
        {
            StringBuilder stringBuilder = new StringBuilder();
            stringBuilder.AppendLine($"{base.Mostrar()}");
            stringBuilder.AppendLine($"costo de la llamada: {CalcularCosto()}");
            return stringBuilder.ToString();
        }

        public override string ToString()
        {
            return Mostrar();
        }

        public override bool Equals(object obj)
        {
            return obj is Provincial;
        }

        public override float CostoLlamada
        {
            get { return this.CalcularCosto(); }
        }
        public void OrdenarLlamadas()
        {

        }


    }
}
