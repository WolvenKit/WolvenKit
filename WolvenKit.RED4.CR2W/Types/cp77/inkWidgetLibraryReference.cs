using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class inkWidgetLibraryReference : CVariable
	{
		[Ordinal(0)] [RED("widgetLibrary")] public inkWidgetLibraryResourceWrapper WidgetLibrary { get; set; }
		[Ordinal(1)] [RED("widgetItem")] public CName WidgetItem { get; set; }

		public inkWidgetLibraryReference(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
