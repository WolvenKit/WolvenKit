using System.IO;
using WolvenKit.CR2W.Reflection;
using FastMember;
using static WolvenKit.CR2W.Types.Enums;

namespace WolvenKit.CR2W.Types
{
	[REDMeta]
	public class BloodPuddleEvent : redEvent
	{
		[Ordinal(0)]  [RED("cyberBlood")] public CBool CyberBlood { get; set; }
		[Ordinal(1)]  [RED("slotName")] public CName SlotName { get; set; }

		public BloodPuddleEvent(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
