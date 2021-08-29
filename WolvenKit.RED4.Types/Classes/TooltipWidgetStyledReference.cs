using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class TooltipWidgetStyledReference : RedBaseClass
	{
		private CName _identifier;
		private inkWidgetLibraryReference _widgetLibraryReference;
		private redResourceReferenceScriptToken _menuTooltipStylePath;
		private redResourceReferenceScriptToken _hudTooltipStylePath;

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

		[Ordinal(2)] 
		[RED("menuTooltipStylePath")] 
		public redResourceReferenceScriptToken MenuTooltipStylePath
		{
			get => GetProperty(ref _menuTooltipStylePath);
			set => SetProperty(ref _menuTooltipStylePath, value);
		}

		[Ordinal(3)] 
		[RED("hudTooltipStylePath")] 
		public redResourceReferenceScriptToken HudTooltipStylePath
		{
			get => GetProperty(ref _hudTooltipStylePath);
			set => SetProperty(ref _hudTooltipStylePath, value);
		}
	}
}
