using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class inkGameNotificationsLayerDefinition : inkLayerDefinition
	{
		[Ordinal(8)] [RED("cursorResource")] public rRef<inkWidgetLibraryResource> CursorResource { get; set; }

		public inkGameNotificationsLayerDefinition(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
