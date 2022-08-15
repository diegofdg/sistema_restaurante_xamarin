using System;
using System.Collections.Generic;
using System.Text;

namespace RestauranteXamarin.Modelo
{
    public class Mmesas
    {
        public int Id_mesa { get; set; }
        public string Mesa { get; set; }
        public int Id_salon { get; set; }
        public string Estado_de_vida { get; set; }
        public string Estado_de_Disponibilidad { get; set; }

    }
}