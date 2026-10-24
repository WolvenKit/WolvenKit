using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class ThumbnailUI : ActionBool
	{
		[Ordinal(39)] 
		[RED("thumbnailWidgetPackage")] 
		public SThumbnailWidgetPackage ThumbnailWidgetPackage
		{
			get => GetPropertyValue<SThumbnailWidgetPackage>();
			set => SetPropertyValue<SThumbnailWidgetPackage>(value);
		}

		public ThumbnailUI()
		{
			RequesterID = new entEntityID();
			CostComponents = new();
			InteractionChoice = new gameinteractionsChoice();
			ActionWidgetPackage = new SActionWidgetPackage();
			CanTriggerStim = true;
			ThumbnailWidgetPackage = new SThumbnailWidgetPackage();

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
