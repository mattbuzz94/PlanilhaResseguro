//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace PlanilhaResseguro
{
    using System;
    using System.Collections.Generic;
    
    public partial class TB_ODS_CEP
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public TB_ODS_CEP()
        {
            this.TB_ODS_REVENDA = new HashSet<TB_ODS_REVENDA>();
            this.TB_ODS_ITEM = new HashSet<TB_ODS_ITEM>();
        }
    
        public string CD_CEP { get; set; }
        public string NM_BAIRRO { get; set; }
        public string NM_CIDADE { get; set; }
        public string SG_UF { get; set; }
        public string NM_ESTADO { get; set; }
        public Nullable<System.DateTime> DT_CARGA { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<TB_ODS_REVENDA> TB_ODS_REVENDA { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<TB_ODS_ITEM> TB_ODS_ITEM { get; set; }
    }
}