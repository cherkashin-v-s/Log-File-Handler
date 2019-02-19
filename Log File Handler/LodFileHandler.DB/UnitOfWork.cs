using LodFileHandler.DB.DataModels;
using LodFileHandler.DB.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LodFileHandler.DB
{
    public class UnitOfWork : IDisposable
    {
        private bool _disposed = false;
        private LogFileDataModel _context;
        private FilesRepository _fileRepository;
        private IP_AddressRepository _iP_AddressRepository;
        private Log_File_DataRepository _log_File_DataRepository;

        public FilesRepository FileRepository
        {
            get
            {
                if (_fileRepository == null)
                {
                    _fileRepository = new FilesRepository(_context);
                }

                return _fileRepository;
            }
        }

        public IP_AddressRepository IP_AddressRepository
        {
            get
            {
                if (_iP_AddressRepository == null)
                {
                    _iP_AddressRepository = new IP_AddressRepository(_context);
                }

                return _iP_AddressRepository;
            }
        }

        public Log_File_DataRepository Log_File_DataRepository
        {
            get
            {
                if (_log_File_DataRepository == null)
                {
                    _log_File_DataRepository = new Log_File_DataRepository(_context);
                }

                return _log_File_DataRepository;
            }
        }

        public void Save()
        {
            _context.SaveChanges();
        }

        protected virtual void Dispose(bool disposing)
        {
            if (!this._disposed)
            {
                if (disposing)
                {
                    _context.Dispose();
                }
            }
            this._disposed = true;
        }

        public void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);
        }
    }
}
