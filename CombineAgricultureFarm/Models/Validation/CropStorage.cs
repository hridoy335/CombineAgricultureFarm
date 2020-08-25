using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace CombineAgricultureFarm.Models
{
    [MetadataType(typeof(MetadataCropStorage))]
    public partial class CropStorage
    {

    }

    public class MetadataCropStorage
    {
        [Required]
        [Display(Name ="Crop Information")]
        public int FarmingDetailId { get; set; }
        [Required]
        [Display(Name = "Storage")]
        public int CropStorage1 { get; set; }
        [Required]
        [Display(Name = "Sell")]
        public Nullable<int> CropSell { get; set; }
        [Required]
        [Display(Name = "Storage Date")]
        public System.DateTime StorageDate { get; set; }
    }
}