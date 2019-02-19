namespace LodFileHandler.DB.DataModels
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Files
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Files()
        {
            Log_File_Data = new HashSet<Log_File_Data>();
        }

        public int Id { get; set; }

        public string File_Name { get; set; }

        public string Path { get; set; }

        public int? File_Size { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Log_File_Data> Log_File_Data { get; set; }
    }
}
