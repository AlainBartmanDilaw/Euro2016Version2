//------------------------------------------------------------------------------
// <auto-generated>
//    Ce code a été généré à partir d'un modèle.
//
//    Des modifications manuelles apportées à ce fichier peuvent conduire à un comportement inattendu de votre application.
//    Les modifications manuelles apportées à ce fichier sont remplacées si le code est régénéré.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Euro2016
{
    using System;
    using System.Collections.Generic;
    
    public partial class stadium
    {
        public stadium()
        {
            this.matchs = new HashSet<matchs>();
        }
    
        public int Idt { get; set; }
        public string Nom { get; set; }
        public int Towns_Idt { get; set; }
    
        public virtual ICollection<matchs> matchs { get; set; }
        public virtual towns towns { get; set; }
    }
}
