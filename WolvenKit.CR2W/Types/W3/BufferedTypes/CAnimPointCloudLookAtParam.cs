using System.Collections.Generic;
using System.IO;
using WolvenKit.CR2W.Editors;
using System.Diagnostics;
using System;
using WolvenKit.CR2W.Reflection;
using System.Runtime.Serialization;

namespace WolvenKit.CR2W.Types
{
    [DataContract(Namespace = "")]
    public class CAnimPointCloudLookAtParam : ISkeletalAnimationSetEntryParam
    {
        [RED("boneName")] public CName BoneName { get; set; }

        [RED("boneMSInv")] public CMatrix BoneMSInv { get; set; }

        [RED("boneTransMSInv")] public EngineQsTransform BoneTransMSInv { get; set; }

        [RED("directionLS")] public Vector DirectionLS { get; set; }

        [RED("pointsBS", 2, 0)] public CArray<Vector> PointsBS { get; set; }

        [RED("pointToTriMapping", 2, 0)] public CArray<CArray<CInt32>> PointToTriMapping { get; set; }

        [RED("refPose", 133, 0)] public CArray<EngineQsTransform> RefPose { get; set; }

        [REDBuffer] public CBufferVLQ<SAnimPointCloudLookAtParamData> buffer { get; set; }
            
        public CAnimPointCloudLookAtParam(CR2WFile cr2w) :
            base(cr2w)
        {
        }

        public override void Read(BinaryReader file, uint size)
        {
            base.Read(file, size);

        }

        public override void Write(BinaryWriter file)
        {
            base.Write(file);

        }

        public override CVariable Create(CR2WFile cr2w)
        {
            return new CAnimPointCloudLookAtParam(cr2w);
        }
    }
}