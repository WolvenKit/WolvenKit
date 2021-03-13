using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class animPoleVectorDetails : CVariable
	{
		[Ordinal(0)] [RED("targetBone")] public animTransformIndex TargetBone { get; set; }
		[Ordinal(1)] [RED("positionOffset")] public Vector3 PositionOffset { get; set; }

		public animPoleVectorDetails(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
