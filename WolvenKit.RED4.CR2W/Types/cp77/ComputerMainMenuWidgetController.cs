using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class ComputerMainMenuWidgetController : inkWidgetLogicController
	{
		private inkWidgetReference _menuButtonsListWidget;
		private CBool _isInitialized;
		private CArray<SComputerMenuButtonWidgetPackage> _computerMenuButtonWidgetsData;

		[Ordinal(1)] 
		[RED("menuButtonsListWidget")] 
		public inkWidgetReference MenuButtonsListWidget
		{
			get
			{
				if (_menuButtonsListWidget == null)
				{
					_menuButtonsListWidget = (inkWidgetReference) CR2WTypeManager.Create("inkWidgetReference", "menuButtonsListWidget", cr2w, this);
				}
				return _menuButtonsListWidget;
			}
			set
			{
				if (_menuButtonsListWidget == value)
				{
					return;
				}
				_menuButtonsListWidget = value;
				PropertySet(this);
			}
		}

		[Ordinal(2)] 
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

		[Ordinal(3)] 
		[RED("computerMenuButtonWidgetsData")] 
		public CArray<SComputerMenuButtonWidgetPackage> ComputerMenuButtonWidgetsData
		{
			get
			{
				if (_computerMenuButtonWidgetsData == null)
				{
					_computerMenuButtonWidgetsData = (CArray<SComputerMenuButtonWidgetPackage>) CR2WTypeManager.Create("array:SComputerMenuButtonWidgetPackage", "computerMenuButtonWidgetsData", cr2w, this);
				}
				return _computerMenuButtonWidgetsData;
			}
			set
			{
				if (_computerMenuButtonWidgetsData == value)
				{
					return;
				}
				_computerMenuButtonWidgetsData = value;
				PropertySet(this);
			}
		}

		public ComputerMainMenuWidgetController(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
