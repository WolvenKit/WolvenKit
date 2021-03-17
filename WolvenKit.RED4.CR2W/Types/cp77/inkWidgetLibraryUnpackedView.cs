using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class inkWidgetLibraryUnpackedView : ISerializable
	{
		private CArray<CHandle<inkWidgetLibraryItemUnpackedView>> _libraryItems;
		private CArray<rRef<inkWidgetLibraryResource>> _externalLibraries;

		[Ordinal(0)] 
		[RED("libraryItems")] 
		public CArray<CHandle<inkWidgetLibraryItemUnpackedView>> LibraryItems
		{
			get => GetProperty(ref _libraryItems);
			set => SetProperty(ref _libraryItems, value);
		}

		[Ordinal(1)] 
		[RED("externalLibraries")] 
		public CArray<rRef<inkWidgetLibraryResource>> ExternalLibraries
		{
			get => GetProperty(ref _externalLibraries);
			set => SetProperty(ref _externalLibraries, value);
		}

		public inkWidgetLibraryUnpackedView(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
