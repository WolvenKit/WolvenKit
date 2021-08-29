using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class LeftHandCyberwareChargeEvents : LeftHandCyberwareEventsTransition
	{
		private CHandle<gameweaponAnimFeature_AimPlayer> _chargeModeAim;
		private CWeakHandle<gameweaponObject> _leftHandObject;

		[Ordinal(0)] 
		[RED("chargeModeAim")] 
		public CHandle<gameweaponAnimFeature_AimPlayer> ChargeModeAim
		{
			get => GetProperty(ref _chargeModeAim);
			set => SetProperty(ref _chargeModeAim, value);
		}

		[Ordinal(1)] 
		[RED("leftHandObject")] 
		public CWeakHandle<gameweaponObject> LeftHandObject
		{
			get => GetProperty(ref _leftHandObject);
			set => SetProperty(ref _leftHandObject, value);
		}
	}
}
