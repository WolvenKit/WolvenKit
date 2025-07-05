using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class CasinoChipsInventoryCallback : gameInventoryScriptCallback
	{
		[Ordinal(1)] 
		[RED("casinoTableGameController")] 
		public CWeakHandle<CasinoTableGameController> CasinoTableGameController
		{
			get => GetPropertyValue<CWeakHandle<CasinoTableGameController>>();
			set => SetPropertyValue<CWeakHandle<CasinoTableGameController>>(value);
		}

		[Ordinal(2)] 
		[RED("slot")] 
		public CEnum<CasinoTableSlot> Slot
		{
			get => GetPropertyValue<CEnum<CasinoTableSlot>>();
			set => SetPropertyValue<CEnum<CasinoTableSlot>>(value);
		}

		public CasinoChipsInventoryCallback()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
