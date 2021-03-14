using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class DebugMenuScenario_HubMenu : MenuScenario_BaseMenu
	{
		private CName _defaultMenu;
		private CName _cpoDefaultMenu;

		[Ordinal(4)] 
		[RED("defaultMenu")] 
		public CName DefaultMenu
		{
			get
			{
				if (_defaultMenu == null)
				{
					_defaultMenu = (CName) CR2WTypeManager.Create("CName", "defaultMenu", cr2w, this);
				}
				return _defaultMenu;
			}
			set
			{
				if (_defaultMenu == value)
				{
					return;
				}
				_defaultMenu = value;
				PropertySet(this);
			}
		}

		[Ordinal(5)] 
		[RED("cpoDefaultMenu")] 
		public CName CpoDefaultMenu
		{
			get
			{
				if (_cpoDefaultMenu == null)
				{
					_cpoDefaultMenu = (CName) CR2WTypeManager.Create("CName", "cpoDefaultMenu", cr2w, this);
				}
				return _cpoDefaultMenu;
			}
			set
			{
				if (_cpoDefaultMenu == value)
				{
					return;
				}
				_cpoDefaultMenu = value;
				PropertySet(this);
			}
		}

		public DebugMenuScenario_HubMenu(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
