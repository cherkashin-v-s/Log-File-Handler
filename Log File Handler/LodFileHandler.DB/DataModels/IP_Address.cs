namespace LodFileHandler.DB.DataModels
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class IP_Address
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public IP_Address()
        {
            Log_File_Data = new HashSet<Log_File_Data>();
        }

        public int Id { get; set; }

        [Column("IP_Address")]
        [MaxLength(16)]
        public byte[] IP_Address1 { get; set; }

        [StringLength(50)]
        public string Сompany_Name { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Log_File_Data> Log_File_Data { get; set; }
    }
}
