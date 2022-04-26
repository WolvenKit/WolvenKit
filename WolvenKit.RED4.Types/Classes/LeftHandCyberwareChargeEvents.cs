using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class LeftHandCyberwareChargeEvents : LeftHandCyberwareEventsTransition
	{
		[Ordinal(0)] 
		[RED("chargeModeAim")] 
		public CHandle<gameweaponAnimFeature_AimPlayer> ChargeModeAim
		{
			get => GetPropertyValue<CHandle<gameweaponAnimFeature_AimPlayer>>();
			set => SetPropertyValue<CHandle<gameweaponAnimFeature_AimPlayer>>(value);
		}

		[Ordinal(1)] 
		[RED("leftHandObject")] 
		public CWeakHandle<gameweaponObject> LeftHandObject
		{
			get => GetPropertyValue<CWeakHandle<gameweaponObject>>();
			set => SetPropertyValue<CWeakHandle<gameweaponObject>>(value);
		}

		public LeftHandCyberwareChargeEvents()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
