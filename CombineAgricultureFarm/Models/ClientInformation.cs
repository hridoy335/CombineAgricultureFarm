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
    
    public partial class ClientInformation
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public ClientInformation()
        {
            this.FarmInformations = new HashSet<FarmInformation>();
        }
    
        public int ClientId { get; set; }
        public string ClientName { get; set; }
        public string ClientEmail { get; set; }
        public string ClientMobile { get; set; }
        public string ClientAddress { get; set; }
        public string FurmName { get; set; }
        public string UserName { get; set; }
        public string Password { get; set; }
        public Nullable<int> ClientTypeId { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<FarmInformation> FarmInformations { get; set; }
        public virtual ClientType ClientType1 { get; set; }
    }
}
