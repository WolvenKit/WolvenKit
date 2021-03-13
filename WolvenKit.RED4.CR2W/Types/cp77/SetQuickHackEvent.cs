using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class SetQuickHackEvent : redEvent
	{
		[Ordinal(0)] [RED("wasQuickHacked")] public CBool WasQuickHacked { get; set; }
		[Ordinal(1)] [RED("quickHackName")] public CName QuickHackName { get; set; }

		public SetQuickHackEvent(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
