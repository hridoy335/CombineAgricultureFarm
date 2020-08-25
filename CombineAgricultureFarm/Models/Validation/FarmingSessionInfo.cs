using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace CombineAgricultureFarm.Models
{
    [MetadataType(typeof(MetadataFarmingSessionInfo))]
    public partial class FarmingSessionInfo
    {

    }

    public class MetadataFarmingSessionInfo
    {
        [Required]
        [Display(Name ="Session Type")]
        [MaxLength(50,ErrorMessage ="Not more than 50 charecters.")]
        public string SessionInfoName { get; set; }
    }
}