using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class MenuScenario_PreGameSubMenu : inkMenuScenario
	{
		private CName _prevScenario;
		private CName _currSubMenuName;

		[Ordinal(0)] 
		[RED("prevScenario")] 
		public CName PrevScenario
		{
			get
			{
				if (_prevScenario == null)
				{
					_prevScenario = (CName) CR2WTypeManager.Create("CName", "prevScenario", cr2w, this);
				}
				return _prevScenario;
			}
			set
			{
				if (_prevScenario == value)
				{
					return;
				}
				_prevScenario = value;
				PropertySet(this);
			}
		}

		[Ordinal(1)] 
		[RED("currSubMenuName")] 
		public CName CurrSubMenuName
		{
			get
			{
				if (_currSubMenuName == null)
				{
					_currSubMenuName = (CName) CR2WTypeManager.Create("CName", "currSubMenuName", cr2w, this);
				}
				return _currSubMenuName;
			}
			set
			{
				if (_currSubMenuName == value)
				{
					return;
				}
				_currSubMenuName = value;
				PropertySet(this);
			}
		}

		public MenuScenario_PreGameSubMenu(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
