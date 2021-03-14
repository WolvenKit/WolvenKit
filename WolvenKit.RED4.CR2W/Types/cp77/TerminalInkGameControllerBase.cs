using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class TerminalInkGameControllerBase : MasterDeviceInkGameControllerBase
	{
		private TweakDBID _layoutID;
		private CName _currentLayoutLibraryID;
		private wCHandle<inkWidget> _mainLayout;
		private CArray<gamePersistentID> _currentlyActiveDevices;
		private wCHandle<inkVideoWidget> _mainDisplayWidget;
		private CString _terminalTitle;
		private CUInt32 _onGlitchingStateChangedListener;

		[Ordinal(18)] 
		[RED("layoutID")] 
		public TweakDBID LayoutID
		{
			get
			{
				if (_layoutID == null)
				{
					_layoutID = (TweakDBID) CR2WTypeManager.Create("TweakDBID", "layoutID", cr2w, this);
				}
				return _layoutID;
			}
			set
			{
				if (_layoutID == value)
				{
					return;
				}
				_layoutID = value;
				PropertySet(this);
			}
		}

		[Ordinal(19)] 
		[RED("currentLayoutLibraryID")] 
		public CName CurrentLayoutLibraryID
		{
			get
			{
				if (_currentLayoutLibraryID == null)
				{
					_currentLayoutLibraryID = (CName) CR2WTypeManager.Create("CName", "currentLayoutLibraryID", cr2w, this);
				}
				return _currentLayoutLibraryID;
			}
			set
			{
				if (_currentLayoutLibraryID == value)
				{
					return;
				}
				_currentLayoutLibraryID = value;
				PropertySet(this);
			}
		}

		[Ordinal(20)] 
		[RED("mainLayout")] 
		public wCHandle<inkWidget> MainLayout
		{
			get
			{
				if (_mainLayout == null)
				{
					_mainLayout = (wCHandle<inkWidget>) CR2WTypeManager.Create("whandle:inkWidget", "mainLayout", cr2w, this);
				}
				return _mainLayout;
			}
			set
			{
				if (_mainLayout == value)
				{
					return;
				}
				_mainLayout = value;
				PropertySet(this);
			}
		}

		[Ordinal(21)] 
		[RED("currentlyActiveDevices")] 
		public CArray<gamePersistentID> CurrentlyActiveDevices
		{
			get
			{
				if (_currentlyActiveDevices == null)
				{
					_currentlyActiveDevices = (CArray<gamePersistentID>) CR2WTypeManager.Create("array:gamePersistentID", "currentlyActiveDevices", cr2w, this);
				}
				return _currentlyActiveDevices;
			}
			set
			{
				if (_currentlyActiveDevices == value)
				{
					return;
				}
				_currentlyActiveDevices = value;
				PropertySet(this);
			}
		}

		[Ordinal(22)] 
		[RED("mainDisplayWidget")] 
		public wCHandle<inkVideoWidget> MainDisplayWidget
		{
			get
			{
				if (_mainDisplayWidget == null)
				{
					_mainDisplayWidget = (wCHandle<inkVideoWidget>) CR2WTypeManager.Create("whandle:inkVideoWidget", "mainDisplayWidget", cr2w, this);
				}
				return _mainDisplayWidget;
			}
			set
			{
				if (_mainDisplayWidget == value)
				{
					return;
				}
				_mainDisplayWidget = value;
				PropertySet(this);
			}
		}

		[Ordinal(23)] 
		[RED("terminalTitle")] 
		public CString TerminalTitle
		{
			get
			{
				if (_terminalTitle == null)
				{
					_terminalTitle = (CString) CR2WTypeManager.Create("String", "terminalTitle", cr2w, this);
				}
				return _terminalTitle;
			}
			set
			{
				if (_terminalTitle == value)
				{
					return;
				}
				_terminalTitle = value;
				PropertySet(this);
			}
		}

		[Ordinal(24)] 
		[RED("onGlitchingStateChangedListener")] 
		public CUInt32 OnGlitchingStateChangedListener
		{
			get
			{
				if (_onGlitchingStateChangedListener == null)
				{
					_onGlitchingStateChangedListener = (CUInt32) CR2WTypeManager.Create("Uint32", "onGlitchingStateChangedListener", cr2w, this);
				}
				return _onGlitchingStateChangedListener;
			}
			set
			{
				if (_onGlitchingStateChangedListener == value)
				{
					return;
				}
				_onGlitchingStateChangedListener = value;
				PropertySet(this);
			}
		}

		public TerminalInkGameControllerBase(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
