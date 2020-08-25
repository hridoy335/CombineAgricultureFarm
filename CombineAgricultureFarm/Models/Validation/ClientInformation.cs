using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace CombineAgricultureFarm.Models
{
   [MetadataType(typeof(MetadataClientInformation))]
    public partial class ClientInformation
    {
    }
    public class MetadataClientInformation
    {
        [Display(Name ="Client Name")]
        [Required]
        [RegularExpression(@"^[a-zA-Z''-'\s]{1,40}$", ErrorMessage = "Name is not correct format")]
        [MaxLength(50, ErrorMessage = "Client name can't be more than 50 characters")]
        public string ClientName { get; set; }

        [Display(Name = "Email")]
        [Required]
        [DataType(DataType.EmailAddress)]
        public string ClientEmail { get; set; }

        [Display(Name = "Mobile")]
        [Required]
        [DataType(DataType.PhoneNumber)]
        public string ClientMobile { get; set; }

        [Display(Name = "Client Address")]
        [Required]
        [MaxLength(200, ErrorMessage = "Address can't be more than 200 characters")]
        public string ClientAddress { get; set; }

        [Display(Name = "Farm Name")]
        [Required]
        [RegularExpression(@"^[a-zA-Z''-'\s]{1,40}$", ErrorMessage = "Name is not correct format")]
        [MaxLength(100, ErrorMessage = "Farm name can't be more than 100 characters")]
        public string FurmName { get; set; }

        [Display(Name = "User Name")]
        [Required]
        [MaxLength(50, ErrorMessage = "User name can't be more than 50 characters")]
        public string UserName { get; set; }

        [Display(Name = "Password")]
        [Required]
        [DataType(DataType.Password)]
        [MaxLength(50, ErrorMessage = "Password can't be more than 50 characters")]
        public string Password { get; set; }
    }
}