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
    
    public partial class Usr
    {
        public Usr()
        {
            this.webpages_Roles = new HashSet<webpages_Roles>();
        }
    
        public int Idt { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }
        public string eMail { get; set; }
    
        public virtual ICollection<webpages_Roles> webpages_Roles { get; set; }
    }
}
