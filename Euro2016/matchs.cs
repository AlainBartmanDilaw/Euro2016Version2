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
    
    public partial class matchs
    {
        public matchs()
        {
            this.bet = new HashSet<bet>();
            this.matchsteam = new HashSet<matchsteam>();
        }
    
        public int Idt { get; set; }
        public Nullable<short> Number { get; set; }
        public string Groups_Cod { get; set; }
        public Nullable<int> Phase_Idt { get; set; }
        public Nullable<System.DateTime> ScheduleDate { get; set; }
        public Nullable<int> Stadium_Idt { get; set; }
    
        public virtual ICollection<bet> bet { get; set; }
        public virtual phase phase { get; set; }
        public virtual stadium stadium { get; set; }
        public virtual ICollection<matchsteam> matchsteam { get; set; }
    }
}
