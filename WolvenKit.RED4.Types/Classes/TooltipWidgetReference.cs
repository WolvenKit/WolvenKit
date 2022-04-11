using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class TooltipWidgetReference : RedBaseClass
	{
		[Ordinal(0)] 
		[RED("identifier")] 
		public CName Identifier
		{
			get => GetPropertyValue<CName>();
			set => SetPropertyValue<CName>(value);
		}

		[Ordinal(1)] 
		[RED("widgetLibraryReference")] 
		public inkWidgetLibraryReference WidgetLibraryReference
		{
			get => GetPropertyValue<inkWidgetLibraryReference>();
			set => SetPropertyValue<inkWidgetLibraryReference>(value);
		}

		public TooltipWidgetReference()
		{
			WidgetLibraryReference = new() { WidgetLibrary = new() };
		}
	}
}
