﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace MOHAMMED_ABDULLAH_P00193895_Booking
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class BOOKINGEntities : DbContext
    {
        public BOOKINGEntities()
            : base("name=BOOKINGEntities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<tblFood> tblFoods { get; set; }
        public virtual DbSet<tblGuide> tblGuides { get; set; }
        public virtual DbSet<tblResort> tblResorts { get; set; }
        public virtual DbSet<tblRestaurant> tblRestaurants { get; set; }
        public virtual DbSet<tblReview> tblReviews { get; set; }
        public virtual DbSet<tblRide> tblRides { get; set; }
        public virtual DbSet<tblUser> tblUsers { get; set; }
    }
}
