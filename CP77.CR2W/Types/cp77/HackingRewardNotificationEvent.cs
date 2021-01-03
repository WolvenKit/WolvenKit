using System.IO;
using WolvenKit.CR2W.Reflection;
using FastMember;
using static WolvenKit.CR2W.Types.Enums;

namespace WolvenKit.CR2W.Types
{
	[REDMeta]
	public class HackingRewardNotificationEvent : redEvent
	{
		[Ordinal(0)]  [RED("icons")] public CArray<CString> Icons { get; set; }
		[Ordinal(1)]  [RED("text")] public CString Text { get; set; }

		public HackingRewardNotificationEvent(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
