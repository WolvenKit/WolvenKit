using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class SWidgetPackage : SWidgetPackageBase
	{
		private CString _displayName;
		private gamePersistentID _ownerID;
		private CName _ownerIDClassName;
		private CHandle<WidgetCustomData> _customData;
		private CBool _isWidgetInactive;
		private CEnum<EWidgetState> _widgetState;
		private CName _iconID;
		private TweakDBID _bckgroundTextureID;
		private TweakDBID _iconTextureID;
		private CHandle<textTextParameterSet> _textData;

		[Ordinal(7)] 
		[RED("displayName")] 
		public CString DisplayName
		{
			get
			{
				if (_displayName == null)
				{
					_displayName = (CString) CR2WTypeManager.Create("String", "displayName", cr2w, this);
				}
				return _displayName;
			}
			set
			{
				if (_displayName == value)
				{
					return;
				}
				_displayName = value;
				PropertySet(this);
			}
		}

		[Ordinal(8)] 
		[RED("ownerID")] 
		public gamePersistentID OwnerID
		{
			get
			{
				if (_ownerID == null)
				{
					_ownerID = (gamePersistentID) CR2WTypeManager.Create("gamePersistentID", "ownerID", cr2w, this);
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

		[Ordinal(9)] 
		[RED("ownerIDClassName")] 
		public CName OwnerIDClassName
		{
			get
			{
				if (_ownerIDClassName == null)
				{
					_ownerIDClassName = (CName) CR2WTypeManager.Create("CName", "ownerIDClassName", cr2w, this);
				}
				return _ownerIDClassName;
			}
			set
			{
				if (_ownerIDClassName == value)
				{
					return;
				}
				_ownerIDClassName = value;
				PropertySet(this);
			}
		}

		[Ordinal(10)] 
		[RED("customData")] 
		public CHandle<WidgetCustomData> CustomData
		{
			get
			{
				if (_customData == null)
				{
					_customData = (CHandle<WidgetCustomData>) CR2WTypeManager.Create("handle:WidgetCustomData", "customData", cr2w, this);
				}
				return _customData;
			}
			set
			{
				if (_customData == value)
				{
					return;
				}
				_customData = value;
				PropertySet(this);
			}
		}

		[Ordinal(11)] 
		[RED("isWidgetInactive")] 
		public CBool IsWidgetInactive
		{
			get
			{
				if (_isWidgetInactive == null)
				{
					_isWidgetInactive = (CBool) CR2WTypeManager.Create("Bool", "isWidgetInactive", cr2w, this);
				}
				return _isWidgetInactive;
			}
			set
			{
				if (_isWidgetInactive == value)
				{
					return;
				}
				_isWidgetInactive = value;
				PropertySet(this);
			}
		}

		[Ordinal(12)] 
		[RED("widgetState")] 
		public CEnum<EWidgetState> WidgetState
		{
			get
			{
				if (_widgetState == null)
				{
					_widgetState = (CEnum<EWidgetState>) CR2WTypeManager.Create("EWidgetState", "widgetState", cr2w, this);
				}
				return _widgetState;
			}
			set
			{
				if (_widgetState == value)
				{
					return;
				}
				_widgetState = value;
				PropertySet(this);
			}
		}

		[Ordinal(13)] 
		[RED("iconID")] 
		public CName IconID
		{
			get
			{
				if (_iconID == null)
				{
					_iconID = (CName) CR2WTypeManager.Create("CName", "iconID", cr2w, this);
				}
				return _iconID;
			}
			set
			{
				if (_iconID == value)
				{
					return;
				}
				_iconID = value;
				PropertySet(this);
			}
		}

		[Ordinal(14)] 
		[RED("bckgroundTextureID")] 
		public TweakDBID BckgroundTextureID
		{
			get
			{
				if (_bckgroundTextureID == null)
				{
					_bckgroundTextureID = (TweakDBID) CR2WTypeManager.Create("TweakDBID", "bckgroundTextureID", cr2w, this);
				}
				return _bckgroundTextureID;
			}
			set
			{
				if (_bckgroundTextureID == value)
				{
					return;
				}
				_bckgroundTextureID = value;
				PropertySet(this);
			}
		}

		[Ordinal(15)] 
		[RED("iconTextureID")] 
		public TweakDBID IconTextureID
		{
			get
			{
				if (_iconTextureID == null)
				{
					_iconTextureID = (TweakDBID) CR2WTypeManager.Create("TweakDBID", "iconTextureID", cr2w, this);
				}
				return _iconTextureID;
			}
			set
			{
				if (_iconTextureID == value)
				{
					return;
				}
				_iconTextureID = value;
				PropertySet(this);
			}
		}

		[Ordinal(16)] 
		[RED("textData")] 
		public CHandle<textTextParameterSet> TextData
		{
			get
			{
				if (_textData == null)
				{
					_textData = (CHandle<textTextParameterSet>) CR2WTypeManager.Create("handle:textTextParameterSet", "textData", cr2w, this);
				}
				return _textData;
			}
			set
			{
				if (_textData == value)
				{
					return;
				}
				_textData = value;
				PropertySet(this);
			}
		}

		public SWidgetPackage(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
