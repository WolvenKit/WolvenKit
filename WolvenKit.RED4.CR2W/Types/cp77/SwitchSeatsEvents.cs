using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class SwitchSeatsEvents : VehicleEventsTransition
	{
		private CHandle<gameWorkspotGameSystem> _workspotSystem;
		private CBool _enabledSceneMode;

		[Ordinal(3)] 
		[RED("workspotSystem")] 
		public CHandle<gameWorkspotGameSystem> WorkspotSystem
		{
			get
			{
				if (_workspotSystem == null)
				{
					_workspotSystem = (CHandle<gameWorkspotGameSystem>) CR2WTypeManager.Create("handle:gameWorkspotGameSystem", "workspotSystem", cr2w, this);
				}
				return _workspotSystem;
			}
			set
			{
				if (_workspotSystem == value)
				{
					return;
				}
				_workspotSystem = value;
				PropertySet(this);
			}
		}

		[Ordinal(4)] 
		[RED("enabledSceneMode")] 
		public CBool EnabledSceneMode
		{
			get
			{
				if (_enabledSceneMode == null)
				{
					_enabledSceneMode = (CBool) CR2WTypeManager.Create("Bool", "enabledSceneMode", cr2w, this);
				}
				return _enabledSceneMode;
			}
			set
			{
				if (_enabledSceneMode == value)
				{
					return;
				}
				_enabledSceneMode = value;
				PropertySet(this);
			}
		}

		public SwitchSeatsEvents(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
