﻿//------------------------------------------------------------------------------
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
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class MusicStory5903Entities : DbContext
    {
        public MusicStory5903Entities()
            : base("name=MusicStory5903Entities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<Albums> Albums { get; set; }
        public virtual DbSet<Author> Author { get; set; }
        public virtual DbSet<Band> Band { get; set; }
        public virtual DbSet<BandType> BandType { get; set; }
        public virtual DbSet<Melody> Melody { get; set; }
        public virtual DbSet<Music> Music { get; set; }
        public virtual DbSet<MusicStyle> MusicStyle { get; set; }
        public virtual DbSet<Record> Record { get; set; }
        public virtual DbSet<UserAccount> UserAccount { get; set; }
        public virtual DbSet<UserType> UserType { get; set; }
    }
}
