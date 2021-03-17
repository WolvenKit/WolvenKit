using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class inkWidgetLibraryResourceWrapper : CVariable
	{
		private raRef<inkWidgetLibraryResource> _library;

		[Ordinal(0)] 
		[RED("library")] 
		public raRef<inkWidgetLibraryResource> Library
		{
			get => GetProperty(ref _library);
			set => SetProperty(ref _library, value);
		}

		public inkWidgetLibraryResourceWrapper(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
