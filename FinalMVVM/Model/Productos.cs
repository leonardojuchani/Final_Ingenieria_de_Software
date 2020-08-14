using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinalMVVM.Model
{

    public class Productos : NotifyBase
    {
        #region Atributos
        private int id;
        private String dueño;
        private String dni;
        private String raza;
        private String descripcion;
        #endregion

        #region Propiedades

        public int Id
        {
            get

            {
                return id;

            } 
            set
            {
                id = value;
                OnPropertyChanged("Id");
            }

        } // Fin de propiedad Id


        public string Dueño
        {
            get

            {
                return dueño;

            }

            set
            {
                dueño = value;
                OnPropertyChanged("Dueño");
            }
        }// Fin de propiedad Dueño


        public string Dni
        {
            get
            {
                return dni;
            }

            set
            {
                dni = value;
                OnPropertyChanged("Dni");
            }
        }// Fin de propiedad Dni


        public string Raza
        {
            get
            {

                return raza;
            }

            set
            {
                raza = value;
                OnPropertyChanged("Raza");
            }
        }// Fin de propiedad Raza


        public string Descripcion
        {
            get
            {
                return descripcion;

            }
            set
            {
                descripcion = value;
                OnPropertyChanged("descipcion");
            }
        }// Fin de propiedad Descripcion

        #endregion
    }

}

