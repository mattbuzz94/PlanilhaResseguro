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
    
    public partial class TB_ODS_PRODUTO_VERSAO
    {
        public string CD_PROD { get; set; }
        public string CD_VERSAO { get; set; }
        public System.DateTime DT_INI_VIG { get; set; }
        public Nullable<System.DateTime> DT_FIM_VIG { get; set; }
        public Nullable<System.DateTime> DT_ULT_CALC { get; set; }
        public Nullable<System.DateTime> DT_INSTALA { get; set; }
        public Nullable<short> QTD_DIAS_VALIDA { get; set; }
        public Nullable<System.DateTime> DT_REFR_CALC { get; set; }
        public Nullable<System.DateTime> DT_INCL { get; set; }
        public Nullable<System.DateTime> DT_ALT { get; set; }
        public string NOM_USR_INCL { get; set; }
        public string NOM_USR_ALT { get; set; }
        public Nullable<short> CD_REVISAO { get; set; }
        public string IN_STATUS { get; set; }
        public Nullable<System.DateTime> DT_TRANSFEREN { get; set; }
        public Nullable<System.DateTime> DT_TRANSFEREN_PROGRAMADA { get; set; }
        public Nullable<byte> FL_EXIBIRKIT { get; set; }
        public Nullable<short> QT_SINISTRO { get; set; }
        public Nullable<decimal> VL_SOMAINDENIZADO { get; set; }
        public Nullable<decimal> VL_PREMIOCONTROLEWF { get; set; }
        public Nullable<decimal> VL_COEF_MAX_INDENIZACAO { get; set; }
        public Nullable<short> QT_DIASCONTROLEWF { get; set; }
        public string IN_EXIBIR_MENU_KIT_CUSTOMIZADO { get; set; }
        public string IN_PC_CORPORATE { get; set; }
        public string IN_LMG_AUTOMATICO { get; set; }
        public Nullable<System.DateTime> DT_CARGA { get; set; }
    }
}
