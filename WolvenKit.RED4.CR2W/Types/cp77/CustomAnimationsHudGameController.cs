using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class CustomAnimationsHudGameController : gameuiHUDGameController
	{
		private CHandle<WidgetAnimationManager> _customAnimations;
		private CArray<CName> _onSpawnAnimations;
		private CName _defaultLibraryItemName;
		private CEnum<inkEAnchor> _defaultLibraryItemAnchor;
		private wCHandle<inkWidget> _spawnedLibrararyItem;
		private CName _curentLibraryItemName;
		private CEnum<inkEAnchor> _currentLibraryItemAnchor;
		private wCHandle<inkCompoundWidget> _root;
		private CBool _isInitialized;
		private entEntityID _ownerID;

		[Ordinal(9)] 
		[RED("customAnimations")] 
		public CHandle<WidgetAnimationManager> CustomAnimations
		{
			get
			{
				if (_customAnimations == null)
				{
					_customAnimations = (CHandle<WidgetAnimationManager>) CR2WTypeManager.Create("handle:WidgetAnimationManager", "customAnimations", cr2w, this);
				}
				return _customAnimations;
			}
			set
			{
				if (_customAnimations == value)
				{
					return;
				}
				_customAnimations = value;
				PropertySet(this);
			}
		}

		[Ordinal(10)] 
		[RED("onSpawnAnimations")] 
		public CArray<CName> OnSpawnAnimations
		{
			get
			{
				if (_onSpawnAnimations == null)
				{
					_onSpawnAnimations = (CArray<CName>) CR2WTypeManager.Create("array:CName", "onSpawnAnimations", cr2w, this);
				}
				return _onSpawnAnimations;
			}
			set
			{
				if (_onSpawnAnimations == value)
				{
					return;
				}
				_onSpawnAnimations = value;
				PropertySet(this);
			}
		}

		[Ordinal(11)] 
		[RED("defaultLibraryItemName")] 
		public CName DefaultLibraryItemName
		{
			get
			{
				if (_defaultLibraryItemName == null)
				{
					_defaultLibraryItemName = (CName) CR2WTypeManager.Create("CName", "defaultLibraryItemName", cr2w, this);
				}
				return _defaultLibraryItemName;
			}
			set
			{
				if (_defaultLibraryItemName == value)
				{
					return;
				}
				_defaultLibraryItemName = value;
				PropertySet(this);
			}
		}

		[Ordinal(12)] 
		[RED("defaultLibraryItemAnchor")] 
		public CEnum<inkEAnchor> DefaultLibraryItemAnchor
		{
			get
			{
				if (_defaultLibraryItemAnchor == null)
				{
					_defaultLibraryItemAnchor = (CEnum<inkEAnchor>) CR2WTypeManager.Create("inkEAnchor", "defaultLibraryItemAnchor", cr2w, this);
				}
				return _defaultLibraryItemAnchor;
			}
			set
			{
				if (_defaultLibraryItemAnchor == value)
				{
					return;
				}
				_defaultLibraryItemAnchor = value;
				PropertySet(this);
			}
		}

		[Ordinal(13)] 
		[RED("spawnedLibrararyItem")] 
		public wCHandle<inkWidget> SpawnedLibrararyItem
		{
			get
			{
				if (_spawnedLibrararyItem == null)
				{
					_spawnedLibrararyItem = (wCHandle<inkWidget>) CR2WTypeManager.Create("whandle:inkWidget", "spawnedLibrararyItem", cr2w, this);
				}
				return _spawnedLibrararyItem;
			}
			set
			{
				if (_spawnedLibrararyItem == value)
				{
					return;
				}
				_spawnedLibrararyItem = value;
				PropertySet(this);
			}
		}

		[Ordinal(14)] 
		[RED("curentLibraryItemName")] 
		public CName CurentLibraryItemName
		{
			get
			{
				if (_curentLibraryItemName == null)
				{
					_curentLibraryItemName = (CName) CR2WTypeManager.Create("CName", "curentLibraryItemName", cr2w, this);
				}
				return _curentLibraryItemName;
			}
			set
			{
				if (_curentLibraryItemName == value)
				{
					return;
				}
				_curentLibraryItemName = value;
				PropertySet(this);
			}
		}

		[Ordinal(15)] 
		[RED("currentLibraryItemAnchor")] 
		public CEnum<inkEAnchor> CurrentLibraryItemAnchor
		{
			get
			{
				if (_currentLibraryItemAnchor == null)
				{
					_currentLibraryItemAnchor = (CEnum<inkEAnchor>) CR2WTypeManager.Create("inkEAnchor", "currentLibraryItemAnchor", cr2w, this);
				}
				return _currentLibraryItemAnchor;
			}
			set
			{
				if (_currentLibraryItemAnchor == value)
				{
					return;
				}
				_currentLibraryItemAnchor = value;
				PropertySet(this);
			}
		}

		[Ordinal(16)] 
		[RED("root")] 
		public wCHandle<inkCompoundWidget> Root
		{
			get
			{
				if (_root == null)
				{
					_root = (wCHandle<inkCompoundWidget>) CR2WTypeManager.Create("whandle:inkCompoundWidget", "root", cr2w, this);
				}
				return _root;
			}
			set
			{
				if (_root == value)
				{
					return;
				}
				_root = value;
				PropertySet(this);
			}
		}

		[Ordinal(17)] 
		[RED("isInitialized")] 
		public CBool IsInitialized
		{
			get
			{
				if (_isInitialized == null)
				{
					_isInitialized = (CBool) CR2WTypeManager.Create("Bool", "isInitialized", cr2w, this);
				}
				return _isInitialized;
			}
			set
			{
				if (_isInitialized == value)
				{
					return;
				}
				_isInitialized = value;
				PropertySet(this);
			}
		}

		[Ordinal(18)] 
		[RED("ownerID")] 
		public entEntityID OwnerID
		{
			get
			{
				if (_ownerID == null)
				{
					_ownerID = (entEntityID) CR2WTypeManager.Create("entEntityID", "ownerID", cr2w, this);
				}
				return _ownerID;
			}
			set
			{
				if (_ownerID == value)
				{
					return;
				}
				_ownerID = value;
				PropertySet(this);
			}
		}

		public CustomAnimationsHudGameController(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
