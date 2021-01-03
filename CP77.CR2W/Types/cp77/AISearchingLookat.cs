using System.IO;
using WolvenKit.CR2W.Reflection;
using FastMember;
using static WolvenKit.CR2W.Types.Enums;

namespace WolvenKit.CR2W.Types
{
	[REDMeta]
	public class AISearchingLookat : AIGenericStaticLookatTask
	{
		[Ordinal(0)]  [RED("currentTarget")] public Vector4 CurrentTarget { get; set; }
		[Ordinal(1)]  [RED("lastTarget")] public Vector4 LastTarget { get; set; }
		[Ordinal(2)]  [RED("maxLookAroundAngle")] public CFloat MaxLookAroundAngle { get; set; }
		[Ordinal(3)]  [RED("maxLookAroundAngleMapping")] public CHandle<AIArgumentMapping> MaxLookAroundAngleMapping { get; set; }
		[Ordinal(4)]  [RED("minAngleDifference")] public CFloat MinAngleDifference { get; set; }
		[Ordinal(5)]  [RED("minAngleDifferenceMapping")] public CHandle<AIArgumentMapping> MinAngleDifferenceMapping { get; set; }
		[Ordinal(6)]  [RED("sideHorizontal")] public CInt32 SideHorizontal { get; set; }
		[Ordinal(7)]  [RED("sideVertical")] public CInt32 SideVertical { get; set; }
		[Ordinal(8)]  [RED("targetSwitchCooldown")] public CFloat TargetSwitchCooldown { get; set; }
		[Ordinal(9)]  [RED("targetSwitchTimeStamp")] public CFloat TargetSwitchTimeStamp { get; set; }

		public AISearchingLookat(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
