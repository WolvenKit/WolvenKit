using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class ShardItemVirtualController : inkVirtualCompoundItemController
	{
		private inkTextWidgetReference _label;
		private inkTextWidgetReference _counter;
		private inkWidgetReference _collapseIcon;
		private inkWidgetReference _isNewFlag;
		private CHandle<ShardEntryData> _entryData;
		private CHandle<VirutalNestedListData> _nestedListData;
		private wCHandle<CodexListSyncData> _activeItemSync;
		private CBool _isActive;
		private CBool _isItemHovered;
		private CBool _isItemToggled;

		[Ordinal(15)] 
		[RED("label")] 
		public inkTextWidgetReference Label
		{
			get
			{
				if (_label == null)
				{
					_label = (inkTextWidgetReference) CR2WTypeManager.Create("inkTextWidgetReference", "label", cr2w, this);
				}
				return _label;
			}
			set
			{
				if (_label == value)
				{
					return;
				}
				_label = value;
				PropertySet(this);
			}
		}

		[Ordinal(16)] 
		[RED("counter")] 
		public inkTextWidgetReference Counter
		{
			get
			{
				if (_counter == null)
				{
					_counter = (inkTextWidgetReference) CR2WTypeManager.Create("inkTextWidgetReference", "counter", cr2w, this);
				}
				return _counter;
			}
			set
			{
				if (_counter == value)
				{
					return;
				}
				_counter = value;
				PropertySet(this);
			}
		}

		[Ordinal(17)] 
		[RED("collapseIcon")] 
		public inkWidgetReference CollapseIcon
		{
			get
			{
				if (_collapseIcon == null)
				{
					_collapseIcon = (inkWidgetReference) CR2WTypeManager.Create("inkWidgetReference", "collapseIcon", cr2w, this);
				}
				return _collapseIcon;
			}
			set
			{
				if (_collapseIcon == value)
				{
					return;
				}
				_collapseIcon = value;
				PropertySet(this);
			}
		}

		[Ordinal(18)] 
		[RED("isNewFlag")] 
		public inkWidgetReference IsNewFlag
		{
			get
			{
				if (_isNewFlag == null)
				{
					_isNewFlag = (inkWidgetReference) CR2WTypeManager.Create("inkWidgetReference", "isNewFlag", cr2w, this);
				}
				return _isNewFlag;
			}
			set
			{
				if (_isNewFlag == value)
				{
					return;
				}
				_isNewFlag = value;
				PropertySet(this);
			}
		}

		[Ordinal(19)] 
		[RED("entryData")] 
		public CHandle<ShardEntryData> EntryData
		{
			get
			{
				if (_entryData == null)
				{
					_entryData = (CHandle<ShardEntryData>) CR2WTypeManager.Create("handle:ShardEntryData", "entryData", cr2w, this);
				}
				return _entryData;
			}
			set
			{
				if (_entryData == value)
				{
					return;
				}
				_entryData = value;
				PropertySet(this);
			}
		}

		[Ordinal(20)] 
		[RED("nestedListData")] 
		public CHandle<VirutalNestedListData> NestedListData
		{
			get
			{
				if (_nestedListData == null)
				{
					_nestedListData = (CHandle<VirutalNestedListData>) CR2WTypeManager.Create("handle:VirutalNestedListData", "nestedListData", cr2w, this);
				}
				return _nestedListData;
			}
			set
			{
				if (_nestedListData == value)
				{
					return;
				}
				_nestedListData = value;
				PropertySet(this);
			}
		}

		[Ordinal(21)] 
		[RED("activeItemSync")] 
		public wCHandle<CodexListSyncData> ActiveItemSync
		{
			get
			{
				if (_activeItemSync == null)
				{
					_activeItemSync = (wCHandle<CodexListSyncData>) CR2WTypeManager.Create("whandle:CodexListSyncData", "activeItemSync", cr2w, this);
				}
				return _activeItemSync;
			}
			set
			{
				if (_activeItemSync == value)
				{
					return;
				}
				_activeItemSync = value;
				PropertySet(this);
			}
		}

		[Ordinal(22)] 
		[RED("isActive")] 
		public CBool IsActive
		{
			get
			{
				if (_isActive == null)
				{
					_isActive = (CBool) CR2WTypeManager.Create("Bool", "isActive", cr2w, this);
				}
				return _isActive;
			}
			set
			{
				if (_isActive == value)
				{
					return;
				}
				_isActive = value;
				PropertySet(this);
			}
		}

		[Ordinal(23)] 
		[RED("isItemHovered")] 
		public CBool IsItemHovered
		{
			get
			{
				if (_isItemHovered == null)
				{
					_isItemHovered = (CBool) CR2WTypeManager.Create("Bool", "isItemHovered", cr2w, this);
				}
				return _isItemHovered;
			}
			set
			{
				if (_isItemHovered == value)
				{
					return;
				}
				_isItemHovered = value;
				PropertySet(this);
			}
		}

		[Ordinal(24)] 
		[RED("isItemToggled")] 
		public CBool IsItemToggled
		{
			get
			{
				if (_isItemToggled == null)
				{
					_isItemToggled = (CBool) CR2WTypeManager.Create("Bool", "isItemToggled", cr2w, this);
				}
				return _isItemToggled;
			}
			set
			{
				if (_isItemToggled == value)
				{
					return;
				}
				_isItemToggled = value;
				PropertySet(this);
			}
		}

		public ShardItemVirtualController(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
