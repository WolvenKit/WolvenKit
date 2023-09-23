using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class TogglePersonalLink : ActionBool
	{
		[Ordinal(38)] 
		[RED("cachedStatus")] 
		public CEnum<EPersonalLinkConnectionStatus> CachedStatus
		{
			get => GetPropertyValue<CEnum<EPersonalLinkConnectionStatus>>();
			set => SetPropertyValue<CEnum<EPersonalLinkConnectionStatus>>(value);
		}

		[Ordinal(39)] 
		[RED("shouldSkipMiniGame")] 
		public CBool ShouldSkipMiniGame
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		public TogglePersonalLink()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
