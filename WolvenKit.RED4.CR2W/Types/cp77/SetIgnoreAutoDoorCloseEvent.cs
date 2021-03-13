using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class SetIgnoreAutoDoorCloseEvent : redEvent
	{
		[Ordinal(0)] [RED("set")] public CBool Set { get; set; }

		public SetIgnoreAutoDoorCloseEvent(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
