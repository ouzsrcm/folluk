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
    
    public partial class tblFarm
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public tblFarm()
        {
            this.tblAnimals = new HashSet<tblAnimal>();
            this.tblCoops = new HashSet<tblCoop>();
            this.tblMedicineAnimals = new HashSet<tblMedicineAnimal>();
            this.tblNests = new HashSet<tblNest>();
        }
    
        public int FarmId { get; set; }
        public Nullable<int> AccountId { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public string CoverImage { get; set; }
        public string ProfileImage { get; set; }
    
        public virtual tblAccount tblAccount { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tblAnimal> tblAnimals { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tblCoop> tblCoops { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tblMedicineAnimal> tblMedicineAnimals { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tblNest> tblNests { get; set; }

        public bool IsWarning { get; set; }
        public string WarningBody { get; set; }
        public string WarningClass { get; set; }

        public tblAccount tblProfile { get; set; }

        public tblAnimal tblAnimal { get; set; }

        public int tblAnimalCount { get; set; }
        public int tblCoopCount { get; set; }
        public int tblNestCount { get; set; }

    }
}
