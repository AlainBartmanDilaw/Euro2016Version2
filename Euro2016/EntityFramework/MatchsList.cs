//------------------------------------------------------------------------------
// <auto-generated>
//    Ce code a été généré à partir d'un modèle.
//
//    Des modifications manuelles apportées à ce fichier peuvent conduire à un comportement inattendu de votre application.
//    Les modifications manuelles apportées à ce fichier sont remplacées si le code est régénéré.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Euro2016.EntityFramework
{
    using System;
    using System.Collections.Generic;
    
    public partial class MatchsList
    {
        public int Idt { get; set; }
        public Nullable<short> Number { get; set; }
        public string Groups_Cod { get; set; }
        public Nullable<System.DateTime> ScheduleDate { get; set; }
        public int Phase_Idt { get; set; }
        public string Phase_Lbl { get; set; }
        public string Stadium_Name { get; set; }
        public string Town_Name { get; set; }
        public string Team_Home { get; set; }
        public string Team_Home_Label { get; set; }
        public string ImageHome { get; set; }
        public Nullable<short> Score_Home { get; set; }
        public string Team_Away { get; set; }
        public string Team_Away_Label { get; set; }
        public string ImageAway { get; set; }
        public Nullable<short> Score_Away { get; set; }
        public int MatchStarted { get; set; }
    }
}
