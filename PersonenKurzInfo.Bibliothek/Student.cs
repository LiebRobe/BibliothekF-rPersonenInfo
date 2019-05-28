
using System;
using System.Collections.Generic;
using System.Text;

using static System.Console;

namespace PersonenKurzInfo.Bibliothek
{
    /*    Klasse Student mit
       *       - den automatisch implementierten Eigenschaften StudienbeginnJahr und
       *         Studienrichtung
       *       - einem Konstruktor, der Werte für Vorname, Nachname, Alter,
       *         StudienbeginnJahr und Studienrichtung übernehmen kann.
       *       - Diese Klasse muss die abstrakte Methode AusgebenKurzInfo implementieren, 
       *         sodass die Methode z.B. folgende Ausgabe macht:
       *            Hermann Reiter (23), studiert seit 2015 Maschinenbau
       *         Dabei soll die ToString-Methode der Basisklasse verwendet werden.
       */
    public class Student : Person
    {
        public int StudienbeginnJahr { get; set; }
        public string StudienRichtung { get; set; }
        public Student(string vorname, string nachname, int alter, int studienbeginnJahr, string studienRichtung) : base(vorname, nachname, alter) => (StudienbeginnJahr, StudienRichtung) = (studienbeginnJahr, studienRichtung);
        public override void KurzInfoAusgeben()
        {
            Write( base.ToString() + string.Format($"studiert seit {StudienbeginnJahr} {StudienRichtung}"));
        }
    }
}
