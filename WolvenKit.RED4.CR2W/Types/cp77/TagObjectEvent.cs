using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class TagObjectEvent : redEvent
	{
		[Ordinal(0)] [RED("isTagged")] public CBool IsTagged { get; set; }

		public TagObjectEvent(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
