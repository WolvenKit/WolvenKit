using System;
using System.Collections.Generic;
using System.IO;
using System.Runtime.Serialization;

using WolvenKit.CR2W.Reflection;
using static WolvenKit.CR2W.Types.Enums;
using FastMember;

namespace WolvenKit.CR2W.Types
{
    public partial class CSectorData : ISerializable
    {

        [Ordinal(1000)] [REDBuffer] public CUInt64 Unknown1 { get; set; }

        [Ordinal(1001)] [REDBuffer] public CBufferVLQInt32<CSectorDataResource> Resources { get; set; }
        [Ordinal(1002)] [REDBuffer] public CBufferVLQInt32<CSectorDataObject> Objects { get; set; }

        [Ordinal(1003)] [REDBuffer(true)] public CVLQInt32 blocksize { get; set; }
        [Ordinal(1004)] [REDBuffer(true)] public CCompressedBuffer<SBlockData> BlockData { get; set; }

        public CSectorData(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name)
        {

            blocksize = new CVLQInt32(cr2w, this, nameof(blocksize)) { IsSerialized = true };
            BlockData = new CCompressedBuffer<SBlockData>(cr2w, this, nameof(BlockData)) { IsSerialized = true };
        }



        public override void Read(BinaryReader file, uint size)
        {
            base.Read(file, size);

            blocksize.Read(file, 1);
            for (int i = 0; i < Objects.elements.Count; i++)
            {
                
                CSectorDataObject curobj = Objects[i];

                ulong curoffset = curobj.offset.val;
                byte type = curobj.type.val;
                if (!(type == 0x1 || type == 0x2))
                {
                    //System.Diagnostics.Debugger.Break();
                    //throw new NotImplementedException();
                }

                ulong len;
                if (i < Objects.elements.Count - 1)
                {
                    CSectorDataObject nextobj = Objects[i + 1];
                    ulong nextoffset = nextobj.offset.val;
                    len = nextoffset - curoffset;
                }
                else
                {
                    len = (ulong)blocksize.val - curoffset;
                }

                var blockdata = new SBlockData(cr2w, BlockData, "")
                {
                    packedObjectType = (Enums.BlockDataObjectType)curobj.type.val
                };
                blockdata.Read(file, (uint)len);
                BlockData.AddVariable(blockdata);
            }
        }

        public override void Write(BinaryWriter file)
        {
            base.Write(file);

            byte[] buffer;
            MemoryStream ms = null;
            try
            {
                ms = new MemoryStream();
                using (var bw = new BinaryWriter(ms))
                {
                    BlockData.Write(bw);
                    blocksize.val = (int)ms.Length;
                    buffer = ms.ToArray();
                    ms.Close();
                    ms = null;
                }
            }
            finally
            {
                ms?.Dispose();
            }
            blocksize.Write(file);
            file.Write(buffer);
        }

        public override string ToString()
        {
            return "";
        }
    }
    
}