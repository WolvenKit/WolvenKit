//using RED.CRC32;
using System;
using System.Collections.Generic;
using System.IO;
using System.Runtime.InteropServices;
//using System.Linq;
using System.Runtime.Serialization;
using System.Xml;
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

    
}
