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
    
    public partial class tblMedicineAnimal
    {
        public int MedicineAnimalId { get; set; }
        public Nullable<int> FarmId { get; set; }
        public Nullable<int> AnimalId { get; set; }
        public Nullable<int> MedicineId { get; set; }
        public Nullable<System.DateTime> CreationDate { get; set; }
        public string Notes { get; set; }
    
        public virtual tblAnimal tblAnimal { get; set; }
        public virtual tblFarm tblFarm { get; set; }
        public virtual tblMedicine tblMedicine { get; set; }
    }
}
