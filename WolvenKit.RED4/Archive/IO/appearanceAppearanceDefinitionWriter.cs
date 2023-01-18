using System.Collections.Generic;
using System.IO;
using WolvenKit.RED4.Archive.Buffer;
using WolvenKit.RED4.Types;

namespace WolvenKit.RED4.Archive.IO
{
    public class appearanceAppearanceDefinitionWriter : RedPackageWriter
    {
        public appearanceAppearanceDefinitionWriter(Stream input) : base(input)
        {
        }

        public void WritePackage(appearanceAppearanceDefinition appearanceDefinition, RedPackage buffer)
        {
            Settings.ImportsAsHash = true;

            buffer.Chunks = new List<RedBaseClass>();
            foreach (var component in appearanceDefinition.Components)
            {
                buffer.Chunks.Add(component);
            }
            base.WritePackage(buffer);
        }
    }
}
