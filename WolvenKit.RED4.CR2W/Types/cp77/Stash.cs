using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class Stash : InteractiveDevice
	{
		private CHandle<gameInventory> _inventory;

		[Ordinal(93)] 
		[RED("inventory")] 
		public CHandle<gameInventory> Inventory
		{
			get
			{
				if (_inventory == null)
				{
					_inventory = (CHandle<gameInventory>) CR2WTypeManager.Create("handle:gameInventory", "inventory", cr2w, this);
				}
				return _inventory;
			}
			set
			{
				if (_inventory == value)
				{
					return;
				}
				_inventory = value;
				PropertySet(this);
			}
		}

		public Stash(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
