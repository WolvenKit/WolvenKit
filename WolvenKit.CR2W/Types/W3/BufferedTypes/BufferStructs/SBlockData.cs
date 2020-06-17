using System.Collections.Generic;
using System.IO;
using WolvenKit.CR2W.Editors;
using System.Diagnostics;
using System;
using System.Linq;
using System.Runtime.Serialization;

namespace WolvenKit.CR2W.Types
{
    [DataContract(Namespace = "")]
    public class SBlockData : CVariable
    {

        public CMatrix3x3 rotationMatrix;
        public SVector3D position;
        public CUInt16 streamingRadius;
        public CUInt16 flags;
        public CUInt32 occlusionSystemID;
        public CUInt32 resourceIndex;

        public CBytes tail;

        public SBlockData(CR2WFile cr2w) :
            base(cr2w)
        {
            rotationMatrix = new CMatrix3x3(cr2w) { Name = "rotationMatrix" };
            position = new SVector3D(cr2w) { Name = "position" };
            streamingRadius = new CUInt16(cr2w) { Name = "streamingRadius" };
            flags = new CUInt16(cr2w) { Name = "flags" };
            occlusionSystemID = new CUInt32(cr2w) { Name = "occlusionSystemID" };
            resourceIndex = new CUInt32(cr2w) { Name = "resourceIndex" };
            tail = new CBytes(cr2w) { Name = "tail" };
        }

        public override void Read(BinaryReader file, uint size)
        {
            rotationMatrix.Read(file, 36);
            position.Read(file, (uint)12);
            streamingRadius.Read(file, 2);
            flags.Read(file, 2);
            occlusionSystemID.Read(file, 4);
            resourceIndex.Read(file, 4);

            tail.Read(file, size - 60);
        }

        public override void Write(BinaryWriter file)
        {
            rotationMatrix.Write(file);
            position.Write(file);
            streamingRadius.Write(file);
            flags.Write(file);
            occlusionSystemID.Write(file);
            resourceIndex.Write(file);


            tail.Write(file);
        }

        public override CVariable Create(CR2WFile cr2w)
        {
            return new SBlockData(cr2w);
        }

        public override string ToString()
        {
            return "";
        }
    }
}