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
    
    public partial class UserPoints
    {
        public int Matchs_Idt { get; set; }
        public string Usr_Name { get; set; }
        public Nullable<short> Number { get; set; }
        public string Team_Home { get; set; }
        public string Team_Away { get; set; }
        public Nullable<short> Score_Home_Bet { get; set; }
        public Nullable<short> Score_Away_Bet { get; set; }
        public Nullable<short> Score_Home { get; set; }
        public Nullable<short> Score_Away { get; set; }
        public Nullable<int> Points { get; set; }
    }
}
