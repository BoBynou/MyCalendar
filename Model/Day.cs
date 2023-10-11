using System;
using System.Collections.Generic;
using System.Text;

namespace MyCalendar
{
    public class Day
    {
        public int Nombre { get; set; }

        public Day(int nombre)
        {
            Nombre = nombre;
        }

        public override string ToString()
        {
            return Convert.ToString(Nombre);
        }
    }
}
