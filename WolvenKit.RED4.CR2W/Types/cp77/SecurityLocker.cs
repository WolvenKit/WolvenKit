using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class SecurityLocker : InteractiveDevice
	{
		private CHandle<gameInventory> _inventory;
		private CHandle<UseSecurityLocker> _cachedEvent;

		[Ordinal(93)] 
		[RED("inventory")] 
		public CHandle<gameInventory> Inventory
		{
			get => GetProperty(ref _inventory);
			set => SetProperty(ref _inventory, value);
		}

		[Ordinal(94)] 
		[RED("cachedEvent")] 
		public CHandle<UseSecurityLocker> CachedEvent
		{
			get => GetProperty(ref _cachedEvent);
			set => SetProperty(ref _cachedEvent, value);
		}

		public SecurityLocker(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
