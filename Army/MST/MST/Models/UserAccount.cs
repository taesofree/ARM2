//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace MST.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class UserAccount
    {
        public string UserName { get; set; }
        public string UserPassword { get; set; }
        public Nullable<int> UserTypeID { get; set; }
    
        public virtual UserType UserType { get; set; }
    }
}
