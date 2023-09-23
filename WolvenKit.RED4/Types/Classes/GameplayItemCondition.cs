using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class GameplayItemCondition : GameplayConditionBase
	{
		[Ordinal(1)] 
		[RED("itemToCheck")] 
		public TweakDBID ItemToCheck
		{
			get => GetPropertyValue<TweakDBID>();
			set => SetPropertyValue<TweakDBID>(value);
		}

		public GameplayItemCondition()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
