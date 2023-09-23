using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class GameplayCyberwareCondition : GameplayConditionBase
	{
		[Ordinal(1)] 
		[RED("cyberwareToCheck")] 
		public TweakDBID CyberwareToCheck
		{
			get => GetPropertyValue<TweakDBID>();
			set => SetPropertyValue<TweakDBID>(value);
		}

		public GameplayCyberwareCondition()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
