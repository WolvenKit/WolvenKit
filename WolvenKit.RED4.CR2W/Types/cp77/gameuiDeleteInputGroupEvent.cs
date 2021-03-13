using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class gameuiDeleteInputGroupEvent : redEvent
	{
		[Ordinal(0)] [RED("groupId")] public CName GroupId { get; set; }
		[Ordinal(1)] [RED("targetHintContainer")] public CName TargetHintContainer { get; set; }

		public gameuiDeleteInputGroupEvent(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
