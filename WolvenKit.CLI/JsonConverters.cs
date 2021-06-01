using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Dynamic;
using System.Linq;
using System.Reflection;
using System.Runtime.Serialization;
using System.Security.Permissions;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using Newtonsoft.Json.Linq;
using Newtonsoft.Json.Serialization;
using WolvenKit.Common.Model.Cr2w;
using WolvenKit.Interfaces.Core;
using WolvenKit.Interfaces.Extensions;
using WolvenKit.RED4.CR2W;
using WolvenKit.RED4.CR2W.Reflection;
using WolvenKit.RED4.CR2W.Types;
using ISerializable = System.Runtime.Serialization.ISerializable;

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

        public Dictionary<string,CR2WExportWrapperDto> Chunks { get; set; } = new();

        public List<CR2WBufferWrapperDto> Buffers { get; set; } = new();


        public Red4W2rcFileDto FromW2rc(CR2WFile cr2w)
        {
            this.Chunks = cr2w.Chunks
                .ToDictionary(_ => _.REDType, _ => new CR2WExportWrapperDto(_));
            this.Buffers = cr2w.Buffers.Select(_ => new CR2WBufferWrapperDto(_)).ToList();

            return this;
        }

        public CR2WFile ToW2rc()
        {
            var cr2w = new CR2WFile();

            // buffers
            cr2w.Buffers = Buffers
                .OrderBy(_ => _.Index)
                .Select(_ => _.ToRedBuffer())
                .ToList();

            // chunks
            // order so that parent chunks get created first
            var groupedChunks = Chunks
                .GroupBy(_ => _.Value.ParentChunkIndex);
            var cr2wChunks = new List<CR2WExportWrapper>();
            foreach (var groupedChunk in groupedChunks)
            {
                foreach (var (key, value) in groupedChunk.OrderBy(_ => _.Value.ChunkIndex))
                {
                    cr2wChunks.Add(value.ToRedExport(cr2w, key));
                }
            }

            // add to cr2w file
            foreach (var cr2WExportWrapper in cr2wChunks.OrderBy(_ => _.ChunkIndex))
            {
                cr2w.Chunks.Add(cr2WExportWrapper);
            }

            return cr2w;
        }
    }

    public class CR2WExportWrapperDto
    {
        public int ChunkIndex { get; set; }
        public int ParentChunkIndex { get; set; }
        public CVariableDto Data { get;set; }


        public CR2WExportWrapperDto() { }

        public CR2WExportWrapperDto(ICR2WExport cr2WExport)
        {
            ChunkIndex = cr2WExport.ChunkIndex;
            ParentChunkIndex = cr2WExport.ParentChunkIndex;
            Data = new CVariableDto().FromCvariable(cr2WExport.Data);
        }

        public CR2WExportWrapper ToRedExport(CR2WFile cr2WFile, string argKey)
        {
            var parentChunk = ParentChunkIndex == -1
                ? null
                : cr2WFile.Chunks.First(_ => _.ChunkIndex == ParentChunkIndex);

            // create wrapped Cvariable
            var cvar = CR2WTypeManager.Create(argKey, argKey, cr2WFile, parentChunk?.Data as CVariable);
            // add data
            PopulateCVarData(ref cvar, Data);

            var export = cr2WFile.CreateChunk(cvar, ChunkIndex, parentChunk as CR2WExportWrapper);

            return export;
        }

        private static void PopulateCVarData(ref CVariable cvar, CVariableDto cVariableDto)
        {
            foreach (var (propertyName, value) in cVariableDto)
            {
                var cobj = GetRedProperty(cvar, propertyName);
                if (cobj == null)
                {
                    throw new InvalidParsingException("not a CVariable");
                }

                switch (value)
                {
                    // complex objects are JObjects and can be deserialized as CVariableDto (recursive)
                    case JObject jObject:
                        var dict = jObject.ToObject<CVariableDto>();
                        PopulateCVarData(ref cobj, dict);
                        break;
                    // simple objects are JTokens and can be directly (needs type info from redproperty)
                    case JToken jToken:
                        cobj.SetValue(DeserializeRedValue(cobj, jToken));
                        break;
                    // primitive types can be set directly
                    default:
                        switch (value)
                        {
                            // all numeric values are deserialized as long
                            case long l:
                                cobj.SetValue(l.ToString()); // cast to string to do the parsing in the classes :/
                                break;
                            // other primitive types can be set directly
                            case bool b: cobj.SetValue(b); break;
                            case string s: cobj.SetValue(s); break;
                            default:
                                throw new InvalidParsingException("file format not supported");
                        }
                        break;
                }
            }
        }

        private static object DeserializeRedValue(CVariable cobj, JToken value)
        {
            switch (cobj)
            {
                // enums are serialized as list of strings
                case IREDEnum b:
                    return value.ToObject<List<string>>();
                // ???
                case IREDBool b:
                    return value.ToObject<bool>();
                default:
                    throw new InvalidParsingException("not a CVariable");
            }
        }

        private static CVariable GetRedProperty(CVariable cvar, string propertyName)
        {
            foreach (var member in REDReflection.GetMembers(cvar))
            {
                try
                {
                    var redname = REDReflection.GetREDNameString(member);
                    if (redname != propertyName)
                    {
                        continue;
                    }

                    var prop = cvar.accessor[cvar, member.Name];
                    return prop as CVariable;
                }
                catch (Exception e)
                {
                    Console.WriteLine(e);
                    throw;
                }
            }

            return null;
        }
    }




    public class CVariableDto : IDictionary<string,object>
    {
        public Dictionary<string, object> Properties { get; set; } = new();
        public bool ShouldSerializeProperties() => (Properties.Count > 0);

        public CVariableDto FromCvariable(IEditableVariable data)
        {
            foreach (var cvar in data.SerializedProperties)
            {
                switch (cvar)
                {
                    // primitive types are serialized as their wrapped net primitives
                    case IREDPrimitive b:
                        Properties.Add(cvar.REDName, b.GetValue());
                        break;
                    // arrays are serialized as lists of CVariableDtos
                    case IREDArray b:
                        dynamic array = b;
                        if (array.Elements is not IList dyn)
                        {
                            throw new InvalidParsingException("Invalid File");
                        }
                        var c = dyn
                            .Cast<IEditableVariable>()
                            .Select(_ => new CVariableDto().FromCvariable(_));
                        Properties.Add(cvar.REDName, c);
                        break;
                    // default for complex properties is as CVariableDto
                    default:
                        Properties.Add(cvar.REDName, new CVariableDto().FromCvariable(cvar));
                        break;
                }
            }

            return this;
        }

        #region implements IDictionary

        public IEnumerator<KeyValuePair<string, object>> GetEnumerator() => Properties.GetEnumerator();

        IEnumerator IEnumerable.GetEnumerator() => ((IEnumerable)Properties).GetEnumerator();

        public void Add(KeyValuePair<string, object> item) => Properties.Add(item.Key, item.Value);

        public void Clear() => Properties.Clear();

        public bool Contains(KeyValuePair<string, object> item) => Properties.Contains(item);

        public void CopyTo(KeyValuePair<string, object>[] array, int arrayIndex) => ((IDictionary<string,object>)Properties).CopyTo(array, arrayIndex);

        public bool Remove(KeyValuePair<string, object> item) => Properties.Remove(item.Key);

        public int Count => Properties.Count;

        public bool IsReadOnly => ((IDictionary<string,object>)Properties).IsReadOnly;

        public void Add(string key, object value) => Properties.Add(key, value);

        public bool ContainsKey(string key) => Properties.ContainsKey(key);

        public bool Remove(string key) => Properties.Remove(key);

        public bool TryGetValue(string key, out object value) => Properties.TryGetValue(key, out value);

        public object this[string key]
        {
            get => Properties[key];
            set => Properties[key] = value;
        }

        public ICollection<string> Keys => ((IDictionary<string,object>)Properties).Keys;

        public ICollection<object> Values => ((IDictionary<string,object>)Properties).Values;

        #endregion
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

        public ICR2WBuffer ToRedBuffer() =>
            new CR2WBufferWrapper(new CR2WBuffer()
            {
                flags = Flags,
                index = Index
            });
    }

}
