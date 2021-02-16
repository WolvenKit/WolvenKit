using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using CP77.CR2W.Reflection;

namespace CP77.CR2W.Types
{
    [REDMeta]
	public class CMaterialTemplate : CMaterialTemplate_
    {
        public CMaterialTemplate(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }

        private List<CMaterialTemplateCustomdata> customData = new ();
        public override void Read(BinaryReader file, uint size)
        {
            base.Read(file, size);

            // read additonal data but not expose it, it will be created on write

            if (Parameters == null)
            {
                var zero = file.ReadBytes(2);
                return;
            }

            foreach (var element in Parameters.Elements.Skip(1))
            {
                var count = file.ReadVLQInt32();
                for (int i = 0; i < count; i++)
                {
                    var c = new CMaterialTemplateCustomdata
                    {
                        Type = (EMaterialTemplateType) file.ReadByte(),
                        Offset = file.ReadUInt16(),
                        Name = cr2w.Names[file.ReadUInt16()].Str
                    };

                    customData.Add(c);
                }
            }
        }

        public override void Write(BinaryWriter file)
        {
            base.Write(file);

            if (Parameters == null)
            {
                file.Write((ushort)0x00);
                return;
            }

            foreach (var parameter in Parameters.Skip(1)) //dbg???
            {
                file.WriteVLQInt32(parameter.Count);
                ushort offset = 0;
                foreach (var handle in parameter)
                {
                    if (handle.Reference?.data is not CMaterialParameter param) continue;
                    var nam = param.ParameterName;
                    
                    // write
                    if (!Enum.TryParse(param.REDType, out EMaterialTemplateType type))
                        throw new InvalidParsingException(nameof(CMaterialTemplate));
                    file.Write((byte)(int)type);
                    file.Write(offset);
                    nam.Write(file);

                    offset += _materialTemplateTypeDict[type];
                }
            }
        }

        private class CMaterialTemplateCustomdata
        {
            public EMaterialTemplateType Type { get; init; }
            public ushort Offset { get; init; }
            public string Name { get; init; }
        }

        private readonly Dictionary<EMaterialTemplateType, ushort> _materialTemplateTypeDict = new()
        {
            { EMaterialTemplateType.CMaterialParameterTexture,  8 },
            { EMaterialTemplateType.CMaterialParameterColor,  4 },
            { EMaterialTemplateType.CMaterialParameterCube,  8 },
            { EMaterialTemplateType.CMaterialParameterVector,  16 },
            { EMaterialTemplateType.CMaterialParameterScalar, 4 },

            { EMaterialTemplateType.CMaterialParameterTextureArray, 8 },
            { EMaterialTemplateType.CMaterialParameterStructBuffer, 8 },
            { EMaterialTemplateType.CMaterialParameterCpuNameU64, 8 },
            { EMaterialTemplateType.CMaterialParameterSkinParameters, 8 },
            { EMaterialTemplateType.CMaterialParameterMultilayerSetup, 8 },
            { EMaterialTemplateType.CMaterialParameterMultilayerMask, 8 },
            { EMaterialTemplateType.CMaterialParameterHairParameters, 8 },
            { EMaterialTemplateType.CMaterialParameterFoliageParameters, 8 },
            { EMaterialTemplateType.CMaterialParameterTerrainSetup, 8 },
            { EMaterialTemplateType.CMaterialParameterGradient, 8 },
        };

        private enum EMaterialTemplateType
        {
            CMaterialParameterTexture = 1,  // 8
            CMaterialParameterColor = 2,    // 4
            CMaterialParameterCube = 3,    // 4
            CMaterialParameterVector = 4,   // 16
            CMaterialParameterScalar = 5,   // 4

            CMaterialParameterTextureArray = 7,
            CMaterialParameterStructBuffer = 8,
            CMaterialParameterCpuNameU64 = 9,   // 8
            CMaterialParameterSkinParameters = 10,   // 8
            CMaterialParameterMultilayerSetup = 11,   // 8
            CMaterialParameterMultilayerMask = 12,   // 8
            CMaterialParameterHairParameters = 13,  // 8
            CMaterialParameterFoliageParameters = 14,   // 8
            CMaterialParameterTerrainSetup = 15,    // 8
            CMaterialParameterGradient = 16,   // 8
        }
    }
}
