//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Folluk.Data
{
    using System;
    using System.Collections.Generic;
    
    public partial class tblCoop
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public tblCoop()
        {
            this.tblAnimals = new HashSet<tblAnimal>();
            this.tblCoopAnimals = new HashSet<tblCoopAnimal>();
            this.tblNests = new HashSet<tblNest>();
        }
    
        public int CoopId { get; set; }
        public Nullable<int> FarmId { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tblAnimal> tblAnimals { get; set; }
        public virtual tblFarm tblFarm { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tblCoopAnimal> tblCoopAnimals { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tblNest> tblNests { get; set; }
    }
}
