using LodFileHandler.DB.DataModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LodFileHandler.DB.Repository
{
    public interface IFilesRepository
    {
        void Add (Files files);

        Files GetDeteils(int id);

        List<Files> GetAll();

        void Update(Files files);

        void Delete(int id);
    }

    public class FilesRepository : IFilesRepository
    {
        private LogFileDataModel _context;

        public FilesRepository(LogFileDataModel context)
        {
            _context = context;
        }

        public void Add(Files files)
        {
            _context.Files.Add(files);
        }

        public void Delete(int id)
        {
            _context.Files.Remove(GetDeteils(id));
        }

        public List<Files> GetAll()
        {
            return _context.Files.ToList();
        }

        public Files GetDeteils(int id)
        {
            return _context.Files.FirstOrDefault(x => x.Id == id);
        }

        public void Update(Files files)
        {
            var oldFiles = GetDeteils(files.Id);

            oldFiles.File_Name = files.File_Name;
            oldFiles.File_Size = files.File_Size;
            oldFiles.Path = files.Path;
        }
    }
}
