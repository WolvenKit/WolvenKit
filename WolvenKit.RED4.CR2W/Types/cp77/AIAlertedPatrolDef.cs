using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class AIAlertedPatrolDef : AIBlackboardDef
	{
		private gamebbScriptID_Variant _patrolPathOverride;
		private gamebbScriptID_Bool _sprint;
		private gamebbScriptID_Variant _selectedPath;
		private gamebbScriptID_Vector4 _closestPathPoint;
		private gamebbScriptID_Variant _workspotData;
		private gamebbScriptID_Vector4 _workspotEntryPosition;
		private gamebbScriptID_Vector4 _workspotExitPosition;
		private gamebbScriptID_Variant _patrolAction;
		private gamebbScriptID_Bool _forceAlerted;
		private gamebbScriptID_Bool _patrolInProgress;

		[Ordinal(0)] 
		[RED("patrolPathOverride")] 
		public gamebbScriptID_Variant PatrolPathOverride
		{
			get
			{
				if (_patrolPathOverride == null)
				{
					_patrolPathOverride = (gamebbScriptID_Variant) CR2WTypeManager.Create("gamebbScriptID_Variant", "patrolPathOverride", cr2w, this);
				}
				return _patrolPathOverride;
			}
			set
			{
				if (_patrolPathOverride == value)
				{
					return;
				}
				_patrolPathOverride = value;
				PropertySet(this);
			}
		}

		[Ordinal(1)] 
		[RED("sprint")] 
		public gamebbScriptID_Bool Sprint
		{
			get
			{
				if (_sprint == null)
				{
					_sprint = (gamebbScriptID_Bool) CR2WTypeManager.Create("gamebbScriptID_Bool", "sprint", cr2w, this);
				}
				return _sprint;
			}
			set
			{
				if (_sprint == value)
				{
					return;
				}
				_sprint = value;
				PropertySet(this);
			}
		}

		[Ordinal(2)] 
		[RED("selectedPath")] 
		public gamebbScriptID_Variant SelectedPath
		{
			get
			{
				if (_selectedPath == null)
				{
					_selectedPath = (gamebbScriptID_Variant) CR2WTypeManager.Create("gamebbScriptID_Variant", "selectedPath", cr2w, this);
				}
				return _selectedPath;
			}
			set
			{
				if (_selectedPath == value)
				{
					return;
				}
				_selectedPath = value;
				PropertySet(this);
			}
		}

		[Ordinal(3)] 
		[RED("closestPathPoint")] 
		public gamebbScriptID_Vector4 ClosestPathPoint
		{
			get
			{
				if (_closestPathPoint == null)
				{
					_closestPathPoint = (gamebbScriptID_Vector4) CR2WTypeManager.Create("gamebbScriptID_Vector4", "closestPathPoint", cr2w, this);
				}
				return _closestPathPoint;
			}
			set
			{
				if (_closestPathPoint == value)
				{
					return;
				}
				_closestPathPoint = value;
				PropertySet(this);
			}
		}

		[Ordinal(4)] 
		[RED("workspotData")] 
		public gamebbScriptID_Variant WorkspotData
		{
			get
			{
				if (_workspotData == null)
				{
					_workspotData = (gamebbScriptID_Variant) CR2WTypeManager.Create("gamebbScriptID_Variant", "workspotData", cr2w, this);
				}
				return _workspotData;
			}
			set
			{
				if (_workspotData == value)
				{
					return;
				}
				_workspotData = value;
				PropertySet(this);
			}
		}

		[Ordinal(5)] 
		[RED("workspotEntryPosition")] 
		public gamebbScriptID_Vector4 WorkspotEntryPosition
		{
			get
			{
				if (_workspotEntryPosition == null)
				{
					_workspotEntryPosition = (gamebbScriptID_Vector4) CR2WTypeManager.Create("gamebbScriptID_Vector4", "workspotEntryPosition", cr2w, this);
				}
				return _workspotEntryPosition;
			}
			set
			{
				if (_workspotEntryPosition == value)
				{
					return;
				}
				_workspotEntryPosition = value;
				PropertySet(this);
			}
		}

		[Ordinal(6)] 
		[RED("workspotExitPosition")] 
		public gamebbScriptID_Vector4 WorkspotExitPosition
		{
			get
			{
				if (_workspotExitPosition == null)
				{
					_workspotExitPosition = (gamebbScriptID_Vector4) CR2WTypeManager.Create("gamebbScriptID_Vector4", "workspotExitPosition", cr2w, this);
				}
				return _workspotExitPosition;
			}
			set
			{
				if (_workspotExitPosition == value)
				{
					return;
				}
				_workspotExitPosition = value;
				PropertySet(this);
			}
		}

		[Ordinal(7)] 
		[RED("patrolAction")] 
		public gamebbScriptID_Variant PatrolAction
		{
			get
			{
				if (_patrolAction == null)
				{
					_patrolAction = (gamebbScriptID_Variant) CR2WTypeManager.Create("gamebbScriptID_Variant", "patrolAction", cr2w, this);
				}
				return _patrolAction;
			}
			set
			{
				if (_patrolAction == value)
				{
					return;
				}
				_patrolAction = value;
				PropertySet(this);
			}
		}

		[Ordinal(8)] 
		[RED("forceAlerted")] 
		public gamebbScriptID_Bool ForceAlerted
		{
			get
			{
				if (_forceAlerted == null)
				{
					_forceAlerted = (gamebbScriptID_Bool) CR2WTypeManager.Create("gamebbScriptID_Bool", "forceAlerted", cr2w, this);
				}
				return _forceAlerted;
			}
			set
			{
				if (_forceAlerted == value)
				{
					return;
				}
				_forceAlerted = value;
				PropertySet(this);
			}
		}

		[Ordinal(9)] 
		[RED("patrolInProgress")] 
		public gamebbScriptID_Bool PatrolInProgress
		{
			get
			{
				if (_patrolInProgress == null)
				{
					_patrolInProgress = (gamebbScriptID_Bool) CR2WTypeManager.Create("gamebbScriptID_Bool", "patrolInProgress", cr2w, this);
				}
				return _patrolInProgress;
			}
			set
			{
				if (_patrolInProgress == value)
				{
					return;
				}
				_patrolInProgress = value;
				PropertySet(this);
			}
		}

		public AIAlertedPatrolDef(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
