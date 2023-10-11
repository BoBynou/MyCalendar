using System;
using System.Collections.Generic;

namespace MyCalendar
{
    public class Calendrier
    {
        public int Année { get; set; }
        public int Mois { get; set; }

        public Calendrier(int année, int mois)
        {
            Année = année;
            Mois = mois;
        }

        public List<DateTime> GetMonthDays()
        {
            List<DateTime> daysInMonth = new List<DateTime>();

            if (Année < 1 || Mois < 1 || Mois > 12)
            {
                throw new Exception("Mois ou année non valide");
            }

            int daysInThisMonth = DateTime.DaysInMonth(Année, Mois);

            for (int day = 1; day <= daysInThisMonth; day++)
            {
                DateTime date = new DateTime(Année, Mois, day);
                daysInMonth.Add(date);
            }

            return daysInMonth;
        }

        public List<Week> GetWeeksForAMonth(List<DateTime> myList)
        {
            List<Week> myListOfWeek = new List<Week>();
            Week myWeek = new Week();
            foreach (DateTime date in myList)
            {
                Day monJour = new Day(date.Day);
                switch (date.DayOfWeek)
                {
                    case DayOfWeek.Monday:
                        {
                            myWeek = new Week();
                            myWeek.Lundi = monJour;
                            break;
                        }
                    case DayOfWeek.Tuesday:
                        {
                            myWeek.Mardi = monJour;
                            break;
                        }
                    case DayOfWeek.Wednesday:
                        {
                            myWeek.Mercredi = monJour;
                            break;
                        }
                    case DayOfWeek.Thursday:
                        {
                            myWeek.Jeudi = monJour;
                            break;
                        }
                    case DayOfWeek.Friday:
                        {
                            myWeek.Vendredi = monJour;
                            break;
                        }
                    case DayOfWeek.Saturday:
                        {
                            myWeek.Samedi = monJour;
                            break;
                        }
                    case DayOfWeek.Sunday:
                        {
                            myWeek.Dimanche = monJour;
                            myListOfWeek.Add(myWeek);
                            break;
                        }
                }
            }
            if (myWeek.Dimanche == null) { myListOfWeek.Add(myWeek); }
            return myListOfWeek;
        }
    }
}
