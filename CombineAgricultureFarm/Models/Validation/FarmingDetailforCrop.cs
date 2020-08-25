using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace CombineAgricultureFarm.Models
{
    [MetadataType(typeof(MetadataFarmingDetailforCrop))]
    public partial class FarmingDetailforCrop
    {
    }
    public class MetadataFarmingDetailforCrop
    {
        [Display(Name = "")]
        [Required]
        public int FarminformationId { get; set; }

        [Display(Name = "Field Size")]
        [Required]
        public Nullable<int> FieldSize { get; set; }

        [Display(Name = "Land Cultivatio Cost")]
        [Required]
        public Nullable<int> LandCultivatioCost { get; set; }

        [Display(Name = "Seeds Cost")]
        [Required]
        public Nullable<int> SeedsCost { get; set; }

        [Display(Name = "Plantation Cost")]
        [Required]
        public Nullable<int> PlantationCost { get; set; }

        [Display(Name = "Weds Cost Frist Time")]
        [Required]
        public Nullable<int> WedsCostFristTime { get; set; }

        [Display(Name = "Weds Cost Second Time")]
        [Required]
        public Nullable<int> WedsCostSecondTime { get; set; }

        [Display(Name = "Fertilizer Cost")]
        [Required]
        public Nullable<int> FertilizerCost { get; set; }

        [Display(Name = "Cuting Harvest Process Cost")]
        [Required]
        public Nullable<int> CutingHarvestProcessCost { get; set; }

        [Display(Name = "Extera Cost")]
        [Required]
        public Nullable<int> ExteraCost { get; set; }

        [Display(Name = "Total Crop(Kg)")]
        [Required]
        public Nullable<int> GattotalCrop { get; set; }
    }
}