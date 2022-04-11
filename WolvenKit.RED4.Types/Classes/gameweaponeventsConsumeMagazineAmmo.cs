using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class gameweaponeventsConsumeMagazineAmmo : redEvent
	{
		[Ordinal(0)] 
		[RED("amount")] 
		public CUInt16 Amount
		{
			get => GetPropertyValue<CUInt16>();
			set => SetPropertyValue<CUInt16>(value);
		}
	}
}
