using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Dynamic;
using System.IO;
using System.Linq;
using System.Numerics;
using System.Reflection;
using System.Runtime.Serialization;
using System.Security.Permissions;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using Newtonsoft.Json.Linq;
using Newtonsoft.Json.Serialization;
using WolvenKit.Common.Model;
using WolvenKit.Common.Model.Cr2w;
using WolvenKit.Interfaces.Core;
using WolvenKit.Interfaces.Extensions;
using WolvenKit.RED4.CR2W;
using WolvenKit.RED4.CR2W.Reflection;
using WolvenKit.RED4.CR2W.Types;
using ISerializable = System.Runtime.Serialization.ISerializable;

namespace WolvenKit.CLI
{
    public static class Red4Serializer
    {
        /// <summary>
        /// Parse
        /// </summary>
        /// <param name="cVariable"></param>
        /// <param name="value">either a JArray, JObject or primitive value</param>
        /// <exception cref="InvalidParsingException"></exception>
        private static void SetFromJObject(this IEditableVariable cVariable, object value)
        {
            // switch over the jobject
            switch (value)
            {
                // enums and arrays are JArrays and can be directly deserialized
                case JArray jArray:
                    switch (cVariable)
                    {
                        // enums are serialized as list of strings
                        case IREDEnum:
                            var enumobj = jArray.ToObject<List<string>>();
                            if (enumobj == null)
                            {
                                throw new InvalidParsingException("not a CVariable");
                            }
                            cVariable.SetValue(enumobj);
                            break;
                        // arrays
                        case ICurveDataAccessor b:

                            break;
                        case IREDArray redArray:
                            var listOfObjects = jArray.ToObject<List<object>>();
                            if (listOfObjects == null)
                            {
                                throw new InvalidParsingException("not a CVariable");
                            }
                            for (var i = 0; i < listOfObjects.Count; i++)
                            {
                                var jitem = listOfObjects[i];
                                var element = redArray.GetElementInstance(i.ToString());
                                // parse the elements according to the array type
                                element.SetFromJObject(jitem);
                                redArray.AddVariable(element);
                            }
                            break;
                        default:
                            throw new InvalidParsingException("not a CVariable");
                    }
                    break;
                // complex objects are JObjects and can be deserialized as CVariableDto (recursive)
                case JObject jObject:
                    cVariable.SetFromDictionary(jObject.ToObject<Dictionary<string,object>>());
                    break;
                // does that ever happen?
                case JToken jToken:
                    throw new InvalidParsingException("file format not supported");
                // primitive types can be set directly
                default:
                    switch (value)
                    {
                        // all numeric values
                        case long:
                        case double:
                        case BigInteger:
                            cVariable.SetValue(value.ToString()); // cast to string to do the parsing in the classes :/
                            break;
                        // other primitive types can be set directly
                        case bool b:
                            cVariable.SetValue(b);
                            break;
                        case string s:
                            cVariable.SetValue(s);
                            break;
                        default:
                            throw new InvalidParsingException("file format not supported");
                    }

                    break;
            }
        }

        public static void SetFromDictionary(this IEditableVariable cvar, Dictionary<string,object> dictionary)
        {
            if (cvar is IREDVariant var)
            {
                var type = dictionary["Type"] as string;
                var name = "Variant";
                if (dictionary.ContainsKey("Name"))
                {
                    name = dictionary["Name"] as string;
                }

                var jvalue = dictionary["Variant"];
                var variant = CR2WTypeManager.Create(type, name, cvar.Cr2wFile as IRed4EngineFile, cvar as CVariable);
                variant.IsSerialized = true;
                variant.SetFromJObject(jvalue);
                var.SetVariant(variant);

                return;
            }

            foreach (var (propertyName, value) in dictionary)
            {
                var redProperty = GetRedProperty(cvar, propertyName);
                if (redProperty == null)
                {
                    throw new InvalidParsingException("not a CVariable");
                }
                redProperty.SetFromJObject(value);
            }
        }

        private static CVariable GetRedProperty(IEditableVariable cvar, string propertyName)
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
                    var cprop = prop as CVariable;

                    return cprop;
                }
                catch (Exception e)
                {
                    Console.WriteLine(e);
                    throw;
                }
            }

            return null;
        }

        public static object ToObject(this IEditableVariable data)
        {
            switch (data)
                {
                    case CDateTime d:
                        return d.ToUInt64();
                    // special cases of primitive types
                    case CVariant var:
                        return new Dictionary<string, object>()
                        {
                            {"Type", var.Variant.REDType},
                            {"Variant", var.Variant.ToObject()}
                        };
                    case CVariantSizeNameType varnt:
                        return new Dictionary<string, object>()
                        {
                            {"Type", varnt.Variant.REDType},
                            {"Name", varnt.Variant.REDName},
                            {"Variant", varnt.Variant.ToObject()}
                        };
                    case IREDCurvePoint cp:
                        if (cp.GetValue() is Tuple<IEditableVariable, IEditableVariable>(var item1, var item2))
                        {
                            return new Dictionary<string, object>() {{"Value", item1.ToObject()}, {"Point", item2.ToObject()}};
                        }
                        throw new InvalidParsingException($"{data.REDType} ToObject");
                    // serialize primitive types directly
                    case IREDPrimitive b:
                        return b.GetValue();
                    // serialize arrays as list of objects
                    // serialize curves as array
                    case IREDArray:
                    case ICurveDataAccessor:
                        dynamic array = data;
                        if (array.Elements is not IList dyn)
                        {
                            throw new InvalidParsingException("Invalid File");
                        }
                        return dyn
                            .Cast<IEditableVariable>()
                            .Select(_ => _.ToObject());
                    // serialize complex properties as Dictionary
                    default:
                        var dict = new Dictionary<string, object>();
                        foreach (var cvar in data.SerializedProperties)
                        {
                            dict.Add(cvar.REDName, cvar.ToObject());
                        }

                        return dict;
                }

        }
    }


    #region models

    public class Red4W2rcFileDto
    {
        public const string Magic = "w2rc";

        public string Extension { get; set; }

        public Dictionary<int,CR2WExportWrapperDto> Chunks { get; set; } = new();

        public List<CR2WBufferWrapperDto> Buffers { get; set; } = new();

        public bool ShouldSerializeBuffers() => (Buffers.Count > 0);

        public Red4W2rcFileDto()
        {

        }

        public Red4W2rcFileDto(IWolvenkitFile cr2w)
        {
            Extension = Path.GetExtension(cr2w.FileName);
            Chunks = cr2w.Chunks
                .ToDictionary(_ => _.ChunkIndex, _ => new CR2WExportWrapperDto(_));
            Buffers = cr2w.Buffers.Select(_ => new CR2WBufferWrapperDto(_)).ToList();
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
                .GroupBy(_ => _.Value.ParentIndex);
            foreach (var groupedChunk in groupedChunks)
            {
                foreach (var (key, value) in groupedChunk.OrderBy(_ => _.Key))
                {
                    value.CreateChunkInFile(cr2w, key);
                }
            }

            return cr2w;
        }
    }

    public class CR2WExportWrapperDto
    {
        public string Type { get; set; }

        //public int ChunkIndex { get; set; }
        public int ParentIndex { get; set; }
        public Dictionary<string,object> Properties { get;set; }

        public bool ShouldSerializeProperties() => (Properties.Count > 0);

        public CR2WExportWrapperDto()
        {

        }

        public CR2WExportWrapperDto(ICR2WExport cr2WExport)
        {
            Type = cr2WExport.REDType;

            //ChunkIndex = cr2WExport.ChunkIndex;
            ParentIndex = cr2WExport.ParentChunkIndex;
            var cvarAsDict = cr2WExport.Data.ToObject();
            if (cvarAsDict is Dictionary<string, object> dict)
            {
                Properties = dict;
            }
        }

        public void CreateChunkInFile(CR2WFile cr2WFile, int idx)
        {
            var parentChunk = ParentIndex == -1
                ? null
                : cr2WFile.Chunks.First(_ => idx == ParentIndex);

            // create wrapped Cvariable
            var cvar = CR2WTypeManager.Create(Type, Type, cr2WFile, parentChunk?.Data as CVariable);
            // add data
            cvar.SetFromDictionary(Properties);

            cr2WFile.CreateChunk(cvar, idx, parentChunk as CR2WExportWrapper);
        }

    }

    public class CR2WBufferWrapperDto
    {
        public uint Flags { get; set; }
        public uint Index { get; set; }

        // public uint Offset { get; set; }
        // public uint DiskSize { get; set; }
        // public uint MemSize { get; set; }
        // public uint Crc32 { get; set; }

        public CR2WBufferWrapperDto()
        {

        }

        public CR2WBufferWrapperDto(ICR2WBuffer cr2WBuffer)
        {
            Flags = cr2WBuffer.Flags;
            Index = cr2WBuffer.Index;
            // Offset = cr2WBuffer.Offset;
            // DiskSize = cr2WBuffer.DiskSize;
            // MemSize = cr2WBuffer.MemSize;
            // Crc32 = cr2WBuffer.Crc32;
        }

        public ICR2WBuffer ToRedBuffer() =>
            new CR2WBufferWrapper(new CR2WBuffer()
            {
                flags = Flags,
                index = Index,
                // offset = Offset,
                // diskSize = DiskSize,
                // memSize = MemSize,
                // crc32 = Crc32,
            });
    }

    #endregion

}
