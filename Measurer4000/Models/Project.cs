﻿using System.Collections.Generic;

namespace Measurer4000.Models
{
    public class Project
    {
        public Project()
        {
            Files = new List<ProgrammingFile>();
            Platform = EnumPlatform.None;
        }

        public List<ProgrammingFile> Files { get; set; }

        public EnumPlatform Platform { get; set; }

        public string Name { get; set; }

        public string Path { get; set; }        
    }
}
