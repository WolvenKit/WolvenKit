using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class Stash : InteractiveDevice
	{
		[Ordinal(94)] 
		[RED("inventory")] 
		public CHandle<gameInventory> Inventory
		{
			get => GetPropertyValue<CHandle<gameInventory>>();
			set => SetPropertyValue<CHandle<gameInventory>>(value);
		}

		public Stash()
		{
			ControllerTypeName = "StashController";

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
