//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace RTLSWebService.Models.RTLS_DB
{
    using System;
    using System.Collections.Generic;
    
    public partial class RTLS_GATEWAY
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public RTLS_GATEWAY()
        {
            this.RTLS_ZONEDTLS = new HashSet<RTLS_ZONEDTLS>();
        }
    
        public decimal gid { get; set; }
        public string gateway_name { get; set; }
        public string gateway_ip { get; set; }
        public decimal gateway_port { get; set; }
        public Nullable<decimal> actinact { get; set; }
        public System.DateTime created_time { get; set; }
        public decimal opeartion_type { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<RTLS_ZONEDTLS> RTLS_ZONEDTLS { get; set; }
    }
}
