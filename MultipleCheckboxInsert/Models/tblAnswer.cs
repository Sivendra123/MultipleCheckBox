//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace MultipleCheckboxInsert.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class tblAnswer
    {
        public int tblAnswersID { get; set; }
        public string Answer { get; set; }
        public Nullable<int> tblQuestionID { get; set; }
    
        public virtual tblQuestion tblQuestion { get; set; }
    }
}
