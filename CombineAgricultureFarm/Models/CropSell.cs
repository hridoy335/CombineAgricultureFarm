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
    
    public partial class CropSell
    {
        public int CropSellId { get; set; }
        public int CropStorageId { get; set; }
        public System.DateTime CropsellDate { get; set; }
        public int TotalCropSell { get; set; }
        public int TotalPrice { get; set; }
    
        public virtual CropStorage CropStorage { get; set; }
    }
}