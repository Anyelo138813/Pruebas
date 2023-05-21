using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pruebas
{
    internal class Ejercicios
    {
        // Peso KGS
        public Ejercicios(string nombreEjercicio, int series, int repeticiones, Peso peso, string maquinaria, string grupoMuscular) 
        {

            if (nombreEjercicio == null )
                nombreEjercicio = "Ejercicio";
            Nombre = nombreEjercicio;

            Series = series;

            Repeticiones = repeticiones;

            if (peso.Unidad == "kg")
            {
                PesoKG = peso.Cantidad;
                PesoLBS = 0;
            }
            else
            {
                PesoLBS = peso.Cantidad;
                PesoKG = 0;
            }

            if (maquinaria == null)
                maquinaria = "Sin especificar";
            Maquinaria = maquinaria;

            if (grupoMuscular == null)
                grupoMuscular = "Sin especificar";
            GrupoMuscular = grupoMuscular;

        }

        public string Nombre
        {
            set { value = _nombre; }
            get { return _nombre; }
        }

        public int Series
        {
            set { value = _series; }
            get { return _series; }
        }

        public int Repeticiones
        {
            set { value = _repeticiones; }
            get { return _repeticiones; }
        }

        public decimal PesoKG
        {
            set { value = _pesoKG; }
            get { return _pesoKG; }
        }

        public decimal PesoLBS
        {
            set { value = _pesoLBS; }
            get { return _pesoLBS; }
        }

        public string Maquinaria
        {
            set { value = _maquinaria; }
            get { return _maquinaria; }
        }

        public string GrupoMuscular
        {
            set { value = _grupoMuscular; }
            get { return _grupoMuscular; }
        }

        public Peso CambiarUnidadesPeso(Peso peso, decimal cantidad)
        {
            if (peso.Unidad == "kg")
                return peso.ConvertirUnidad(cantidad);
            else
                return peso.ConvertirUnidad(cantidad);
        }

        private string _nombre;
        private int _series;
        private int _repeticiones;
        private decimal _pesoKG;
        private decimal _pesoLBS;
        private string _maquinaria;
        private string _grupoMuscular;
    }
}
