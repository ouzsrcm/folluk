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
    
    public partial class tblAnimal
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public tblAnimal()
        {
            this.tblCoopAnimals = new HashSet<tblCoopAnimal>();
            this.tblMedicineAnimals = new HashSet<tblMedicineAnimal>();
            this.tblNests = new HashSet<tblNest>();
        }
    
        public int AnimalId { get; set; }
        public Nullable<int> AnimalTypeId { get; set; }
        public Nullable<int> FarmId { get; set; }
        public Nullable<int> CoopId { get; set; }
        public string Title { get; set; }
        public Nullable<int> Quantity { get; set; }
        public Nullable<System.DateTime> CreationDate { get; set; }
        public Nullable<System.DateTime> PublishDate { get; set; }
        public Nullable<System.DateTime> DeployDate { get; set; }
    
        public virtual tblAnimalType tblAnimalType { get; set; }
        public virtual tblCoop tblCoop { get; set; }
        public virtual tblFarm tblFarm { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tblCoopAnimal> tblCoopAnimals { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tblMedicineAnimal> tblMedicineAnimals { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tblNest> tblNests { get; set; }
    }
}