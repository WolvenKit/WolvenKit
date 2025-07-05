using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class gameEffectObjectFilter_PlayerIgnoreFriendlyAndAlive : gameEffectObjectGroupFilter
	{
		[Ordinal(0)] 
		[RED("ignoreCharacterRecord")] 
		public TweakDBID IgnoreCharacterRecord
		{
			get => GetPropertyValue<TweakDBID>();
			set => SetPropertyValue<TweakDBID>(value);
		}

		public gameEffectObjectFilter_PlayerIgnoreFriendlyAndAlive()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
