using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Runtime.Serialization;
using WolvenKit.Common.Model.Cr2w;
using WolvenKit.Interfaces.Core;
using WolvenKit.RED4.CR2W.Reflection;

namespace WolvenKit.RED4.CR2W.Types
{
    [REDMeta]
    public class SharedDataBuffer : CVariable, IDataBufferAccessor
    {

        public SharedDataBuffer(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }

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

        public override void Write(BinaryWriter file)
        {
            Buffer.Write(file);
        }
    }

    [REDMeta]
    public class DataBuffer : CVariable, IDataBufferAccessor
    {

        public DataBuffer(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }

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

        public override void Write(BinaryWriter file)
        {
            Buffer.Write(file);
        }
    }

    [REDMeta]
    public class serializationDeferredDataBuffer : CVariable, IDataBufferAccessor
    {

        public serializationDeferredDataBuffer(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }

        public CUInt16 Buffer { get; set; }

        public override void Read(BinaryReader file, uint size)
        {
            Buffer = new CUInt16(cr2w, this, nameof(Buffer))
            {
                IsSerialized = true
            };

            if (size > 2)
            {
                throw new InvalidParsingException(nameof(serializationDeferredDataBuffer));
            }

            Buffer.Read(file, size);
        }

        public override void Write(BinaryWriter file)
        {
            Buffer.Write(file);
        }
    }

    [REDMeta]
    public class AITrafficWorkspotCompiled : worldTrafficSpotCompiled
    {

        public AITrafficWorkspotCompiled(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }

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

        public override void Write(BinaryWriter file)
        {
            Buffer.Write(file);
        }

    }

    [REDMeta]
    public class MessageResourcePath : CVariable
    {
        public MessageResourcePath(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }

        public override void Read(BinaryReader file, uint size)
        {
            throw new NotImplementedException(nameof(MessageResourcePath));
        }

        public override void Write(BinaryWriter file)
        {
            throw new NotImplementedException(nameof(MessageResourcePath));
        }

    }
    [REDMeta]
    public class EditorObjectID : CVariable
    {
        public EditorObjectID(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }

        public override void Read(BinaryReader file, uint size)
        {
            throw new NotImplementedException(nameof(EditorObjectID));
        }

        public override void Write(BinaryWriter file)
        {
            throw new NotImplementedException(nameof(EditorObjectID));
        }

    }

}
