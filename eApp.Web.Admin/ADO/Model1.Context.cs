﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace eApp.Web.Admin.ADO
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class dbsmappEntities : DbContext
    {
        public dbsmappEntities()
            : base("name=dbsmappEntities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<C__MigrationHistory> C__MigrationHistory { get; set; }
        public virtual DbSet<C_Role> C_Role { get; set; }
        public virtual DbSet<C_User> C_User { get; set; }
        public virtual DbSet<C_UserClaim> C_UserClaim { get; set; }
        public virtual DbSet<C_UserLogin> C_UserLogin { get; set; }
        public virtual DbSet<iproduct> iproducts { get; set; }
        public virtual DbSet<iproductprice> iproductprices { get; set; }
        public virtual DbSet<nservice> nservices { get; set; }
        public virtual DbSet<nservicesproductprice> nservicesproductprices { get; set; }
        public virtual DbSet<nservicesproduct> nservicesproducts { get; set; }
        public virtual DbSet<sdepartment> sdepartments { get; set; }
        public virtual DbSet<sdepartmentservice> sdepartmentservices { get; set; }
        public virtual DbSet<userapp> userapps { get; set; }
        public virtual DbSet<userappbranch> userappbranches { get; set; }
        public virtual DbSet<userapprole> userapproles { get; set; }
        public virtual DbSet<userappservice> userappservices { get; set; }
        public virtual DbSet<userappsession> userappsessions { get; set; }
        public virtual DbSet<xbranch> xbranches { get; set; }
        public virtual DbSet<xbranchorder> xbranchorders { get; set; }
        public virtual DbSet<xbranchorderslist> xbranchorderslists { get; set; }
        public virtual DbSet<xbranchsale> xbranchsales { get; set; }
        public virtual DbSet<xbranchstock> xbranchstocks { get; set; }
        public virtual DbSet<ysysphoto> ysysphotoes { get; set; }
    }
}
