namespace LodFileHandler.DB.DataModels
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Log_File_Data
    {
        public int Id { get; set; }

        public int? IP_Address_Id { get; set; }

        public int? Path_File_Id { get; set; }

        public DateTimeOffset? Date_Time { get; set; }

        [StringLength(8)]
        public string Request_Type { get; set; }

        [StringLength(3)]
        public string Query_Result { get; set; }

        public int? Data_Volume { get; set; }

        [StringLength(10)]
        public string Provider_Name { get; set; }

        public virtual Files Files { get; set; }

        public virtual IP_Address IP_Address { get; set; }
    }
}
