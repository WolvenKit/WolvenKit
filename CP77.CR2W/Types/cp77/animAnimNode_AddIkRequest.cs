using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class animAnimNode_AddIkRequest : animAnimNode_OnePoseInput
	{
		[Ordinal(12)] [RED("ikChain")] public CName IkChain { get; set; }
		[Ordinal(13)] [RED("targetBone")] public animTransformIndex TargetBone { get; set; }
		[Ordinal(14)] [RED("positionOffset")] public Vector3 PositionOffset { get; set; }
		[Ordinal(15)] [RED("rotationOffset")] public Quaternion RotationOffset { get; set; }
		[Ordinal(16)] [RED("poleVector")] public animPoleVectorDetails PoleVector { get; set; }
		[Ordinal(17)] [RED("weightPosition")] public CFloat WeightPosition { get; set; }
		[Ordinal(18)] [RED("weightRotation")] public CFloat WeightRotation { get; set; }
		[Ordinal(19)] [RED("blendTimeIn")] public CFloat BlendTimeIn { get; set; }
		[Ordinal(20)] [RED("blendTimeOut")] public CFloat BlendTimeOut { get; set; }
		[Ordinal(21)] [RED("priority")] public CInt32 Priority { get; set; }

		public animAnimNode_AddIkRequest(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
