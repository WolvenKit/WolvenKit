using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class FastTravelGameController : gameuiWidgetGameController
	{
		private inkCompoundWidgetReference _fastTravelPointsList;
		private wCHandle<inkMenuEventDispatcher> _menuEventDispatcher;

		[Ordinal(2)] 
		[RED("fastTravelPointsList")] 
		public inkCompoundWidgetReference FastTravelPointsList
		{
			get
			{
				if (_fastTravelPointsList == null)
				{
					_fastTravelPointsList = (inkCompoundWidgetReference) CR2WTypeManager.Create("inkCompoundWidgetReference", "fastTravelPointsList", cr2w, this);
				}
				return _fastTravelPointsList;
			}
			set
			{
				if (_fastTravelPointsList == value)
				{
					return;
				}
				_fastTravelPointsList = value;
				PropertySet(this);
			}
		}

		[Ordinal(3)] 
		[RED("menuEventDispatcher")] 
		public wCHandle<inkMenuEventDispatcher> MenuEventDispatcher
		{
			get
			{
				if (_menuEventDispatcher == null)
				{
					_menuEventDispatcher = (wCHandle<inkMenuEventDispatcher>) CR2WTypeManager.Create("whandle:inkMenuEventDispatcher", "menuEventDispatcher", cr2w, this);
				}
				return _menuEventDispatcher;
			}
			set
			{
				if (_menuEventDispatcher == value)
				{
					return;
				}
				_menuEventDispatcher = value;
				PropertySet(this);
			}
		}

		public FastTravelGameController(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
