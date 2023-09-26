using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class gameuiCrosshairBaseMelee : gameuiCrosshairBaseGameController
	{
		[Ordinal(27)] 
		[RED("meleeStateBlackboardId")] 
		public CHandle<redCallbackObject> MeleeStateBlackboardId
		{
			get => GetPropertyValue<CHandle<redCallbackObject>>();
			set => SetPropertyValue<CHandle<redCallbackObject>>(value);
		}

		public gameuiCrosshairBaseMelee()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
