using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class gameeventsCoverHitEvent : gameeventsHitEvent
	{
		[Ordinal(12)] [RED("cover")] public wCHandle<gameObject> Cover { get; set; }

		public gameeventsCoverHitEvent(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
