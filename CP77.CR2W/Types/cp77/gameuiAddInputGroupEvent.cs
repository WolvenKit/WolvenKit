using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class gameuiAddInputGroupEvent : redEvent
	{
		[Ordinal(0)] [RED("groupId")] public CName GroupId { get; set; }
		[Ordinal(1)] [RED("data")] public gameuiInputHintGroupData Data { get; set; }
		[Ordinal(2)] [RED("targetHintContainer")] public CName TargetHintContainer { get; set; }

		public gameuiAddInputGroupEvent(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
