using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class gameweaponeventsSetAmmoCountEvent : redEvent
	{
		[Ordinal(0)] 
		[RED("ammoTypeID")] 
		public gameItemID AmmoTypeID
		{
			get => GetPropertyValue<gameItemID>();
			set => SetPropertyValue<gameItemID>(value);
		}

		[Ordinal(1)] 
		[RED("count")] 
		public CUInt32 Count
		{
			get => GetPropertyValue<CUInt32>();
			set => SetPropertyValue<CUInt32>(value);
		}

		public gameweaponeventsSetAmmoCountEvent()
		{
			AmmoTypeID = new gameItemID();

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
