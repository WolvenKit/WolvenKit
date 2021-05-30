using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.Serialization;

using WolvenKit.RED3.CR2W.Reflection;

namespace WolvenKit.RED3.CR2W.Types
{
    [REDMeta(EREDMetaInfo.REDStruct )]
    public class DataBuffer : CVariable
    {
        [REDBuffer] public CByteArray Bufferdata { get; set; }
        public DataBuffer(IRed3EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
    }

    [REDMeta(EREDMetaInfo.REDStruct)]
    public class SharedDataBuffer : CVariable
    {
        [REDBuffer] public CByteArray Bufferdata { get; set; }
        public SharedDataBuffer(IRed3EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
    }

    [REDMeta(EREDMetaInfo.REDStruct)]
    public class DeferredDataBuffer : CVariable
    {
        [REDBuffer] public CInt16 Bufferdata { get; set; }
        public DeferredDataBuffer(IRed3EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) {  }
    }

    //FIXME is that an ID?
    [REDMeta(EREDMetaInfo.REDStruct)]
    public class GlobalVisID : CVariable
    {
        public GlobalVisID(IRed3EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
    }

    [REDMeta(EREDMetaInfo.REDStruct)]
    public class SMeshTypeResourceLODLevel : CVariable
    {
        [REDBuffer] public CFloat ResourceLODLevel { get; set; }
        public SMeshTypeResourceLODLevel(IRed3EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
    }
}
