using LodFileHandler.DB.DataModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LodFileHandler.DB.Repository
{
    public interface ILog_File_DataRepository
    {
        void Add(Log_File_Data log_File_Data);

        Log_File_Data GetDeteils(int id);

        List<Log_File_Data> GetDeteils();

        void Deleted(int id);

        void Update(Log_File_Data log_File_Data);

    }

    public class Log_File_DataRepository : ILog_File_DataRepository
    {
        private LogFileDataModel _context;

        public Log_File_DataRepository(LogFileDataModel context)
        {
            _context = context;
        }
        public void Add(Log_File_Data log_File_Data)
        {
            _context.Log_File_Data.Add(log_File_Data);
        }

        public void Deleted(int id)
        {
            _context.Log_File_Data.Remove(GetDeteils(id));
        }

        public Log_File_Data GetDeteils(int id)
        {
            return _context.Log_File_Data.FirstOrDefault(x=>x.Id == id);
        }

        public List<Log_File_Data> GetDeteils()
        {
            return _context.Log_File_Data.ToList();
        }

        public void Update(Log_File_Data log_File_Data)
        {
            var oldLog_File_Data = GetDeteils(log_File_Data.Id);

            oldLog_File_Data.IP_Address_Id = log_File_Data.IP_Address_Id;
            oldLog_File_Data.Path_File_Id = log_File_Data.Path_File_Id;
            oldLog_File_Data.Date_Time = log_File_Data.Date_Time;
            oldLog_File_Data.Data_Volume = log_File_Data.Data_Volume;
            log_File_Data.Provider_Name = log_File_Data.Provider_Name;
            log_File_Data.Request_Type = log_File_Data.Request_Type;
            oldLog_File_Data.Query_Result = log_File_Data.Query_Result;
        }
    }
}
