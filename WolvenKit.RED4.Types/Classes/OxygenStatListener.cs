using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class OxygenStatListener : gameCustomValueStatPoolsListener
	{
		[Ordinal(0)] 
		[RED("ownerPuppet")] 
		public CWeakHandle<PlayerPuppet> OwnerPuppet
		{
			get => GetPropertyValue<CWeakHandle<PlayerPuppet>>();
			set => SetPropertyValue<CWeakHandle<PlayerPuppet>>(value);
		}

		[Ordinal(1)] 
		[RED("oxygenVfxBlackboard")] 
		public CHandle<worldEffectBlackboard> OxygenVfxBlackboard
		{
			get => GetPropertyValue<CHandle<worldEffectBlackboard>>();
			set => SetPropertyValue<CHandle<worldEffectBlackboard>>(value);
		}

		public OxygenStatListener()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
