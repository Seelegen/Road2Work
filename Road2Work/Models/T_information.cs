//------------------------------------------------------------------------------
// <auto-generated>
//     Ce code a été généré à partir d'un modèle.
//
//     Des modifications manuelles apportées à ce fichier peuvent conduire à un comportement inattendu de votre application.
//     Les modifications manuelles apportées à ce fichier sont remplacées si le code est régénéré.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Road2Work.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class T_information
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public T_information()
        {
            this.T_site = new HashSet<T_site>();
        }
    
        public int id_user { get; set; }
        public string adresse { get; set; }
        public string code_postal { get; set; }
        public string ville { get; set; }
        public string mail { get; set; }
        public string nom { get; set; }
        public string prenom { get; set; }
        public string score { get; set; }
        public string nombre_place { get; set; }
        public Nullable<int> id_site { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<T_site> T_site { get; set; }
        public virtual T_user T_user { get; set; }
    }
}
