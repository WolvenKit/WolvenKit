using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class SetCustomObjectDescriptionEvent : redEvent
	{
		[Ordinal(0)] [RED("objectDescription")] public CHandle<ObjectScanningDescription> ObjectDescription { get; set; }

		public SetCustomObjectDescriptionEvent(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
