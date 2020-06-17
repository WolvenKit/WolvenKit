using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.Serialization;
using WolvenKit.CR2W.Editors;
using WolvenKit.CR2W.Reflection;

namespace WolvenKit.CR2W.Types
{
    [REDMeta(EREDMetaInfo.REDStruct, EREDMetaInfo.REDComplex)]
    public class DataBuffer : CVariable
    {
        [REDBuffer] public CByteArray Bufferdata { get; set; }
        public DataBuffer(CR2WFile cr2w) : base(cr2w) { Bufferdata = new CByteArray(cr2w); }

        public override void Read(BinaryReader file, uint size) => Bufferdata.Read(file, size);

        public override void Write(BinaryWriter file) => base.Write(file);

        public override CVariable Create(CR2WFile cr2w) => new DataBuffer(cr2w);
    }

    [REDMeta(EREDMetaInfo.REDStruct, EREDMetaInfo.REDComplex)]
    public class SharedDataBuffer : CVariable
    {
        [REDBuffer] public CByteArray Bufferdata { get; set; }
        public SharedDataBuffer(CR2WFile cr2w) : base(cr2w) { Bufferdata = new CByteArray(cr2w); }

        public override void Read(BinaryReader file, uint size) => Bufferdata.Read(file, size);

        public override void Write(BinaryWriter file) => base.Write(file);

        public override CVariable Create(CR2WFile cr2w) => new SharedDataBuffer(cr2w);
    }

    [REDMeta(EREDMetaInfo.REDStruct, EREDMetaInfo.REDComplex)]
    public class DeferredDataBuffer : CVariable
    {
        [REDBuffer] public CInt16 Bufferdata { get; set; }
        public DeferredDataBuffer(CR2WFile cr2w) : base(cr2w) { Bufferdata = new CInt16(cr2w); }

        public override void Read(BinaryReader file, uint size) => Bufferdata.Read(file, size);

        public override void Write(BinaryWriter file) => base.Write(file);

        public override CVariable Create(CR2WFile cr2w) => new DeferredDataBuffer(cr2w);
    }

    //FIXME is that an ID?
    [REDMeta(EREDMetaInfo.REDStruct, EREDMetaInfo.REDComplex)]
    public class GlobalVisID : CVariable
    {
        public GlobalVisID(CR2WFile cr2w) : base(cr2w) { }

        public override void Read(BinaryReader file, uint size) => base.Read(file, size);

        public override void Write(BinaryWriter file) => base.Write(file);

        public override CVariable Create(CR2WFile cr2w) => new GlobalVisID(cr2w);
    }

    [REDMeta(EREDMetaInfo.REDStruct, EREDMetaInfo.REDComplex)]
    public class SMeshTypeResourceLODLevel : CVariable
    {
        [REDBuffer] public CFloat ResourceLODLevel { get; set; }
        public SMeshTypeResourceLODLevel(CR2WFile cr2w) : base(cr2w) { ResourceLODLevel = new CFloat(cr2w); }

        public override void Read(BinaryReader file, uint size) => ResourceLODLevel.Read(file, size);

        public override void Write(BinaryWriter file) => base.Write(file);

        public override CVariable Create(CR2WFile cr2w) => new SMeshTypeResourceLODLevel(cr2w);
    }
}