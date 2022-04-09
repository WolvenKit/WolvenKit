using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class RemoveStatusEffectEvent : redEvent
	{
		[Ordinal(0)] 
		[RED("effectID")] 
		public TweakDBID EffectID
		{
			get => GetPropertyValue<TweakDBID>();
			set => SetPropertyValue<TweakDBID>(value);
		}

		[Ordinal(1)] 
		[RED("removeCount")] 
		public CUInt32 RemoveCount
		{
			get => GetPropertyValue<CUInt32>();
			set => SetPropertyValue<CUInt32>(value);
		}

		public RemoveStatusEffectEvent()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
