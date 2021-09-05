using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WolvenKit.Common.Model
{
    public class WolvenKitFileDefinitions
    {
        public List<FileCategoryModel> Categories { get; set; } = new();
    }

    public class FileCategoryModel
    {
        public string Name { get; set; }

        public string Description { get; set; }

        public List<AddFileModel> Files { get; set; }
    }

    public class AddFileModel
    {
        public string Name { get; set; }

        public string Description { get; set; }

        public string Extension { get; set; }

        public EWolvenKitFile Type { get; set; }
    }

    
}
