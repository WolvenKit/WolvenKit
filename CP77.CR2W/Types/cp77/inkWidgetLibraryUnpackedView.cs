using System.IO;
using WolvenKit.CR2W.Reflection;
using FastMember;
using static WolvenKit.CR2W.Types.Enums;

namespace WolvenKit.CR2W.Types
{
	[REDMeta]
	public class inkWidgetLibraryUnpackedView : ISerializable
	{
		[Ordinal(0)]  [RED("externalLibraries")] public CArray<rRef<inkWidgetLibraryResource>> ExternalLibraries { get; set; }
		[Ordinal(1)]  [RED("libraryItems")] public CArray<CHandle<inkWidgetLibraryItemUnpackedView>> LibraryItems { get; set; }

		public inkWidgetLibraryUnpackedView(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
