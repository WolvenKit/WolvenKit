using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class RequestEquipHeavyWeapon : redEvent
	{
		[Ordinal(0)] 
		[RED("itemID")] 
		public gameItemID ItemID
		{
			get => GetPropertyValue<gameItemID>();
			set => SetPropertyValue<gameItemID>(value);
		}

		public RequestEquipHeavyWeapon()
		{
			ItemID = new();

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
