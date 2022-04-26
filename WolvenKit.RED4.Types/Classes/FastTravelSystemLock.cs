using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class FastTravelSystemLock : RedBaseClass
	{
		[Ordinal(0)] 
		[RED("lockReason")] 
		public CName LockReason
		{
			get => GetPropertyValue<CName>();
			set => SetPropertyValue<CName>(value);
		}

		[Ordinal(1)] 
		[RED("linkedStatusEffectID")] 
		public TweakDBID LinkedStatusEffectID
		{
			get => GetPropertyValue<TweakDBID>();
			set => SetPropertyValue<TweakDBID>(value);
		}

		public FastTravelSystemLock()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
