using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class TooltipWidgetStyledReference : RedBaseClass
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

		[Ordinal(2)] 
		[RED("menuTooltipStylePath")] 
		public redResourceReferenceScriptToken MenuTooltipStylePath
		{
			get => GetPropertyValue<redResourceReferenceScriptToken>();
			set => SetPropertyValue<redResourceReferenceScriptToken>(value);
		}

		[Ordinal(3)] 
		[RED("hudTooltipStylePath")] 
		public redResourceReferenceScriptToken HudTooltipStylePath
		{
			get => GetPropertyValue<redResourceReferenceScriptToken>();
			set => SetPropertyValue<redResourceReferenceScriptToken>(value);
		}

		public TooltipWidgetStyledReference()
		{
			WidgetLibraryReference = new() { WidgetLibrary = new() };
			MenuTooltipStylePath = new();
			HudTooltipStylePath = new();

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
