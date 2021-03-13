using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class gamehitRepresentationEventsToggleHitShapeEvent : redEvent
	{
		[Ordinal(0)] [RED("enable")] public CBool Enable { get; set; }
		[Ordinal(1)] [RED("hitShapeName")] public CName HitShapeName { get; set; }
		[Ordinal(2)] [RED("hierarchical")] public CBool Hierarchical { get; set; }

		public gamehitRepresentationEventsToggleHitShapeEvent(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
