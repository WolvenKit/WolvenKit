using WolvenKit.RED4.Archive.Buffer;
using WolvenKit.RED4.Types;

namespace WolvenKit.RED4.Archive.IO;

public class entEntityTemplateReader : RedPackageReader
{
    public entEntityTemplateReader(Stream input) : base(input)
    {
    }

    public entEntityTemplateReader(BinaryReader reader) : base(reader)
    {
    }

    public override EFileReadErrorCodes ReadBuffer(RedBuffer buffer)
    {
        var code = base.ReadBuffer(buffer);
        if (code == EFileReadErrorCodes.NoError)
        {
            if (buffer.Parent is entEntityTemplate entityTemplate && buffer.Data is RedPackage rp)
            {
                if (rp.RootChunk is entEntity ee)
                {
                    entityTemplate.Entity = new(ee);
                }
                entityTemplate.Components = new();
                foreach (var component in rp.Chunks)
                {
                    if (component is entIComponent eic)
                    {
                        entityTemplate.Components.Add(eic);
                    }
                    // maybe should catch/look for items that differ?
                }
            }
        }

        return code;
    }
}