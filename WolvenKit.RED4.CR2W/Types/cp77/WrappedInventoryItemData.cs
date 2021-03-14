using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class WrappedInventoryItemData : IScriptable
	{
		private InventoryItemData _itemData;
		private CEnum<gameItemComparisonState> _comparisonState;
		private CBool _isNew;
		private CUInt32 _itemTemplate;
		private CEnum<gameItemDisplayContext> _displayContext;

		[Ordinal(0)] 
		[RED("ItemData")] 
		public InventoryItemData ItemData
		{
			get
			{
				if (_itemData == null)
				{
					_itemData = (InventoryItemData) CR2WTypeManager.Create("InventoryItemData", "ItemData", cr2w, this);
				}
				return _itemData;
			}
			set
			{
				if (_itemData == value)
				{
					return;
				}
				_itemData = value;
				PropertySet(this);
			}
		}

		[Ordinal(1)] 
		[RED("ComparisonState")] 
		public CEnum<gameItemComparisonState> ComparisonState
		{
			get
			{
				if (_comparisonState == null)
				{
					_comparisonState = (CEnum<gameItemComparisonState>) CR2WTypeManager.Create("gameItemComparisonState", "ComparisonState", cr2w, this);
				}
				return _comparisonState;
			}
			set
			{
				if (_comparisonState == value)
				{
					return;
				}
				_comparisonState = value;
				PropertySet(this);
			}
		}

		[Ordinal(2)] 
		[RED("IsNew")] 
		public CBool IsNew
		{
			get
			{
				if (_isNew == null)
				{
					_isNew = (CBool) CR2WTypeManager.Create("Bool", "IsNew", cr2w, this);
				}
				return _isNew;
			}
			set
			{
				if (_isNew == value)
				{
					return;
				}
				_isNew = value;
				PropertySet(this);
			}
		}

		[Ordinal(3)] 
		[RED("ItemTemplate")] 
		public CUInt32 ItemTemplate
		{
			get
			{
				if (_itemTemplate == null)
				{
					_itemTemplate = (CUInt32) CR2WTypeManager.Create("Uint32", "ItemTemplate", cr2w, this);
				}
				return _itemTemplate;
			}
			set
			{
				if (_itemTemplate == value)
				{
					return;
				}
				_itemTemplate = value;
				PropertySet(this);
			}
		}

		[Ordinal(4)] 
		[RED("DisplayContext")] 
		public CEnum<gameItemDisplayContext> DisplayContext
		{
			get
			{
				if (_displayContext == null)
				{
					_displayContext = (CEnum<gameItemDisplayContext>) CR2WTypeManager.Create("gameItemDisplayContext", "DisplayContext", cr2w, this);
				}
				return _displayContext;
			}
			set
			{
				if (_displayContext == value)
				{
					return;
				}
				_displayContext = value;
				PropertySet(this);
			}
		}

		public WrappedInventoryItemData(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
