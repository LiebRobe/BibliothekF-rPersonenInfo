using System;
using System.Collections.Generic;
using System.Text;

using static System.Console;

namespace PersonenKurzInfo.Bibliothek
{ 
    /*    Klasse Dozent mit
    *       - der automatisch implementierten Eigenschaften Fakultaet (string)
    *       - einem Konstruktor, der Werte für Vorname, Nachname, Alter und Fakultaet
    *         übernehmen kann.
    *       - Diese Klasse muss die abstrakte Methode AusgebenKurzInfo implementieren, 
    *         sodass die Methode z.B. folgende Ausgabe macht:
    *            Gregor Schneider (49), Dozent an der Fakultät für Bauingenieurwesen
    *         Dabei soll die ToString-Methode der Basisklasse verwendet werden.
    */
    public class Dozent : Person
    {
        public string Fakultaet { get; set; }
        public Dozent(string vorname, string nachname, int alter, string fakultaet) : base(vorname, nachname, alter) => Fakultaet = fakultaet;
        public override void KurzInfoAusgeben()
        {
            Write(base.ToString() + string.Format($"{nameof(Dozent)} an der {nameof(Fakultaet)} für {Fakultaet}"));
        }
    }
}
