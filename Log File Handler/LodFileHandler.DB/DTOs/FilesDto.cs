﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LodFileHandler.DB.DTOs
{
    public class FilesDto
    {
        public int Id { get; set; }

        public string File_Name { get; set; }

        public string Path { get; set; }

        public int? File_Size { get; set; }

    }
}
