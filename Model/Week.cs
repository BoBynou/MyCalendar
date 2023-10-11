using System;
using System.Collections.Generic;
using System.Text;

namespace MyCalendar
{
    public class Week
    {
        public Day Lundi { get; set; }
        public Day Mardi { get; set; }
        public Day Mercredi { get; set; }
        public Day Jeudi { get; set; }
        public Day Vendredi { get; set; }
        public Day Samedi { get; set; }
        public Day Dimanche { get; set; }

        public Week(Day lundi = null, Day mardi = null, Day mercredi = null, Day jeudi = null, Day vendredi = null, Day samedi = null, Day dimanche = null)
        {
            Lundi = lundi;
            Mardi = mardi;
            Mercredi = mercredi;
            Jeudi = jeudi;
            Vendredi = vendredi;
            Samedi = samedi;
            Dimanche = dimanche;
        }
    }
}
