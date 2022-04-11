using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
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
		}
	}
}
