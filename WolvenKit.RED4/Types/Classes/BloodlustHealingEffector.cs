using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class BloodlustHealingEffector : ApplyEffectToDismemberedEffector
	{
		[Ordinal(0)] 
		[RED("poolSystem")] 
		public CHandle<gameStatPoolsSystem> PoolSystem
		{
			get => GetPropertyValue<CHandle<gameStatPoolsSystem>>();
			set => SetPropertyValue<CHandle<gameStatPoolsSystem>>(value);
		}

		[Ordinal(1)] 
		[RED("maxDistanceSquared")] 
		public CFloat MaxDistanceSquared
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		[Ordinal(2)] 
		[RED("healAmount")] 
		public CFloat HealAmount
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		[Ordinal(3)] 
		[RED("usePercent")] 
		public CBool UsePercent
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(4)] 
		[RED("lastActivationTime")] 
		public CFloat LastActivationTime
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		public BloodlustHealingEffector()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
