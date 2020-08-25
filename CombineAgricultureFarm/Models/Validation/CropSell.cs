using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace CombineAgricultureFarm.Models
{
    [MetadataType(typeof(MetadataCropSell))]
    public partial class CropSell
    {
    }

    public class MetadataCropSell
    {
        [Display(Name ="Crop Storage")]
        [Required]
        public int CropStorageId { get; set; }

        [Display(Name = "Sell Date")]
        [Required]
        public System.DateTime CropsellDate { get; set; }

        [Display(Name = "Total Sell(Kg)")]
        [Required]
        public int TotalCropSell { get; set; }

        [Display(Name = "Total Price")]
        [Required]
        public int TotalPrice { get; set; }
    }
}