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
    
    public partial class bet
    {
        public int Idt { get; set; }
        public string HomeAway { get; set; }
        public Nullable<short> Score { get; set; }
        public int Matchs_Idt { get; set; }
        public int Usr_Idt { get; set; }
    
        public virtual matchs matchs { get; set; }
    }
}
