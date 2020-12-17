//using RED.CRC32;
using System;
using System.Collections.Generic;
using System.IO;
using WolvenKit.CR2W.Types;
using System.Runtime.InteropServices;
//using System.Linq;
using System.Runtime.Serialization;
using System.Xml;
using System.Linq;
using System.IO.MemoryMappedFiles;
using System.Threading.Tasks;
using System.Diagnostics;
using System.Text;
using Newtonsoft.Json;
using WolvenKit.Common.Extensions;
using WolvenKit.CR2W.Reflection;

[assembly: ContractNamespaceAttribute("", ClrNamespace = "WolvenKit.CR2W")]

namespace WolvenKit.CR2W
{

    [StructLayout(LayoutKind.Explicit, Size = 24)]
    public struct CR2WExport
    {
        [DataMember]
        [FieldOffset(0)]
        public ushort className;        //needs to be registered upon new creation and updated on file write!   //done

        [DataMember]
        [FieldOffset(2)]
        public ushort objectFlags;      // 0 means uncooked, 8192 is cooked //TODO

        [DataMember]
        [FieldOffset(4)]
        // 0 means no parent, 1 is chunkID 0
        // CDPR had the horrendous idea to put an uint here.
        // So parentID really is [1;n], with 0 to denote a null parent...
        // ... when it could have been the usual int [0;n], with -1 for null parent.
        // We will thus touch this stupidity as little as possible, and rather interact with the wrapper
        // CR2WExportWrapper.ParentChunkIndex.
        public uint parentID;

        [DataMember]
        [FieldOffset(8)]
        public uint dataSize;           // created upon data write  //done

        [DataMember]
        [FieldOffset(12)]
        public uint dataOffset;         // created upon data write  //done

        [DataMember]
        [FieldOffset(16)]
        public uint template;           // can be 0 //TODO?

        [DataMember]
        [FieldOffset(20)]
        public uint crc32;              // created upon write   //done
    }

    public class CR2WExportWrapper
    {

        #region  Constructors
        /// <summary>
        /// This constructor should be used when manually creating chunks
        /// </summary>
        /// <param name="file"></param>
        /// <param name="redtype"></param>
        /// <param name="parentchunk"></param>
        /// <param name="cooked"></param>
        public CR2WExportWrapper(CR2WFile file, string redtype, CR2WExportWrapper parentchunk, bool cooked = false)
        {
            _export = new CR2WExport
            {
                objectFlags = (ushort)(cooked ? 8192 : 0),
            };
            AdReferences = new List<IChunkPtrAccessor>();
            AbReferences = new List<IChunkPtrAccessor>();

            this.cr2w = file;
            this.REDType = redtype;
            ParentChunk = parentchunk;
        }

        /// <summary>
        /// This constructor is only used in cr2w parsing = deserialization
        /// </summary>
        /// <param name="export"></param>
        /// <param name="file"></param>
        public CR2WExportWrapper(CR2WExport export, CR2WFile file)
        {
            this.cr2w = file;
            _export = export;

            REDType = cr2w.Names[export.className].Str;
            AdReferences = new List<IChunkPtrAccessor>();
            AbReferences = new List<IChunkPtrAccessor>();
        }
        #endregion

        #region Fields
        private CR2WExport _export;


        #endregion

        #region Properties
        [JsonIgnore]
        public CR2WFile cr2w { get; }


        public CR2WExport Export => _export;
        public CVariable data { get; private set; }
        public string REDType { get; private set; }
        public string REDName => REDType + " #" + (ChunkIndex);

        /// <summary>
        /// This property is used as BindingProperty in frmChunkProperties
        /// Do not delete!
        /// </summary>
        [JsonIgnore]
        public string REDValue => this.ToString();


        [NonSerialized]
        [JsonIgnore]
        public CBytes unknownBytes;


        /// <summary>
        /// Main CR2WExport.parentId wrapper
        /// </summary>
        public int ParentChunkIndex
        {
            get => (int)_export.parentID - 1;
            private set => _export.parentID = (uint)(value + 1);
        }

        [JsonIgnore]
        public CR2WExportWrapper ParentChunk
        {
            get => ParentChunkIndex == -1 ? null : cr2w.Chunks[ParentChunkIndex];
            set => ParentChunkIndex = value == null ? -1 : cr2w.Chunks.IndexOf(value);
        }
        [JsonIgnore]
        public CR2WExportWrapper VirtualParentChunk { get; set; }

        [JsonIgnore]
        public int VirtualParentChunkIndex => cr2w.Chunks.IndexOf(VirtualParentChunk);

        [JsonIgnore]
        public List<CR2WExportWrapper> ChildrenChunks => cr2w.Chunks.Where(_ => _.ParentChunk == this).ToList();

        [JsonIgnore]
        public List<CR2WExportWrapper> VirtualChildrenChunks => cr2w.Chunks.Where(_ => _.VirtualParentChunk == this).ToList();

        /// <summary>
        /// Playing with latin here, ab means toward, ab away from.
        /// This is the directed-graph in-edge list :
        /// CVariables, being CPtr or CHandle, which reference this chunk.
        /// </summary>
        [JsonIgnore]
        public List<IChunkPtrAccessor> AdReferences;

        /// <summary>
        /// Playing with latin here, ab means toward, ab away from.
        /// This is the directed-graph out-edge list :
        /// CVariables, being CPtr or CHandle, which are referenced by this chunk.
        /// </summary>
        [JsonIgnore]
        public List<IChunkPtrAccessor> AbReferences;


        public int ChunkIndex => cr2w.Chunks.IndexOf(this);

        /// <summary>
        /// This property is used as BindingProperty in frmChunkProperties
        /// Do not delete!
        /// </summary>
        [JsonIgnore]
        public string Preview
        {
            get
            {
                var vars = data.GetEditableVariables();
                var firstString = vars
                        .Where(_ => _ is CString)
                        .Cast<CString>()
                        .FirstOrDefault(_ => _.val != null)
                    ;
                if (firstString != null)
                {
                    return firstString.val;
                }

                var firstName = vars
                        .Where(_ => (_ is CName))
                        .Cast<CName>()
                        .FirstOrDefault(_ => _.Value != null)
                    ;
                return firstName != null ? firstName.Value : "";
            }
        }

        [JsonIgnore]
        public bool IsSerialized => true;

        #endregion

        #region Methods

        public class Cr2wVariableDumpObject
        {
            public string Name { get; set; }
            public string Type { get; set; }
            public int Size { get; set; }
            public long Offset { get; set; }

            public List<Cr2wVariableDumpObject> Variables { get; set; } = new List<Cr2wVariableDumpObject>();



            public string ToVarString()
            {
                var wktype = REDReflection.GetWKitBaseTypeFromREDBaseType(Type);
                return $"[RED(\"{Name}\")] public {wktype} {Name.FirstCharToUpper()} {{ get; set; }}";
            }

            public string ToSimpleString() => $"{Type} {Name}";
        }



        public Cr2wVariableDumpObject GetDumpObject(BinaryReader br)
        {
            br.BaseStream.Seek(Export.dataOffset, SeekOrigin.Begin);
            var o = new Cr2wVariableDumpObject()
            {
                Name = this.REDName,
                Type = this.REDType,
                Size = (int)this.Export.dataSize,
                Offset = br.BaseStream.Position
            };


            var zero = br.ReadByte();
            if (zero != 0)
                return null;

            while (true)
            {
                try
                {
                    var nameId = br.ReadUInt16();
                if (nameId == 0)
                    break;

                var variable = new Cr2wVariableDumpObject();
                variable.Offset = br.BaseStream.Position - 3;
                
                    var typeId = (int)br.ReadUInt16();
                    variable.Size = br.ReadInt32();
                

                var endoffset = br.BaseStream.Position + variable.Size - 4;

                try
                {
                    variable.Name = cr2w.StringDictionary.Values.ToList()[(int)nameId];
                    variable.Type = cr2w.StringDictionary.Values.ToList()[typeId];


                    if (variable.Type.Contains("array:"))
                    {

                        var count = br.ReadUInt32();
                        for (int i = 0; i < count; i++)
                        {
                            // dbg for now
                            var elementsize = (variable.Size - 8) / count;
                            if (elementsize > 9)
                                variable.Variables = TryGetClassVariables((int)elementsize);
                        }
                    }
                    // may be another class:
                    else if (variable.Size > 9)
                    {
                        variable.Variables = TryGetClassVariables(variable.Size);
                    }
                }
                catch (Exception e)
                {

                }
                

                // go to variable end
                br.BaseStream.Seek(endoffset, SeekOrigin.Begin);
                o.Variables.Add(variable);
                }
                catch (Exception e)
                {
                    return o;
                }
            }

            return o;


            List<Cr2wVariableDumpObject> TryGetClassVariables(int innersize)
            {
                var ret = new List<Cr2wVariableDumpObject>();
                var startpos = br.BaseStream.Position;

                var zero = br.ReadByte();
                if (zero != 0)
                    return ret;

                while (true)
                {
                    try
                    {
                        var nameId = br.ReadUInt16();
                        if (nameId == 0)
                            return ret;


                        var variable = new Cr2wVariableDumpObject
                        {
                            Offset = br.BaseStream.Position - 3,
                            Name = cr2w.StringDictionary.Values.ToList()[(int)nameId],
                            Type = cr2w.StringDictionary.Values.ToList()[(int)br.ReadUInt16()],
                            Size = br.ReadInt32()
                        };

                        var endoffset = br.BaseStream.Position + variable.Size - 4;

                        //var buffer = br.ReadBytes(variable.Size - 4);
                        // try read variable
                        //array
                        if (variable.Type.Contains("array:"))
                        {
                            var count = br.ReadUInt32();
                            for (int i = 0; i < count; i++)
                            {
                                variable.Variables = TryGetClassVariables(variable.Size);
                            }
                        }
                        // may be another class:
                        else if (variable.Size > 9)
                        {
                            variable.Variables = TryGetClassVariables(variable.Size);
                        }

                        // go to variable end
                        br.BaseStream.Seek(endoffset, SeekOrigin.Begin);
                        ret.Add(variable);
                    }
                    catch (Exception e)
                    {
                        return null;
                    }
                }
            }

        }





        /// <summary>
        /// We can use something like this for hashing
        /// </summary>
        /// <returns></returns>
        public string GetFullChunkTypeDependencyString()
        {
            var depstr = this.REDName;
            var par = this.VirtualParentChunk;
            while (par != null)
            {
                depstr = $"{par.REDName}.{depstr}";
                par = par.VirtualParentChunk;
            }

            return depstr;
        }

        public void SetType(ushort val) => _export.className = val;

        public void SetOffset(uint offset) => _export.dataOffset = offset;

        public virtual List<IEditableVariable> GetEditableVariables()
        {
            var vars = new List<IEditableVariable>
            {
                //ParentPtr,
                data
            };
            if (unknownBytes != null && unknownBytes.Bytes != null && unknownBytes.Bytes.Length != 0)
            {
                vars.Add(unknownBytes);
            }
            return vars;
        }

        public void MountChunkVirtually(int virtualparentchunkindex, bool force = false)
        {
            if (VirtualParentChunk == null || force)
            {
                VirtualParentChunk = cr2w.Chunks[virtualparentchunkindex];
                //cr2w.Logger.LogString($"Mounted {this.REDName} to {VirtualParentChunk.REDName}.");
            }
        }
        public void MountChunkVirtually(CR2WExportWrapper virtualparentchunk, bool force = false)
        {
            if (VirtualParentChunk == null || force)
            {
                VirtualParentChunk = virtualparentchunk;
            }
        }

        public void ReadData(BinaryReader file)
        {
            file.BaseStream.Seek(_export.dataOffset, SeekOrigin.Begin);

            CreateDefaultData();

            data.VarChunkIndex = ChunkIndex;

            data.Read(file, _export.dataSize);

            // Unknown bytes
            var bytesLeft = _export.dataSize - (file.BaseStream.Position - _export.dataOffset);
            unknownBytes = new CBytes(cr2w, data, "unknownBytes");
            if (bytesLeft > 0)
            {
                unknownBytes.Read(file, (uint)bytesLeft);
            }
            else if (bytesLeft < 0)
            {
                //throw new InvalidParsingException("File read too far.");
            }
            else
            {
                unknownBytes.Bytes = new byte[0];
            }
        }

        public /*async Task*/ void ReadData(MemoryMappedFile mmf)
        {
            //await Task.Run(() =>
            //{
            using (MemoryMappedViewStream vs = mmf.CreateViewStream(_export.dataOffset, _export.dataSize, MemoryMappedFileAccess.Read))
            using (BinaryReader br = new BinaryReader(vs))
            {
                CreateDefaultData();

                data.Read(br, _export.dataSize);

                // Unknown bytes
                var bytesLeft = _export.dataSize - (br.BaseStream.Position - _export.dataOffset);
                unknownBytes = new CBytes(cr2w, data, "unknownBytes");
                if (bytesLeft > 0)
                {
                    unknownBytes.Read(br, (uint)bytesLeft);
                }
                else if (bytesLeft < 0)
                {
                    //throw new InvalidParsingException("File read too far.");
                }
                else
                {
                    unknownBytes.Bytes = new byte[0];
                }

                if (cr2w.Logger != null)
                {
                    float percentprogress = (float)(1 / (float)cr2w.Chunks.Count * 100.0);
                    cr2w.Logger.LogProgressInc(percentprogress, $"Reading chunk {REDName}...");
                }

            }
            //}
            //);
        }


        public /*async Task*/ void ReadData(MemoryMappedViewStream vs)
        {
            Stopwatch stopwatch = new Stopwatch();
            stopwatch.Start();

            //await Task.Run(() =>
            //{
            using (BinaryReader br = new BinaryReader(vs))
            {
                CreateDefaultData();

                data.VarChunkIndex = ChunkIndex;

                data.Read(br, _export.dataSize);

                // Unknown bytes
                var bytesLeft = _export.dataSize - (br.BaseStream.Position - _export.dataOffset);
                unknownBytes = new CBytes(cr2w, data, "unknownBytes");
                if (bytesLeft > 0)
                {
                    unknownBytes.Read(br, (uint)bytesLeft);
                }
                else if (bytesLeft < 0)
                {
                    //throw new InvalidParsingException("File read too far.");
                }
                else
                {
                    unknownBytes.Bytes = new byte[0];
                }

                stopwatch.Stop();
                if (cr2w.Logger != null)
                {
                    float percentprogress = (float)(1 / (float)cr2w.Chunks.Count * 100.0);
                    cr2w.Logger.LogProgressInc(percentprogress, $"Reading chunk {REDName}...");
                    //cr2w.Logger.LogString($"{stopwatch.Elapsed} CHUNK {REDName}\n");
                }

            }
            //}
            //);
        }


        public void WriteData(BinaryWriter file)
        {
            _export.dataOffset = (uint)file.BaseStream.Position;
            //_export.className = (ushort)cr2w.GetStringIndex(_type);

            var posstart = file.BaseStream.Position;

            if (data != null)
            {
                data.Write(file);
            }

            // Unknown bytes not as variable because I always want it at the end.
            if (unknownBytes != null)
            {
                unknownBytes.Write(file);
            }

            var newsize = (uint)(file.BaseStream.Position - posstart);
            _export.dataSize = newsize;
        }

        /// <summary>
        /// Needs the parentChunk idx to be set!
        /// </summary>
        public void CreateDefaultData(CVariable cvar = null)
        {
            //if (Export.className != 1 && GetParentChunk() == null)
            //    throw new InvalidChunkTypeException("No parent chunk set!");

            if (cvar == null)
            {
                data = CR2WTypeManager.Create(REDType, REDType, cr2w, ParentChunk?.data);
            }
            else
            {
                data = cvar;
            }

            if (data == null)
            {
                throw new NotImplementedException();
            }

            data.IsSerialized = true;
            data.SetREDFlags(Export.objectFlags);
        }

        public override string ToString() => REDName;

        public virtual bool CanRemoveVariable(IEditableVariable child)
        {
            return false;
        }

        public virtual bool CanAddVariable(IEditableVariable newvar)
        {
            return false;
        }

        public virtual void AddVariable(CVariable var)
        {
        }

        public virtual bool RemoveVariable(IEditableVariable child)
        {
            return false;
        }

        public void SetREDName(string val)
        {
            throw new NotImplementedException();
        }

        public void Read(BinaryReader file, uint size)
        {
            throw new NotImplementedException();
        }

        public void Write(BinaryWriter file)
        {
            throw new NotImplementedException();
        }

        public CVariable Copy(CR2WCopyAction context)
        {
            throw new NotImplementedException();
        }
        #endregion
    }
}
