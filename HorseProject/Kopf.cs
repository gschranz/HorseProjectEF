//------------------------------------------------------------------------------
// <auto-generated>
//     Der Code wurde von einer Vorlage generiert.
//
//     Manuelle Änderungen an dieser Datei führen möglicherweise zu unerwartetem Verhalten der Anwendung.
//     Manuelle Änderungen an dieser Datei werden überschrieben, wenn der Code neu generiert wird.
// </auto-generated>
//------------------------------------------------------------------------------

namespace HorseProject
{
    using System;
    using System.Collections.Generic;
    
    public partial class Kopf
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Kopf()
        {
            this.Merkmale = new HashSet<Merkmale>();
        }
    
        public int id { get; set; }
        public string farbe { get; set; }
        public string abzeichen { get; set; }
        public string gebiss { get; set; }
        public string augen { get; set; }
        public string wirbelzahlstirn { get; set; }
        public string wirbelzahlzwischennuestern { get; set; }
        public string wirbelzahloberlippe { get; set; }
        public string wirbelzahlbacken { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Merkmale> Merkmale { get; set; }
    }
}