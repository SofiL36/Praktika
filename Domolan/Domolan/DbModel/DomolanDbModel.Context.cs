//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Domolan.DbModel
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class DomolanDbEntities : DbContext
    {
        public DomolanDbEntities()
            : base("name=DomolanDbEntities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<Акции> Акции { get; set; }
        public virtual DbSet<Договоры> Договоры { get; set; }
        public virtual DbSet<Оборудование> Оборудование { get; set; }
        public virtual DbSet<Связи> Связи { get; set; }
        public virtual DbSet<Сотрудники> Сотрудники { get; set; }
        public virtual DbSet<Тарифы> Тарифы { get; set; }
    }
}
