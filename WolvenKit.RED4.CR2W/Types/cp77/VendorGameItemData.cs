using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class VendorGameItemData : IScriptable
	{
		private CHandle<gameItemData> _gameItemData;
		private gameSItemStack _itemStack;

		[Ordinal(0)] 
		[RED("gameItemData")] 
		public CHandle<gameItemData> GameItemData
		{
			get
			{
				if (_gameItemData == null)
				{
					_gameItemData = (CHandle<gameItemData>) CR2WTypeManager.Create("handle:gameItemData", "gameItemData", cr2w, this);
				}
				return _gameItemData;
			}
			set
			{
				if (_gameItemData == value)
				{
					return;
				}
				_gameItemData = value;
				PropertySet(this);
			}
		}

		[Ordinal(1)] 
		[RED("itemStack")] 
		public gameSItemStack ItemStack
		{
			get
			{
				if (_itemStack == null)
				{
					_itemStack = (gameSItemStack) CR2WTypeManager.Create("gameSItemStack", "itemStack", cr2w, this);
				}
				return _itemStack;
			}
			set
			{
				if (_itemStack == value)
				{
					return;
				}
				_itemStack = value;
				PropertySet(this);
			}
		}

		public VendorGameItemData(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
