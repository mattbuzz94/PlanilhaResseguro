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
    
    public partial class TB_ODS_AGRUPAMENTO
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public TB_ODS_AGRUPAMENTO()
        {
            this.TB_ODS_CORRETOR = new HashSet<TB_ODS_CORRETOR>();
            this.TB_ODS_EMISSAO = new HashSet<TB_ODS_EMISSAO>();
            this.TB_ODS_REVENDA = new HashSet<TB_ODS_REVENDA>();
        }
    
        public string CD_AGRUPAMENTO { get; set; }
        public string NM_GRUPO { get; set; }
        public Nullable<System.DateTime> DT_CARGA { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<TB_ODS_CORRETOR> TB_ODS_CORRETOR { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<TB_ODS_EMISSAO> TB_ODS_EMISSAO { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<TB_ODS_REVENDA> TB_ODS_REVENDA { get; set; }
    }
}
