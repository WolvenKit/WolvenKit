using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class inkLayerDefinition : CVariable
	{
		private CBool _enabled;
		private rRef<inkWidgetLibraryResource> _rootLibrary;
		private CBool _activeByDefault;
		private CBool _isPermanent;
		private CBool _useGlobalStyleTheme;
		private CBool _isAffectedByFadeout;
		private CBool _useGameInput;
		private CName _inputContext;

		[Ordinal(0)] 
		[RED("enabled")] 
		public CBool Enabled
		{
			get
			{
				if (_enabled == null)
				{
					_enabled = (CBool) CR2WTypeManager.Create("Bool", "enabled", cr2w, this);
				}
				return _enabled;
			}
			set
			{
				if (_enabled == value)
				{
					return;
				}
				_enabled = value;
				PropertySet(this);
			}
		}

		[Ordinal(1)] 
		[RED("rootLibrary")] 
		public rRef<inkWidgetLibraryResource> RootLibrary
		{
			get
			{
				if (_rootLibrary == null)
				{
					_rootLibrary = (rRef<inkWidgetLibraryResource>) CR2WTypeManager.Create("rRef:inkWidgetLibraryResource", "rootLibrary", cr2w, this);
				}
				return _rootLibrary;
			}
			set
			{
				if (_rootLibrary == value)
				{
					return;
				}
				_rootLibrary = value;
				PropertySet(this);
			}
		}

		[Ordinal(2)] 
		[RED("activeByDefault")] 
		public CBool ActiveByDefault
		{
			get
			{
				if (_activeByDefault == null)
				{
					_activeByDefault = (CBool) CR2WTypeManager.Create("Bool", "activeByDefault", cr2w, this);
				}
				return _activeByDefault;
			}
			set
			{
				if (_activeByDefault == value)
				{
					return;
				}
				_activeByDefault = value;
				PropertySet(this);
			}
		}

		[Ordinal(3)] 
		[RED("isPermanent")] 
		public CBool IsPermanent
		{
			get
			{
				if (_isPermanent == null)
				{
					_isPermanent = (CBool) CR2WTypeManager.Create("Bool", "isPermanent", cr2w, this);
				}
				return _isPermanent;
			}
			set
			{
				if (_isPermanent == value)
				{
					return;
				}
				_isPermanent = value;
				PropertySet(this);
			}
		}

		[Ordinal(4)] 
		[RED("useGlobalStyleTheme")] 
		public CBool UseGlobalStyleTheme
		{
			get
			{
				if (_useGlobalStyleTheme == null)
				{
					_useGlobalStyleTheme = (CBool) CR2WTypeManager.Create("Bool", "useGlobalStyleTheme", cr2w, this);
				}
				return _useGlobalStyleTheme;
			}
			set
			{
				if (_useGlobalStyleTheme == value)
				{
					return;
				}
				_useGlobalStyleTheme = value;
				PropertySet(this);
			}
		}

		[Ordinal(5)] 
		[RED("isAffectedByFadeout")] 
		public CBool IsAffectedByFadeout
		{
			get
			{
				if (_isAffectedByFadeout == null)
				{
					_isAffectedByFadeout = (CBool) CR2WTypeManager.Create("Bool", "isAffectedByFadeout", cr2w, this);
				}
				return _isAffectedByFadeout;
			}
			set
			{
				if (_isAffectedByFadeout == value)
				{
					return;
				}
				_isAffectedByFadeout = value;
				PropertySet(this);
			}
		}

		[Ordinal(6)] 
		[RED("useGameInput")] 
		public CBool UseGameInput
		{
			get
			{
				if (_useGameInput == null)
				{
					_useGameInput = (CBool) CR2WTypeManager.Create("Bool", "useGameInput", cr2w, this);
				}
				return _useGameInput;
			}
			set
			{
				if (_useGameInput == value)
				{
					return;
				}
				_useGameInput = value;
				PropertySet(this);
			}
		}

		[Ordinal(7)] 
		[RED("inputContext")] 
		public CName InputContext
		{
			get
			{
				if (_inputContext == null)
				{
					_inputContext = (CName) CR2WTypeManager.Create("CName", "inputContext", cr2w, this);
				}
				return _inputContext;
			}
			set
			{
				if (_inputContext == value)
				{
					return;
				}
				_inputContext = value;
				PropertySet(this);
			}
		}

		public inkLayerDefinition(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
