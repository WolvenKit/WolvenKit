using System.IO;
using WolvenKit.CR2W.Reflection;
using FastMember;
using static WolvenKit.CR2W.Types.Enums;

namespace WolvenKit.CR2W.Types
{
	[REDMeta]
	public class animAnimNode_AddIkRequest : animAnimNode_OnePoseInput
	{
		[Ordinal(0)]  [RED("blendTimeIn")] public CFloat BlendTimeIn { get; set; }
		[Ordinal(1)]  [RED("blendTimeOut")] public CFloat BlendTimeOut { get; set; }
		[Ordinal(2)]  [RED("ikChain")] public CName IkChain { get; set; }
		[Ordinal(3)]  [RED("poleVector")] public animPoleVectorDetails PoleVector { get; set; }
		[Ordinal(4)]  [RED("positionOffset")] public Vector3 PositionOffset { get; set; }
		[Ordinal(5)]  [RED("priority")] public CInt32 Priority { get; set; }
		[Ordinal(6)]  [RED("rotationOffset")] public Quaternion RotationOffset { get; set; }
		[Ordinal(7)]  [RED("targetBone")] public animTransformIndex TargetBone { get; set; }
		[Ordinal(8)]  [RED("weightPosition")] public CFloat WeightPosition { get; set; }
		[Ordinal(9)]  [RED("weightRotation")] public CFloat WeightRotation { get; set; }

		public animAnimNode_AddIkRequest(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
