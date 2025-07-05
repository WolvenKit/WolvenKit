using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class ApplyNewStatusEffectEvent : redEvent
	{
		[Ordinal(0)] 
		[RED("effectID")] 
		public TweakDBID EffectID
		{
			get => GetPropertyValue<TweakDBID>();
			set => SetPropertyValue<TweakDBID>(value);
		}

		[Ordinal(1)] 
		[RED("instigatorID")] 
		public TweakDBID InstigatorID
		{
			get => GetPropertyValue<TweakDBID>();
			set => SetPropertyValue<TweakDBID>(value);
		}

		public ApplyNewStatusEffectEvent()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
