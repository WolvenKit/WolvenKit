using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class gameEffectObjectProvider_PhysicalRayFan : gameEffectObjectProvider_PhysicalRay
	{
		[Ordinal(5)] [RED("inputMinRayAngleDiff")] public gameEffectInputParameter_Float InputMinRayAngleDiff { get; set; }

		public gameEffectObjectProvider_PhysicalRayFan(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
