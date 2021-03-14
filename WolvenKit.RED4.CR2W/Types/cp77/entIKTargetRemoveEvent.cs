using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class entIKTargetRemoveEvent : redEvent
	{
		[Ordinal(0)] [RED("ikTargetRef")] public animIKTargetRef IkTargetRef { get; set; }

		public entIKTargetRemoveEvent(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
