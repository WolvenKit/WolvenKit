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
			RequesterID = new entEntityID();
			InteractionChoice = new gameinteractionsChoice { CaptionParts = new gameinteractionsChoiceCaption { Parts = new() }, Data = new(), ChoiceMetaData = new gameinteractionsChoiceMetaData { Type = new gameinteractionsChoiceTypeWrapper() }, LookAtDescriptor = new gameinteractionsChoiceLookAtDescriptor { Offset = new Vector3(), OrbId = new gameinteractionsOrbID() } };
			ActionWidgetPackage = new SActionWidgetPackage { DependendActions = new() };
			CanTriggerStim = true;
			ThumbnailWidgetPackage = new SThumbnailWidgetPackage();

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
