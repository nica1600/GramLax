//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace GrammatikLaxen
{
    using System;
    using System.Collections.Generic;
    
    public partial class adjektiv
    {
        public int Id { get; set; }
        public string ord { get; set; }
        public string ordklass { get; set; }
        public Nullable<bool> ren { get; set; }
        public string även { get; set; }
        public string obestämd_form_utrum { get; set; }
        public string obestämd_form_neutrum { get; set; }
        public string bestämd_form_ej_maskulinum { get; set; }
        public string singular { get; set; }
        public string plural { get; set; }
        public string positiv { get; set; }
        public string komparativ { get; set; }
        public string superlativ_predikativt { get; set; }
        public string superlativ_attributivt_ej_maskulinum { get; set; }
        public Nullable<int> fkordklass { get; set; }
    
        public virtual ordklasser ordklasser { get; set; }
    }
}
