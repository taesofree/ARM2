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
    
    public partial class Music:Upload
    {
        public int msMusicID { get; set; }
        public int msABID { get; set; }
        public string msMusicName { get; set; }
        public string msLyrics { get; set; }
        public Nullable<int> msAuthorID { get; set; }
        public Nullable<int> msMelodyID { get; set; }
        public Nullable<int> msBandID { get; set; }
        public Nullable<int> msMStyleID { get; set; }
        public string msMusicUpload { get; set; }
    
        public virtual Albums Albums { get; set; }
        public virtual Author Author { get; set; }
        public virtual Melody Melody { get; set; }
        public virtual MusicStyle MusicStyle { get; set; }
    }
}
