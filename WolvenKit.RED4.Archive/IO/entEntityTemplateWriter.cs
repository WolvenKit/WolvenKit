using System.Collections.Generic;
using System.IO;
using WolvenKit.RED4.Archive.Buffer;
using WolvenKit.RED4.Types;

namespace WolvenKit.RED4.Archive.IO
{
    public class entEntityTemplateWriter : RedPackageWriter
    {
        public entEntityTemplateWriter(Stream input) : base(input)
        {
        }

        public void WritePackage(entEntityTemplate eet, RedPackage buffer)
        { 
            buffer.Chunks = new List<RedBaseClass>();
            buffer.Chunks.Add(eet.Entity);
            foreach (var component in eet.Components)
            {
                buffer.Chunks.Add(component);
            }
            base.WritePackage(buffer);
        }
    }
}
