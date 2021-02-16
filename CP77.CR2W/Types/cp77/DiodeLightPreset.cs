using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class DiodeLightPreset : CVariable
	{
		[Ordinal(0)] [RED("state")] public CBool State { get; set; }
		[Ordinal(1)] [RED("colorMax")] public CArray<CInt32> ColorMax { get; set; }
		[Ordinal(2)] [RED("colorMin")] public CArray<CInt32> ColorMin { get; set; }
		[Ordinal(3)] [RED("overrideColorMin")] public CBool OverrideColorMin { get; set; }
		[Ordinal(4)] [RED("strength")] public CFloat Strength { get; set; }
		[Ordinal(5)] [RED("curve")] public CName Curve { get; set; }
		[Ordinal(6)] [RED("time")] public CFloat Time { get; set; }
		[Ordinal(7)] [RED("loop")] public CBool Loop { get; set; }
		[Ordinal(8)] [RED("duration")] public CFloat Duration { get; set; }
		[Ordinal(9)] [RED("force")] public CBool Force { get; set; }

		public DiodeLightPreset(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
