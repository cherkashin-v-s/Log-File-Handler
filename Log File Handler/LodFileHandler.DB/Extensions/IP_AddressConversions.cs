using LodFileHandler.DB.DataModels;
using LodFileHandler.DB.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LodFileHandler.DB.Extensions
{
    public static class IP_AddressConversions
    {
        public static IP_Address ToSqlModel(this IP_AddressDto iP_AddressDto)
        {
            if (iP_AddressDto == null)
            {
                return null;
            }

            return new IP_Address
            {
                Id = iP_AddressDto.Id,
                IP_Address1 = iP_AddressDto.IP_Address1,
                Сompany_Name = iP_AddressDto.Сompany_Name
            };
        }

        public static IP_AddressDto ToDtoModel(this IP_Address iP_Address)
        {
            if (iP_Address == null)
            {
                return null;
            }

            return new IP_AddressDto
            {
                Id = iP_Address.Id,
                IP_Address1 = iP_Address.IP_Address1,
                Сompany_Name = iP_Address.Сompany_Name
            };
        }
    }
}
