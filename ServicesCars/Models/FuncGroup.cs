//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace ServicesCars.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class FuncGroup
    {
        public int id { get; set; }
        public int idFuncionario { get; set; }
        public Nullable<int> idGrupo { get; set; }
    
        public virtual Grupos Grupos { get; set; }
        public virtual Funcionarios Funcionarios { get; set; }
    }
}
