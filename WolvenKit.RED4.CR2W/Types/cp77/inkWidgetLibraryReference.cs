using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class inkWidgetLibraryReference : CVariable
	{
		private inkWidgetLibraryResourceWrapper _widgetLibrary;
		private CName _widgetItem;

		[Ordinal(0)] 
		[RED("widgetLibrary")] 
		public inkWidgetLibraryResourceWrapper WidgetLibrary
		{
			get => GetProperty(ref _widgetLibrary);
			set => SetProperty(ref _widgetLibrary, value);
		}

		[Ordinal(1)] 
		[RED("widgetItem")] 
		public CName WidgetItem
		{
			get => GetProperty(ref _widgetItem);
			set => SetProperty(ref _widgetItem, value);
		}

		public inkWidgetLibraryReference(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
