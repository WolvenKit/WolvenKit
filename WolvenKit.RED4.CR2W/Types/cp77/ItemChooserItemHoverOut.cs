using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class ItemChooserItemHoverOut : redEvent
	{
		[Ordinal(0)] [RED("sourceEvent")] public CHandle<inkPointerEvent> SourceEvent { get; set; }

		public ItemChooserItemHoverOut(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
