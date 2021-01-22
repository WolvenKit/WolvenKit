using System.IO;
using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class gamehitRepresentationEventsToggleHitShapeEvent : redEvent
	{
		[Ordinal(0)]  [RED("enable")] public CBool Enable { get; set; }
		[Ordinal(1)]  [RED("hierarchical")] public CBool Hierarchical { get; set; }
		[Ordinal(2)]  [RED("hitShapeName")] public CName HitShapeName { get; set; }

		public gamehitRepresentationEventsToggleHitShapeEvent(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
