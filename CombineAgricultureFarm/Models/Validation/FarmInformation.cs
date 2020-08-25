using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace CombineAgricultureFarm.Models
{
    [MetadataType(typeof(MetadataFarmInformation))]
    public partial class FarmInformation
    {
    }
    public class MetadataFarmInformation
    {
        [Required]
        [Display(Name ="Crop Session")]
        public int SessionInfoId { get; set; }

        [Required]
        [Display(Name = "Client Name")]
        public int ClientId { get; set; }

        [Required]
        [Display(Name = "Farm Type")]
        public int FurmingTypeId { get; set; }

        [Required]
        [Display(Name = "Crop Name")]
        public int CropInfod { get; set; }
    }
}