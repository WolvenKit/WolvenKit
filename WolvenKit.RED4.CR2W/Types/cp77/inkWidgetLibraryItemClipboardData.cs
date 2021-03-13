using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class inkWidgetLibraryItemClipboardData : ISerializable
	{
		[Ordinal(0)] [RED("libraryItem")] public CHandle<inkWidgetLibraryItemUnpackedView> LibraryItem { get; set; }

		public inkWidgetLibraryItemClipboardData(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
