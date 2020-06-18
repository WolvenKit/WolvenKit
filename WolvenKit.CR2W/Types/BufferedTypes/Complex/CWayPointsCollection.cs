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
    public partial class CWayPointsCollection : CResource
    {

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
    [REDMeta(EREDMetaInfo.REDStruct)]
    public class SBufferWaypoints : CVariable
    {
        [RED] public CGUID guid { get; set; }
        [RED] public CInt32 componentsMapping { get; set; }


        public SBufferWaypoints(CR2WFile cr2w) :
            base(cr2w)
        {

        }

        public override CVariable Create(CR2WFile cr2w) => new SBufferWaypoints(cr2w);


        public override string ToString()
        {
            return "";
        }
    }
    #endregion

    #region SBufferComponentsMappings
    [REDMeta(EREDMetaInfo.REDStruct)]
    public class SBufferComponentsMappings : CVariable
    {
        [RED] public CGUID guid { get; set; }
        [RED] public CGUID guid2 { get; set; }


        public SBufferComponentsMappings(CR2WFile cr2w) :
            base(cr2w)
        {

        }

        public override CVariable Create(CR2WFile cr2w) => new SBufferComponentsMappings(cr2w);


        public override string ToString()
        {
            return "";
        }
    }
    #endregion

    #region SBufferwaypointsGroup
    [REDMeta(EREDMetaInfo.REDStruct)]
    public class SBufferwaypointsGroup : CVariable
    {
        [RED] public CUInt32 offset { get; set; }
        [RED] public CUInt32 count { get; set; }
        [RED] public CUInt16 nullbytes { get; set; }
        [RED] public CUInt16 groupIdx { get; set; }


        public SBufferwaypointsGroup(CR2WFile cr2w) :
            base(cr2w)
        {

        }
        public override CVariable Create(CR2WFile cr2w) => new SBufferwaypointsGroup(cr2w);


        public override string ToString()
        {
            return "";
        }
    }
    #endregion

    



















}