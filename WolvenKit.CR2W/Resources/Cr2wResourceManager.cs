using CsvHelper;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WolvenKit.Common.Model;

namespace WolvenKit.CR2W.Resources
{
    public class Cr2wResourceManager
    {
        private static Cr2wResourceManager resourceManager;
        public List<HashDump> Hashdumplist { get; set; }



        public static Cr2wResourceManager Get()
        {
            if (resourceManager == null)
            {
                resourceManager = new Cr2wResourceManager();
            }
            return resourceManager;
        }

        public Cr2wResourceManager()
        {
            using (var reader = new StringReader(Properties.Resources.pathhashes))
            using (var csv = new CsvReader(reader, CultureInfo.InvariantCulture))
            {
                Hashdumplist = csv.GetRecords<HashDump>().ToList();
            }
        }

    }
}
