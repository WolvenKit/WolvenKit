using System.Collections.Generic;
using System.IO;
using WolvenKit.CR2W.Editors;
using System.Diagnostics;
using System;
using System.Linq;
using System.Runtime.InteropServices;

namespace WolvenKit.CR2W.Types
{
    public class CWayPointsCollection : CVector
    {
        public CCompressedArray waypoints;
        public CCompressedArray componentsMappings;
        public CCompressedArray waypointsGroups;
        public CCompressedArray indexes;

        private UInt16 waypointsCount;
        private UInt16 componentsMappingsCount;
        private UInt16 waypointsGroupsCount;
        private UInt32 indexesCount;


        public CWayPointsCollection(CR2WFile cr2w) :
            base(cr2w)
        {
            waypoints = new CCompressedArray("[]SBufferWaypoints", "SBufferWaypoints", true, cr2w)
            {
                Name = "waypoints"
            };
            componentsMappings = new CCompressedArray("[]SBufferComponentsMappings", "SBufferComponentsMappings", true, cr2w)
            {
                Name = "componentsMappings"
            };
            waypointsGroups = new CCompressedArray("[]SBufferwaypointsGroup", "SBufferwaypointsGroup", true, cr2w)
            {
                Name = "waypointsGroups"
            };
            indexes = new CCompressedArray("[]Uint16", "Uint16", true, cr2w)
            {
                Name = "indexes"
            };

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
                waypoints.Read(br, (uint)waypointsCount * 20, waypointsCount);
                componentsMappings.Read(br, (uint)componentsMappingsCount * 32, componentsMappingsCount);
                waypointsGroups.Read(br, (uint)waypointsGroupsCount * 12, waypointsGroupsCount);
                indexes.Read(br, (uint)indexesCount * 2, (int)indexesCount);

                if (buffersize - ms.Position > 0)
                    throw new InvalidParsingException("Did not read buffer to the end.");
            }

        }

        public override void Write(BinaryWriter file)
        {
            SetUInt16byName("waypointsCount", (UInt16)waypoints.Count());
            SetUInt16byName("componentsMappingsCount", (UInt16)componentsMappings.Count());
            SetUInt16byName("waypointsGroupsCount", (UInt16)waypointsGroups.Count());
            SetUInt32byName("indexesCount", (UInt32)indexes.Count());

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

            void SetUInt16byName(string name, UInt16 val)
            {
                var v = variables.FirstOrDefault(_ => _.Name == name);
                if ((v as CUInt16) != null)
                    (v as CUInt16).val = val;
            }
            void SetUInt32byName(string name, UInt32 val)
            {
                var v = variables.FirstOrDefault(_ => _.Name == name);
                if ((v as CUInt32) != null)
                    (v as CUInt32).val = val;
            }

        }

        private int CalculateBufferSize()
        {
            waypointsCount = GetUInt16byName("waypointsCount");
            componentsMappingsCount = GetUInt16byName("componentsMappingsCount");
            waypointsGroupsCount = GetUInt16byName("waypointsGroupsCount");
            indexesCount = GetUInt32byName("indexesCount");

            /*return (int)(waypointsCount * Marshal.SizeOf<SBufferWaypoints>() +
                componentsMappingsCount * Marshal.SizeOf<SBufferComponentsMappings>() +
                waypointsGroupsCount * Marshal.SizeOf<SBufferwaypointsGroup>() +
                indexesCount * Marshal.SizeOf<CUInt16>());*/
            return (int)(waypointsCount * 20 +
                componentsMappingsCount * 32 +
                waypointsGroupsCount * 12 +
                indexesCount * 2);

            UInt16 GetUInt16byName(string name)
            {
                UInt16 result = 0;
                var v = variables.FirstOrDefault(_ => _.Name == name);
                if ((v as CUInt16) != null)
                    result = (v as CUInt16).val;
                return result;
            }
            UInt32 GetUInt32byName(string name)
            {
                UInt32 result = 0;
                var v = variables.FirstOrDefault(_ => _.Name == name);
                if ((v as CUInt32) != null)
                    result = (v as CUInt32).val;
                return result;
            }
        }

        public override CVariable SetValue(object val)
        {
            return this;
        }

        public override CVariable Create(CR2WFile cr2w)
        {
            return new CWayPointsCollection(cr2w);
        }

        public override CVariable Copy(CR2WCopyAction context)
        {
            var var = (CWayPointsCollection) base.Copy(context);
            var.waypoints = (CCompressedArray) waypoints.Copy(context);
            var.componentsMappings = (CCompressedArray)componentsMappings.Copy(context);
            var.waypointsGroups = (CCompressedArray)waypointsGroups.Copy(context);
            var.indexes = (CCompressedArray)indexes.Copy(context);

            return var;
        }

        public override List<IEditableVariable> GetEditableVariables()
        {
            return new List<IEditableVariable>(variables)
            {
                waypoints,
                componentsMappings,
                waypointsGroups,
                indexes,
            };
        }
    }

    #region SBufferWaypoints
    //[StructLayout(LayoutKind.Explicit, Size = 20)]
    public class SBufferWaypoints : CVariable
    {
        //[FieldOffset(0)]
        public CGUID guid;
        //[FieldOffset(16)]
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

        public override CVariable SetValue(object val) => this;

        public override CVariable Create(CR2WFile cr2w) => new SBufferWaypoints(cr2w);

        public override CVariable Copy(CR2WCopyAction context)
        {
            var var = (SBufferWaypoints)base.Copy(context);

            var.guid = (CGUID)guid.Copy(context);
            var.componentsMapping = (CInt32)componentsMapping.Copy(context);

            return var;
        }

        public override List<IEditableVariable> GetEditableVariables()
        {
            return new List<IEditableVariable>()
            {
                guid,
                componentsMapping
            };
        }

        public override string ToString()
        {
            return "";
        }
    }
    #endregion

    #region SBufferComponentsMappings
    //[StructLayout(LayoutKind.Explicit, Size = 32)]
    public class SBufferComponentsMappings : CVariable
    {
        //[FieldOffset(0)]
        public CGUID guid;
        //[FieldOffset(16)]
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

        public override CVariable SetValue(object val) => this;

        public override CVariable Create(CR2WFile cr2w) => new SBufferComponentsMappings(cr2w);

        public override CVariable Copy(CR2WCopyAction context)
        {
            var var = (SBufferComponentsMappings)base.Copy(context);
            var.guid = (CGUID)guid.Copy(context);
            var.guid2 = (CGUID)guid2.Copy(context);

            return var;
        }

        public override List<IEditableVariable> GetEditableVariables()
        {
            return new List<IEditableVariable>()
            {
                guid,
                guid2
            };
        }

        public override string ToString()
        {
            return "";
        }
    }
    #endregion

    #region SBufferwaypointsGroup
    //[StructLayout(LayoutKind.Explicit, Size = 12)]
    public class SBufferwaypointsGroup : CVariable
    {
        //[FieldOffset(0)]
        public CUInt32 offset;
        //[FieldOffset(4)]
        public CUInt32 count;
        //[FieldOffset(8)]
        public CUInt16 nullbytes;
        //[FieldOffset(10)]
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

        public override CVariable SetValue(object val) => this;

        public override CVariable Create(CR2WFile cr2w) => new SBufferwaypointsGroup(cr2w);

        public override CVariable Copy(CR2WCopyAction context)
        {
            var var = (SBufferwaypointsGroup)base.Copy(context);
            var.offset = (CUInt32)offset.Copy(context);
            var.count = (CUInt32)count.Copy(context);
            var.nullbytes = (CUInt16)nullbytes.Copy(context);
            var.groupIdx = (CUInt16)groupIdx.Copy(context);

            return var;
        }

        public override List<IEditableVariable> GetEditableVariables()
        {
            return new List<IEditableVariable>()
            {
                offset,
                count,
                nullbytes,
                groupIdx
            };
        }

        public override string ToString()
        {
            return "";
        }
    }
    #endregion

    



















}