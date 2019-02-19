using LodFileHandler.DB.DataModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LodFileHandler.DB.Repository
{
    public interface IIP_AddressRepository
    {
        void Add(IP_Address iP_Address);

        IP_Address GetDeteils(int id);

        List<IP_Address> GetAll();

        void Delete(int id);

        void Update(IP_Address iP_Address); 

    }

    public class IP_AddressRepository : IIP_AddressRepository
    {
        private LogFileDataModel _context;

        public IP_AddressRepository(LogFileDataModel context)
        {
            _context = context;
        }

        public void Add(IP_Address iP_Address)
        {
            _context.IP_Address.Add(iP_Address);
        }

        public void Delete(int id)
        {
            _context.IP_Address.Remove(GetDeteils(id));
        }

        public IP_Address GetDeteils(int id)
        {
            return _context.IP_Address.FirstOrDefault(x=>x.Id == id);
        }

        public List<IP_Address> GetAll()
        {
            return _context.IP_Address.ToList();
        }

        public void Update(IP_Address iP_Address)
        {
            var oldIp_Address = GetDeteils(iP_Address.Id);

            oldIp_Address.IP_Address1 = iP_Address.IP_Address1;
            oldIp_Address.Сompany_Name = iP_Address.Сompany_Name;
        }
    }
}
