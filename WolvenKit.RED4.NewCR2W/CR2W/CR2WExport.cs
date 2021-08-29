using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices;
using System.Runtime.Serialization;
using Newtonsoft.Json;
using WolvenKit.RED4.IO;
using WolvenKit.RED4.Types;

[assembly: ContractNamespace("", ClrNamespace = "WolvenKit.RED4.CR2W")]

namespace WolvenKit.RED4.NewCR2W
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

    public class CR2WExportWrapper : ICR2WExport
    {
        #region Constructors

        public CR2WExportWrapper()
        {
            _export = new CR2WExport();
        }

        /// <summary>
        /// This constructor should be used when manually creating chunks
        /// </summary>
        /// <param name="file"></param>
        /// <param name="redtype"></param>
        /// <param name="parentchunk"></param>
        /// <param name="cooked"></param>
        public CR2WExportWrapper(NewCR2WFile file, string redtype, CR2WExportWrapper parentchunk, bool cooked = false)
        {
            _export = new CR2WExport
            {
                objectFlags = (ushort)(cooked ? 8192 : 0),
            };

            this.cr2w = file;
            this.REDType = redtype;
            ParentChunk = parentchunk;
        }

        /// <summary>
        /// This constructor is only used in cr2w parsing = deserialization
        /// </summary>
        /// <param name="export"></param>
        /// <param name="file"></param>
        internal CR2WExportWrapper(CR2WExport export, NewCR2WFile file)
        {
            this.cr2w = file;
            _export = export;

            REDType = cr2w.Names[export.className].Str;
        }

        #endregion Constructors

        #region Fields

        private CR2WExport _export;

        #endregion Fields

        #region Properties

        /// <summary>
        /// Main CR2WExport.parentId wrapper
        /// </summary>
        public int ParentChunkIndex
        {
            get => (int)_export.parentID - 1;
            private set => _export.parentID = (uint)(value + 1);
        }

        public string REDType { get; private set; }
        
        public IRedClass NewData { get; private set; }

        [JsonIgnore] public NewCR2WFile cr2w { get; }

        [JsonIgnore] public CR2WExport Export => _export;

        [JsonIgnore] public bool IsSerialized => true;

        [JsonIgnore]
        public ICR2WExport ParentChunk
        {
            get => ParentChunkIndex == -1 ? null : cr2w.Chunks[ParentChunkIndex];
            set => ParentChunkIndex = value == null ? -1 : cr2w.Chunks.IndexOf(value);
        }

        [JsonIgnore] public int ChunkIndex => cr2w.Chunks.IndexOf(this);

        [JsonIgnore] public string REDName => REDType + " #" + (ChunkIndex);

        #endregion Properties

        public void CreateDefaultData(IRedClass cvar = null)
        {
            //if (Export.className != 1 && GetParentChunk() == null)
            //    throw new InvalidChunkTypeException("No parent chunk set!");

            // Data = cvar ?? CR2WTypeManager.Create(REDType, REDType, cr2w, ParentChunk?.Data as CVariable);

            NewData = cvar ?? RedTypeManager.Create(REDType);
            if (NewData is not IRedType cdata)
            {
                throw new Exception($"{nameof(CreateDefaultData)} failed: {this.REDName}");
            }
        }

        public void ReadData(Red4ReaderExt file)
        {
            file.BaseStream.Seek(_export.dataOffset, SeekOrigin.Begin);

            CreateDefaultData();

            // Data.VarChunkIndex = ChunkIndex;

            file.ReadClass(NewData, _export.dataSize);
        }
    }
}
