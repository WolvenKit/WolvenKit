using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.Serialization;

using WolvenKit.CR2W.Reflection;

namespace WolvenKit.CR2W.Types
{
    //[REDMeta(EREDMetaInfo.REDStruct )]
    //public class DataBuffer : CVariable
    //{
    //    [REDBuffer] public CByteArray Bufferdata { get; set; }
    //    public DataBuffer(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
    //    public static CVariable Create(CR2WFile cr2w, CVariable parent, string name) => new DataBuffer(cr2w, parent, name);
    //}

    [REDMeta(EREDMetaInfo.REDStruct)]
    public class SharedDataBuffer : CVariable
    {
        [REDBuffer] public CByteArray Bufferdata { get; set; }
        public SharedDataBuffer(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
        public static CVariable Create(CR2WFile cr2w, CVariable parent, string name) => new SharedDataBuffer(cr2w, parent, name);
    }

    [REDMeta(EREDMetaInfo.REDStruct)]
    public class DeferredDataBuffer : CVariable
    {
        [REDBuffer] public CInt16 Bufferdata { get; set; }
        public DeferredDataBuffer(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) {  }
        public static CVariable Create(CR2WFile cr2w, CVariable parent, string name) => new DeferredDataBuffer(cr2w, parent, name);
    }

    //FIXME is that an ID?
    [REDMeta(EREDMetaInfo.REDStruct)]
    public class GlobalVisID : CVariable
    {
        public GlobalVisID(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
        public static CVariable Create(CR2WFile cr2w, CVariable parent, string name) => new GlobalVisID(cr2w, parent, name);
    }

    [REDMeta(EREDMetaInfo.REDStruct)]
    public class SMeshTypeResourceLODLevel : CVariable
    {
        [REDBuffer] public CFloat ResourceLODLevel { get; set; }
        public SMeshTypeResourceLODLevel(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
        public static CVariable Create(CR2WFile cr2w, CVariable parent, string name) => new SMeshTypeResourceLODLevel(cr2w, parent, name);
    }
}