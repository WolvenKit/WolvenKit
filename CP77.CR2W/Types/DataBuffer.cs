using System;
using System.Collections.Generic;
using System.IO;
using System.Runtime.Serialization;
using System.Text;
using FastMember;
using CP77.CR2W.Reflection;

namespace CP77.CR2W.Types
{
    [REDMeta]
    public class DataBuffer : CVariable
    {
        
        public DataBuffer(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }

        public CBytes Buffer { get; set; }

        public override void Read(BinaryReader file, uint size)
        {
            Buffer = new CBytes(cr2w, this, nameof(Buffer))
            {
                Bytes = new byte[0],
                IsSerialized = true
            };

            Buffer.Read(file, size);
        }
    }

    [REDMeta]
    public class serializationDeferredDataBuffer : CVariable
    {
        
        public serializationDeferredDataBuffer(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }

        public CBytes Buffer { get; set; }

        public override void Read(BinaryReader file, uint size)
        {
            Buffer = new CBytes(cr2w, this, nameof(Buffer))
            {
                Bytes = new byte[0],
                IsSerialized = true
            };

            Buffer.Read(file, size);
        }
    }

    [REDMeta]
    public class RenderSceneLayerMask : CVariable
    {
        public RenderSceneLayerMask(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
    }

    [REDMeta]
    public class workWorkspotItemPolicy : CVariable
    {
        public workWorkspotItemPolicy(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
    }
    [REDMeta]
    public class MessageResourcePath : CVariable
    {
        public MessageResourcePath(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
    }
    [REDMeta]
    public class EditorObjectID : CVariable
    {
        public EditorObjectID(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
    }
    [REDMeta]
    public class gameuiContext : CVariable
    {
        public gameuiContext(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
    }
    [REDMeta]
    public class animMuteAnimEvents : CVariable
    {
        public animMuteAnimEvents(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
    }



}
