using LodFileHandler.DB.DataModels;
using LodFileHandler.DB.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LodFileHandler.DB.Extensions
{
    public static class Log_File_DataConversions
    {
        public static Log_File_Data ToSqlModel(this Log_File_DataDto log_File_DataDto)
        {
            if (log_File_DataDto == null)
            {
                return null;
            }

            return new Log_File_Data
            {
                Id = log_File_DataDto.Id,
                IP_Address_Id = log_File_DataDto.IP_Address_Id,
                Path_File_Id = log_File_DataDto.Path_File_Id,
                Date_Time = log_File_DataDto.Date_Time,
                Request_Type = log_File_DataDto.Request_Type,
                Query_Result = log_File_DataDto.Query_Result,
                Data_Volume = log_File_DataDto.Data_Volume,
                Provider_Name = log_File_DataDto.Provider_Name
            };
        }

        public static Log_File_DataDto ToDtoModel(this Log_File_Data log_File_Data)
        {
            if (log_File_Data == null)
            {
                return null;
            }

            return new Log_File_DataDto
            {
                Id = log_File_Data.Id,
                IP_Address_Id = log_File_Data.IP_Address_Id,
                Path_File_Id = log_File_Data.Path_File_Id,
                Date_Time = log_File_Data.Date_Time,
                Request_Type = log_File_Data.Request_Type,
                Query_Result = log_File_Data.Query_Result,
                Data_Volume = log_File_Data.Data_Volume,
                Provider_Name = log_File_Data.Provider_Name
            };
        }
    }
}
