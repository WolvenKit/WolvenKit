using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class QuickSlotCommandUsed : redEvent
	{
		[Ordinal(0)] 
		[RED("action")] 
		public CHandle<gamedeviceAction> Action
		{
			get => GetPropertyValue<CHandle<gamedeviceAction>>();
			set => SetPropertyValue<CHandle<gamedeviceAction>>(value);
		}

		public QuickSlotCommandUsed()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
