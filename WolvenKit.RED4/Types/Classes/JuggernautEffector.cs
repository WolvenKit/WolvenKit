using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class JuggernautEffector : gameContinuousEffector
	{
		[Ordinal(0)] 
		[RED("modifiersAdded")] 
		public CBool ModifiersAdded
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(1)] 
		[RED("poolSystem")] 
		public CHandle<gameStatPoolsSystem> PoolSystem
		{
			get => GetPropertyValue<CHandle<gameStatPoolsSystem>>();
			set => SetPropertyValue<CHandle<gameStatPoolsSystem>>(value);
		}

		[Ordinal(2)] 
		[RED("statusEffectSystem")] 
		public CHandle<gameStatusEffectSystem> StatusEffectSystem
		{
			get => GetPropertyValue<CHandle<gameStatusEffectSystem>>();
			set => SetPropertyValue<CHandle<gameStatusEffectSystem>>(value);
		}

		public JuggernautEffector()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
