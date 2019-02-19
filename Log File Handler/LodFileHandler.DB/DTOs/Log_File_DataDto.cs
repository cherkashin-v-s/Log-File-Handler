using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LodFileHandler.DB.DTOs
{
    public class Log_File_DataDto
    {
        public int Id { get; set; }

        public int? IP_Address_Id { get; set; }

        public int? Path_File_Id { get; set; }

        public DateTimeOffset? Date_Time { get; set; }

        public string Request_Type { get; set; }

        public string Query_Result { get; set; }

        public int? Data_Volume { get; set; }

        public string Provider_Name { get; set; }
    }
}
