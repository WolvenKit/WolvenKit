using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class TogglePersonalLink : ActionBool
	{
		[Ordinal(39)] 
		[RED("cachedStatus")] 
		public CEnum<EPersonalLinkConnectionStatus> CachedStatus
		{
			get => GetPropertyValue<CEnum<EPersonalLinkConnectionStatus>>();
			set => SetPropertyValue<CEnum<EPersonalLinkConnectionStatus>>(value);
		}

		[Ordinal(40)] 
		[RED("shouldSkipMiniGame")] 
		public CBool ShouldSkipMiniGame
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		public TogglePersonalLink()
		{
			RequesterID = new entEntityID();
			CostComponents = new();
			InteractionChoice = new gameinteractionsChoice();
			ActionWidgetPackage = new SActionWidgetPackage();
			Duration = 2.733000F;
			CanTriggerStim = true;

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
