using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class SecurityLocker : InteractiveDevice
	{
		private CHandle<gameInventory> _inventory;
		private CHandle<UseSecurityLocker> _cachedEvent;

		[Ordinal(97)] 
		[RED("inventory")] 
		public CHandle<gameInventory> Inventory
		{
			get => GetProperty(ref _inventory);
			set => SetProperty(ref _inventory, value);
		}

		[Ordinal(98)] 
		[RED("cachedEvent")] 
		public CHandle<UseSecurityLocker> CachedEvent
		{
			get => GetProperty(ref _cachedEvent);
			set => SetProperty(ref _cachedEvent, value);
		}
	}
}
