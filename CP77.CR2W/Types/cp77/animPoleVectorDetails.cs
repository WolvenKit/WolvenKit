using System.IO;
using WolvenKit.CR2W.Reflection;
using FastMember;
using static WolvenKit.CR2W.Types.Enums;

namespace WolvenKit.CR2W.Types
{
	[REDMeta]
	public class animPoleVectorDetails : CVariable
	{
		[Ordinal(0)]  [RED("positionOffset")] public Vector3 PositionOffset { get; set; }
		[Ordinal(1)]  [RED("targetBone")] public animTransformIndex TargetBone { get; set; }

		public animPoleVectorDetails(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
