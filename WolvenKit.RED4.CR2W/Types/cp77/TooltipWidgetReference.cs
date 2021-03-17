using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class TooltipWidgetReference : CVariable
	{
		private CName _identifier;
		private inkWidgetLibraryReference _widgetLibraryReference;

		[Ordinal(0)] 
		[RED("identifier")] 
		public CName Identifier
		{
			get => GetProperty(ref _identifier);
			set => SetProperty(ref _identifier, value);
		}

		[Ordinal(1)] 
		[RED("widgetLibraryReference")] 
		public inkWidgetLibraryReference WidgetLibraryReference
		{
			get => GetProperty(ref _widgetLibraryReference);
			set => SetProperty(ref _widgetLibraryReference, value);
		}

		public TooltipWidgetReference(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
