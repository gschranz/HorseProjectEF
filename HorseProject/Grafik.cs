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
    
    public partial class Grafik
    {
        public int id { get; set; }
        public Nullable<int> pferd { get; set; }
    
        public virtual Pferd Pferd1 { get; set; }
    }
}
