using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class MenuScenario_BaseMenu : inkMenuScenario
	{
		private CName _currMenuName;
		private CHandle<IScriptable> _currUserData;
		private CName _currSubMenuName;
		private CName _prevMenuName;

		[Ordinal(0)] 
		[RED("currMenuName")] 
		public CName CurrMenuName
		{
			get
			{
				if (_currMenuName == null)
				{
					_currMenuName = (CName) CR2WTypeManager.Create("CName", "currMenuName", cr2w, this);
				}
				return _currMenuName;
			}
			set
			{
				if (_currMenuName == value)
				{
					return;
				}
				_currMenuName = value;
				PropertySet(this);
			}
		}

		[Ordinal(1)] 
		[RED("currUserData")] 
		public CHandle<IScriptable> CurrUserData
		{
			get
			{
				if (_currUserData == null)
				{
					_currUserData = (CHandle<IScriptable>) CR2WTypeManager.Create("handle:IScriptable", "currUserData", cr2w, this);
				}
				return _currUserData;
			}
			set
			{
				if (_currUserData == value)
				{
					return;
				}
				_currUserData = value;
				PropertySet(this);
			}
		}

		[Ordinal(2)] 
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

		[Ordinal(3)] 
		[RED("prevMenuName")] 
		public CName PrevMenuName
		{
			get
			{
				if (_prevMenuName == null)
				{
					_prevMenuName = (CName) CR2WTypeManager.Create("CName", "prevMenuName", cr2w, this);
				}
				return _prevMenuName;
			}
			set
			{
				if (_prevMenuName == value)
				{
					return;
				}
				_prevMenuName = value;
				PropertySet(this);
			}
		}

		public MenuScenario_BaseMenu(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
