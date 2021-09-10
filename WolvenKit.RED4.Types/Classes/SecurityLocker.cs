using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class SecurityLocker : InteractiveDevice
	{
		[Ordinal(97)] 
		[RED("inventory")] 
		public CHandle<gameInventory> Inventory
		{
			get => GetPropertyValue<CHandle<gameInventory>>();
			set => SetPropertyValue<CHandle<gameInventory>>(value);
		}

		[Ordinal(98)] 
		[RED("cachedEvent")] 
		public CHandle<UseSecurityLocker> CachedEvent
		{
			get => GetPropertyValue<CHandle<UseSecurityLocker>>();
			set => SetPropertyValue<CHandle<UseSecurityLocker>>(value);
		}

		public SecurityLocker()
		{
			ControllerTypeName = "SecurityLockerController";
		}
	}
}
