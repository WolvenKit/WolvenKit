using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class TabRadioGroup : inkRadioGroupController
	{
		private inkCompoundWidgetReference _root;
		private CArray<wCHandle<TabButtonController>> _toggles;
		private wCHandle<gameuiTooltipsManager> _tooltipsManager;

		[Ordinal(5)] 
		[RED("root")] 
		public inkCompoundWidgetReference Root
		{
			get
			{
				if (_root == null)
				{
					_root = (inkCompoundWidgetReference) CR2WTypeManager.Create("inkCompoundWidgetReference", "root", cr2w, this);
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

		[Ordinal(6)] 
		[RED("toggles")] 
		public CArray<wCHandle<TabButtonController>> Toggles
		{
			get
			{
				if (_toggles == null)
				{
					_toggles = (CArray<wCHandle<TabButtonController>>) CR2WTypeManager.Create("array:whandle:TabButtonController", "toggles", cr2w, this);
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

		[Ordinal(7)] 
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

		public TabRadioGroup(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
