using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class gameweaponeventsConsumeMagazineAmmo : redEvent
	{
		[Ordinal(0)] 
		[RED("amount")] 
		public CUInt16 Amount
		{
			get => GetPropertyValue<CUInt16>();
			set => SetPropertyValue<CUInt16>(value);
		}

		public gameweaponeventsConsumeMagazineAmmo()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
