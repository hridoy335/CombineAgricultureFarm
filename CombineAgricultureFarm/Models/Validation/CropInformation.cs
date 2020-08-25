using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace CombineAgricultureFarm.Models
{
    [MetadataType(typeof(MetadataCropInformation))]
    public partial class CropInformation
    {

    }

    public class MetadataCropInformation
    {
        [Display(Name ="Crop Name")]
        [Required]
        [MaxLength(50, ErrorMessage = "Crop name can't be more than 50 characters")]
        public string CropName { get; set; }

        [Display(Name ="Crop Information")]
        [Required]
        [MaxLength(200,ErrorMessage ="Crop information can't be more than 200 characters")]
        public string CropInformation1 { get; set; }

        [Display(Name = "Crop Medicine")]
        [Required]
        [MaxLength(200, ErrorMessage = "Crop medicine can't be more than 200 characters")]
        public string CropMedicine { get; set; }

        [Display(Name ="Crop Picture")]
        public string CropPicture { get; set; }
    }
}