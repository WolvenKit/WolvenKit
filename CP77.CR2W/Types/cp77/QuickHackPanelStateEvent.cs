using System.IO;
using WolvenKit.CR2W.Reflection;
using FastMember;
using static WolvenKit.CR2W.Types.Enums;

namespace WolvenKit.CR2W.Types
{
	[REDMeta]
	public class QuickHackPanelStateEvent : redEvent
	{
		[Ordinal(0)]  [RED("isOpened")] public CBool IsOpened { get; set; }

		public QuickHackPanelStateEvent(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
