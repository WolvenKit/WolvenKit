using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class inkWidgetLibraryUnpackedView : ISerializable
	{
		[Ordinal(0)] [RED("libraryItems")] public CArray<CHandle<inkWidgetLibraryItemUnpackedView>> LibraryItems { get; set; }
		[Ordinal(1)] [RED("externalLibraries")] public CArray<rRef<inkWidgetLibraryResource>> ExternalLibraries { get; set; }

		public inkWidgetLibraryUnpackedView(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
