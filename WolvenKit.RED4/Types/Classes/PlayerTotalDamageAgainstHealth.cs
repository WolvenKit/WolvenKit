using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class PlayerTotalDamageAgainstHealth : RedBaseClass
	{
		[Ordinal(0)] 
		[RED("player")] 
		public CWeakHandle<gameObject> Player
		{
			get => GetPropertyValue<CWeakHandle<gameObject>>();
			set => SetPropertyValue<CWeakHandle<gameObject>>(value);
		}

		[Ordinal(1)] 
		[RED("totalDamage")] 
		public CFloat TotalDamage
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		[Ordinal(2)] 
		[RED("targetHealth")] 
		public CFloat TargetHealth
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		public PlayerTotalDamageAgainstHealth()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
