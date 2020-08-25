//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace CombineAgricultureFarm.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class FarmingDetailforCrop
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public FarmingDetailforCrop()
        {
            this.CropStorages = new HashSet<CropStorage>();
        }
    
        public int FarmingDetailId { get; set; }
        public int FarminformationId { get; set; }
        public Nullable<int> FieldSize { get; set; }
        public Nullable<int> LandCultivatioCost { get; set; }
        public Nullable<int> SeedsCost { get; set; }
        public Nullable<int> PlantationCost { get; set; }
        public Nullable<int> WedsCostFristTime { get; set; }
        public Nullable<int> WedsCostSecondTime { get; set; }
        public Nullable<int> FertilizerCost { get; set; }
        public Nullable<int> CutingHarvestProcessCost { get; set; }
        public Nullable<int> ExteraCost { get; set; }
        public Nullable<int> GattotalCrop { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<CropStorage> CropStorages { get; set; }
        public virtual FarmInformation FarmInformation { get; set; }
    }
}
