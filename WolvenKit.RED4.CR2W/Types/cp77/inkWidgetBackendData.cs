using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class inkWidgetBackendData : IBackendData
	{
		private wCHandle<inkWidget> _owner;
		private CBool _isHiddenInEditor;
		private CBool _isLocked;
		private CName _boundLibraryItemName;

		[Ordinal(0)] 
		[RED("owner")] 
		public wCHandle<inkWidget> Owner
		{
			get
			{
				if (_owner == null)
				{
					_owner = (wCHandle<inkWidget>) CR2WTypeManager.Create("whandle:inkWidget", "owner", cr2w, this);
				}
				return _owner;
			}
			set
			{
				if (_owner == value)
				{
					return;
				}
				_owner = value;
				PropertySet(this);
			}
		}

		[Ordinal(1)] 
		[RED("isHiddenInEditor")] 
		public CBool IsHiddenInEditor
		{
			get
			{
				if (_isHiddenInEditor == null)
				{
					_isHiddenInEditor = (CBool) CR2WTypeManager.Create("Bool", "isHiddenInEditor", cr2w, this);
				}
				return _isHiddenInEditor;
			}
			set
			{
				if (_isHiddenInEditor == value)
				{
					return;
				}
				_isHiddenInEditor = value;
				PropertySet(this);
			}
		}

		[Ordinal(2)] 
		[RED("isLocked")] 
		public CBool IsLocked
		{
			get
			{
				if (_isLocked == null)
				{
					_isLocked = (CBool) CR2WTypeManager.Create("Bool", "isLocked", cr2w, this);
				}
				return _isLocked;
			}
			set
			{
				if (_isLocked == value)
				{
					return;
				}
				_isLocked = value;
				PropertySet(this);
			}
		}

		[Ordinal(3)] 
		[RED("boundLibraryItemName")] 
		public CName BoundLibraryItemName
		{
			get
			{
				if (_boundLibraryItemName == null)
				{
					_boundLibraryItemName = (CName) CR2WTypeManager.Create("CName", "boundLibraryItemName", cr2w, this);
				}
				return _boundLibraryItemName;
			}
			set
			{
				if (_boundLibraryItemName == value)
				{
					return;
				}
				_boundLibraryItemName = value;
				PropertySet(this);
			}
		}

		public inkWidgetBackendData(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
