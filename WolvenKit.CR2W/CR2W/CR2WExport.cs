//using RED.CRC32;
using System;
using System.Collections.Generic;
using System.IO;
using WolvenKit.CR2W.Types;
using System.Runtime.InteropServices;
//using System.Linq;
using System.Runtime.Serialization;
using System.Xml;
using WolvenKit.Utils;
using System.Linq;
using System.IO.MemoryMappedFiles;
using System.Threading.Tasks;
using System.Diagnostics;

[assembly: ContractNamespaceAttribute("",    ClrNamespace = "WolvenKit.CR2W")]

namespace WolvenKit.CR2W
{

    [DataContract(Namespace ="")]
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

    [DataContract(Namespace = "")]
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
            IsVirtuallyMounted = false;
            Referrers = new List<CVariable>();

            this.cr2w = file;
            this.REDType = redtype;
            SetParentChunk(parentchunk);
        }

        /// <summary>
        /// This constructor is only used in cr2w parsing
        /// </summary>
        /// <param name="export"></param>
        /// <param name="file"></param>
        public CR2WExportWrapper(CR2WExport export, CR2WFile file)
        {
            this.cr2w = file;
            _export = export;

            REDType = cr2w.names[export.className].Str;
            IsVirtuallyMounted = false;
            Referrers = new List<CVariable>();
        }
        #endregion

        private CR2WExport _export;
        [DataMember()]
        public CR2WExport Export => _export;

        #region Fields

        [NonSerialized]
        public CBytes unknownBytes;
        #endregion

        #region Properties
        public CR2WFile cr2w { get; }

        public CVariable data { get; private set; }

        /// <summary>
        /// Main CR2WExport.parentId wrapper
        /// </summary>
        public int ParentChunkIndex
        {
            get => (int)_export.parentID - 1;
            private set => _export.parentID = (uint)(value + 1);
        }
        private void SetParentChunk(CR2WExportWrapper parent)
        {
            ParentChunkIndex = parent == null ? -1 : cr2w.chunks.IndexOf(parent);
            IsVirtuallyMounted = false;
            VirtualParentChunkIndex = ParentChunkIndex;
        }

        public bool IsVirtuallyMounted { get; set; }
        private int _virtualParentChunkIndex;
        public int VirtualParentChunkIndex
        {
            get => IsVirtuallyMounted ? _virtualParentChunkIndex : ParentChunkIndex;
            set
            {
                if (IsVirtuallyMounted) return;
                _virtualParentChunkIndex = value;
                IsVirtuallyMounted = true;
            }
        }

        /// <summary>
        /// Reverse lookup : CVariables, being CPtr or CHandle, which reference this chunk.
        /// Beware, in case of multithreading, this needs locking!
        /// </summary>
        public readonly List<CVariable> Referrers;


        public string REDType { get; private set; }


        [DataMember]
        public string REDName => REDType + " #" + (ChunkIndex);

        public int ChunkIndex => cr2w.chunks.IndexOf(this);
        private CR2WExportWrapper ParentChunk => ParentChunkIndex==-1 ? null : cr2w.chunks[ParentChunkIndex];
        public CR2WExportWrapper VirtualParentChunk => VirtualParentChunkIndex==-1 ? null : cr2w.chunks[VirtualParentChunkIndex];

        /// <summary>
        /// This property is used as BindingProperty in frmChunkProperties
        /// Do not delete!
        /// </summary>
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


        /// <summary>
        /// This property is used as BindingProperty in frmChunkProperties
        /// Do not delete!
        /// </summary>
        public string REDValue => this.ToString();


        public bool IsSerialized => true;

        #endregion

        #region Methods
        /// <summary>
        /// We can use something like this for hashing
        /// </summary>
        /// <returns></returns>
        public string GetFullChunkDependencyStringName()
        {
            var depstr = this.REDName;
            var par = this.GetVirtualParentChunk();
            while (par != null)
            {
                depstr = $"{par.REDName}.{depstr}";
                par = par.GetVirtualParentChunk();
            }

            return depstr;
        }

        public void SetType(ushort val) => _export.className = val;

        public void SetOffset(uint offset) => _export.dataOffset = offset;

        private CR2WExportWrapper GetParentChunk() => ParentChunkIndex >= 0 ? cr2w.chunks[ParentChunkIndex] : null;

        public CR2WExportWrapper GetVirtualParentChunk()
        {
            if (IsVirtuallyMounted && VirtualParentChunkIndex != -1)
            {
                return cr2w.chunks[VirtualParentChunkIndex];
            }
            else return GetParentChunk();
        }

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



        public void ReadData(BinaryReader file)
        {
            file.BaseStream.Seek(_export.dataOffset, SeekOrigin.Begin);

            CreateDefaultData();
            if(data.REDType== "CBTTaskTeleportDecoratorDef" ||
                data.REDType == "CBTTaskTeleportDef")
            {
                //System.Console.WriteLine("Not bothering with buggy vars yoo");
                //return;
            }

            //TODO explain next two lines
            data.VarChunkIndex = ChunkIndex;
            VirtualParentChunkIndex = ParentChunkIndex;

            data.Read(file, _export.dataSize);

            // Unknown bytes
            var bytesLeft = _export.dataSize - (file.BaseStream.Position - _export.dataOffset);
            unknownBytes = new CBytes(cr2w, data, "unknownBytes");
            if (bytesLeft > 0)
            {
                unknownBytes.Read(file, (uint) bytesLeft);
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

                    if (cr2w.Logger!= null)
                    {
                        float percentprogress = (float)(1 / (float)cr2w.chunks.Count * 100.0);
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

                //TODO explain next two lines
                data.VarChunkIndex = ChunkIndex;
                VirtualParentChunkIndex = ParentChunkIndex;

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
                    float percentprogress = (float)(1 / (float)cr2w.chunks.Count * 100.0);
                    cr2w.Logger.LogProgressInc(percentprogress, $"Reading chunk {REDName}...");
                    //cr2w.Logger.LogString($"{stopwatch.Elapsed} CHUNK {REDName}\n");
                }

            }
            //}
            //);
        }


        public void WriteData(BinaryWriter file)
        {
            _export.dataOffset = (uint) file.BaseStream.Position;
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

            var newsize = (uint) (file.BaseStream.Position - posstart);
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
                data = CR2WTypeManager.Create(REDType, REDType, cr2w, GetParentChunk()?.data);
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

        public Guid InternalGuid { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }

        public CVariable Copy(CR2WCopyAction context)
        {
            throw new NotImplementedException();
        }
        #endregion
    }
}