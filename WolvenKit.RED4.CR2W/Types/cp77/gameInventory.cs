using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class gameInventory : gameComponent
	{
		private CBool _saveInventory;
		private CEnum<gameSharedInventoryTag> _inventoryTag;
		private CBool _noInitialization;

		[Ordinal(4)] 
		[RED("saveInventory")] 
		public CBool SaveInventory
		{
			get
			{
				if (_saveInventory == null)
				{
					_saveInventory = (CBool) CR2WTypeManager.Create("Bool", "saveInventory", cr2w, this);
				}
				return _saveInventory;
			}
			set
			{
				if (_saveInventory == value)
				{
					return;
				}
				_saveInventory = value;
				PropertySet(this);
			}
		}

		[Ordinal(5)] 
		[RED("inventoryTag")] 
		public CEnum<gameSharedInventoryTag> InventoryTag
		{
			get
			{
				if (_inventoryTag == null)
				{
					_inventoryTag = (CEnum<gameSharedInventoryTag>) CR2WTypeManager.Create("gameSharedInventoryTag", "inventoryTag", cr2w, this);
				}
				return _inventoryTag;
			}
			set
			{
				if (_inventoryTag == value)
				{
					return;
				}
				_inventoryTag = value;
				PropertySet(this);
			}
		}

		[Ordinal(6)] 
		[RED("noInitialization")] 
		public CBool NoInitialization
		{
			get
			{
				if (_noInitialization == null)
				{
					_noInitialization = (CBool) CR2WTypeManager.Create("Bool", "noInitialization", cr2w, this);
				}
				return _noInitialization;
			}
			set
			{
				if (_noInitialization == value)
				{
					return;
				}
				_noInitialization = value;
				PropertySet(this);
			}
		}

		public gameInventory(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
