//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace DataProvider.EF
{
    using System;
    using System.Collections.Generic;
    
    public partial class SYS_Layer_Role
    {
        public long ID { get; set; }
        public string Layer { get; set; }
        public string Role { get; set; }
        public Nullable<bool> IsEdit { get; set; }
        public Nullable<bool> IsDelete { get; set; }
        public Nullable<bool> IsView { get; set; }
        public Nullable<bool> IsCreate { get; set; }
        public string OutFields { get; set; }
        public string Definition { get; set; }
        public Nullable<bool> IsVisible { get; set; }
    }
}
