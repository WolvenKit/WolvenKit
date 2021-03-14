using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class AddItemForPlayerToPickUp : ScriptableDeviceAction
	{
		private TweakDBID _lootTable;
		private CBool _shouldAdd;

		[Ordinal(25)] 
		[RED("lootTable")] 
		public TweakDBID LootTable
		{
			get
			{
				if (_lootTable == null)
				{
					_lootTable = (TweakDBID) CR2WTypeManager.Create("TweakDBID", "lootTable", cr2w, this);
				}
				return _lootTable;
			}
			set
			{
				if (_lootTable == value)
				{
					return;
				}
				_lootTable = value;
				PropertySet(this);
			}
		}

		[Ordinal(26)] 
		[RED("shouldAdd")] 
		public CBool ShouldAdd
		{
			get
			{
				if (_shouldAdd == null)
				{
					_shouldAdd = (CBool) CR2WTypeManager.Create("Bool", "shouldAdd", cr2w, this);
				}
				return _shouldAdd;
			}
			set
			{
				if (_shouldAdd == value)
				{
					return;
				}
				_shouldAdd = value;
				PropertySet(this);
			}
		}

		public AddItemForPlayerToPickUp(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
