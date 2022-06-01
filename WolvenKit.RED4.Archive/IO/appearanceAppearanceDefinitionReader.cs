using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WolvenKit.RED4.Archive.Buffer;
using WolvenKit.RED4.Types;

namespace WolvenKit.RED4.Archive.IO
{
    public class appearanceAppearanceDefinitionReader : RedPackageReader
    {
        public appearanceAppearanceDefinitionReader(Stream input) : base(input)
        {
        }

        public appearanceAppearanceDefinitionReader(BinaryReader reader) : base(reader)
        {
        }

        public override EFileReadErrorCodes ReadBuffer(RedBuffer buffer)
        {
            var code = base.ReadBuffer(buffer);
            if (code == EFileReadErrorCodes.NoError)
            {
                if (buffer.Parent is appearanceAppearanceDefinition aad && buffer.Data is RedPackage rp)
                {
                    aad.Components = new();
                    foreach (var component in rp.Chunks)
                    {
                        if (component is entIComponent eic)
                        {
                            aad.Components.Add(eic);
                        }
                    }
                }
            }

            return code;
        }
    }
}
