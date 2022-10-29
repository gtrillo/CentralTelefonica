using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CentralTelefonica
{
    public class Centralita
    {
        protected List<Llamada> listaDeLlamadas;
        protected string razonSocial;

        public Centralita()
        {
            this.listaDeLlamadas = new List<Llamada>();
        }

        public Centralita(string nombreEmpresa) : this()
        {
            this.razonSocial = nombreEmpresa;
        }

        private float CalcularGanancia(eTipoLlamada tipoLlamada)
        {
            float total = 0;
           foreach (Llamada llamada in this.Llamadas)
            {
                switch (tipoLlamada)
                {

                    case eTipoLlamada.Local:
                        if(llamada is Local)
                        {
                            total += ((Local)llamada).CostoLlamada;            
                        }
                    break;

                    case eTipoLlamada.Provincial:
                        if (llamada is Provincial)
                        {
                            total += ((Provincial)llamada).CostoLlamada;
                        }
                        break;
                    case eTipoLlamada.Todas:
                        if (llamada is Local)
                        {
                            total += ((Local)llamada).CostoLlamada;
                        }else if(llamada is Provincial)
                        {
                            total += ((Provincial)llamada).CostoLlamada;
                        }
                        break;

                }

            }
            return total;
        }

        public float GananciaTotal
        {
            get { return CalcularGanancia(eTipoLlamada.Todas);}
        }
        public float GananciaPorProvincial
        {
            get { return CalcularGanancia(eTipoLlamada.Provincial);}
        }
        public float GananciaPorLocal
        {
            get { return CalcularGanancia(eTipoLlamada.Local);}
        }

        public List<Llamada> Llamadas
        {
            get { return listaDeLlamadas; }
        }

        private string Mostrar()
        {
            StringBuilder stringBuilder = new StringBuilder();
            stringBuilder.AppendLine($"*****************************************");
            stringBuilder.AppendLine($"Razon social: {this.razonSocial}");
            stringBuilder.AppendLine($"Ganancia total: {this.GananciaTotal}");
            stringBuilder.AppendLine($"Ganancia por los llamados provinciales: {this.GananciaPorProvincial}");
            stringBuilder.AppendLine($"Ganancia por los llamados locales: {this.GananciaPorLocal}");
            stringBuilder.AppendLine($"*****************************************");
            foreach(Llamada llamada in listaDeLlamadas)
            {
                stringBuilder.AppendLine($"{llamada.ToString()}");
            }
            return stringBuilder.ToString();
        }

        public override string ToString()
        {
            return Mostrar();
        }

        public void AgregarLlamada (Llamada nuevaLlamada)
        {
            listaDeLlamadas.Add(nuevaLlamada);
        }

        public static bool operator == (Centralita c, Llamada llamada)
        {
            bool retorno = false;
            foreach (Llamada item in c.listaDeLlamadas)
            {
                if(item==llamada)
                {
                    retorno = true;
                }
            }
            return retorno;
        }

        public static bool operator !=(Centralita c, Llamada llamada)
        {
            return !(c == llamada);
        }

        public static Centralita operator + (Centralita c, Llamada nuevaLlamada)
        {
            
            if (c == nuevaLlamada)
            {
                throw new LaCentralitaException("Error la llamada ya existe en la central", "Centralita", "+");
            }
            else
            {
                c.AgregarLlamada(nuevaLlamada);
            }
            return c;
        }


        public void OrdenarLlamadas ()
        {
            
        }
    }
}
