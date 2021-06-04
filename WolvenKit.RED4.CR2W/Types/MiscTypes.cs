using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Runtime.Serialization;
using FastMember;
using WolvenKit.Common.Model.Cr2w;
using WolvenKit.Interfaces.Core;
using WolvenKit.RED4.CR2W.Reflection;

namespace WolvenKit.RED4.CR2W.Types
{
    [REDMeta]
    public class SharedDataBuffer : CVariable, IDataBufferAccessor
    {
        public SharedDataBuffer(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }

        private CBytes _buffer;

        [Ordinal(1)]
        [REDBuffer(true)]
        public CBytes Buffer
        {
            get => GetProperty(ref _buffer);
            set => SetProperty(ref _buffer, value);
        }

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

        private CUInt16 _buffer;

        [Ordinal(1)]
        [REDBuffer(true)]
        public CUInt16 Buffer
        {
            get => GetProperty(ref _buffer);
            set => SetProperty(ref _buffer, value);
        }

        public override void Read(BinaryReader file, uint size)
        {
            switch (size)
            {
                case 2:
                    Buffer.Read(file, size);
                    break;
                case 4:
                {
                    Buffer.Read(file, 2);

                    var ff = file.ReadBytes(2);

                    break;
                }
                default:
                    throw new InvalidParsingException(nameof(serializationDeferredDataBuffer));
            }
        }

        public override void Write(BinaryWriter file) => Buffer.Write(file);
    }

    [REDMeta]
    public class serializationDeferredDataBuffer : CVariable
    {

        public serializationDeferredDataBuffer(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }

        private CUInt16 _buffer;

        [Ordinal(1)]
        [REDBuffer(true)]
        public CUInt16 Buffer
        {
            get => GetProperty(ref _buffer);
            set => SetProperty(ref _buffer, value);
        }

        public override void Read(BinaryReader file, uint size)
        {
            if (size > 2)
            {
                throw new InvalidParsingException(nameof(serializationDeferredDataBuffer));
            }

            Buffer.Read(file, size);
        }

        public override void Write(BinaryWriter file) => Buffer.Write(file);
    }

    [REDMeta]
    public class AITrafficWorkspotCompiled : worldTrafficSpotCompiled
    {

        public AITrafficWorkspotCompiled(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }

        private CBytes _buffer;

        [Ordinal(1)]
        [REDBuffer(true)]
        public CBytes Buffer
        {
            get => GetProperty(ref _buffer);
            set => SetProperty(ref _buffer, value);
        }

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
