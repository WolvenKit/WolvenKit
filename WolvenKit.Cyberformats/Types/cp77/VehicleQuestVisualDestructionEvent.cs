using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class VehicleQuestVisualDestructionEvent : redEvent
	{
		[Ordinal(0)] [RED("accumulate")] public CBool Accumulate { get; set; }
		[Ordinal(1)] [RED("frontLeft")] public CFloat FrontLeft { get; set; }
		[Ordinal(2)] [RED("frontRight")] public CFloat FrontRight { get; set; }
		[Ordinal(3)] [RED("front")] public CFloat Front { get; set; }
		[Ordinal(4)] [RED("right")] public CFloat Right { get; set; }
		[Ordinal(5)] [RED("left")] public CFloat Left { get; set; }
		[Ordinal(6)] [RED("backLeft")] public CFloat BackLeft { get; set; }
		[Ordinal(7)] [RED("backRight")] public CFloat BackRight { get; set; }
		[Ordinal(8)] [RED("back")] public CFloat Back { get; set; }
		[Ordinal(9)] [RED("roof")] public CFloat Roof { get; set; }

		public VehicleQuestVisualDestructionEvent(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
