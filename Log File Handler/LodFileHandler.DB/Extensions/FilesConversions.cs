using LodFileHandler.DB.DataModels;
using LodFileHandler.DB.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LodFileHandler.DB.Extensions
{
    public static class FilesConversions
    {
        public static Files ToSqlModel(this FilesDto filesDto)
        {
            if (filesDto == null)
            {
                return null;
            }

            return new Files
            {
                Id = filesDto.Id,
                File_Name= filesDto.File_Name,
                File_Size=filesDto.File_Size,
                Path=filesDto.Path
            };
        }

        public static FilesDto ToDtoModel(this Files files)
        {
            if (files == null)
            {
                return null;
            }

            return new FilesDto
            {
                Id = files.Id,
                File_Name = files.File_Name,
                File_Size = files.File_Size,
                Path = files.Path
            };
        }
    }
}
