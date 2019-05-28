using System;
using System.Collections.Generic;
using System.Text;

namespace PersonenKurzInfo.Bibliothek
{
    public static class Berechne
    {
        public static int GeburtsjahrBerechnen(Person p)
        {
            int aktuellesJahr = DateTime.Now.Year;
            return aktuellesJahr - p.Alter;
        }
    }
}
