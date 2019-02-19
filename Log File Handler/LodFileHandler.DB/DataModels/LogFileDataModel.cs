namespace LodFileHandler.DB.DataModels
{
    using System;
    using System.Data.Entity;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Linq;

    public partial class LogFileDataModel : DbContext
    {
        public LogFileDataModel()
            : base("name=LogFileModel")
        {
        }

        public virtual DbSet<Files> Files { get; set; }
        public virtual DbSet<IP_Address> IP_Address { get; set; }
        public virtual DbSet<Log_File_Data> Log_File_Data { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Files>()
                .HasMany(e => e.Log_File_Data)
                .WithOptional(e => e.Files)
                .HasForeignKey(e => e.Path_File_Id);

            modelBuilder.Entity<IP_Address>()
                .HasMany(e => e.Log_File_Data)
                .WithOptional(e => e.IP_Address)
                .HasForeignKey(e => e.IP_Address_Id);

            modelBuilder.Entity<Log_File_Data>()
                .Property(e => e.Provider_Name)
                .IsFixedLength();
        }
    }
}
