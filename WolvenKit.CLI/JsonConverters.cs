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
using WolvenKit.RED4.CR2W;
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

        public Red4W2rcFileDto()
        {

        }

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

            return cr2w;
        }
    }

    [Serializable]
    public class CR2WExportWrapperDto: ISerializable
    {
        public int ParentChunkIndex { get; set; }
        public CVariableDto Data { get;set; }

        public CR2WExportWrapperDto()
        {

        }

        protected CR2WExportWrapperDto(SerializationInfo info, StreamingContext context)
        {

        }

        public void GetObjectData(SerializationInfo info, StreamingContext context)
        {
            info.AddValue(nameof(ParentChunkIndex), ParentChunkIndex);
            info.AddValue(nameof(Data), Data.Properties);
        }

        public CR2WExportWrapperDto(ICR2WExport cr2WExport)
        {
            ParentChunkIndex = cr2WExport.ParentChunkIndex;
            Data = new CVariableDto().FromCvariable(cr2WExport.Data);
        }

    }

    [Serializable]
    public class CVariableDto : IDictionary<string,object>
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
                    case IREDPrimitive b:
                        Properties.Add(cvar.REDName, b.GetValue());
                        break;
                    case IREDArray b:
                        dynamic array = b;
                        Properties.Add(cvar.REDName, array.Elements);
                        break;
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
    }

}
