using System.IO;
using WolvenKit.CR2W.Reflection;
using FastMember;
using static WolvenKit.CR2W.Types.Enums;

namespace WolvenKit.CR2W.Types
{
	[REDMeta]
	public class SetQuickHackEvent : redEvent
	{
		[Ordinal(0)]  [RED("quickHackName")] public CName QuickHackName { get; set; }
		[Ordinal(1)]  [RED("wasQuickHacked")] public CBool WasQuickHacked { get; set; }

		public SetQuickHackEvent(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
