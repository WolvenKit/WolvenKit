using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class ThumbnailUI : ActionBool
	{
		[Ordinal(38)] 
		[RED("thumbnailWidgetPackage")] 
		public SThumbnailWidgetPackage ThumbnailWidgetPackage
		{
			get => GetPropertyValue<SThumbnailWidgetPackage>();
			set => SetPropertyValue<SThumbnailWidgetPackage>(value);
		}

		public ThumbnailUI()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
