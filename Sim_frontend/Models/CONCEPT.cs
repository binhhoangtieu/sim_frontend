//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Sim_frontend.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class CONCEPT
    {
        public string ConceptID { get; set; }
        public string TopicID { get; set; }
        public string Concept_Name { get; set; }
        public string Concept_Content { get; set; }
        public Nullable<double> Concept_Weight { get; set; }
    
        public virtual TOPIC TOPIC { get; set; }
    }
}
