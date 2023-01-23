using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class ThumbnailUI : ActionBool
	{
		[Ordinal(25)] 
		[RED("thumbnailWidgetPackage")] 
		public SThumbnailWidgetPackage ThumbnailWidgetPackage
		{
			get => GetPropertyValue<SThumbnailWidgetPackage>();
			set => SetPropertyValue<SThumbnailWidgetPackage>(value);
		}

		public ThumbnailUI()
		{
			RequesterID = new();
			InteractionChoice = new() { CaptionParts = new() { Parts = new() }, Data = new(), ChoiceMetaData = new() { Type = new() }, LookAtDescriptor = new() { Offset = new(), OrbId = new() } };
			ActionWidgetPackage = new() { DependendActions = new() };
			CanTriggerStim = true;
			ThumbnailWidgetPackage = new();

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
