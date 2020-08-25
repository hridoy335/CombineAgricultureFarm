using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace CombineAgricultureFarm.Models
{
    [MetadataType(typeof(MetadataFarmingType))]
    public partial class FarmingType
    {
    }

    public class MetadataFarmingType
    {
        [Required]
        [Display(Name ="Farming Type")]
        [MaxLength(50,ErrorMessage ="Not more than 50  charecters.")]
        public string FarmingTyeName { get; set; }
    }
}