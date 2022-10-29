using System;
using System.Text;
namespace CentralTelefonica
{
    public abstract class Llamada
    {
        protected float duracion;
        protected string nroDestino;
        protected string nroOrigen;

        public abstract float CostoLlamada
        {
            get;
        }
        
        public float Duracion
        {
            get { return duracion; }
        }

        public string NroDestino
        {
            get { return nroDestino; }
        }

        public string NroOrigen
        {
            get { return nroOrigen; }
        }


        public Llamada (float duracion, string nroOrigen, string numeroDestino)
        {
            this.duracion = duracion;
            this.nroDestino = numeroDestino;
            this.nroOrigen = nroOrigen;
        }

        public int OrdenarPorDuracion (Llamada llamada1, Llamada llamada2)
        {
            int retorno = 0;
            if (llamada1.Duracion > llamada2.Duracion)
            {
                retorno = 1;
            }
            return retorno;
        }

        protected virtual string Mostrar()
        {
            StringBuilder stringBuilder = new StringBuilder();
            stringBuilder.AppendLine($"Duración de la llamada: {this.Duracion}");
            stringBuilder.AppendLine($"Origen de la llamada: {this.NroOrigen}");
            stringBuilder.AppendLine($"Destino de la llamada: {this.NroDestino}");
            return stringBuilder.ToString();
        }

        public static bool operator == (Llamada l1, Llamada l2)
        {
            return l1.GetType() == l2.GetType();
        }

        public static bool operator != (Llamada l1, Llamada l2)
        {
            return !(l1 == l2);
        }

    }
}
