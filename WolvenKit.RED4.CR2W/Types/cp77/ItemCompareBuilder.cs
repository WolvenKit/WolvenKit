using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class ItemCompareBuilder : IScriptable
	{
		private InventoryItemData _item1;
		private InventoryItemData _item2;
		private CHandle<CompareBuilder> _compareBuilder;

		[Ordinal(0)] 
		[RED("item1")] 
		public InventoryItemData Item1
		{
			get
			{
				if (_item1 == null)
				{
					_item1 = (InventoryItemData) CR2WTypeManager.Create("InventoryItemData", "item1", cr2w, this);
				}
				return _item1;
			}
			set
			{
				if (_item1 == value)
				{
					return;
				}
				_item1 = value;
				PropertySet(this);
			}
		}

		[Ordinal(1)] 
		[RED("item2")] 
		public InventoryItemData Item2
		{
			get
			{
				if (_item2 == null)
				{
					_item2 = (InventoryItemData) CR2WTypeManager.Create("InventoryItemData", "item2", cr2w, this);
				}
				return _item2;
			}
			set
			{
				if (_item2 == value)
				{
					return;
				}
				_item2 = value;
				PropertySet(this);
			}
		}

		[Ordinal(2)] 
		[RED("compareBuilder")] 
		public CHandle<CompareBuilder> CompareBuilder
		{
			get
			{
				if (_compareBuilder == null)
				{
					_compareBuilder = (CHandle<CompareBuilder>) CR2WTypeManager.Create("handle:CompareBuilder", "compareBuilder", cr2w, this);
				}
				return _compareBuilder;
			}
			set
			{
				if (_compareBuilder == value)
				{
					return;
				}
				_compareBuilder = value;
				PropertySet(this);
			}
		}

		public ItemCompareBuilder(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
