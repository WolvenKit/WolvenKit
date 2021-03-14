using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class FilterRadioGroup : inkRadioGroupController
	{
		private inkWidgetLibraryReference _libraryPath;
		private wCHandle<gameuiTooltipsManager> _tooltipsManager;
		private CInt32 _tooltipIndex;
		private CArray<wCHandle<inkToggleController>> _toggles;
		private wCHandle<inkCompoundWidget> _rootRef;

		[Ordinal(5)] 
		[RED("libraryPath")] 
		public inkWidgetLibraryReference LibraryPath
		{
			get
			{
				if (_libraryPath == null)
				{
					_libraryPath = (inkWidgetLibraryReference) CR2WTypeManager.Create("inkWidgetLibraryReference", "libraryPath", cr2w, this);
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

		[Ordinal(6)] 
		[RED("TooltipsManager")] 
		public wCHandle<gameuiTooltipsManager> TooltipsManager
		{
			get
			{
				if (_tooltipsManager == null)
				{
					_tooltipsManager = (wCHandle<gameuiTooltipsManager>) CR2WTypeManager.Create("whandle:gameuiTooltipsManager", "TooltipsManager", cr2w, this);
				}
				return _tooltipsManager;
			}
			set
			{
				if (_tooltipsManager == value)
				{
					return;
				}
				_tooltipsManager = value;
				PropertySet(this);
			}
		}

		[Ordinal(7)] 
		[RED("TooltipIndex")] 
		public CInt32 TooltipIndex
		{
			get
			{
				if (_tooltipIndex == null)
				{
					_tooltipIndex = (CInt32) CR2WTypeManager.Create("Int32", "TooltipIndex", cr2w, this);
				}
				return _tooltipIndex;
			}
			set
			{
				if (_tooltipIndex == value)
				{
					return;
				}
				_tooltipIndex = value;
				PropertySet(this);
			}
		}

		[Ordinal(8)] 
		[RED("toggles")] 
		public CArray<wCHandle<inkToggleController>> Toggles
		{
			get
			{
				if (_toggles == null)
				{
					_toggles = (CArray<wCHandle<inkToggleController>>) CR2WTypeManager.Create("array:whandle:inkToggleController", "toggles", cr2w, this);
				}
				return _toggles;
			}
			set
			{
				if (_toggles == value)
				{
					return;
				}
				_toggles = value;
				PropertySet(this);
			}
		}

		[Ordinal(9)] 
		[RED("rootRef")] 
		public wCHandle<inkCompoundWidget> RootRef
		{
			get
			{
				if (_rootRef == null)
				{
					_rootRef = (wCHandle<inkCompoundWidget>) CR2WTypeManager.Create("whandle:inkCompoundWidget", "rootRef", cr2w, this);
				}
				return _rootRef;
			}
			set
			{
				if (_rootRef == value)
				{
					return;
				}
				_rootRef = value;
				PropertySet(this);
			}
		}

		public FilterRadioGroup(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
