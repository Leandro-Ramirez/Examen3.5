#region Usos
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
#endregion

namespace Forms.Clases
{
    class Estudiante : Persona
    {
        #region variables
        string Carnet;
        string Nivel;
        #endregion

        #region Get & Set
        public string Carnets
        {
            get => Carnet;
            set => Carnet = value;
        }
        public string Niveles
        {
            get => Nivel;
            set => Nivel = value;
        }
        #endregion

        #region Public Estudiante
        public Estudiante()
        {
            Carnets = string.Empty;
            Niveles = string.Empty;
        }
        #endregion

        #region Public Herencia Estudiante
        public Estudiante(string Nombre, string Sexo, int Edad,
            string Carnet, string Nivel)
        {
            this.Nombres = Nombre;
            this.Sexos = Sexo;
            this.Edades = Edad;
            this.Carnets = Carnet;
            this.Niveles = Nivel;
        }
        #endregion
    }
}