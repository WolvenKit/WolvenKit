using System;
using System.Collections.Generic;
using System.Linq;
using System.IO;
using System.Runtime.InteropServices;
using WolvenKit.Common.Extensions;
using WolvenKit.Common.FNV1A;
using WolvenKit.RED4.CR2W;
using WolvenKit.RED4.CR2W.Types;
namespace WolvenKit.Modkit.RED4.Compiled
{
    public class CompiledBuffer
    {
        [StructLayout(LayoutKind.Explicit, Size = 32)]
        struct header
        {
            [FieldOffset(0)]
            public UInt16 uk1;

            [FieldOffset(2)]
            public UInt16 uk2;  // sections count apparently mostly its 7

            [FieldOffset(4)]
            public UInt32 ids_cnt;

            [FieldOffset(8)]
            public UInt32 rarefpool_descs_offset;

            [FieldOffset(12)]
            public UInt32 rarefpool_data_offset;

            [FieldOffset(16)]
            public UInt32 strpool_descs_offset;

            [FieldOffset(20)]
            public UInt32 strpool_data_offset;

            [FieldOffset(24)]
            public UInt32 obj_descs_offset;

            [FieldOffset(28)]
            public UInt32 objdata_offset;
        }

        header _header;
        UInt16 _uk1;
        List<UInt64> _ids { get; set; }
        Dictionary<int, string> StrTable1asStr { get; set; } // Imports TBH, if string exists directly in the file both StrTable1asStr and StrTable1asHash is filled
        Dictionary<int, UInt64> StrTable1asHash { get; set; } // Imports as hashes TBH, if string exists as Hashes then Obvs only StrTable1asHash can be filled
        Dictionary<int, string> StrTable2asStr { get; set; } // Names TBH
        List<ObjDesc> ObjectDescs; // Names Idx and Offset of Object Data in file from Origin

        const UInt32 strTable1SizeBitShift = 23;
        const UInt32 strTable1OffsetMask = (1U << (int)strTable1SizeBitShift) - 1U;
        const UInt32 strTable2SizeBitShift = 24;
        const UInt32 strTable2OffsetMask = (1U << (int)strTable2SizeBitShift) - 1U;
        const UInt32 sizeBitMask = (1U << 8) - 1;
        public CompiledBuffer(Stream ms)
        {
            var br = new BinaryReader(ms);
            _header = br.BaseStream.ReadStruct<header>();
            if (_header.rarefpool_descs_offset != 0)
                throw new Exception("m_header.u32arr_offset != 0");

            _uk1 = br.ReadUInt16();
            UInt16 ids_cnt;
            ids_cnt = br.ReadUInt16();
            if (ids_cnt != _header.ids_cnt)
                throw new Exception("ids_cnt != m_header.ids_cnt");

            _ids = new List<ulong>();
            for (int i = 0; i < ids_cnt; i++)
                _ids.Add(br.ReadUInt64());

            long baseOff = ms.Position;
            UInt32 rarefpool_descs_size = _header.rarefpool_data_offset - _header.rarefpool_descs_offset;

            StrTable1asStr = new Dictionary<int, string>();
            StrTable1asHash = new Dictionary<int, UInt64>();

            for (int i = 0; i < rarefpool_descs_size/4; i++)
            {
                ms.Seek(baseOff + _header.rarefpool_descs_offset + i * 4, SeekOrigin.Begin);
                UInt32 maskData = br.ReadUInt32();
                UInt32 off = maskData & strTable1OffsetMask;
                UInt32 len = (maskData >> (int)strTable1SizeBitShift) & sizeBitMask;

                if(_uk1 == 0)
                {
                    ms.Seek(baseOff + off, SeekOrigin.Begin);
                    string name = new string(br.ReadChars((int)len));
                    StrTable1asStr.Add(i, name);
                    StrTable1asHash.Add(i, FNV1A64HashAlgorithm.HashString(name));
                }
                else
                {
                    ms.Seek(baseOff + off, SeekOrigin.Begin);
                    StrTable1asHash.Add(i, br.ReadUInt64());
                }
            }

            UInt32 strpool_descs_size = _header.strpool_data_offset - _header.strpool_descs_offset;

            StrTable2asStr = new Dictionary<int, string>();

            for (int i = 0; i < strpool_descs_size / 4; i++)
            {
                ms.Seek(baseOff + _header.strpool_descs_offset + i * 4, SeekOrigin.Begin);
                UInt32 maskData = br.ReadUInt32();
                UInt32 off = maskData & strTable2OffsetMask;
                UInt32 len = (maskData >> (int)strTable2SizeBitShift) & sizeBitMask;

                ms.Seek(baseOff + off, SeekOrigin.Begin);
                string name = new string(br.ReadChars((int)len));
                StrTable2asStr.Add(i, name);
            }
            UInt32 obj_descs_size = _header.objdata_offset - _header.obj_descs_offset;

            ObjectDescs = new List<ObjDesc>();

            for (int i = 0; i < obj_descs_size / 8; i++)
            {
                ms.Seek(baseOff + _header.obj_descs_offset + i * 8, SeekOrigin.Begin);
                UInt32 varNameIdx = br.ReadUInt32();
                UInt32 off = br.ReadUInt32();

                ObjDesc obj_desc = new ObjDesc(varNameIdx, off + baseOff);
                ObjectDescs.Add(obj_desc);
            }
            CR2WFile cr2w = new CR2WFile();
            {
                uint idx = 0;
                cr2w.StringDictionary.Add(idx, "");
                var nam = new CR2WName();
                nam.value = idx;
                cr2w.Names.Add(new CR2WNameWrapper(nam, cr2w));
                idx += 1;
                for (int i = 0; i < StrTable2asStr.Values.Count; i++)
                {
                    cr2w.StringDictionary.Add(idx, StrTable2asStr[i].Replace("\0",""));
                    nam.value = idx;
                    cr2w.Names.Add(new CR2WNameWrapper(nam, cr2w));
                    idx += (uint)StrTable2asStr[i].Length;
                }
                var imp = new CR2WImport();
                imp.flags = 4;
                for (int i = 0; i < StrTable1asStr.Values.Count; i++)
                {
                    cr2w.StringDictionary.Add(idx, StrTable1asStr[i]);
                    imp.depotPath = idx;
                    cr2w.Imports.Add(new CR2WImportWrapper(imp, cr2w));
                    idx += (uint)StrTable1asStr[i].Length;
                }
            }
        }
        struct ObjDesc
        {
            public uint NameIdx;
            public long objDataOffset;
            public ObjDesc(uint varnameIdx, long dataOffset)
            {
                NameIdx = varnameIdx;
                objDataOffset = dataOffset;
            }
        }

    }
}
