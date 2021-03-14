using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class NameplateVisibleEvent : redEvent
	{
		[Ordinal(0)] [RED("isNameplateVisible")] public CBool IsNameplateVisible { get; set; }
		[Ordinal(1)] [RED("entityID")] public entEntityID EntityID { get; set; }

		public NameplateVisibleEvent(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
