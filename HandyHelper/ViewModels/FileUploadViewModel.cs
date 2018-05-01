﻿using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HandyHelper.ViewModels
{
    public class FileUploadViewModel
    {
        public IFormFile File { get; set; }

        public string Source { get; set; }

        public long Size { get; set; }

        public int Width { get; set; }

        public int Height { get; set; }

        public string Extension { get; set; }
    }
}
