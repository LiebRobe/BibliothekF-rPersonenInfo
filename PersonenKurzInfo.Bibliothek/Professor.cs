using System;
using System.Collections.Generic;
using System.Text;

using static System.Console;

namespace PersonenKurzInfo.Bibliothek
{
    /*    Klasse Professor mit
       *       - der automatisch implementierten Eigenschaften Fach (string)
       *       - einem Konstruktor, der Werte für Vorname, Nachname, Alter und Fach
       *         übernehmen kann.
       *       - Diese Klasse muss die abstrakte Methode AusgebenKurzInfo implementieren,
       *         sodass die Methode z.B. folgende Ausgabe macht:
       *            Heinz Wagner (52), Professor für Informatik
       *         Dabei soll die ToString-Methode der Basisklasse verwendet werden.
       */
    public class Professor : Person
    {
        public string Fach { get; set; }
        public Professor(string vorname, string nachname, int alter, string fach) : base(vorname, nachname, alter) => (Fach) = (fach);
        public override void KurzInfoAusgeben()
        {
            Write(base.ToString() + string.Format($"{nameof(Professor)} für {Fach}"));
        }
    }
}
