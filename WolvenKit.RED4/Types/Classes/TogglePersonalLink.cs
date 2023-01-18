using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class TogglePersonalLink : ActionBool
	{
		[Ordinal(25)] 
		[RED("cachedStatus")] 
		public CEnum<EPersonalLinkConnectionStatus> CachedStatus
		{
			get => GetPropertyValue<CEnum<EPersonalLinkConnectionStatus>>();
			set => SetPropertyValue<CEnum<EPersonalLinkConnectionStatus>>(value);
		}

		[Ordinal(26)] 
		[RED("shouldSkipMiniGame")] 
		public CBool ShouldSkipMiniGame
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		public TogglePersonalLink()
		{
			RequesterID = new();
			InteractionChoice = new() { CaptionParts = new() { Parts = new() }, Data = new(), ChoiceMetaData = new() { Type = new() }, LookAtDescriptor = new() { Offset = new(), OrbId = new() } };
			ActionWidgetPackage = new() { DependendActions = new() };
			Duration = 2.733000F;
			CanTriggerStim = true;

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
