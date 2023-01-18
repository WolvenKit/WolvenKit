using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class gameuiCrosshairBaseMelee : gameuiCrosshairBaseGameController
	{
		[Ordinal(18)] 
		[RED("meleeStateBlackboardId")] 
		public CHandle<redCallbackObject> MeleeStateBlackboardId
		{
			get => GetPropertyValue<CHandle<redCallbackObject>>();
			set => SetPropertyValue<CHandle<redCallbackObject>>(value);
		}

		[Ordinal(19)] 
		[RED("playerSMBB")] 
		public CWeakHandle<gameIBlackboard> PlayerSMBB
		{
			get => GetPropertyValue<CWeakHandle<gameIBlackboard>>();
			set => SetPropertyValue<CWeakHandle<gameIBlackboard>>(value);
		}

		public gameuiCrosshairBaseMelee()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
