using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class gameuiMainMenuGameController : gameuiMenuItemListGameController
	{
		private inkCompoundWidgetReference _backgroundContainer;

		[Ordinal(6)] 
		[RED("backgroundContainer")] 
		public inkCompoundWidgetReference BackgroundContainer
		{
			get
			{
				if (_backgroundContainer == null)
				{
					_backgroundContainer = (inkCompoundWidgetReference) CR2WTypeManager.Create("inkCompoundWidgetReference", "backgroundContainer", cr2w, this);
				}
				return _backgroundContainer;
			}
			set
			{
				if (_backgroundContainer == value)
				{
					return;
				}
				_backgroundContainer = value;
				PropertySet(this);
			}
		}

		public gameuiMainMenuGameController(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
