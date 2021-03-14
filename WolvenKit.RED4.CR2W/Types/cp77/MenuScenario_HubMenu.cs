using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class MenuScenario_HubMenu : MenuScenario_BaseMenu
	{
		private CHandle<HubMenuInitData> _hubMenuInitData;
		private wCHandle<inkMenusState> _currentState;

		[Ordinal(4)] 
		[RED("hubMenuInitData")] 
		public CHandle<HubMenuInitData> HubMenuInitData
		{
			get
			{
				if (_hubMenuInitData == null)
				{
					_hubMenuInitData = (CHandle<HubMenuInitData>) CR2WTypeManager.Create("handle:HubMenuInitData", "hubMenuInitData", cr2w, this);
				}
				return _hubMenuInitData;
			}
			set
			{
				if (_hubMenuInitData == value)
				{
					return;
				}
				_hubMenuInitData = value;
				PropertySet(this);
			}
		}

		[Ordinal(5)] 
		[RED("currentState")] 
		public wCHandle<inkMenusState> CurrentState
		{
			get
			{
				if (_currentState == null)
				{
					_currentState = (wCHandle<inkMenusState>) CR2WTypeManager.Create("whandle:inkMenusState", "currentState", cr2w, this);
				}
				return _currentState;
			}
			set
			{
				if (_currentState == value)
				{
					return;
				}
				_currentState = value;
				PropertySet(this);
			}
		}

		public MenuScenario_HubMenu(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
