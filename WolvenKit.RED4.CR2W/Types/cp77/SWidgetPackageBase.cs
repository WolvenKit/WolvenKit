using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class SWidgetPackageBase : CVariable
	{
		private redResourceReferenceScriptToken _libraryPath;
		private CName _libraryID;
		private TweakDBID _widgetTweakDBID;
		private wCHandle<inkWidget> _widget;
		private CString _widgetName;
		private CEnum<EWidgetPlacementType> _placement;
		private CBool _isValid;

		[Ordinal(0)] 
		[RED("libraryPath")] 
		public redResourceReferenceScriptToken LibraryPath
		{
			get
			{
				if (_libraryPath == null)
				{
					_libraryPath = (redResourceReferenceScriptToken) CR2WTypeManager.Create("redResourceReferenceScriptToken", "libraryPath", cr2w, this);
				}
				return _libraryPath;
			}
			set
			{
				if (_libraryPath == value)
				{
					return;
				}
				_libraryPath = value;
				PropertySet(this);
			}
		}

		[Ordinal(1)] 
		[RED("libraryID")] 
		public CName LibraryID
		{
			get
			{
				if (_libraryID == null)
				{
					_libraryID = (CName) CR2WTypeManager.Create("CName", "libraryID", cr2w, this);
				}
				return _libraryID;
			}
			set
			{
				if (_libraryID == value)
				{
					return;
				}
				_libraryID = value;
				PropertySet(this);
			}
		}

		[Ordinal(2)] 
		[RED("widgetTweakDBID")] 
		public TweakDBID WidgetTweakDBID
		{
			get
			{
				if (_widgetTweakDBID == null)
				{
					_widgetTweakDBID = (TweakDBID) CR2WTypeManager.Create("TweakDBID", "widgetTweakDBID", cr2w, this);
				}
				return _widgetTweakDBID;
			}
			set
			{
				if (_widgetTweakDBID == value)
				{
					return;
				}
				_widgetTweakDBID = value;
				PropertySet(this);
			}
		}

		[Ordinal(3)] 
		[RED("widget")] 
		public wCHandle<inkWidget> Widget
		{
			get
			{
				if (_widget == null)
				{
					_widget = (wCHandle<inkWidget>) CR2WTypeManager.Create("whandle:inkWidget", "widget", cr2w, this);
				}
				return _widget;
			}
			set
			{
				if (_widget == value)
				{
					return;
				}
				_widget = value;
				PropertySet(this);
			}
		}

		[Ordinal(4)] 
		[RED("widgetName")] 
		public CString WidgetName
		{
			get
			{
				if (_widgetName == null)
				{
					_widgetName = (CString) CR2WTypeManager.Create("String", "widgetName", cr2w, this);
				}
				return _widgetName;
			}
			set
			{
				if (_widgetName == value)
				{
					return;
				}
				_widgetName = value;
				PropertySet(this);
			}
		}

		[Ordinal(5)] 
		[RED("placement")] 
		public CEnum<EWidgetPlacementType> Placement
		{
			get
			{
				if (_placement == null)
				{
					_placement = (CEnum<EWidgetPlacementType>) CR2WTypeManager.Create("EWidgetPlacementType", "placement", cr2w, this);
				}
				return _placement;
			}
			set
			{
				if (_placement == value)
				{
					return;
				}
				_placement = value;
				PropertySet(this);
			}
		}

		[Ordinal(6)] 
		[RED("isValid")] 
		public CBool IsValid
		{
			get
			{
				if (_isValid == null)
				{
					_isValid = (CBool) CR2WTypeManager.Create("Bool", "isValid", cr2w, this);
				}
				return _isValid;
			}
			set
			{
				if (_isValid == value)
				{
					return;
				}
				_isValid = value;
				PropertySet(this);
			}
		}

		public SWidgetPackageBase(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
