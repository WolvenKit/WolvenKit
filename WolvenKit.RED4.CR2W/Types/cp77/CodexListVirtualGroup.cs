using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class CodexListVirtualGroup : inkVirtualCompoundItemController
	{
		private inkTextWidgetReference _title;
		private inkWidgetReference _arrow;
		private inkWidgetReference _newWrapper;
		private CHandle<CodexEntryData> _entryData;
		private CHandle<VirutalNestedListData> _nestedListData;
		private wCHandle<CodexListSyncData> _activeItemSync;
		private CBool _isActive;
		private CBool _isItemHovered;
		private CBool _isItemToggled;

		[Ordinal(15)] 
		[RED("title")] 
		public inkTextWidgetReference Title
		{
			get
			{
				if (_title == null)
				{
					_title = (inkTextWidgetReference) CR2WTypeManager.Create("inkTextWidgetReference", "title", cr2w, this);
				}
				return _title;
			}
			set
			{
				if (_title == value)
				{
					return;
				}
				_title = value;
				PropertySet(this);
			}
		}

		[Ordinal(16)] 
		[RED("arrow")] 
		public inkWidgetReference Arrow
		{
			get
			{
				if (_arrow == null)
				{
					_arrow = (inkWidgetReference) CR2WTypeManager.Create("inkWidgetReference", "arrow", cr2w, this);
				}
				return _arrow;
			}
			set
			{
				if (_arrow == value)
				{
					return;
				}
				_arrow = value;
				PropertySet(this);
			}
		}

		[Ordinal(17)] 
		[RED("newWrapper")] 
		public inkWidgetReference NewWrapper
		{
			get
			{
				if (_newWrapper == null)
				{
					_newWrapper = (inkWidgetReference) CR2WTypeManager.Create("inkWidgetReference", "newWrapper", cr2w, this);
				}
				return _newWrapper;
			}
			set
			{
				if (_newWrapper == value)
				{
					return;
				}
				_newWrapper = value;
				PropertySet(this);
			}
		}

		[Ordinal(18)] 
		[RED("entryData")] 
		public CHandle<CodexEntryData> EntryData
		{
			get
			{
				if (_entryData == null)
				{
					_entryData = (CHandle<CodexEntryData>) CR2WTypeManager.Create("handle:CodexEntryData", "entryData", cr2w, this);
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

		[Ordinal(19)] 
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

		[Ordinal(20)] 
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

		[Ordinal(21)] 
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

		[Ordinal(22)] 
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

		[Ordinal(23)] 
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

		public CodexListVirtualGroup(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
