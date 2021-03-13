using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class gameRicochetData : CVariable
	{
		[Ordinal(0)] [RED("count")] public CInt32 Count { get; set; }
		[Ordinal(1)] [RED("range")] public CFloat Range { get; set; }
		[Ordinal(2)] [RED("targetSearchAngle")] public CFloat TargetSearchAngle { get; set; }
		[Ordinal(3)] [RED("minAngle")] public CFloat MinAngle { get; set; }
		[Ordinal(4)] [RED("maxAngle")] public CFloat MaxAngle { get; set; }
		[Ordinal(5)] [RED("chance")] public CFloat Chance { get; set; }

		public gameRicochetData(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
