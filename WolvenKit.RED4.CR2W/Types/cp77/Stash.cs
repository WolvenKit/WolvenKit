using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class Stash : InteractiveDevice
	{
		private CHandle<gameInventory> _inventory;

		[Ordinal(96)] 
		[RED("inventory")] 
		public CHandle<gameInventory> Inventory
		{
			get => GetProperty(ref _inventory);
			set => SetProperty(ref _inventory, value);
		}

		public Stash(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
