using System.Collections.Generic;
using System.IO;
using WolvenKit.CR2W.Editors;
using System.Diagnostics;
using System;
using System.Linq;
using System.Runtime.InteropServices;
using System.Runtime.Serialization;
using WolvenKit.CR2W.Reflection;
using static WolvenKit.CR2W.Types.Enums;


namespace WolvenKit.CR2W.Types
{
    [DataContract(Namespace = "")]
    [REDMeta(EREDMetaInfo.REDComplex)]
    public class CWayPointsCollection : CResource
    {
        [RED("version")] public CUInt16 Version { get; set; }

        [RED("waypointsCount")] public CUInt16 WaypointsCount { get; set; }

        [RED("componentsMappingsCount")] public CUInt16 ComponentsMappingsCount { get; set; }

        [RED("waypointsGroupsCount")] public CUInt16 WaypointsGroupsCount { get; set; }

        [RED("indexesCount")] public CUInt32 IndexesCount { get; set; }

        [RED("parties", 2, 0)] public CArray<SPartySpawner> Parties { get; set; }

        [RED("partyWaypoints", 2, 0)] public CArray<SPartyWaypointData> PartyWaypoints { get; set; }

        [REDBuffer(true)] public CCompressedBuffer<SBufferWaypoints> waypoints { get; set; }
        [REDBuffer(true)] public CCompressedBuffer<SBufferComponentsMappings> componentsMappings { get; set; }
        [REDBuffer(true)] public CCompressedBuffer<SBufferwaypointsGroup> waypointsGroups { get; set; }
        [REDBuffer(true)] public CCompressedBuffer<CUInt16> indexes { get; set; }

        public CWayPointsCollection(CR2WFile cr2w) :
            base(cr2w)
        {
            waypoints = new CCompressedBuffer<SBufferWaypoints>(cr2w, _ => new SBufferWaypoints(_));
            componentsMappings = new CCompressedBuffer<SBufferComponentsMappings>(cr2w, _ => new SBufferComponentsMappings(_));
            waypointsGroups = new CCompressedBuffer<SBufferwaypointsGroup>(cr2w, _ => new SBufferwaypointsGroup(_));
            indexes = new CCompressedBuffer<CUInt16>(cr2w, _ => new CUInt16(_));
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

                waypoints.Read(br, (uint)wc * 20, wc);
                componentsMappings.Read(br, (uint)cc * 32, cc);
                waypointsGroups.Read(br, (uint)wgc * 12, wgc);
                indexes.Read(br, (uint)ic * 2, ic);

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
                waypoints.Write(bw);
                componentsMappings.Write(bw);
                waypointsGroups.Write(bw);
                indexes.Write(bw);

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
    [DataContract(Namespace = "")]
    public class SBufferWaypoints : CVariable
    {
        public CGUID guid;
        public CInt32 componentsMapping;


        public SBufferWaypoints(CR2WFile cr2w) :
            base(cr2w)
        {
            guid = new CGUID(cr2w)
            {
                Name = "guid"
            };
            componentsMapping = new CInt32(cr2w)
            {
                Name = "componentsMapping"
            };
        }

        public override void Read(BinaryReader file, uint size)
        {
            guid.Read(file, 16);
            componentsMapping.Read(file, 4);
        }

        public override void Write(BinaryWriter file)
        {
            guid.Write(file);
            componentsMapping.Write(file);
        }

        public override CVariable Create(CR2WFile cr2w) => new SBufferWaypoints(cr2w);


        public override string ToString()
        {
            return "";
        }
    }
    #endregion

    #region SBufferComponentsMappings
    [DataContract(Namespace = "")]
    public class SBufferComponentsMappings : CVariable
    {
        public CGUID guid;
        public CGUID guid2;


        public SBufferComponentsMappings(CR2WFile cr2w) :
            base(cr2w)
        {
            guid = new CGUID(cr2w)
            {
                Name = "guid"
            };
            guid2 = new CGUID(cr2w)
            {
                Name = "guid2"
            };
        }

        public override void Read(BinaryReader file, uint size)
        {
            guid.Read(file, 16);
            guid2.Read(file, 4);
        }

        public override void Write(BinaryWriter file)
        {
            guid.Write(file);
            guid2.Write(file);
        }

        public override CVariable Create(CR2WFile cr2w) => new SBufferComponentsMappings(cr2w);


        public override string ToString()
        {
            return "";
        }
    }
    #endregion

    #region SBufferwaypointsGroup
    [DataContract(Namespace = "")]
    public class SBufferwaypointsGroup : CVariable
    {
        public CUInt32 offset;
        public CUInt32 count;
        public CUInt16 nullbytes;
        public CUInt16 groupIdx;


        public SBufferwaypointsGroup(CR2WFile cr2w) :
            base(cr2w)
        {
            offset = new CUInt32(cr2w)
            {
                Name = "offset"
            };
            count = new CUInt32(cr2w)
            {
                Name = "count"
            };
            nullbytes = new CUInt16(cr2w)
            {
                Name = "nullbytes"
            };
            groupIdx = new CUInt16(cr2w)
            {
                Name = "groupIdx"
            };
        }

        public override void Read(BinaryReader file, uint size)
        {
            offset.Read(file, 16);
            count.Read(file, 4);
            nullbytes.Read(file, 4);
            groupIdx.Read(file, 4);
        }

        public override void Write(BinaryWriter file)
        {
            offset.Write(file);
            count.Write(file);
            nullbytes.Write(file);
            groupIdx.Write(file);
        }

        public override CVariable Create(CR2WFile cr2w) => new SBufferwaypointsGroup(cr2w);


        public override string ToString()
        {
            return "";
        }
    }
    #endregion

    



















}