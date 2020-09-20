using System.Collections.Generic;
using System.IO;

using System.Diagnostics;
using System;
using System.Linq;
using System.Runtime.InteropServices;
using System.Runtime.Serialization;
using WolvenKit.CR2W.Reflection;
using static WolvenKit.CR2W.Types.Enums;
using FastMember;

namespace WolvenKit.CR2W.Types
{
    public partial class CWayPointsCollection : CResource
    {

        [Ordinal(1000)] [REDBuffer(true)] public CCompressedBuffer<SBufferWaypoints> Waypoints { get; set; }
        [Ordinal(1001)] [REDBuffer(true)] public CCompressedBuffer<SBufferComponentsMappings> ComponentsMappings { get; set; }
        [Ordinal(1002)] [REDBuffer(true)] public CCompressedBuffer<SBufferwaypointsGroup> WaypointsGroups { get; set; }
        [Ordinal(1003)] [REDBuffer(true)] public CCompressedBuffer<CUInt16> Indexes { get; set; }

        public CWayPointsCollection(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name)
        {
            Waypoints = new CCompressedBuffer<SBufferWaypoints>(cr2w, this, nameof(Waypoints)) { IsSerialized = true };
            ComponentsMappings = new CCompressedBuffer<SBufferComponentsMappings>(cr2w, this, nameof(ComponentsMappings)) { IsSerialized = true };
            WaypointsGroups = new CCompressedBuffer<SBufferwaypointsGroup>(cr2w, this, nameof(WaypointsGroups)) { IsSerialized = true };
            Indexes = new CCompressedBuffer<CUInt16>(cr2w, this, nameof(Indexes)) { IsSerialized = true };
        }

        public override void Read(BinaryReader file, uint size)
        {
            base.Read(file, size);

            var buffersize = file.ReadUInt32();

            var d = CalculateBufferSize();
            if (buffersize != CalculateBufferSize())
                throw new InvalidParsingException("Calculated buffersize is not equal actual buffersize.");

            using (var ms = new MemoryStream(file.ReadBytes((int)buffersize)))
            using (var br = new BinaryReader(ms))
            {
                int wc = WaypointsCount != null ? WaypointsCount.val : 0;
                int cc = ComponentsMappingsCount != null ? ComponentsMappingsCount.val : 0;
                int wgc = WaypointsGroupsCount != null ? WaypointsGroupsCount.val : 0;
                int ic = IndexesCount != null ? (int)IndexesCount.val : 0;

                Waypoints.Read(br, (uint)wc * 20, wc);
                ComponentsMappings.Read(br, (uint)cc * 32, cc);
                WaypointsGroups.Read(br, (uint)wgc * 12, wgc);
                Indexes.Read(br, (uint)ic * 2, ic);

                if (buffersize - ms.Position > 0)
                    throw new InvalidParsingException("Did not read buffer to the end.");
            }

        }

        public override void Write(BinaryWriter file)
        {

            base.Write(file);

            using (var ms = new MemoryStream())
            using (var bw = new BinaryWriter(ms))
            {
                Waypoints.Write(bw);
                ComponentsMappings.Write(bw);
                WaypointsGroups.Write(bw);
                Indexes.Write(bw);

                bw.Flush();

                int buffersize = (int)ms.Position;

                int calcb = CalculateBufferSize();
                if (buffersize != calcb)
                    throw new InvalidParsingException("Calculated buffersize is not equal actual buffersize.");

                file.Write(buffersize);
                file.Write(ms.ToArray());
            }
        }

        private int CalculateBufferSize()
        {
            int wc = WaypointsCount != null ? WaypointsCount.val * 20 : 0;
            int cc = ComponentsMappingsCount != null ? ComponentsMappingsCount.val * 32 : 0;
            int wgc = WaypointsGroupsCount != null ? WaypointsGroupsCount.val * 12 : 0;
            int ic = IndexesCount != null ? (int)IndexesCount.val * 2 : 0;

            return wc + cc + wgc + ic;
        }
    }

    #region SBufferWaypoints
    [REDMeta(EREDMetaInfo.REDStruct)]
    public class SBufferWaypoints : CVariable
    {
        [Ordinal(1)] [RED] public CGUID guid { get; set; }
        [Ordinal(2)][RED] public CInt32 componentsMapping { get; set; }


        public SBufferWaypoints(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }

        public static CVariable Create(CR2WFile cr2w, CVariable parent, string name) => new SBufferWaypoints(cr2w, parent, name);
    }
    #endregion

    #region SBufferComponentsMappings
    [REDMeta(EREDMetaInfo.REDStruct)]
    public class SBufferComponentsMappings : CVariable
    {
        [Ordinal(1)] [RED] public CGUID guid { get; set; }
        [Ordinal(2)] [RED] public CGUID guid2 { get; set; }


        public SBufferComponentsMappings(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }

        public static CVariable Create(CR2WFile cr2w, CVariable parent, string name) => new SBufferComponentsMappings(cr2w, parent, name);
    }
    #endregion

    #region SBufferwaypointsGroup
    [REDMeta(EREDMetaInfo.REDStruct)]
    public class SBufferwaypointsGroup : CVariable
    {
        [Ordinal(1)] [RED] public CUInt32 offset { get; set; }
        [Ordinal(2)] [RED] public CUInt32 count { get; set; }
        [Ordinal(3)] [RED] public CUInt16 nullbytes { get; set; }
        [Ordinal(4)] [RED] public CUInt16 groupIdx { get; set; }


        public SBufferwaypointsGroup(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
        public static CVariable Create(CR2WFile cr2w, CVariable parent, string name) => new SBufferwaypointsGroup(cr2w, parent, name);
    }
    #endregion

    



















}