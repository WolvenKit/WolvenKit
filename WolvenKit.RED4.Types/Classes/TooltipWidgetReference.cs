using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class TooltipWidgetReference : RedBaseClass
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
	}
}
