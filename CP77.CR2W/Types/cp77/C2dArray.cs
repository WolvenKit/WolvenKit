using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FastMember;
using WolvenKit.CR2W;
using WolvenKit.CR2W.Reflection;
using WolvenKit.CR2W.Types;

namespace WolvenKit.CR2W.Types
{
	[REDMeta]
    public class C2dArray : CVariable
    {
        [Ordinal(0)] [RED("cookingPlatform")] public CEnum<Enums.ECookingPlatform> CookingPlatform { get; set; }
        [Ordinal(1)] [RED("headers")] public CArray<CString> Headers { get; set; }
        [Ordinal(2)] [RED("data")] public CArray<CArray<CString>> Data { get; set; }
        public C2dArray(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }

        public void ToCsvStream(Stream stream, char seperator = ',')
        {
            using var writer = new StreamWriter(stream);

            // write header
            if (Headers?.Elements == null) return;
            string headerline = string.Join(seperator, Headers.Elements.Select(_ => _.val));
            writer.WriteLine(headerline);
            
            // write body
            if (Data?.Elements == null) return;
            foreach (var dataElement in Data.Elements)
            {
                string dataline = string.Join(seperator, dataElement.Elements.Select(_ => _.val));
                writer.WriteLine(dataline);
            }
        }
        
    }
}
