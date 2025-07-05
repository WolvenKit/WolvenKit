using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class WeaponMalfunctionHudEffector : gameEffector
	{
		[Ordinal(0)] 
		[RED("bb")] 
		public CWeakHandle<gameIBlackboard> Bb
		{
			get => GetPropertyValue<CWeakHandle<gameIBlackboard>>();
			set => SetPropertyValue<CWeakHandle<gameIBlackboard>>(value);
		}

		public WeaponMalfunctionHudEffector()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
