using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class gameStatusEffectTDBPicker : RedBaseClass
	{
		[Ordinal(0)] 
		[RED("statusEffect")] 
		public TweakDBID StatusEffect
		{
			get => GetPropertyValue<TweakDBID>();
			set => SetPropertyValue<TweakDBID>(value);
		}

		public gameStatusEffectTDBPicker()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
