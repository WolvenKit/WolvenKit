using System.Collections.Generic;
using System.IO;

using System.Diagnostics;
using System;
using System.Linq;
using System.Runtime.Serialization;
using WolvenKit.CR2W.Reflection;
using FastMember;

namespace WolvenKit.CR2W.Types
{
    [REDMeta(EREDMetaInfo.REDStruct)]
    class SBlockDataRigidBody : CVariable
    {
        [Ordinal(1)] [RED] public CUInt16 meshIndex { get; set; }
        [Ordinal(2)] [RED] public CUInt16 forceAutoHide { get; set; }
        [Ordinal(3)] [RED] public CUInt8 lightChanels { get; set; }
        [Ordinal(4)] [RED] public CUInt8 forcedLodLevel { get; set; }
        [Ordinal(5)] [RED] public CUInt8 shadowBias { get; set; }
        [Ordinal(6)] [RED] public CUInt8 renderingPlane { get; set; }
        [Ordinal(7)] [RED] public CFloat linearDamping { get; set; }
        [Ordinal(8)] [RED] public CFloat angularDamping { get; set; }
        [Ordinal(9)] [RED] public CFloat linearVelocityClamp { get; set; }
        [Ordinal(10)] [RED] public CUInt64 collisionMask { get; set; }
        [Ordinal(11)] [RED] public CUInt64 collisionGroup { get; set; }
        [Ordinal(12)] [RED] public CUInt8 motionType { get; set; }
        [Ordinal(13)] [RED] public CUInt8 padd1 { get; set; }
        [Ordinal(14)] [RED] public CUInt8 padd2 { get; set; }
        [Ordinal(15)] [RED] public CUInt8 padd3 { get; set; }

        public SBlockDataRigidBody(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
    }
}