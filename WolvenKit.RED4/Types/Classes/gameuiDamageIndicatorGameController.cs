using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class gameuiDamageIndicatorGameController : gameuiHUDGameController
	{
		[Ordinal(9)] 
		[RED("maxVisibleParts")] 
		public CUInt8 MaxVisibleParts
		{
			get => GetPropertyValue<CUInt8>();
			set => SetPropertyValue<CUInt8>(value);
		}

		public gameuiDamageIndicatorGameController()
		{
			MaxVisibleParts = 6;

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
