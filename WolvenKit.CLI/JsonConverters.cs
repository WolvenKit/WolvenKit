using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Dynamic;
using System.Linq;
using System.Reflection;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using Newtonsoft.Json.Linq;
using Newtonsoft.Json.Serialization;
using WolvenKit.Common.Model.Cr2w;
using WolvenKit.RED4.CR2W;
using WolvenKit.RED4.CR2W.Types;

namespace WolvenKit.CLI
{
    public class CVarContractResolver : DefaultContractResolver
    {
        public static readonly CVarContractResolver Instance = new CVarContractResolver();

        protected override JsonProperty CreateProperty(MemberInfo member, MemberSerialization memberSerialization)
        {
            var property = base.CreateProperty(member, memberSerialization);

            if (property.PropertyType == null)
            {
                return property;
            }

            if (property.PropertyType.IsSubclassOf(typeof(CVariable)))
            {
                property.ShouldSerialize = (o) =>
                {
                    var e = (CVariable)o;

                    var s = property.PropertyName;
                    var p = e.accessor[o,s];
                    if (p is CVariable x)
                    {
                        return x.IsSerialized;
                    }

                    return e.IsSerialized;
                };
            }

            return property;
        }


    }


    public class Red4W2rcFileDto
    {
        public const string Magic = "w2rc";

        public Red4W2rcFileDto()
        {

        }

        public List<CR2WExportWrapperDto> Chunks { get; set; } = new();

        public List<CR2WBufferWrapperDto> Buffers { get; set; } = new();


        public Red4W2rcFileDto FromW2rc(CR2WFile cr2w)
        {
            this.Chunks = cr2w.Chunks.Select(_ => new CR2WExportWrapperDto(_)).ToList();
            this.Buffers = cr2w.Buffers.Select(_ => new CR2WBufferWrapperDto(_)).ToList();

            return this;
        }

        public CR2WFile ToW2rc()
        {
            var cr2w = new CR2WFile();

            return cr2w;
        }
    }

    public class CR2WExportWrapperDto
    {
        public string Type { get; set; }
        public int ParentChunkIndex { get; set; }
        public CVariableDto Data { get;set; }

        public CR2WExportWrapperDto()
        {

        }

        public CR2WExportWrapperDto(ICR2WExport cr2WExport)
        {
            Type = cr2WExport.REDType;
            ParentChunkIndex = cr2WExport.ParentChunkIndex;
            Data = new CVariableDto().FromCvariable(cr2WExport.Data);
        }

    }

    public class CVariableDto
    {
        public Dictionary<string, object> Properties { get; set; } = new();
        public bool ShouldSerializeProperties() => (Properties.Count > 0);

        public CVariableDto()
        {

        }


        public CVariableDto FromCvariable(IEditableVariable data)
        {
            foreach (var cvar in data.SerializedProperties)
            {
                switch (cvar)
                {
                    case IEnumAccessor b:
                        Properties.Add(cvar.REDName, b.EnumValueList);
                        break;
                    case IEditorBindable b:
                        dynamic d = b;
                        Properties.Add(cvar.REDName, d.Value);
                        break;
                    default:
                        Properties.Add(cvar.REDName, new CVariableDto().FromCvariable(cvar));
                        break;
                }
            }

            return this;
        }
    }

    public class CR2WBufferWrapperDto
    {
        public uint Flags { get; set; }
        public uint Index { get; set; }

        public CR2WBufferWrapperDto()
        {

        }

        public CR2WBufferWrapperDto(ICR2WBuffer cr2WBuffer)
        {
            Flags = cr2WBuffer.Flags;
            Index = cr2WBuffer.Index;
        }
    }

}
