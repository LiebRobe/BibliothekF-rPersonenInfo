using System;

namespace PersonenKurzInfo.Bibliothek
{
    /*    Klasse Person mit
   *       - den automatisch implementierten Eigenschaften Vorname, Nachname und Alter
   *       - einem Konstruktor, der Werte für Vorname, Nachname und Alter übernehmen
   *         kann
   *       - einer abstrakten Methode AusgebenKurzInfo ohne Parameter und ohne
   *         Rückgabewert.
   *       - Überschreiben Sie die Methode ToString, so dass diese den Vornamen, den
   *         Nachnamen und das Alter einer Person zurückgibt, z.B.
   *            Hermann Reiter (23)
   */
    public abstract class Person
    {
        public string Vorname { get; set; }
        public string Nachname { get; set; }
        public int Alter { get; set; }

        public Person(string vorname, string nachname, int alter) => (Vorname, Nachname, Alter) = (vorname, nachname, alter);
        public abstract void KurzInfoAusgeben();
        public override string ToString()
        {
            return string.Format($"{Vorname} {Nachname} ({Alter})");
        }
         
    }
}
